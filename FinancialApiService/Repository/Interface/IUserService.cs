using FinancialApiModel.Dtos;
using FinancialApiModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiService.Repository.Interface
{
    public interface IUserService
    {
        Task<User> GetUser(string UserId);
        Task<List<User>> GetUsers();
        Task<string> AddUser(RegistrationDto model);

        Task<string> DeleteUser(string UserId);

        Task<User> UpdateUser(string UserId, UpdateUserDto model);
    }


    
}
