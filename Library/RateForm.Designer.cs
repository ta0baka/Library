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
            btnExit = new Button();
            numericUpDown1 = new NumericUpDown();
            btnRate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(444, 46);
            label1.TabIndex = 0;
            label1.Text = "Если вам понравился проект, пожалуйста,\r\nпоставьте 5 звёзд!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(384, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.DarkSlateGray;
            numericUpDown1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.ForeColor = Color.MintCream;
            numericUpDown1.Location = new Point(168, 151);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 48);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRate
            // 
            btnRate.FlatStyle = FlatStyle.Flat;
            btnRate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRate.ForeColor = Color.MintCream;
            btnRate.Location = new Point(168, 229);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(150, 48);
            btnRate.TabIndex = 6;
            btnRate.Text = "Отправить";
            btnRate.UseVisualStyleBackColor = true;
            btnRate.Click += btnRate_Click;
            // 
            // RateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(490, 396);
            Controls.Add(btnRate);
            Controls.Add(numericUpDown1);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Name = "RateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Электронная библиотека - Оценка";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnExit;
        private NumericUpDown numericUpDown1;
        private Button btnRate;
    }
}