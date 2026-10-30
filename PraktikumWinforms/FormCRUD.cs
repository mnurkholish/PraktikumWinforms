using PraktikumWinForms.Database;
using PraktikumWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PraktikumWinforms
{
    public partial class FormCRUD : Form
    {
        private DatabaseHelper db;
        private User _user; // null jika mode tambah

        public FormCRUD(User user)
        {
            InitializeComponent();
            _user = user;
            db = new DatabaseHelper();

            if (_user != null) // mode EDIT, isi field dengan data lama
            {
                txtNama.Text = _user.nama;
                txtUmur.Text = _user.umur.ToString();
                txtAsal.Text = _user.asal;

            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi sederhana
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                return;
            }


            //if (_user == null) // TAMBAH
            //{
            //    User baru = new User(0, txtNama.Text, int.Parse(txtUmur.Text), txtAsal.Text);
            //    db.AddUser(baru);
            //    MessageBox.Show("User berhasil ditambahkan!");
            //}
            //else // EDIT
            //{
            //    _user.nama = txtNama.Text;
            //    _user.umur = int.Parse(txtUmur.Text);
            //    _user.asal = txtAsal.Text;
            //    db.UpdateUser(_user);
            //    MessageBox.Show("User berhasil diupdate!");
            //}


            this.Close();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}