using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Dosage
{
    public interface IDosageService
    {
        List<LieuLuong> GetAll();
    }
}
