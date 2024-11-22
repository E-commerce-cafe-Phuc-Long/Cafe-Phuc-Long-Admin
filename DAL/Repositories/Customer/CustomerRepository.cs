using DTO;
using System;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly E_Commerce_Coffee_And_TeaDataContext _context;
        public CustomerRepository(E_Commerce_Coffee_And_TeaDataContext context)
        {
            _context = context;
        }
        public List<KhachHang> GetCustomersList()
        {
            return _context.KhachHangs.ToList();
        }

      


        public bool InsertCustomer(KhachHang p)
        {
            try
            {
                _context.KhachHangs.InsertOnSubmit(p);

                _context.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(string maKH)
        {
            try
            {
                var kh = _context.KhachHangs.SingleOrDefault(p => p.maKH == maKH);

                if (kh != null)
                {
                    _context.KhachHangs.DeleteOnSubmit(kh);
                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(KhachHang updated)
        {
            try
            {
                var nv = _context.KhachHangs.SingleOrDefault(p => p.maKH == updated.maKH);

                if (nv != null)
                {
                    nv.tenKH = updated.maKH;
                    //nv.username = updated.username;
                    //nv.matKhau = updated.matKhau;
                    nv.soDT = updated.soDT;
                    nv.ngaySinh = updated.ngaySinh;
                    nv.diaChi = updated.diaChi;
                    nv.email = updated.email;
                  

                    _context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public List<KhachHang> SearchCustomer(string keyword)
        {
            try
            {
                var result = _context.KhachHangs
                    .Where(nv => nv.maKH.Contains(keyword) ||
                                 nv.tenKH.Contains(keyword))
                    .ToList();

                return result;
            }
            catch
            {
                return new List<KhachHang>();
            }
        }

    }
}
