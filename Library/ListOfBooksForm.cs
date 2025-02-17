using Npgsql;
using System.Data;
using iTextSharp.text;
using DocumentFormat.OpenXml.Packaging;
using iTextSharp.text.pdf;
using DocumentFormat.OpenXml;
using Word = DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf.parser;

namespace Library
{
    public partial class ListOfBooksForm : Form
    {
        DataBase database = new DataBase();
        private string userLogin;
        int selectedRow;

        public ListOfBooksForm(string login)
        {
            InitializeComponent();
            userLogin = login;
            FillComboBox();
            dgvBooks.SortCompare += dgvBooks_SortCompare;
            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;
        }

        private void CreateColumns()
        {
            dgvBooks.Columns.Add("title", "Название");
            dgvBooks.Columns.Add("author", "Автор");
            dgvBooks.Columns.Add("year", "Год издания");
            dgvBooks.Columns.Add("stop_page", "Страница, на которой остановились");
            dgvBooks.Columns.Add("status", "Статус");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetString(4));
        }

        private void RefreshDgvBooks(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT title, author, year, stop_page, status FROM books";
            NpgsqlCommand command = new NpgsqlCommand(queryString, database.getConnection());
            database.openConnection();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = "SELECT title, author, year FROM books WHERE title LIKE @search OR author LIKE @search OR year::text LIKE @search";
            using (NpgsqlCommand com = new NpgsqlCommand(searchString, database.getConnection()))
            {
                com.Parameters.AddWithValue("@search", "%" + tbSearch.Text + "%");
                database.openConnection();

                using (NpgsqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ReadSingleRow(dgw, read);
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgvBooks(dgvBooks);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(userLogin);
            addForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBooks.SelectedRows[0];

                string bookTitle = selectedRow.Cells["title"].Value?.ToString();

                if (!string.IsNullOrEmpty(bookTitle))
                {
                    RemoveBook(bookTitle);
                    RefreshDgvBooks(dgvBooks);
                }
                else
                {
                    MessageBox.Show("Не удалось получить название книги.", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void RemoveBook(string bookTitle)
        {
            database.openConnection();
            string query = "DELETE FROM books WHERE title = @title";
            using (NpgsqlCommand command = new NpgsqlCommand(query, database.getConnection()))
            {
                command.Parameters.AddWithValue("title", bookTitle);
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Книга успешно удалена.", "Успех", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Книга не найдена.", "Ошибка", MessageBoxButtons.OK);
                }
            }
            database.closeConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dgvBooks);
        }

        private void llRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RateForm rateForm = new RateForm(userLogin);
            rateForm.Show();
        }

        private void ExportToTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        writer.WriteLine($"{row.Cells[0].Value}\t{row.Cells[1].Value}\t{row.Cells[2].Value}");
                    }
                }
            }
            MessageBox.Show("Data exported to TXT successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ExportToDocx(string filePath)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Word.Document();
                Word.Body body = new Word.Body();
                mainPart.Document.Append(body);

                Word.Paragraph titleParagraph = new Word.Paragraph(
                    new Word.Run(new Word.Text("Book List"))
                );
                titleParagraph.ParagraphProperties = new Word.ParagraphProperties(
                    new Word.Justification() { Val = Word.JustificationValues.Center }
                );
                body.Append(titleParagraph);

                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string rowText = $"{row.Cells[0].Value} | {row.Cells[1].Value} | {row.Cells[2].Value}";
                        Word.Paragraph para = new Word.Paragraph(
                            new Word.Run(new Word.Text(rowText))
                        );
                        body.Append(para);
                    }
                }

                mainPart.Document.Save();
            }

            MessageBox.Show("Data exported to DOCX successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToPdf(string filePath)
        {
            using (var pdfDoc = new iTextSharp.text.Document())
            {
                PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                int columnCount = dgvBooks.Columns.Count;
                PdfPTable table = new PdfPTable(columnCount) { WidthPercentage = 100 };

                // Заголовки
                foreach (DataGridViewColumn column in dgvBooks.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText ?? ""))
                    {
                        BackgroundColor = new BaseColor(230, 230, 230),
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    table.AddCell(headerCell);
                }

                // Данные
                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    if (row.IsNewRow) continue;

                    for (int i = 0; i < columnCount; i++)
                    {
                        object cellValue = row.Cells[i].Value;

                        // Отладочный вывод в консоль
                        Console.WriteLine($"Column {i}: {cellValue}");

                        string text = cellValue?.ToString()?.Trim() ?? "N/A"; // Чтобы избежать пустых значений
                        table.AddCell(new Phrase(text));
                    }
                }

                pdfDoc.Add(table);
                pdfDoc.Close();
            }

            MessageBox.Show("Data exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Document|*.pdf|Text Files|*.txt|Word Document|*.docx",
                Title = "Save File"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    switch (System.IO.Path.GetExtension(filePath).ToLower())
                    {
                        case ".txt": ExportToTxt(filePath); break;
                        case ".docx": ExportToDocx(filePath); break;
                        case ".pdf": ExportToPdf(filePath); break;
                    }
                }
            }
        }

        public void ImportFromFile(string filePath)
        {
            string extension = System.IO.Path.GetExtension(filePath).ToLower();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Year");

            try
            {
                switch (extension)
                {
                    case ".txt":
                        ImportFromTxt(filePath, dataTable);
                        break;
                    case ".docx":
                        ImportFromDocx(filePath, dataTable);
                        break;
                    case ".pdf":
                        ImportFromPdf(filePath, dataTable);
                        break;
                    default:
                        MessageBox.Show("Unsupported file format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (dataTable.Rows.Count > 0)
                {
                    SaveToDatabase(dataTable);
                    MessageBox.Show("Import successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No valid data found in the file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportFromTxt(string filePath, DataTable dataTable)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');
                    if (parts.Length == 3)
                    {
                        dataTable.Rows.Add(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
                    }
                }
            }
        }

        private void ImportFromDocx(string filePath, DataTable dataTable)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, false))
            {
                if (doc.MainDocumentPart == null || doc.MainDocumentPart.Document == null)
                {
                    MessageBox.Show("The DOCX file is empty or corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Body body = doc.MainDocumentPart.Document.Body;
                if (body == null)
                {
                    MessageBox.Show("No text found in the DOCX file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DocumentFormat.OpenXml.Wordprocessing.Paragraph para in body.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>())
                {
                    string text = para.InnerText.Trim();
                    string[] parts = text.Split('|');
                    if (parts.Length == 3)
                    {
                        dataTable.Rows.Add(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
                    }
                }
            }
        }

        private void ImportFromPdf(string filePath, DataTable dataTable)
        {
            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    string text = PdfTextExtractor.GetTextFromPage(reader, i);
                    string[] lines = text.Split('\n');

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            dataTable.Rows.Add(parts[0].Trim(), parts[1].Trim(), parts[2].Trim());
                        }
                    }
                }
            }
        }

        private void SaveToDatabase(DataTable dataTable)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Database=Library;Username=postgres;Password=2928"))
            {
                conn.Open();
                using (NpgsqlTransaction transaction = conn.BeginTransaction())
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string title = row["Title"].ToString();
                        string author = row["Author"].ToString();
                        int year = Convert.ToInt32(row["Year"]);

                        using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO books (title, author, year) VALUES (@title, @author, @year) ON CONFLICT (title) DO NOTHING", conn))
                        {
                            cmd.Parameters.AddWithValue("@title", title);
                            cmd.Parameters.AddWithValue("@author", author);
                            cmd.Parameters.AddWithValue("@year", year);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ErrorReportForm errorReportForm = new ErrorReportForm(userLogin);
            errorReportForm.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|Word Documents (*.docx)|*.docx|PDF Files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImportFromFile(openFileDialog.FileName);
                }
            }
            RefreshDgvBooks(dgvBooks);
        }

        private void FillComboBox()
        {
            database.openConnection();
            string query = "SELECT id_b_status, status FROM book_statuses";
            NpgsqlCommand com = new NpgsqlCommand(query, database.getConnection());
            NpgsqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                cbStatus.Items.Add(read["status"]);
            }

            read.Close();
            database.closeConnection();
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];
                var status = selectedRow.Cells["status"].Value.ToString();

                if (cbStatus.Items.Contains(status))
                {
                    cbStatus.SelectedItem = status;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedStatus = (string)cbStatus.SelectedItem;
            int idStatus = GetStatusId(selectedStatus);

            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для обновления.", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow row = dgvBooks.SelectedRows[0];
            string bookTitle = row.Cells["title"].Value.ToString();

            string updateQuery = "UPDATE books SET id_b_status = @idStatus WHERE title = @bookTitle";

            using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, database.getConnection()))
            {
                database.openConnection();
                command.Parameters.AddWithValue("@idStatus", idStatus);
                command.Parameters.AddWithValue("@bookTitle", bookTitle);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Сохранено.", "Успех", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Книга не найдена или статус не изменился.", "Информация", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK);
                }
                finally
                {
                    database.closeConnection();
                }
            }

            RefreshDgvBooks(dgvBooks);
        }

        private int GetStatusId(string status)
        {
            int idStatus = -1;
            string query = "SELECT id_b_status FROM book_statuses WHERE status = @status";

            using (NpgsqlCommand com = new NpgsqlCommand(query, database.getConnection()))
            {
                com.Parameters.AddWithValue("@status", status);
                database.openConnection();
                object result = com.ExecuteScalar();
                if (result != null)
                {
                    idStatus = Convert.ToInt32(result);
                }
                database.closeConnection();
            }

            return idStatus;
        }
        private void dgvBooks_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "Статус")
            {
                int GetPriority(string status) => status == "Прочитано" ? 0 : 1;

                string statusX = e.CellValue1?.ToString();
                string statusY = e.CellValue2?.ToString();

                e.SortResult = GetPriority(statusX).CompareTo(GetPriority(statusY));

                e.Handled = true;
            }
        }
    }
}