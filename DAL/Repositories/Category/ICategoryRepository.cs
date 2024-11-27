using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Category
{
    public interface ICategoryRepository
    {
        List<DanhMuc> GetCategoriesList();
        bool InsertCategory(DanhMuc nv);
        bool UpdateCategory(DanhMuc update);
        List<DanhMuc> SearchCategory(string keyword);
        string GetLastCategoryCode();
    }
}
