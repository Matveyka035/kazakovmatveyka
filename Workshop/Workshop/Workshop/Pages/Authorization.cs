using MySqlConnector;
using System.Data;
using System.Runtime.InteropServices;
using Workshop.Pages;

namespace Workshop.Pages
{
    public partial class Authorization : Form
    {
        int click = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        Main mainpage;

        public Authorization(Main main)
        {
            InitializeComponent();

            mainpage = main;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            login.Text = "Login";
            login.ForeColor = System.Drawing.Color.Gray;
            password.Text = "Password";
            password.ForeColor = System.Drawing.Color.Gray;

            button1.ImageIndex = 0;



        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            login.ForeColor = Color.Black;
            login.Text = "";
            login.Enter -= textBox1_Enter;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            password.ForeColor = Color.Black;
            password.Text = "";
            password.Enter -= textBox2_Enter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                button1.ImageIndex = 1;
                password.UseSystemPasswordChar = false;
                click = 1;
            }
            else if (click == 1)
            {
                button1.ImageIndex = 0;
                password.UseSystemPasswordChar = true;
                click = 0;
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string LoginUser = login.Text;
            string PassUser = password.Text;

            DB database = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` WHERE `login` = @uL OR email = @uL AND `password` = @uP", database.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                mainpage.GoToUp();
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainpage.GoToRegistrationPage();
        }
    }
}