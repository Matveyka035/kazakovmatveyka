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
    public partial class Clients : Form
    {
        Main mainpage;
        public Clients(Main main)
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM clients;", database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            EntranceTable.DataSource = table;

            SetColumnsName();
        }

        private void SetColumnsName()
        {
            EntranceTable.Columns[0].HeaderText = "Номер клиента";
            EntranceTable.Columns[1].HeaderText = "Имя";
            EntranceTable.Columns[2].HeaderText = "Фамилия";
            EntranceTable.Columns[3].HeaderText = "Отчество";
            EntranceTable.Columns[4].HeaderText = "E-mail";
            EntranceTable.Columns[5].HeaderText = "Логин";
            EntranceTable.Columns[6].HeaderText = "Пароль";

            EntranceTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EntranceTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EntranceTable.ColumnHeadersDefaultCellStyle.Font = new Font(EntranceTable.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
        }
    }
}
