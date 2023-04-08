using BansosKu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BansosKu.Repository
{
    public class MasyarakatRepository : IMasyarakatRepository
    {
        List<Masyarakat> listMasyarakat;
        public MasyarakatRepository() { 
            listMasyarakat = new List<Masyarakat>();
        }

        public bool Create(Masyarakat masyarakat)
        {
            try
            {
                listMasyarakat.Add(masyarakat);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                var data = listMasyarakat.Where(x => x.Id == id).First();
                listMasyarakat.Remove(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public List<Masyarakat> GetAll()
        {
            return listMasyarakat;
        }

        public Masyarakat GetById(int id)
        {
            var data = new Masyarakat();
            try
            {
                data = listMasyarakat.Where(x => x.Id == id).First();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return data;
        }

        public bool Update(Masyarakat masyarakat, int id)
        {
            try
            {
                var m = listMasyarakat.Where(x => x.Id == id).First();
                m.Fullname = masyarakat.Fullname;
                m.Kelurahan = masyarakat.Kelurahan;
                m.RT_id = masyarakat.RT_id;
                m.RW_id = masyarakat.RW_id;
                m.NIK = masyarakat.NIK;
                m.UpdatedAt = masyarakat.CreatedAt;
                m.IsDelete = masyarakat.IsDelete;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
