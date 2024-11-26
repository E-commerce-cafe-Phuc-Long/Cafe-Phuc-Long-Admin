using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Method
{
    public class MethodRepository : IMethodRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public MethodRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<PhuongThucThanhToan> GetMethodsList()
        {
            return _context.PhuongThucThanhToans.ToList();
        }
    }
}
