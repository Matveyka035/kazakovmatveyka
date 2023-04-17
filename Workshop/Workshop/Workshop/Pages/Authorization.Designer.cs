namespace Workshop.Pages
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            pictureBox1 = new PictureBox();
            login = new TextBox();
            password = new TextBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            buttonLogin = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg;
            pictureBox1.Location = new Point(143, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(579, 483);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            login.AccessibleDescription = "";
            login.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = Color.Gray;
            login.Location = new Point(273, 513);
            login.Margin = new Padding(4, 3, 4, 3);
            login.Name = "login";
            login.Size = new Size(350, 48);
            login.TabIndex = 1;
            login.TabStop = false;
            login.Enter += textBox1_Enter;
            // 
            // password
            // 
            password.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(273, 596);
            password.Margin = new Padding(4, 3, 4, 3);
            password.Name = "password";
            password.Size = new Size(350, 48);
            password.TabIndex = 2;
            password.TabStop = false;
            password.Enter += textBox2_Enter;
            // 
            // button1
            // 
            button1.ImageList = imageList1;
            button1.Location = new Point(640, 596);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(50, 48);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "hidden.png");
            imageList1.Images.SetKeyName(1, "eye.png");
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.AppWorkspace;
            buttonLogin.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(384, 680);
            buttonLogin.Margin = new Padding(4, 3, 4, 3);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(141, 48);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(363, 742);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(184, 53);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "или зарегистрироваться";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Login;
            pictureBox2.Location = new Point(234, 529);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(234, 612);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1374, 844);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(buttonLogin);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workshop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox login;
        private TextBox password;
        private Button button1;
        private ImageList imageList1;
        private Button buttonLogin;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}