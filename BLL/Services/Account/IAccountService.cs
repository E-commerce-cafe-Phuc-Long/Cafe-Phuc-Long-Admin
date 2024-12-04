using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Account
{
     public interface IAccountService
    {
        IEnumerable<Account_DTO> GetAccountsInfo();
        IEnumerable<Account_DTO> SearchAccountsByPhoneOrEmail(string keyword);
    }
}
