using FinancialApiDataAccess.Repository.Interface;
using FinancialApiModel.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiDataAccess.Repository.Implementation
{
    public class UserTransactionRepository : IUserTransactionRepository
    {
        private readonly FinancialApiDbContext _context;
      
        public UserTransactionRepository(FinancialApiDbContext  context)
        {
            _context = context;
        }

        public async Task<List<UserTransaction>> GetTransactionsByUserId(string userId)
            => await _context.UserTransactions.Where(x => x.UserId == userId).ToListAsync();
    }
}
