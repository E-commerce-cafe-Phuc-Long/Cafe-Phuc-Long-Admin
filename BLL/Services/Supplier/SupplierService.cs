using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Supplier;
using DTO;

namespace BLL.Services.Supplier
{
    public class SupplierService:ISupplierService
    {
        public readonly ISupplierRepository _repository;
        public SupplierService(ISupplierRepository repository)
        {
            this._repository = repository;
        }
        public List<NhaCungCap> GetSupplierList()
        {
            return _repository.GetSupplierList();
        }
    }
}
