using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Size
{
    public class SizeRepository : ISizeRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public SizeRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<DTO.Size> GetSizeList()
        {
            return _context.Sizes.ToList();
        }
        public List<DTO.Size> GetSizesByProductId(string productId)
        {
            return _context.ChiTietSanPhams
                .Where(ctsp => ctsp.maSP == productId)
                .Select(ctsp => ctsp.Size)
                .Distinct()
                .ToList();
        }
        public string GetLastSizeCode()
        {
            return _context.Sizes
                .OrderByDescending(kh => kh.maSize)
                .Select(kh => kh.maSize)
                .FirstOrDefault();
        }
        public bool InsertSize(DTO.Size size)
        {
            try
            {
                _context.Sizes.InsertOnSubmit(size);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteSize(string maSize)
        {
            try
            {
                var size = _context.Sizes.SingleOrDefault(p => p.maSize == maSize);

                if (size != null)
                {
                    _context.Sizes.DeleteOnSubmit(size);
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
        public bool UpdateSize(DTO.Size updated)
        {
            try
            {
                var nv = _context.Sizes.SingleOrDefault(p => p.maSize == updated.maSize);

                if (nv != null)
                {
                    nv.tenSize = updated.tenSize;
                    nv.ghiChu = updated.ghiChu;
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
        public List<DTO.Size> SearchSize(string keyword)
        {
            try
            {

                if (string.IsNullOrEmpty(keyword))
                {
                    return GetSizeList();
                }

                var result = _context.Sizes
                   .Where(nv => nv.maSize.Contains(keyword) ||
                             nv.tenSize.Contains(keyword))

                                   .ToList();


                return result;
            }

            catch
            {
                return new List<DTO.Size>();
            }
        }
    }
}
