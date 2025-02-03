namespace Library
{
    partial class RateForm
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
            label1 = new Label();
            btnGenerateQRCode = new Button();
            pbQR = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(444, 46);
            label1.TabIndex = 0;
            label1.Text = "Если вам понравился проект, пожалуйста,\r\nпоставьте звезду на GitHub!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerateQRCode
            // 
            btnGenerateQRCode.FlatStyle = FlatStyle.Flat;
            btnGenerateQRCode.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnGenerateQRCode.ForeColor = Color.MintCream;
            btnGenerateQRCode.Location = new Point(121, 176);
            btnGenerateQRCode.Name = "btnGenerateQRCode";
            btnGenerateQRCode.Size = new Size(231, 51);
            btnGenerateQRCode.TabIndex = 2;
            btnGenerateQRCode.Text = "Сгенерировать QR";
            btnGenerateQRCode.UseVisualStyleBackColor = true;
            btnGenerateQRCode.Click += btnGenerateQRCode_Click;
            // 
            // pbQR
            // 
            pbQR.Location = new Point(121, 83);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(220, 220);
            pbQR.TabIndex = 3;
            pbQR.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(374, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // RateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(480, 396);
            Controls.Add(btnExit);
            Controls.Add(pbQR);
            Controls.Add(btnGenerateQRCode);
            Controls.Add(label1);
            Name = "RateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронная библиотека - Оценка";
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerateQRCode;
        private PictureBox pbQR;
        private Button btnExit;
    }
}