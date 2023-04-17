using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop.Pages
{
    public partial class Registration : Form
    {
        int click = 0;
        int TextBoxClick = 0;

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
        public Registration(Main main)
        {
            InitializeComponent();

            mainpage = main;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            loginReg.Text = "Login";
            loginReg.ForeColor = System.Drawing.Color.Gray;
            passwordReg.Text = "Password";
            passwordReg.ForeColor = System.Drawing.Color.Gray;
            surname.Text = "Surname";
            surname.ForeColor = System.Drawing.Color.Gray;
            name.Text = "Name";
            name.ForeColor = System.Drawing.Color.Gray;
            fathername.Text = "Fathername";
            fathername.ForeColor = System.Drawing.Color.Gray;
            email.Text = "E-mail";
            email.ForeColor = System.Drawing.Color.Gray;

            visiblebtn.ImageIndex = 0;

            EnabledBtn();
        }

        private void loginReg_Enter(object sender, EventArgs e)
        {
            loginReg.ForeColor = Color.Black;
            loginReg.Text = "";
            loginReg.Enter -= loginReg_Enter;
            TextBoxClick += 1;
            EnabledBtn();
        }

        private void surname_Enter(object sender, EventArgs e)
        {
            surname.ForeColor = Color.Black;
            surname.Text = "";
            surname.Enter -= surname_Enter;
            TextBoxClick += 1;
            EnabledBtn();
        }

        private void name_Enter(object sender, EventArgs e)
        {
            name.ForeColor = Color.Black;
            name.Text = "";
            name.Enter -= name_Enter;
            TextBoxClick += 1;
            EnabledBtn();
        }

        private void fathername_Enter(object sender, EventArgs e)
        {
            fathername.ForeColor = Color.Black;
            fathername.Text = "";
            fathername.Enter -= fathername_Enter;
            TextBoxClick += 1;
            EnabledBtn();
        }

        private void email_Enter(object sender, EventArgs e)
        {
            email.ForeColor = Color.Black;
            email.Text = "";
            email.Enter -= email_Enter;
            TextBoxClick += 1;
            EnabledBtn();
        }

        private void passwordReg_Enter(object sender, EventArgs e)
        {
            passwordReg.UseSystemPasswordChar = true;
            passwordReg.ForeColor = Color.Black;
            passwordReg.Text = "";
            passwordReg.Enter -= passwordReg_Enter;
            TextBoxClick += 1;
            EnabledBtn();
        }

        private void visiblebtn_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                visiblebtn.ImageIndex = 1;
                passwordReg.UseSystemPasswordChar = false;
                click = 1;
            }
            else if (click == 1)
            {
                visiblebtn.ImageIndex = 0;
                passwordReg.UseSystemPasswordChar = true;
                click = 0;
            }
        }

        private void EnabledBtn()
        {
            if (TextBoxClick != 6)
                buttonRegister.Enabled = false;
            else
                buttonRegister.Enabled = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (loginReg.Text == "")
            {
                MessageBox.Show("Введите login");
                return;
            }

            if (surname.Text == "")
            {
                MessageBox.Show("Введите surname");
                return;
            }

            if (name.Text == "")
            {
                MessageBox.Show("Введите name");
                return;
            }

            if (fathername.Text == "")
            {
                MessageBox.Show("Введите fathername");
                return;
            }

            if (email.Text == "")
            {
                MessageBox.Show("Введите email");
                return;
            }

            if (passwordReg.Text == "")
            {
                MessageBox.Show("Введите password");
                return;
            }

            if (CheckUser())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`login`, `surname`, `name`, `fatherName`, `email`, `password`) VALUES (@login, @surname, @name, @fatherName, @email, @pass)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginReg.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@fathername", MySqlDbType.VarChar).Value = fathername.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordReg.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешная регистрация!");
                mainpage.GoToAuthorizationPage();
            }
            else
                MessageBox.Show("Ошибка регистрации!");

            db.closeConnection();
        }

        public Boolean CheckUser()
        {
            DB database = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` WHERE `login` = @uL OR email = @uL", database.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginReg.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким login уже существует");
                return true;
            }
            else
                return false;

        }

    }
}
