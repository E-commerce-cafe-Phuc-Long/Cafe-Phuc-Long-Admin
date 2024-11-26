using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Method
{
    public interface IMethodRepository
    {
        List<PhuongThucThanhToan> GetMethodsList();
    }
}
