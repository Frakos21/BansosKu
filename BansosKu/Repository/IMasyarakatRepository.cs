using BansosKu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BansosKu.Repository
{
    public interface IMasyarakatRepository
    {
        public bool Create(Masyarakat masyarakat);
        public bool Update(Masyarakat masyarakat,int id);
        public bool Delete(int id);
        public List<Masyarakat> GetAll();
        public Masyarakat GetById(int id);
    }
}
