namespace Workshop.Pages
{
    partial class Registration
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            buttonRegister = new Button();
            visiblebtn = new Button();
            imageList1 = new ImageList(components);
            passwordReg = new TextBox();
            loginReg = new TextBox();
            surname = new TextBox();
            name = new TextBox();
            fathername = new TextBox();
            email = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.AppWorkspace;
            buttonRegister.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.Location = new Point(297, 615);
            buttonRegister.Margin = new Padding(4, 3, 4, 3);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(306, 48);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // visiblebtn
            // 
            visiblebtn.ImageList = imageList1;
            visiblebtn.Location = new Point(636, 533);
            visiblebtn.Margin = new Padding(4, 3, 4, 3);
            visiblebtn.Name = "visiblebtn";
            visiblebtn.Size = new Size(50, 48);
            visiblebtn.TabIndex = 8;
            visiblebtn.UseVisualStyleBackColor = true;
            visiblebtn.Click += visiblebtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "hidden.png");
            imageList1.Images.SetKeyName(1, "eye.png");
            // 
            // passwordReg
            // 
            passwordReg.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            passwordReg.Location = new Point(269, 533);
            passwordReg.Margin = new Padding(4, 3, 4, 3);
            passwordReg.Name = "passwordReg";
            passwordReg.Size = new Size(350, 48);
            passwordReg.TabIndex = 7;
            passwordReg.TabStop = false;
            passwordReg.Enter += passwordReg_Enter;
            // 
            // loginReg
            // 
            loginReg.AccessibleDescription = "";
            loginReg.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            loginReg.ForeColor = Color.Gray;
            loginReg.Location = new Point(269, 175);
            loginReg.Margin = new Padding(4, 3, 4, 3);
            loginReg.Name = "loginReg";
            loginReg.Size = new Size(350, 48);
            loginReg.TabIndex = 6;
            loginReg.TabStop = false;
            loginReg.Enter += loginReg_Enter;
            // 
            // surname
            // 
            surname.AccessibleDescription = "";
            surname.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            surname.ForeColor = Color.Gray;
            surname.Location = new Point(269, 247);
            surname.Margin = new Padding(4, 3, 4, 3);
            surname.Name = "surname";
            surname.Size = new Size(350, 48);
            surname.TabIndex = 10;
            surname.TabStop = false;
            surname.Enter += surname_Enter;
            // 
            // name
            // 
            name.AccessibleDescription = "";
            name.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.Gray;
            name.Location = new Point(269, 311);
            name.Margin = new Padding(4, 3, 4, 3);
            name.Name = "name";
            name.Size = new Size(350, 48);
            name.TabIndex = 11;
            name.TabStop = false;
            name.Enter += name_Enter;
            // 
            // fathername
            // 
            fathername.AccessibleDescription = "";
            fathername.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            fathername.ForeColor = Color.Gray;
            fathername.Location = new Point(269, 385);
            fathername.Margin = new Padding(4, 3, 4, 3);
            fathername.Name = "fathername";
            fathername.Size = new Size(350, 48);
            fathername.TabIndex = 12;
            fathername.TabStop = false;
            fathername.Enter += fathername_Enter;
            // 
            // email
            // 
            email.AccessibleDescription = "";
            email.Font = new Font("Source Code Pro", 16F, FontStyle.Regular, GraphicsUnit.Point);
            email.ForeColor = Color.Gray;
            email.Location = new Point(269, 456);
            email.Margin = new Padding(4, 3, 4, 3);
            email.Name = "email";
            email.Size = new Size(350, 48);
            email.TabIndex = 13;
            email.TabStop = false;
            email.Enter += email_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(334, 79);
            label1.Name = "label1";
            label1.Size = new Size(226, 48);
            label1.TabIndex = 14;
            label1.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login;
            pictureBox1.Location = new Point(230, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.email1;
            pictureBox2.Location = new Point(230, 472);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(230, 549);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 844);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(email);
            Controls.Add(fathername);
            Controls.Add(name);
            Controls.Add(surname);
            Controls.Add(buttonRegister);
            Controls.Add(visiblebtn);
            Controls.Add(passwordReg);
            Controls.Add(loginReg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegister;
        private Button visiblebtn;
        private TextBox passwordReg;
        private TextBox loginReg;
        private TextBox surname;
        private TextBox name;
        private TextBox fathername;
        private TextBox email;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}