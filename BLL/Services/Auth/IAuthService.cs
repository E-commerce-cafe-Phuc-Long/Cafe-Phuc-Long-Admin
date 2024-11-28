using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Auth
{
    public interface IAuthService
    {
        string getRoleByUsernamePassword(string username);
    }
}
