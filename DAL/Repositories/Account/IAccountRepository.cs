using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Account
{
    public interface IAccountRepository
    {
        IEnumerable<Account_DTO> GetAccountsInfo();
        IEnumerable<Account_DTO> SearchAccountsByPhoneOrEmail(string keyword);

    }
}
