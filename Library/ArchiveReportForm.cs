using Npgsql;
using System.Data;

namespace Library
{
    public partial class ArchiveReportForm : Form
    {
        DataBase database = new DataBase();
        int selectedRow;

        public ArchiveReportForm()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dgvReports.Columns.Add("report", "Жалоба");
            dgvReports.Columns.Add("status", "Статус ");
            dgvReports.Columns.Add("feedback", "Ответ разработчика");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2));
        }

        private void RefreshDgvReports(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "select ur.report, s.status, ur.feedback from user_reports ur join report_statuses s ON ur.id_status = s.id_status";
            NpgsqlCommand command = new NpgsqlCommand(queryString, database.getConnection());
            database.openConnection();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void ArchiveReportForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgvReports(dgvReports);
        }

        private void dgvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReports.Rows[selectedRow];
                tbReport.Text = row.Cells[0].Value.ToString();
                tbFeedback.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
