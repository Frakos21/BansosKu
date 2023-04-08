using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BansosKu.ViewModel
{
    class MasyarakatVM
    {
        public int Id { get; set; }
        public string NIK { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDelete { get; set; }
        public string RT_name { get; set; }
        public string RW_name { get; set; }
        public string Kelurahan_name { get; set; }
    }
}
