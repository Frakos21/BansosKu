using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string NIK { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Alamat { get; set; }
        public string FotoKTP { get; set; }
        public string FotoRumah { get; set; }
        public string Pendapatan { get; set; }
        public string Role { get; set; }
    }

}
