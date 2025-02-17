namespace Library
{
    partial class ErrorReportForm
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
            tbReport = new TextBox();
            btnSendReport = new Button();
            lText = new Label();
            lError = new Label();
            btnExit = new Button();
            btnArchive = new Button();
            SuspendLayout();
            // 
            // tbReport
            // 
            tbReport.BackColor = Color.DarkSlateGray;
            tbReport.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbReport.ForeColor = Color.MintCream;
            tbReport.Location = new Point(46, 126);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(399, 175);
            tbReport.TabIndex = 0;
            // 
            // btnSendReport
            // 
            btnSendReport.FlatStyle = FlatStyle.Flat;
            btnSendReport.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSendReport.ForeColor = Color.MintCream;
            btnSendReport.Location = new Point(162, 307);
            btnSendReport.Name = "btnSendReport";
            btnSendReport.Size = new Size(163, 39);
            btnSendReport.TabIndex = 1;
            btnSendReport.Text = "Отправить";
            btnSendReport.UseVisualStyleBackColor = true;
            btnSendReport.Click += btnSendReport_Click;
            // 
            // lText
            // 
            lText.AutoSize = true;
            lText.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lText.ForeColor = Color.MintCream;
            lText.Location = new Point(67, 26);
            lText.Name = "lText";
            lText.Size = new Size(399, 80);
            lText.TabIndex = 6;
            lText.Text = "Войдите в свою почту\r\n для отправки отчета\r\n";
            // 
            // lError
            // 
            lError.AutoSize = true;
            lError.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lError.ForeColor = Color.MintCream;
            lError.Location = new Point(36, 26);
            lError.Name = "lError";
            lError.Size = new Size(430, 80);
            lError.TabIndex = 8;
            lError.Text = "Опишите ошибку,\r\n с которой столкнулись";
            lError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(409, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 9;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnArchive
            // 
            btnArchive.FlatStyle = FlatStyle.Flat;
            btnArchive.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnArchive.ForeColor = Color.MintCream;
            btnArchive.Location = new Point(12, 350);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(94, 34);
            btnArchive.TabIndex = 10;
            btnArchive.Text = "Архив";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // ErrorReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(515, 396);
            Controls.Add(btnArchive);
            Controls.Add(btnExit);
            Controls.Add(lError);
            Controls.Add(lText);
            Controls.Add(btnSendReport);
            Controls.Add(tbReport);
            Name = "ErrorReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbReport;
        private Button btnSendReport;
        private Label lText;
        private Label lError;
        private Button btnExit;
        private Button btnArchive;
    }
}