using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Category
{
    public interface ICategoryService
    {
        List<DanhMuc> GetCategoriesList();
        bool InsertCategory(DanhMuc nv);
        bool UpdateCategory(DanhMuc update);
        List<DanhMuc> SearchCategory(string keyword);
        string GenerateCategoryCode();
    }
    
}
