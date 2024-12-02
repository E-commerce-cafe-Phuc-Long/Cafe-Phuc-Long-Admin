using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Recipe
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public RecipeRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<CongThuc> GetRecipeList()
        {
            return _context.CongThucs.ToList();
        }
        public string GetLastRecipeCode()
        {
            return _context.CongThucs
                .OrderByDescending(kh => kh.maCT)
                .Select(kh => kh.maCT)
                .FirstOrDefault();
        }
        public bool InsertRecipe(CongThuc congThuc)
        {
            try
            {
                _context.CongThucs.InsertOnSubmit(congThuc);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        
        public bool DeleteRecipe(string maCT)
        {
            try
            {
                var congthuc = _context.CongThucs.SingleOrDefault(p => p.maCT == maCT);

                if (congthuc != null)
                {
                    _context.CongThucs.DeleteOnSubmit(congthuc);
                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateRecipe(CongThuc updated)
        {
            try
            {
                var nv = _context.CongThucs.SingleOrDefault(p => p.maCT == updated.maCT);

                if (nv != null)
                {
                    nv.tenCT = updated.tenCT;
                    nv.moTa = updated.moTa;
                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public List<CongThuc> SearchRecipe(string keyword)
        {
            try
            {

                if (string.IsNullOrEmpty(keyword))
                {
                    return GetRecipeList();
                }

                var result = _context.CongThucs.Where(nv => nv.maCT.Contains(keyword) ||
                             nv.tenCT.Contains(keyword))
                                   .ToList();
                  


                return result;
            }

            catch
            {
                return new List<CongThuc>();
            }
        }

    }
}
