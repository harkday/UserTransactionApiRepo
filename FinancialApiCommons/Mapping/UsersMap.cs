using AutoMapper;
using FinancialApiModel.Dtos;
using FinancialApiModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiCommons.Mapping
{
    public class UsersMap: Profile
    {
        public UsersMap()
        {
            CreateMap<UserTransaction, UserTransactionDto>();
            CreateMap< RegistrationDto, User>();
            CreateMap<UpdateUserDto, User>();
         
        }

    }
}
