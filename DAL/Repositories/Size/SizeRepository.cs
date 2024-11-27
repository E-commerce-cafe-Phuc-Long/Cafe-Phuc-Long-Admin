using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Size
{
    public class SizeRepository : ISizeRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public SizeRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<DTO.Size> GetSizeList()
        {
            return _context.Sizes.ToList();
        }
        public List<DTO.Size> GetSizesByProductId(string productId)
        {
            return _context.ChiTietSanPhams
                .Where(ctsp => ctsp.maSP == productId)
                .Select(ctsp => ctsp.Size)
                .Distinct()
                .ToList();
        }
    }
}
