namespace Library
{
    partial class AdminForm
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
            dgvReports = new DataGridView();
            lSearch = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            tbFeedback = new TextBox();
            label2 = new Label();
            cbStatus = new ComboBox();
            tbLogin = new TextBox();
            label1 = new Label();
            tbReport = new TextBox();
            btnExit = new Button();
            btnRemove = new Button();
            llRate = new LinkLabel();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReports
            // 
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.DarkSlateGray;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(12, 51);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(351, 433);
            dgvReports.TabIndex = 10;
            dgvReports.CellClick += dgvReports_CellClick;
            // 
            // lSearch
            // 
            lSearch.AutoSize = true;
            lSearch.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lSearch.ForeColor = Color.MintCream;
            lSearch.Location = new Point(12, 14);
            lSearch.Name = "lSearch";
            lSearch.Size = new Size(290, 34);
            lSearch.TabIndex = 20;
            lSearch.Text = "Отчеты об ошибках";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbFeedback);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(tbLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbReport);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.MintCream;
            groupBox1.Location = new Point(369, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 422);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Жалоба:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MintCream;
            label3.Location = new Point(11, 275);
            label3.Name = "label3";
            label3.Size = new Size(284, 23);
            label3.TabIndex = 27;
            label3.Text = "Сообщение пользователю:";
            // 
            // tbFeedback
            // 
            tbFeedback.BackColor = Color.DarkSlateGray;
            tbFeedback.ForeColor = Color.MintCream;
            tbFeedback.Location = new Point(11, 301);
            tbFeedback.Multiline = true;
            tbFeedback.Name = "tbFeedback";
            tbFeedback.Size = new Size(393, 110);
            tbFeedback.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(11, 210);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 25;
            label2.Text = "Статус:";
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.DarkSlateGray;
            cbStatus.ForeColor = Color.MintCream;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(11, 236);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(208, 31);
            cbStatus.TabIndex = 24;
            // 
            // tbLogin
            // 
            tbLogin.BackColor = Color.DarkSlateGray;
            tbLogin.ForeColor = Color.MintCream;
            tbLogin.Location = new Point(11, 170);
            tbLogin.Multiline = true;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(393, 37);
            tbLogin.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(11, 144);
            label1.Name = "label1";
            label1.Size = new Size(208, 23);
            label1.TabIndex = 22;
            label1.Text = "Логин пользователя:";
            // 
            // tbReport
            // 
            tbReport.BackColor = Color.DarkSlateGray;
            tbReport.ForeColor = Color.MintCream;
            tbReport.Location = new Point(11, 31);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(393, 110);
            tbReport.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(702, 493);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 41);
            btnExit.TabIndex = 25;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkSlateGray;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Century Gothic", 12F);
            btnRemove.ForeColor = Color.MintCream;
            btnRemove.Location = new Point(591, 444);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(201, 40);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "Удалить";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // llRate
            // 
            llRate.ActiveLinkColor = Color.MintCream;
            llRate.AutoSize = true;
            llRate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            llRate.LinkColor = Color.MintCream;
            llRate.Location = new Point(12, 493);
            llRate.Name = "llRate";
            llRate.Size = new Size(176, 21);
            llRate.TabIndex = 27;
            llRate.TabStop = true;
            llRate.Text = "Открыть статистику";
            llRate.LinkClicked += llRate_LinkClicked;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 12F);
            btnSave.ForeColor = Color.MintCream;
            btnSave.Location = new Point(373, 444);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 40);
            btnSave.TabIndex = 28;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(804, 547);
            Controls.Add(btnSave);
            Controls.Add(llRate);
            Controls.Add(btnRemove);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(lSearch);
            Controls.Add(dgvReports);
            Name = "AdminForm";
            Text = "Электронная библиотека - Администрирование";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReports;
        private Label lSearch;
        private GroupBox groupBox1;
        private TextBox tbLogin;
        private Label label1;
        private TextBox tbReport;
        private Button btnExit;
        private Button btnRemove;
        private LinkLabel llRate;
        private ComboBox cbStatus;
        private Label label2;
        private Button btnSave;
        private Label label3;
        private TextBox tbFeedback;
    }
}