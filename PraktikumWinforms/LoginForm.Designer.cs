namespace PraktikumWinForms
{
    partial class LoginForm
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
            panel1 = new Panel();
            BtnLogin = new Button();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(TbPassword);
            panel1.Controls.Add(TbUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(289, 29);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 533);
            panel1.TabIndex = 0;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DeepSkyBlue;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(105, 411);
            BtnLogin.Margin = new Padding(3, 4, 3, 4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(112, 40);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TbPassword
            // 
            TbPassword.BackColor = SystemColors.Window;
            TbPassword.BorderStyle = BorderStyle.None;
            TbPassword.Cursor = Cursors.IBeam;
            TbPassword.Location = new Point(25, 357);
            TbPassword.Margin = new Padding(3, 4, 3, 4);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(290, 20);
            TbPassword.TabIndex = 5;
            TbPassword.UseSystemPasswordChar = true;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = SystemColors.Window;
            TbUsername.BorderStyle = BorderStyle.None;
            TbUsername.Cursor = Cursors.IBeam;
            TbUsername.Location = new Point(25, 280);
            TbUsername.Margin = new Padding(3, 4, 3, 4);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(290, 20);
            TbUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 333);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 256);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 199);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = PraktikumWinforms.Properties.Resources.images;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(93, 25);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 155);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = PraktikumWinforms.Properties.Resources.H1_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Form1";
            Load += this.LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Button BtnLogin;
    }
}
