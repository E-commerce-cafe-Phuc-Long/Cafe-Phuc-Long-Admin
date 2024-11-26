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
    }
}
