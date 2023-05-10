    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Model
{
    public class TrxBansosModel
    {
        public int Id { get; set; }
        public string Bansos { get; set; }
        public string User { get; set; }
        public string Tanggal { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
    }
}
