using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Recipe_material
{
    public interface IRecipe_materialService
    {
        List<CongThuc_NguyenLieu> GetRecipe_materialsList();
        List<CongThuc_NguyenLieu> GetRecipe_materialsListById(string maCT, string maNL);
        CongThuc_NguyenLieu GetRecipe_materialsById(string maCT, string maNL);
        bool InsertRecipe_material(CongThuc_NguyenLieu ct_nl);
        bool DeleteRecipe_material(string maCT, string maNL);
        bool UpdateRecipe_material(CongThuc_NguyenLieu updated);
    }
}
