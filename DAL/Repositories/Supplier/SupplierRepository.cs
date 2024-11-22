using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Supplier
{
    public class SupplierRepository:ISupplierRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public SupplierRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            this._context = context;

        }
        public List<NhaCungCap> GetSupplierList()
        {
            return _context.NhaCungCaps.ToList();
        }

    }
}
