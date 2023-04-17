using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop.Pages
{
    public partial class Masters : Form
    {
        Main mainpage;
        public Masters(Main main)
        {
            mainpage = main;
            InitializeComponent();
            TableOut();
        }

        private void TableOut()
        {

            DB database = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT master_id, surname, name, fathername, dateOfBirth, experience, salary FROM masters;", database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            EntranceTable.DataSource = table;

            SetColumnsName();
        }

        private void SetColumnsName()
        {
            EntranceTable.Columns[0].HeaderText = "Номер мастера";
            EntranceTable.Columns[1].HeaderText = "Фамилия";
            EntranceTable.Columns[2].HeaderText = "Имя";
            EntranceTable.Columns[3].HeaderText = "Отчетсво";
            EntranceTable.Columns[4].HeaderText = "Дата рождения";
            EntranceTable.Columns[5].HeaderText = "Опыт работы(лет)";
            EntranceTable.Columns[6].HeaderText = "Зарплата(руб.)";

            EntranceTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EntranceTable.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EntranceTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EntranceTable.ColumnHeadersDefaultCellStyle.Font = new Font(EntranceTable.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
        }
    }
}
