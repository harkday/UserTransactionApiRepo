using FinancialApiModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiDataAccess.Repository.Interface
{
    public interface IUserTransactionRepository
    {
        Task<List<UserTransaction>> GetTransactionsByUserId(string userId);

     
    }
}
