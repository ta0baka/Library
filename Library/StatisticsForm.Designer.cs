namespace Library
{
    partial class StatisticsForm
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
            btnExit = new Button();
            dgvRating = new DataGridView();
            dgvAverageRating = new DataGridView();
            lSearch = new Label();
            label1 = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAverageRating).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.MintCream;
            btnExit.Location = new Point(451, 396);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 41);
            btnExit.TabIndex = 25;
            btnExit.Text = "Назад";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvRating
            // 
            dgvRating.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRating.BackgroundColor = Color.DarkSlateGray;
            dgvRating.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRating.GridColor = Color.MintCream;
            dgvRating.Location = new Point(12, 58);
            dgvRating.Name = "dgvRating";
            dgvRating.RowHeadersWidth = 51;
            dgvRating.Size = new Size(277, 333);
            dgvRating.TabIndex = 26;
            // 
            // dgvAverageRating
            // 
            dgvAverageRating.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAverageRating.BackgroundColor = Color.DarkSlateGray;
            dgvAverageRating.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAverageRating.GridColor = Color.MintCream;
            dgvAverageRating.Location = new Point(300, 58);
            dgvAverageRating.Name = "dgvAverageRating";
            dgvAverageRating.RowHeadersWidth = 51;
            dgvAverageRating.Size = new Size(245, 53);
            dgvAverageRating.TabIndex = 27;
            // 
            // lSearch
            // 
            lSearch.AutoSize = true;
            lSearch.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lSearch.ForeColor = Color.MintCream;
            lSearch.Location = new Point(300, 9);
            lSearch.Name = "lSearch";
            lSearch.Size = new Size(245, 34);
            lSearch.TabIndex = 28;
            lSearch.Text = "Средняя оценка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 34);
            label1.TabIndex = 29;
            label1.Text = "Список оценок";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkSlateGray;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Century Gothic", 12F);
            btnRemove.ForeColor = Color.MintCream;
            btnRemove.Location = new Point(44, 397);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(201, 40);
            btnRemove.TabIndex = 30;
            btnRemove.Text = "Удалить оценку";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(558, 450);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(lSearch);
            Controls.Add(dgvAverageRating);
            Controls.Add(dgvRating);
            Controls.Add(btnExit);
            Name = "StatisticsForm";
            Text = "Электронная библиотека - Статистика";
            ((System.ComponentModel.ISupportInitialize)dgvRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAverageRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private DataGridView dgvRating;
        private DataGridView dgvAverageRating;
        private Label lSearch;
        private Label label1;
        private Button btnRemove;
    }
}