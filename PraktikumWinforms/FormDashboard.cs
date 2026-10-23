using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWinForms
{

    public partial class FormDashboard : Form
    {
        private List<User> users;
        public FormDashboard()
        {
            InitializeComponent();
            this.users = generateData();
            DgUser.DataSource = users;
        }

        public List<User> generateData()
        {
            List<User> users = new List<User>();
            for (var i = 0; i < 5; i++)
            {
                User user = new User($"Andro : {i}", 100 + i, "Lumajang");
                users.Add(user);
            }

            return users;
        }
    }



}
