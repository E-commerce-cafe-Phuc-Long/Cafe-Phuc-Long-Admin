﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL.Repositories.Supplier;
using DTO;

namespace BLL.Services.Supplier
{
    public class SupplierService:ISupplierService
    {
        public readonly ISupplierRepository _repository;
        public SupplierService(ISupplierRepository repository)
        {
            this._repository = repository;
        }

        public string GenerateCode()
        {
            var lastCode = _repository.GetCode();

            // Nếu chưa có nhân viên thì khởi tạo mã NV: NV001
            if (string.IsNullOrEmpty(lastCode))
            {
                return "NCC001";
            }

            var number = int.Parse(lastCode.Substring(3));

            return $"NCC{(number + 1):D3}";
        }
         

        public List<NhaCungCap> GetSupplierList()
        {
            return _repository.GetSupplierList();
        }

        public bool Insert(NhaCungCap p)
        {
            return _repository.Insert(p);
        }
        public bool Update(NhaCungCap updated)
        {
            return _repository.Update(updated);
        }
        public bool Delete(string maNCC) 
        {
            return _repository.Delete(maNCC);
        }
            
        public dynamic Search(string keyword)
        {
            return _repository.Search(keyword);
        }
    }
}
