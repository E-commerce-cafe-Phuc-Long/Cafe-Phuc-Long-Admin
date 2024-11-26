using DAL.Repositories.Method;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Method
{
    public class MethodService : IMethodService
    {
        private readonly IMethodRepository _repository;
        public MethodService(IMethodRepository repository)
        { 
            _repository = repository; 
        }
        public List<PhuongThucThanhToan> GetMethodsList()
        {
            return _repository.GetMethodsList();
        }
    }
}
