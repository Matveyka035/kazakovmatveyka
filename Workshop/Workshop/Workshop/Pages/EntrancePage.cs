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
    public partial class EntrancePage : Form
    {
        Main mainpage;
        public EntrancePage(Main main)
        {
            InitializeComponent();
            mainpage = main;

            TableOut();
        }

        private void TableOut()
        {

            DB database = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `devices`", database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            EntranceTable.DataSource = table;

            SetColumnsName();
        }

        private void SetColumnsName()
        {
            EntranceTable.Columns[0].HeaderText = "Номер оборудования";
            EntranceTable.Columns[1].HeaderText = "Название";
            EntranceTable.Columns[2].HeaderText = "Дата принятия";
            EntranceTable.Columns[3].HeaderText = "Описание";


            EntranceTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EntranceTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EntranceTable.ColumnHeadersDefaultCellStyle.Font = new Font(EntranceTable.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
        }
    }
}
