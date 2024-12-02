using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Recipe
{
    public interface IRecipeService
    {
        List<CongThuc> GetRecipeList();
        bool InsertRecipe(CongThuc congThuc);
        string GenerateRecipeCode();
        bool DeleteRecipe(string maCT);

        bool UpdateRecipe(CongThuc updated);
        List<CongThuc> SearchRecipe(string keyword);
    }
}
