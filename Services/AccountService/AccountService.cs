using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness_Application.Data;

namespace Fitness_Application.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly DataContext _context;
        public AccountService(DataContext context)
        {
            _context = context;
            
        }
        public async Task<ServiceResponse<Account>> PostAccount(Account newAccount)
        {
            var response = new ServiceResponse<Account>();
            var account = newAccount;
            
            await _context.Accounts.AddAsync(newAccount);
            await _context.SaveChangesAsync();

            response.Data = await _context.Accounts.FirstOrDefaultAsync(A => A.Id == newAccount.Id);
            response.Message = "Success!";
            response.Success = true;

            return response;

        }
        private void HashPassword(string password, out byte[] PasswordHash, out byte[] PasswordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPasswordHash(string password, byte[] PasswordHash, byte[] PasswordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512(PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(PasswordHash);
            }
        }
    }
}