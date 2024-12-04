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
        public DTO.Size GetSizeByCode(string sizeCode)
        {
            return _repository.GetSizeByCode(sizeCode);
        }
        public string GenerateSizeCode()
        {
            var lastSizeCode = _repository.GetLastSizeCode();

            if (string.IsNullOrEmpty(lastSizeCode))
            {
                return "S001";
            }

            var number = int.Parse(lastSizeCode.Substring(2));

            return $"S{(number + 1):D3}";
        }
        public bool InsertSize(DTO.Size size)
        {
            return _repository.InsertSize(size);

        }
        public bool UpdateSize(DTO.Size size)
        {
            return _repository.UpdateSize(size);
        }
        public bool DeleteSize(string maSize)
        {
            return _repository.DeleteSize(maSize);
        }
        public List<DTO.Size> SearchSize(string keyword)
        {
            return _repository.SearchSize(keyword);
        }
    }
}
