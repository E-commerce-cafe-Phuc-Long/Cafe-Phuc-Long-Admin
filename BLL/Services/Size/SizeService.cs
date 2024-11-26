using DAL.Repositories.Size;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Size
{
    public class SizeService : ISizeService
    {
        private readonly ISizeRepository _repository;
        public SizeService(ISizeRepository repository)
        {
            _repository = repository;
        }
        public List<DTO.Size> GetSizeList()
        {
            return _repository.GetSizeList();
        }
        public List<DTO.Size> GetSizesByProductId(string productId)
        {
            return _repository.GetSizesByProductId(productId);
        }
    }
}
