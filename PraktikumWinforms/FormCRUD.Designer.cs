namespace PraktikumWinforms
{
    partial class FormCRUD
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
            lblNama = new Label();
            lblUmur = new Label();
            lblAsal = new Label();
            txtNama = new TextBox();
            txtUmur = new TextBox();
            txtAsal = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();


            // lblNama
            lblNama.Location = new Point(30, 30);
            lblNama.Size = new Size(80, 25);
            lblNama.Text = "Nama :";


            // txtNama
            txtNama.Location = new Point(130, 27);
            txtNama.Size = new Size(220, 30);
            txtNama.Name = "txtNama";


            // lblUmur
            lblUmur.Location = new Point(30, 75);
            lblUmur.Size = new Size(80, 25);
            lblUmur.Text = "Umur :";


            // txtUmur
            txtUmur.Location = new Point(130, 72);
            txtUmur.Size = new Size(220, 30);
            txtUmur.Name = "txtUmur";


            // lblAsal
            lblAsal.Location = new Point(30, 120);
            lblAsal.Size = new Size(80, 25);
            lblAsal.Text = "Asal :";


            // txtAsal
            txtAsal.Location = new Point(130, 117);
            txtAsal.Size = new Size(220, 30);
            txtAsal.Name = "txtAsal";


            // btnSimpan
            btnSimpan.Location = new Point(130, 170);
            btnSimpan.Size = new Size(100, 35);
            btnSimpan.Text = "Simpan";
            btnSimpan.BackColor = Color.SeaGreen;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Click += btnSimpan_Click;


            // btnBatal
            btnBatal.Location = new Point(245, 170);
            btnBatal.Size = new Size(100, 35);
            btnBatal.Text = "Batal";
            btnBatal.BackColor = Color.Gray;
            btnBatal.ForeColor = Color.White;
            btnBatal.FlatStyle = FlatStyle.Flat;
            //btnBatal.Click += (s, e) => this.Close();
            btnBatal.Click += btnBatal_Click;


            //
            // FormCRUD
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 240);
            Controls.Add(lblNama);
            Controls.Add(txtNama);
            Controls.Add(lblUmur);
            Controls.Add(txtUmur);
            Controls.Add(lblAsal);
            Controls.Add(txtAsal);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Name = "FormCRUD";
            Text = "Form Tambah / Edit User";
            //Load += Form3_Load;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }


        #endregion
        private Label lblNama, lblUmur, lblAsal;
        private TextBox txtNama, txtUmur, txtAsal;
        private Button btnSimpan, btnBatal;
    }
}