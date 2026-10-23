using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumWinForms
{
    public class User
    {
        public string nama { get; set; }
        public int umur { get; set; }
        public string asal { get; set; }

        public User(string nama, int umur, string asal)
        {
            this.nama = nama;
            this.umur = umur;
            this.asal = asal;
        }
    }
}
