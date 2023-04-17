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
    public partial class Works : Form
    {
        Main mainpage;
        public Works(Main main)
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

            MySqlCommand command = new MySqlCommand("SELECT works.work_id, CONCAT(masters.surname, ' ', masters.name, ' ', masters.fatherName), devices.naming, works.states, CONCAT(clients.surname, ' ', clients.name, ' ', clients.fatherName)\r\nFROM works\r\nJOIN masters ON works.master_id = masters.master_id\r\nJOIN devices ON works.device_id = devices.device_id\r\nJOIN clients ON works.client_id = clients.client_id;", database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            EntranceTable.DataSource = table;

            SetColumnsName();
        }

        private void SetColumnsName()
        {
            EntranceTable.Columns[0].HeaderText = "Номер работ";
            EntranceTable.Columns[1].HeaderText = "Мастер";
            EntranceTable.Columns[2].HeaderText = "Оборудование";
            EntranceTable.Columns[3].HeaderText = "Статус";
            EntranceTable.Columns[4].HeaderText = "Клиент";

            EntranceTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EntranceTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EntranceTable.ColumnHeadersDefaultCellStyle.Font = new Font(EntranceTable.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
        }
    }
}
