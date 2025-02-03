namespace Library
{
    partial class ListOfBooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImport = new Button();
            btnExport = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            dgvBooks = new DataGridView();
            tbSearch = new TextBox();
            lSearch = new Label();
            linkLabel1 = new LinkLabel();
            btnPDF = new Button();
            llRate = new LinkLabel();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.DarkSlateGray;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Century Gothic", 12F);
            btnImport.ForeColor = Color.MintCream;
            btnImport.Location = new Point(691, 190);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(201, 40);
            btnImport.TabIndex = 16;
            btnImport.Text = "Импорт";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.DarkSlateGray;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Century Gothic", 12F);
            btnExport.ForeColor = Color.MintCream;
            btnExport.Location = new Point(691, 143);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(201, 41);
            btnExport.TabIndex = 15;
            btnExport.Text = "Экспорт";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkSlateGray;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Century Gothic", 12F);
            btnRemove.ForeColor = Color.MintCream;
            btnRemove.Location = new Point(691, 97);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(201, 40);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSlateGray;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F);
            btnAdd.ForeColor = Color.MintCream;
            btnAdd.Location = new Point(691, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 41);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.DarkSlateGray;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(18, 50);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(667, 409);
            dgvBooks.TabIndex = 9;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.DarkSlateGray;
            tbSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSearch.ForeColor = Color.MintCream;
            tbSearch.Location = new Point(146, 10);
            tbSearch.Multiline = true;
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(539, 34);
            tbSearch.TabIndex = 18;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // lSearch
            // 
            lSearch.AutoSize = true;
            lSearch.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lSearch.ForeColor = Color.MintCream;
            lSearch.Location = new Point(18, 4);
            lSearch.Name = "lSearch";
            lSearch.Size = new Size(122, 40);
            lSearch.TabIndex = 19;
            lSearch.Text = "Поиск";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.MintCream;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.LinkColor = Color.MintCream;
            linkLabel1.Location = new Point(18, 465);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(199, 21);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Сообщить об ошибке";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnPDF
            // 
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnPDF.ForeColor = Color.MintCream;
            btnPDF.Location = new Point(691, 236);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(201, 40);
            btnPDF.TabIndex = 22;
            btnPDF.Text = "Открыть в PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // llRate
            // 
            llRate.ActiveLinkColor = Color.MintCream;
            llRate.AutoSize = true;
            llRate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            llRate.LinkColor = Color.MintCream;
            llRate.Location = new Point(18, 491);
            llRate.Name = "llRate";
            llRate.Size = new Size(188, 21);
            llRate.TabIndex = 23;
            llRate.TabStop = true;
            llRate.Text = "Оценить программу";
            llRate.LinkClicked += llRate_LinkClicked;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(798, 465);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 41);
            btnExit.TabIndex = 24;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ListOfBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(904, 518);
            Controls.Add(btnExit);
            Controls.Add(llRate);
            Controls.Add(btnPDF);
            Controls.Add(linkLabel1);
            Controls.Add(lSearch);
            Controls.Add(tbSearch);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dgvBooks);
            Name = "ListOfBooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронная библиотека - Список книг";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnImport;
        private Button btnExport;
        private Button btnRemove;
        private Button btnAdd;
        private DataGridView dgvBooks;
        private TextBox tbSearch;
        private Label lSearch;
        private LinkLabel linkLabel1;
        private Button btnPDF;
        private LinkLabel llRate;
        private Button btnExit;
    }
}