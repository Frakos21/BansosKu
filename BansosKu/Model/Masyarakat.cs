using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BansosKu.Model
{
    public class Masyarakat : User
    { 
        public int RT_id { get; set; }
        public int RW_id { get; set; }
        public int Kelurahan { get; set; }
    }
}
