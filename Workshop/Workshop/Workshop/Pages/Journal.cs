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
    public partial class Journal : Form
    {
        Main mainpage;
        public Journal(Main main)
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

            MySqlCommand command = new MySqlCommand("SELECT works_and_spareparts.id, works_and_spareparts.work_id, spare_parts.name FROM works_and_spareparts JOIN spare_parts ON works_and_spareparts.spare_parts_id = spare_parts.spare_parts_id;", database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            EntranceTable.DataSource = table;

            SetColumnsName();
        }

        private void SetColumnsName()
        {
            EntranceTable.Columns[0].HeaderText = "Номер";
            EntranceTable.Columns[1].HeaderText = "Номер работы";
            EntranceTable.Columns[2].HeaderText = "Запчасть";


            EntranceTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EntranceTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            EntranceTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EntranceTable.ColumnHeadersDefaultCellStyle.Font = new Font(EntranceTable.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
        }
    }
}
