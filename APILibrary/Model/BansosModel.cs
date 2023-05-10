using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Model
{
public class BansosModel
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Tanggal { get; set; }
        public string Deskripsi { get; set; }
        public string Lokasi { get; set; }
        public string Image { get; set; }
    }
}
