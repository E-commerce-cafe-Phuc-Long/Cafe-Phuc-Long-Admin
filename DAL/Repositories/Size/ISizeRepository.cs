using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Size
{
    public interface ISizeRepository
    {
        List<DTO.Size> GetSizeList();
        List<DTO.Size> GetSizesByProductId(string productId);
        string GetLastSizeCode();

        bool InsertSize(DTO.Size size);
        bool UpdateSize(DTO.Size size);
        bool DeleteSize(string maSize);
        List<DTO.Size> SearchSize(string keyword);

    }
}
