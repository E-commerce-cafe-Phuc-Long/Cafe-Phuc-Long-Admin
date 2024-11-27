using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public CategoryRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<DanhMuc> GetCategoriesList()
        {
            return _context.DanhMucs.ToList();
        }
        public bool InsertCategory(DanhMuc nv)
        {
            try
            {
                _context.DanhMucs.InsertOnSubmit(nv);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
       
        public bool UpdateCategory(DanhMuc updated)
        {
            try
            {
                var nv = _context.DanhMucs.SingleOrDefault(p => p.maDM == updated.maDM);

                if (nv != null)
                {
                    nv.tenDM = updated.tenDM;
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
        public List<DanhMuc> SearchCategory(string keyword)
        {
            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    return GetCategoriesList();
                }

                var result = _context.DanhMucs
                   .Where(nv => nv.maDM.Contains(keyword) ||
                             nv.tenDM.Contains(keyword))
                   
                   .ToList();
                

                return result;
            }

            catch
            {
                return new List<DanhMuc>();
            }
        }
        public string GetLastCategoryCode()
        {
            return _context.DanhMucs
                .OrderByDescending(dm => dm.maDM)
                .Select(dm => dm.maDM)
                .FirstOrDefault();
        }
    }
}
