using Npgsql;
using System.Data;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Exceptions;

namespace Library
{
    public partial class ListOfBooksForm : Form
    {
        DataBase database = new DataBase();
        int selectedRow;

        public ListOfBooksForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dgvBooks.Columns.Add("title", "Название");
            dgvBooks.Columns.Add("author", "Автор");
            dgvBooks.Columns.Add("year", "Год издания");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2));
        }

        private void RefreshDgvBooks(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT title, author, year FROM books";
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
            AddForm addForm = new AddForm();
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
            RateForm rateForm = new RateForm();
            rateForm.Show();
        }

        private void ExportToTextFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (DataGridViewRow row in dgvBooks.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string line = $"{row.Cells["title"].Value}, {row.Cells["author"].Value}, {row.Cells["year"].Value}";
                        writer.WriteLine(line);
                    }
                }
                MessageBox.Show("Данные успешно экспортированы в текстовый файл.", "Успех", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToCsv(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Title,Author,Year");
                    foreach (DataGridViewRow row in dgvBooks.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string line = $"{row.Cells["title"].Value},{row.Cells["author"].Value},{row.Cells["year"].Value}";
                        writer.WriteLine(line);
                    }
                }
                MessageBox.Show("Данные успешно экспортированы в CSV файл.", "Успех", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Сохранить файл";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    if (filePath.EndsWith(".txt"))
                    {
                        ExportToTextFile(filePath);
                    }
                    else if (filePath.EndsWith(".csv"))
                    {
                        ExportToCsv(filePath);
                    }
                }
            }
        }

        private void ImportFromTextFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length == 3)
                        {
                            string title = parts[0].Trim();
                            string author = parts[1].Trim();
                            if (int.TryParse(parts[2].Trim(), out int year))
                            {
                                dgvBooks.Rows.Add(title, author, year);
                            }
                        }
                    }
                }
                MessageBox.Show("Данные успешно импортированы из текстового файла.", "Успех", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при импорте данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportFromCsv(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string headerLine = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length == 3)
                        {
                            string title = parts[0].Trim();
                            string author = parts[1].Trim();
                            if (int.TryParse(parts[2].Trim(), out int year))
                            {
                                dgvBooks.Rows.Add(title, author, year);
                            }
                        }
                    }
                }
                MessageBox.Show("Данные успешно импортированы из CSV файла.", "Успех", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при импорте данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
                openFileDialog.Title = "Выберите файл для импорта";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    if (filePath.EndsWith(".txt"))
                    {
                        ImportFromTextFile(filePath);
                    }
                    else if (filePath.EndsWith(".csv"))
                    {
                        ImportFromCsv(filePath);
                    }
                }
            }
        }

        private void ExportToPdf(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                        document.Add(new Paragraph("Список книг").SetFont(boldFont).SetFontSize(20));

                        foreach (DataGridViewRow row in dgvBooks.Rows)
                        {
                            if (row.IsNewRow) continue;

                            if (row.Cells["title"].Value == null || row.Cells["author"].Value == null || row.Cells["year"].Value == null)
                            {
                                continue;
                            }

                            string title = row.Cells["title"].Value.ToString();
                            string author = row.Cells["author"].Value.ToString();
                            string year = row.Cells["year"].Value.ToString();

                            document.Add(new Paragraph($"Название: {title}, Автор: {author}, Год издания: {year}"));
                        }

                        document.Close();
                    }
                }
                MessageBox.Show("Данные успешно экспортированы в PDF файл.", "Успех", MessageBoxButtons.OK);
            }
            catch (PdfException pdfEx)
            {
                MessageBox.Show("Ошибка при экспорте данных: " + pdfEx.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Сохранить PDF файл";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportToPdf(filePath);

                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при открытии PDF файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ErrorReportForm errorReportForm = new ErrorReportForm();
            errorReportForm.Show();
        }
    }
}