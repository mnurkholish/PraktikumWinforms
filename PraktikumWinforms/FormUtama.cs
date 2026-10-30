using PraktikumWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PraktikumWinforms
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();

            // Saat aplikasi jalan, langsung buka Form 1 (Login) ke dalam panel.
            // Kita mengirimkan 'this' (FormUtama) agar Form 1 mengenali siapa induknya.

            BukaFormDiPanel(new LoginForm(this));
        }


        // Fungsi ajaib untuk mengganti isi panel
        public void BukaFormDiPanel(Form formAnak)
        {
            if (this.PanelUtama.Controls.Count > 0)
            {
                this.PanelUtama.Controls[0].Dispose(); // Bersihkan form sebelumnya
                this.PanelUtama.Controls.Clear();
            }


            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;

            this.PanelUtama.Controls.Add(formAnak);
            this.PanelUtama.Tag = formAnak;
            formAnak.Show();
        }
    }
}
