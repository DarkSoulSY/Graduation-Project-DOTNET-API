using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness_Application.Services.AccountService
{
    public interface IAccountService
    {
        Task<ServiceResponse<Account>> PostAccount(Account newAccount);
    }
}