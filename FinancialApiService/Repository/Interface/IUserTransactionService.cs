using FinancialApiModel.Dtos;
using FinancialApiModel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiService.Repository.Interface
{
  public  interface IUserTransactionService
    {

        Task<List<UserTransactionDto>> GetTransactionsByUserI(string userId);
        Task<string> GetTransactionsAsCSV(string userId);
    }
}
