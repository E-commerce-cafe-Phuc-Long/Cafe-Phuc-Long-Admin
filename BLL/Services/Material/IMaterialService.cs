using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Material
{
    public interface IMaterialService
    {
        List<NguyenLieu> GetMaterialsList();
        string GenerateMaterialCode();
        bool InsertMaterial(NguyenLieu nguyenlieu);
        bool DeleteMaterial(string maNL);
        bool UpdateMaterial(NguyenLieu updated);
        List<NguyenLieu> SearchMaterial(string keyword);
        string GetMaterialNameById(string maNL);
    }
}
