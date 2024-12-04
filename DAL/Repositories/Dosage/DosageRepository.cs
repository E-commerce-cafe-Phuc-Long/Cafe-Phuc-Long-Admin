using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Dosage
{
    public class DosageRepository : IDosageRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public DosageRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;
        }
        public List<LieuLuong> GetAll()
        {
            return _context.LieuLuongs.ToList();
        }
        public LieuLuong Get(string id)
        {
            return _context.LieuLuongs.FirstOrDefault(x => x.maLL == id);
        }
    }
}
