using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Material
{
    public interface IMaterialRepository
    {
        List<NguyenLieu> GetMaterialsList();
            string GetCode();
        string GetMaterialNameById(string maNL);
         bool InsertMaterial(NguyenLieu congThuc);
        string GetLastMaterialCode();
        bool DeleteMaterial(string maNL);

        bool UpdateMaterial(NguyenLieu updated);
        List<NguyenLieu> SearchMaterial(string keyword);
        
    }
}
