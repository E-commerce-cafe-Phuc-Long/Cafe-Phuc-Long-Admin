using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Recipe_material
{
    public class Recipe_materialRepository : IRecipe_materialRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public Recipe_materialRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<CongThuc_NguyenLieu> GetRecipe_materialsList()
        {
            return _context.CongThuc_NguyenLieus.ToList();
        }
        public List<CongThuc_NguyenLieu> GetRecipe_materialsListById(string maCT, string maNL)
        {
            return _context.CongThuc_NguyenLieus
                .Where(x => x.maCT == maCT || x.maNL == maNL)
                .ToList();
        }
        public CongThuc_NguyenLieu GetRecipe_materialsById(string maCT, string maNL)
        {
            return _context.CongThuc_NguyenLieus
                .Where(x => x.maCT == maCT && x.maNL == maNL)
                .FirstOrDefault();
        }
        public bool InsertRecipe_material(CongThuc_NguyenLieu ct_nl)
        {
            try
            {
                _context.CongThuc_NguyenLieus.InsertOnSubmit(ct_nl);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool DeleteRecipe_material(string maCT,string maNL)
        {
            try
            {
                var ct_nl = _context.CongThuc_NguyenLieus.SingleOrDefault(p => p.maCT == maCT && p.maNL == maNL);

                if (ct_nl != null)
                {
                    _context.CongThuc_NguyenLieus.DeleteOnSubmit(ct_nl);
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
        public bool UpdateRecipe_material(CongThuc_NguyenLieu updated)
        {

            try
            {
                var ct_nl = _context.CongThuc_NguyenLieus.SingleOrDefault(p => p.maCT == updated.maCT && p.maNL == updated.maNL);

                if (ct_nl != null)
                {
                    ct_nl.soLuong = updated.soLuong;
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
    }
}
