using DAL.Repositories.Category;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository repository)
        { 
            _repository = repository; 
        }
        public List<DanhMuc> GetCategoriesList()
        {
            return _repository.GetCategoriesList();
        }
        public bool InsertCategory(DanhMuc nv)
        {
            return _repository.InsertCategory(nv);
        }

        public bool UpdateCategory(DanhMuc update)
        {
            return _repository.UpdateCategory(update);
        }
        public List<DanhMuc> SearchCategory(string keyword)
        {
            return _repository.SearchCategory(keyword);
        }
        public string GenerateCategoryCode()
        {
            var lastCustomerCode = _repository.GetLastCategoryCode();

            if (string.IsNullOrEmpty(lastCustomerCode))
            {
                return "DM001";
            }

            var number = int.Parse(lastCustomerCode.Substring(2));

            return $"DM{(number + 1):D3}";
        }
    }
}
