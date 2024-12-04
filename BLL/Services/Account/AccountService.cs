using DAL.Repositories.Account;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            this._repository = repository;
        }

        public IEnumerable<Account_DTO> GetAccountsInfo()
        {
            return _repository.GetAccountsInfo();
        }
        public IEnumerable<Account_DTO> SearchAccountsByPhoneOrEmail(string keyword)
        {
            return _repository.SearchAccountsByPhoneOrEmail(keyword);
        }
    }
}
