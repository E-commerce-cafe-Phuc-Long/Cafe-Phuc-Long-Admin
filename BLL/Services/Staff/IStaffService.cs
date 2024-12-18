﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Staff
{
    public interface IStaffService
    {
     
        List<NhanVien> GetStaffList();
        string GenerateStaffCode();
        string HashPassword(string password);
        bool VerifyHashedPassword(string hashedPassword, string providedPassword);
        dynamic GetStaffWithRoleNames();
        bool InsertStaff(NhanVien newStaff);
        bool DeleteStaff(string maNV);
        bool UpdateStaff(NhanVien nv);
        dynamic SearchStaff(string keyword);
        NhanVien GetStaffByUsername(string username);
    }
}
