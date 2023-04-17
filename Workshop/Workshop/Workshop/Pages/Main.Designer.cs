namespace Workshop.Pages
{
    partial class Main
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
            paneltop = new Panel();
            label3 = new Label();
            Close_click = new Label();
            label2 = new Label();
            label1 = new Label();
            panelmenu = new Panel();
            labelclients = new Label();
            clientsbtn = new Button();
            labelspare = new Label();
            labelmasters = new Label();
            labeljournal = new Label();
            labellist = new Label();
            labelentrance = new Label();
            labelhome = new Label();
            sparebtn = new Button();
            mastersbnt = new Button();
            journalbtn = new Button();
            listworksbtn = new Button();
            deliveriesbtn = new Button();
            homebtn = new Button();
            ContentPanel = new Panel();
            paneltop.SuspendLayout();
            panelmenu.SuspendLayout();
            SuspendLayout();
            // 
            // paneltop
            // 
            paneltop.BackColor = SystemColors.ControlDarkDark;
            paneltop.Controls.Add(label3);
            paneltop.Controls.Add(Close_click);
            paneltop.Controls.Add(label2);
            paneltop.Controls.Add(label1);
            paneltop.Dock = DockStyle.Top;
            paneltop.Location = new Point(0, 0);
            paneltop.Margin = new Padding(4, 3, 4, 3);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(1374, 36);
            paneltop.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1291, -1);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 45);
            label3.TabIndex = 1;
            label3.Text = "-";
            label3.Click += label3_Click_1;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // Close_click
            // 
            Close_click.AutoSize = true;
            Close_click.Font = new Font("Ink Free", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            Close_click.ForeColor = Color.White;
            Close_click.Location = new Point(1334, -1);
            Close_click.Margin = new Padding(4, 0, 4, 0);
            Close_click.Name = "Close_click";
            Close_click.Size = new Size(35, 45);
            Close_click.TabIndex = 0;
            Close_click.Text = "X";
            Close_click.Click += Close_click_Click;
            Close_click.MouseEnter += Close_click_MouseEnter;
            Close_click.MouseLeave += Close_click_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1334, -1);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 45);
            label2.TabIndex = 0;
            label2.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1334, -1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 45);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // panelmenu
            // 
            panelmenu.BackColor = SystemColors.ControlDarkDark;
            panelmenu.Controls.Add(labelclients);
            panelmenu.Controls.Add(clientsbtn);
            panelmenu.Controls.Add(labelspare);
            panelmenu.Controls.Add(labelmasters);
            panelmenu.Controls.Add(labeljournal);
            panelmenu.Controls.Add(labellist);
            panelmenu.Controls.Add(labelentrance);
            panelmenu.Controls.Add(labelhome);
            panelmenu.Controls.Add(sparebtn);
            panelmenu.Controls.Add(mastersbnt);
            panelmenu.Controls.Add(journalbtn);
            panelmenu.Controls.Add(listworksbtn);
            panelmenu.Controls.Add(deliveriesbtn);
            panelmenu.Controls.Add(homebtn);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 36);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(240, 808);
            panelmenu.TabIndex = 6;
            panelmenu.Paint += panelmenu_Paint;
            // 
            // labelclients
            // 
            labelclients.AutoSize = true;
            labelclients.BackColor = SystemColors.ControlDarkDark;
            labelclients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelclients.ForeColor = Color.LightGray;
            labelclients.Location = new Point(95, 582);
            labelclients.Name = "labelclients";
            labelclients.Size = new Size(91, 32);
            labelclients.TabIndex = 13;
            labelclients.Text = "Clients";
            labelclients.Click += labelclients_Click;
            // 
            // clientsbtn
            // 
            clientsbtn.BackColor = Color.LightGray;
            clientsbtn.FlatAppearance.BorderSize = 2;
            clientsbtn.FlatStyle = FlatStyle.Flat;
            clientsbtn.Image = Properties.Resources.Clients1;
            clientsbtn.Location = new Point(28, 572);
            clientsbtn.Name = "clientsbtn";
            clientsbtn.Size = new Size(61, 57);
            clientsbtn.TabIndex = 12;
            clientsbtn.UseVisualStyleBackColor = false;
            clientsbtn.Click += clientsbtn_Click;
            // 
            // labelspare
            // 
            labelspare.AutoSize = true;
            labelspare.BackColor = SystemColors.ControlDarkDark;
            labelspare.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelspare.ForeColor = Color.LightGray;
            labelspare.Location = new Point(95, 497);
            labelspare.Name = "labelspare";
            labelspare.Size = new Size(144, 32);
            labelspare.TabIndex = 11;
            labelspare.Text = "Spare parts";
            labelspare.Click += labelspare_Click;
            // 
            // labelmasters
            // 
            labelmasters.AutoSize = true;
            labelmasters.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelmasters.ForeColor = Color.LightGray;
            labelmasters.Location = new Point(95, 412);
            labelmasters.Name = "labelmasters";
            labelmasters.Size = new Size(104, 32);
            labelmasters.TabIndex = 10;
            labelmasters.Text = "Masters";
            labelmasters.Click += labelmasters_Click;
            // 
            // labeljournal
            // 
            labeljournal.AutoSize = true;
            labeljournal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labeljournal.ForeColor = Color.LightGray;
            labeljournal.Location = new Point(95, 327);
            labeljournal.Name = "labeljournal";
            labeljournal.Size = new Size(100, 32);
            labeljournal.TabIndex = 9;
            labeljournal.Text = "Journal";
            labeljournal.Click += labeljournal_Click;
            // 
            // labellist
            // 
            labellist.AutoSize = true;
            labellist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labellist.ForeColor = Color.LightGray;
            labellist.Location = new Point(95, 242);
            labellist.Name = "labellist";
            labellist.Size = new Size(128, 32);
            labellist.TabIndex = 8;
            labellist.Text = "List works";
            labellist.Click += label5_Click;
            // 
            // labelentrance
            // 
            labelentrance.AutoSize = true;
            labelentrance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelentrance.ForeColor = Color.LightGray;
            labelentrance.Location = new Point(95, 159);
            labelentrance.Name = "labelentrance";
            labelentrance.Size = new Size(114, 32);
            labelentrance.TabIndex = 7;
            labelentrance.Text = "Entrance";
            labelentrance.Click += label4_Click;
            // 
            // labelhome
            // 
            labelhome.AutoSize = true;
            labelhome.BackColor = SystemColors.ControlDarkDark;
            labelhome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelhome.ForeColor = Color.LightGray;
            labelhome.Location = new Point(95, 76);
            labelhome.Name = "labelhome";
            labelhome.Size = new Size(82, 32);
            labelhome.TabIndex = 6;
            labelhome.Text = "Home";
            labelhome.Click += label3_Click;
            // 
            // sparebtn
            // 
            sparebtn.BackColor = Color.LightGray;
            sparebtn.FlatAppearance.BorderSize = 2;
            sparebtn.FlatStyle = FlatStyle.Flat;
            sparebtn.Image = Properties.Resources.spareparts;
            sparebtn.Location = new Point(28, 487);
            sparebtn.Name = "sparebtn";
            sparebtn.Size = new Size(61, 57);
            sparebtn.TabIndex = 5;
            sparebtn.UseVisualStyleBackColor = false;
            sparebtn.Click += sparebtn_Click;
            // 
            // mastersbnt
            // 
            mastersbnt.BackColor = Color.LightGray;
            mastersbnt.FlatAppearance.BorderSize = 2;
            mastersbnt.FlatStyle = FlatStyle.Flat;
            mastersbnt.Image = Properties.Resources.masters;
            mastersbnt.Location = new Point(28, 402);
            mastersbnt.Name = "mastersbnt";
            mastersbnt.Size = new Size(61, 57);
            mastersbnt.TabIndex = 4;
            mastersbnt.UseVisualStyleBackColor = false;
            mastersbnt.Click += mastersbnt_Click;
            // 
            // journalbtn
            // 
            journalbtn.BackColor = Color.LightGray;
            journalbtn.FlatAppearance.BorderSize = 2;
            journalbtn.FlatStyle = FlatStyle.Flat;
            journalbtn.Image = Properties.Resources.Journal;
            journalbtn.Location = new Point(28, 317);
            journalbtn.Name = "journalbtn";
            journalbtn.Size = new Size(61, 57);
            journalbtn.TabIndex = 3;
            journalbtn.UseVisualStyleBackColor = false;
            journalbtn.Click += journalbtn_Click;
            // 
            // listworksbtn
            // 
            listworksbtn.BackColor = Color.LightGray;
            listworksbtn.FlatAppearance.BorderSize = 2;
            listworksbtn.FlatStyle = FlatStyle.Flat;
            listworksbtn.ForeColor = SystemColors.ControlText;
            listworksbtn.Image = Properties.Resources.list;
            listworksbtn.Location = new Point(28, 232);
            listworksbtn.Name = "listworksbtn";
            listworksbtn.Size = new Size(61, 57);
            listworksbtn.TabIndex = 2;
            listworksbtn.UseVisualStyleBackColor = false;
            listworksbtn.Click += listworksbtn_Click;
            // 
            // deliveriesbtn
            // 
            deliveriesbtn.BackColor = Color.LightGray;
            deliveriesbtn.FlatAppearance.BorderSize = 2;
            deliveriesbtn.FlatStyle = FlatStyle.Flat;
            deliveriesbtn.Image = Properties.Resources.development;
            deliveriesbtn.Location = new Point(28, 147);
            deliveriesbtn.Name = "deliveriesbtn";
            deliveriesbtn.Size = new Size(61, 57);
            deliveriesbtn.TabIndex = 1;
            deliveriesbtn.TextAlign = ContentAlignment.BottomCenter;
            deliveriesbtn.UseVisualStyleBackColor = false;
            deliveriesbtn.Click += deliveriesbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.LightGray;
            homebtn.FlatAppearance.BorderSize = 2;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Image = Properties.Resources.home;
            homebtn.Location = new Point(28, 64);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(61, 57);
            homebtn.TabIndex = 0;
            homebtn.TextAlign = ContentAlignment.BottomCenter;
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(240, 36);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1134, 808);
            ContentPanel.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 844);
            Controls.Add(ContentPanel);
            Controls.Add(panelmenu);
            Controls.Add(paneltop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            paneltop.ResumeLayout(false);
            paneltop.PerformLayout();
            panelmenu.ResumeLayout(false);
            panelmenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltop;
        private Label Close_click;
        private Label label2;
        private Label label1;
        private Panel panelmenu;
        private Panel ContentPanel;
        private Button sparebtn;
        private Button mastersbnt;
        private Button journalbtn;
        private Button listworksbtn;
        private Button deliveriesbtn;
        private Button homebtn;
        private Label labelhome;
        private Label labellist;
        private Label labelentrance;
        private Label labeljournal;
        private Label labelmasters;
        private Label labelspare;
        private Label labelclients;
        private Button clientsbtn;
        private Label label3;
    }
}