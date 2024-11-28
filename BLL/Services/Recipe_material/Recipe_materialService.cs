using DAL.Repositories.Recipe_material;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Recipe_material
{
    public class Recipe_materialService : IRecipe_materialService
    {
        private readonly IRecipe_materialRepository _repository;
        public Recipe_materialService(IRecipe_materialRepository repository)
        { 
            _repository = repository; 
        }
        public List<CongThuc_NguyenLieu> GetRecipe_materialsList()
        {
            return _repository.GetRecipe_materialsList();
        }
        public List<CongThuc_NguyenLieu> GetRecipe_materialsListById(string maCT, string maNL)
        {
            return _repository.GetRecipe_materialsListById(maCT, maNL);
        }
        public CongThuc_NguyenLieu GetRecipe_materialsById(string maCT, string maNL)
        {
            return _repository.GetRecipe_materialsById(maCT, maNL);
        }
        public bool InsertRecipe_material(CongThuc_NguyenLieu ct_nl)
        {
            return _repository.InsertRecipe_material(ct_nl);
        }
        public bool DeleteRecipe_material(string maCT, string maNL)
        {
            return _repository.DeleteRecipe_material(maCT, maNL);
        }
        public bool UpdateRecipe_material(CongThuc_NguyenLieu updated)
        {
            return _repository.UpdateRecipe_material(updated);
        }
    }
    
}
