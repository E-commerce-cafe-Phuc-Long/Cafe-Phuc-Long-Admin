using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Dosage
{
    public interface IDosageRepository
    {
        List<LieuLuong> GetAll();
        LieuLuong Get(string id);
    }
}
