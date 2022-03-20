using FinancialApiDataAccess.Repository.Interface;
using FinancialApiModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiDataAccess.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly FinancialApiDbContext _context;
        public UserRepository(FinancialApiDbContext context)
        {

            _context = context;

        }

        public async Task<bool> AddUser(User user)
        {
            await _context.AddAsync(user);
            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<List<User>> GetUsers()
        {
           return await _context.Users.ToListAsync();
          
        }

        public async Task<User> GetUser(string UserId)
        {
            var user = await _context.Users.Include(x => x.UserTransactions)
                .Include(u => u.Accounts).FirstOrDefaultAsync(x => x.Id == UserId);
            return user;
        }

        public async Task<bool> DeleteUser(User user)
        {
            var users = _context.Remove(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateUser(User user)
        {
            _context.Update(user);
            return await _context.SaveChangesAsync() >0;
        }
    }
}
