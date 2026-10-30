using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using PraktikumWinforms;
using PraktikumWinforms.Controllers;
using PraktikumWinforms.Models;
using PraktikumWinforms.Repositories;
using PraktikumWinForms.Database;

namespace PraktikumWinForms
{

    public partial class FormDashboard : Form
    {
        //private List<User> users;

        private UserController userController;
        private UserRepository userRepository;
        public User user;
        public FormDashboard()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            userController = new UserController(userRepository);
            loadData();
        }

        public void loadData()
        {

            List<User> users = userController.GetUser();
            DgUser.DataSource = users;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormCRUD formTambah = new FormCRUD(null); // null = mode tambah
            formTambah.ShowDialog();
            this.loadData(); // refresh tabel setelah tutup
        }


        // Tombol Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DgUser.CurrentRow == null) return;


            User selected = (User)DgUser.CurrentRow.DataBoundItem;
            FormCRUD formEdit = new FormCRUD(selected); // kirim data = mode edit
            formEdit.ShowDialog();
            loadData();
        }


        // Tombol Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (DgUser.CurrentRow == null) return;


            User selected = (User)DgUser.CurrentRow.DataBoundItem;
            var konfirmasi = MessageBox.Show(
                $"Hapus user '{selected.nama}'?",
                "Konfirmasi", MessageBoxButtons.YesNo);


            if (konfirmasi == DialogResult.Yes)
            {
                userController.DeleteUser(selected.id);
                //dbHelper.DeleteUser(selected.id);
                loadData();
            }
        }
    }



}