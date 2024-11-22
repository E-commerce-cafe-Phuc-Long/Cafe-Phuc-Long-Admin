using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories.Supplier
{
    public interface ISupplierRepository
    {
        List<NhaCungCap> GetSupplierList();
    }
}
