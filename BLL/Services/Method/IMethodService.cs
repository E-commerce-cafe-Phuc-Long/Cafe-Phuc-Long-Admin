﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Method
{
    public interface IMethodService
    {
        List<PhuongThucThanhToan> GetMethodsList();
    }
}
