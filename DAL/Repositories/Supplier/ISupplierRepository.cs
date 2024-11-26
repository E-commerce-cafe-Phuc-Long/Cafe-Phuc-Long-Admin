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
        bool Insert(NhaCungCap p);
        bool Update(NhaCungCap updated);
        bool Delete(string maNCC);
        dynamic Search(string keyword);

    }
}
