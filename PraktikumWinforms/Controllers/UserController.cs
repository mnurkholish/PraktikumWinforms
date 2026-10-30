using PraktikumWinforms.Models;
using PraktikumWinforms.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PraktikumWinforms.Controllers
{
    public class UserController
    {
        private readonly UserRepository _repository;

        public UserController(UserRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetUser()
        {
            return _repository.GetAllUsers();
        }

        public bool AddUser(string pnama, string umurText, string asal)
        {
            if (!int.TryParse(umurText, out int umur))
            {
                throw new Exception("Umur harus berupa angka.");
            }

            if (string.IsNullOrWhiteSpace(pnama))
            {
                throw new Exception("Nama tidak boleh kosong.");
            }

            if (umur <= 0)
            {
                throw new Exception("Umur harus lebih dari 0.");
            }


            User user = new User(
                id : 1, nama : pnama, umur : umur, asal : asal);
         

            bool isSuccess = false;
            try
            {
                _repository.AddUser(user);
                isSuccess = true;
            }
            catch (Exception e)
            {
                throw new Exception();
            }

            return isSuccess;
        }

        public bool UpdateUser(
            int id,
            string nama,
            string umurText,
            string asal)
        {
            if (id <= 0)
            {
                throw new Exception("Pilih data yang ingin diubah.");
            }

            if (!int.TryParse(umurText, out int umur))
            {
                throw new Exception("Umur harus berupa angka.");
            }

            if (string.IsNullOrWhiteSpace(nama))
            {
                throw new Exception("Nama tidak boleh kosong.");
            }

            if (umur <= 0)
            {
                throw new Exception("Umur harus lebih dari 0.");
            }

            User user = new User(
                id : id,
                nama : nama,
                umur : umur,
                asal : asal)
            ;

            bool isSuccess = false;
            try
            {
                _repository.UpdateUser(user);
                isSuccess = true;
            }
            catch (Exception e)
            {
                throw new Exception();
            }

            return isSuccess;
        }

        public bool DeleteUser(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Pilih data yang ingin dihapus.");
            }

            bool isSuccess = false;
            try
            {
                _repository.DeleteUser(id);
                isSuccess = true;
            }
            catch (Exception e)
            {
                throw new Exception();
            }

            return isSuccess;
        }
    }
}
