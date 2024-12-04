using CloudinaryDotNet.Actions;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Size
{
    public interface ISizeService
    {
        List<DTO.Size> GetSizeList();
        List<DTO.Size> GetSizesByProductId(string productId);
        DTO.Size GetSizeByCode(string sizeCode);
        string GenerateSizeCode();
        bool InsertSize(DTO.Size size);
        bool UpdateSize(DTO.Size size);
        bool DeleteSize(string maSize);
        List<DTO.Size> SearchSize(string keyword);
    }
}
