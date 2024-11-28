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

        public string GetMaterialNameById(string maNL)
        { return _repository.GetMaterialNameById(maNL); }
    }
}
