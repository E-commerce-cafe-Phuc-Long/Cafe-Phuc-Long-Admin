using DAL.Repositories.Recipe;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Recipe
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _repository;
        public RecipeService(IRecipeRepository repository)
        {
            _repository = repository;
        }
        public List<CongThuc> GetRecipeList()
        {
            return _repository.GetRecipeList();
        }
        public string GenerateRecipeCode()
        {
            var lastRecipeCode = _repository.GetLastRecipeCode();

            if (string.IsNullOrEmpty(lastRecipeCode))
            {
                return "CT001";
            }

            var number = int.Parse(lastRecipeCode.Substring(2));

            return $"CT{(number + 1):D3}";
        }
        public bool InsertRecipe(CongThuc congThuc)
        {
            return _repository.InsertRecipe(congThuc);

        }
        public bool DeleteRecipe(string maCT)
        {
            return _repository.DeleteRecipe(maCT);
        }

        public bool UpdateRecipe(CongThuc updated)
        {
            return _repository.UpdateRecipe(updated);
        }
        public List<CongThuc> SearchRecipe(string keyword)
        {
            return _repository.SearchRecipe(keyword);
        }

    }
}
