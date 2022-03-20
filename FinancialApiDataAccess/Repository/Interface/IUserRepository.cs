using FinancialApiModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiDataAccess.Repository.Interface
{
    public interface IUserRepository
    {
        Task <User>GetUser(string UserId);
        Task<List<User>>  GetUsers();
        Task<bool> AddUser(User user);
        Task<bool> DeleteUser(User user);
        Task<bool> UpdateUser(User user);
    }
}
