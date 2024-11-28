using DAL.Repositories.Material;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Material
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _repository;
        public MaterialService(IMaterialRepository repository)
        { 
            _repository = repository; 
        }
        public List<NguyenLieu> GetMaterialsList()
        {
            return _repository.GetMaterialsList();
        }
        public string GenerateMaterialCode()
        {
            var lastMaterialCode = _repository.GetLastMaterialCode();

            if (string.IsNullOrEmpty(lastMaterialCode))
            {
                return "NL001";
            }

            var number = int.Parse(lastMaterialCode.Substring(2));

            return $"NL{(number + 1):D3}";
        }
        public bool InsertMaterial(NguyenLieu nguyenlieu)
        {
            return _repository.InsertMaterial(nguyenlieu);

        }
        public bool DeleteMaterial(string maNL)
        {
            return _repository.DeleteMaterial(maNL);
        }

        public bool UpdateMaterial(NguyenLieu updated)
        {
            return _repository.UpdateMaterial(updated);
        }
        public List<NguyenLieu> SearchMaterial(string keyword)
        {
            return _repository.SearchMaterial(keyword);
        }
    }
}
