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
    public partial class Main : Form
    {
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

        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            GoToAuthorizationPage();
        }

        public void GoToAuthorizationPage()
        {
            homebtn.Visible = false; homebtn.Enabled = false;
            deliveriesbtn.Visible = false; deliveriesbtn.Enabled = false;
            listworksbtn.Visible = false; listworksbtn.Enabled = false;
            journalbtn.Visible = false; journalbtn.Enabled = false;
            mastersbnt.Visible = false; mastersbnt.Enabled = false;
            sparebtn.Visible = false; sparebtn.Enabled = false;
            clientsbtn.Visible = false; clientsbtn.Enabled = false;

            labelhome.Visible = false;
            labelentrance.Visible = false;
            labellist.Visible = false;
            labeljournal.Visible = false;
            labelmasters.Visible = false;
            labelspare.Visible = false;
            labelclients.Visible = false;

            paneltop.BackColor = SystemColors.ControlDarkDark;
            panelmenu.BackColor = SystemColors.Control;
            PanelForm(new Pages.Authorization(this));
        }

        public void GoToUp()
        {
            homebtn.Visible = true; homebtn.Enabled = true;
            deliveriesbtn.Visible = true; deliveriesbtn.Enabled = true;
            listworksbtn.Visible = true; listworksbtn.Enabled = true;
            journalbtn.Visible = true; journalbtn.Enabled = true;
            mastersbnt.Visible = true; mastersbnt.Enabled = true;
            sparebtn.Visible = true; sparebtn.Enabled = true;
            clientsbtn.Visible = true; clientsbtn.Enabled = true;


            labelhome.Visible = true;
            labelentrance.Visible = true;
            labellist.Visible = true;
            labeljournal.Visible = true;
            labelmasters.Visible = true;
            labelspare.Visible = true;
            labelclients.Visible = true;

            paneltop.BackColor = SystemColors.ControlDarkDark;
            panelmenu.BackColor = SystemColors.ControlDarkDark;
            PanelForm(new Pages.Home(this));
        }

        public void GoToRegistrationPage()
        {
            PanelForm(new Pages.Registration(this));
        }

        private void Close_click_Click(object sender, EventArgs e)
        {
            var closewindow = MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo);
            if (closewindow == DialogResult.Yes)
            {
                this.Close();
            }
            else
            { }
        }

        private void Close_click_MouseEnter(object sender, EventArgs e)
        {
            Close_click.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Close_click_MouseLeave(object sender, EventArgs e)
        {
            Close_click.BorderStyle = BorderStyle.None;
        }

        #region FormChange
        private System.Windows.Forms.Form active;
        public void PanelForm(System.Windows.Forms.Form fm)
        {
            if (active != null)
                active.Close();

            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.ContentPanel.Controls.Add(fm);
            this.ContentPanel.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }
        #endregion

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Home(this));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Home(this));
        }

        private void deliveriesbtn_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.EntrancePage(this));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.EntrancePage(this));
        }

        private void listworksbtn_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Works(this));
        }

        private void journalbtn_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Journal(this));
        }

        private void mastersbnt_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Masters(this));
        }

        private void sparebtn_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Spareparts(this));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Works(this));
        }

        private void clientsbtn_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Clients(this));
        }

        private void labelclients_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Clients(this));
        }

        private void labeljournal_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Journal(this));
        }

        private void labelmasters_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Masters(this));
        }

        private void labelspare_Click(object sender, EventArgs e)
        {
            PanelForm(new Pages.Spareparts(this));
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BorderStyle = BorderStyle.None;
        }
    }
}
