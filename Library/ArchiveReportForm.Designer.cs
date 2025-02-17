namespace Library
{
    partial class ArchiveReportForm
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            tbFeedback = new TextBox();
            tbReport = new TextBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReports
            // 
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.DarkSlateGray;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(12, 12);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(362, 357);
            dgvReports.TabIndex = 10;
            dgvReports.CellClick += dgvReports_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbFeedback);
            groupBox1.Controls.Add(tbReport);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = Color.MintCream;
            groupBox1.Location = new Point(380, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 295);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Жалоба:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MintCream;
            label3.Location = new Point(11, 144);
            label3.Name = "label3";
            label3.Size = new Size(284, 23);
            label3.TabIndex = 27;
            label3.Text = "Сообщение пользователю:";
            // 
            // tbFeedback
            // 
            tbFeedback.BackColor = Color.DarkSlateGray;
            tbFeedback.ForeColor = Color.MintCream;
            tbFeedback.Location = new Point(11, 170);
            tbFeedback.Multiline = true;
            tbFeedback.Name = "tbFeedback";
            tbFeedback.Size = new Size(393, 110);
            tbFeedback.TabIndex = 26;
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
            btnExit.Location = new Point(694, 328);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 41);
            btnExit.TabIndex = 26;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ArchiveReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 381);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(dgvReports);
            Name = "ArchiveReportForm";
            Text = "Электронная библиотека - Архив";
            Load += ArchiveReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReports;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox tbFeedback;
        private TextBox tbReport;
        private Button btnExit;
    }
}