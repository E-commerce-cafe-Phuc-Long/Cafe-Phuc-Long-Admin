using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Auth
{
    public interface IAuthRepository
    {
        string getRoleByUsernamePassword(string username);
    }
}
