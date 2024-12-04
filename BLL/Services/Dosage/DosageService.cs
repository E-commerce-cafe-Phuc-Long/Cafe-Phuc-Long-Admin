using DAL.Repositories.Dosage;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Dosage
{
    public class DosageService : IDosageService
    {
        private readonly IDosageRepository _repository;
        public DosageService(IDosageRepository repository)
        {
            this._repository = repository;
        }
        public List<LieuLuong> GetAll()
        {
            return _repository.GetAll();
        }
        public LieuLuong Get(string id)
        {
            return _repository.Get(id);
        }
    }
}
