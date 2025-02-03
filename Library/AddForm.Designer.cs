namespace Library
{
    partial class AddForm
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
            btnAdd = new Button();
            tbTitle = new TextBox();
            tbAuthor = new TextBox();
            tbYear = new TextBox();
            lAddBook = new Label();
            lTitle = new Label();
            lAuthor = new Label();
            lYear = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.ForeColor = Color.MintCream;
            btnAdd.Location = new Point(202, 278);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbTitle
            // 
            tbTitle.BackColor = Color.DarkSlateGray;
            tbTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbTitle.ForeColor = Color.MintCream;
            tbTitle.Location = new Point(202, 104);
            tbTitle.Multiline = true;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(217, 34);
            tbTitle.TabIndex = 1;
            // 
            // tbAuthor
            // 
            tbAuthor.BackColor = Color.DarkSlateGray;
            tbAuthor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbAuthor.ForeColor = Color.MintCream;
            tbAuthor.Location = new Point(202, 159);
            tbAuthor.Multiline = true;
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(217, 34);
            tbAuthor.TabIndex = 2;
            // 
            // tbYear
            // 
            tbYear.BackColor = Color.DarkSlateGray;
            tbYear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbYear.ForeColor = Color.MintCream;
            tbYear.Location = new Point(202, 212);
            tbYear.Multiline = true;
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(217, 34);
            tbYear.TabIndex = 3;
            // 
            // lAddBook
            // 
            lAddBook.AutoSize = true;
            lAddBook.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lAddBook.ForeColor = Color.MintCream;
            lAddBook.Location = new Point(123, 38);
            lAddBook.Name = "lAddBook";
            lAddBook.Size = new Size(332, 40);
            lAddBook.TabIndex = 4;
            lAddBook.Text = "Добавление книги";
            // 
            // lTitle
            // 
            lTitle.AutoSize = true;
            lTitle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lTitle.ForeColor = Color.MintCream;
            lTitle.Location = new Point(90, 107);
            lTitle.Name = "lTitle";
            lTitle.Size = new Size(106, 23);
            lTitle.TabIndex = 5;
            lTitle.Text = "Название";
            // 
            // lAuthor
            // 
            lAuthor.AutoSize = true;
            lAuthor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lAuthor.ForeColor = Color.MintCream;
            lAuthor.Location = new Point(127, 162);
            lAuthor.Name = "lAuthor";
            lAuthor.Size = new Size(69, 23);
            lAuthor.TabIndex = 6;
            lAuthor.Text = "Автор";
            // 
            // lYear
            // 
            lYear.AutoSize = true;
            lYear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lYear.ForeColor = Color.MintCream;
            lYear.Location = new Point(67, 215);
            lYear.Name = "lYear";
            lYear.Size = new Size(129, 23);
            lYear.TabIndex = 7;
            lYear.Text = "Год издания";
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(427, 354);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 39);
            btnExit.TabIndex = 8;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(544, 405);
            Controls.Add(btnExit);
            Controls.Add(lYear);
            Controls.Add(lAuthor);
            Controls.Add(lTitle);
            Controls.Add(lAddBook);
            Controls.Add(tbYear);
            Controls.Add(tbAuthor);
            Controls.Add(tbTitle);
            Controls.Add(btnAdd);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронная библиотека - Добавление книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox tbTitle;
        private TextBox tbAuthor;
        private TextBox tbYear;
        private Label lAddBook;
        private Label lTitle;
        private Label lAuthor;
        private Label lYear;
        private Button btnExit;
    }
}