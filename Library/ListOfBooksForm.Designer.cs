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
            llRate = new LinkLabel();
            btnExit = new Button();
            cbStatus = new ComboBox();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            groupBox1.SuspendLayout();
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
            dgvBooks.SortCompare += dgvBooks_SortCompare;
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
            // llRate
            // 
            llRate.ActiveLinkColor = Color.MintCream;
            llRate.AutoSize = true;
            llRate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            llRate.LinkColor = Color.MintCream;
            llRate.Location = new Point(18, 491);
            llRate.Name = "llRate";
            llRate.Size = new Size(194, 21);
            llRate.TabIndex = 23;
            llRate.TabStop = true;
            llRate.Text = "Оценить приложение";
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
            // cbStatus
            // 
            cbStatus.BackColor = Color.DarkSlateGray;
            cbStatus.ForeColor = Color.MintCream;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(6, 31);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(189, 31);
            cbStatus.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.MintCream;
            groupBox1.Location = new Point(691, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 115);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Статус книги";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.MintCream;
            btnSave.Location = new Point(6, 68);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 40);
            btnSave.TabIndex = 29;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ListOfBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(904, 518);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(llRate);
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
            groupBox1.ResumeLayout(false);
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
        private LinkLabel llRate;
        private Button btnExit;
        private ComboBox cbStatus;
        private GroupBox groupBox1;
        private Button btnSave;
    }
}