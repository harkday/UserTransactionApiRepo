using FinancialApiDataAccess;
using FinancialApiModel.Dtos;
using FinancialApiModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiProject.Controllers
{
    public class AuthController : BaseController
    {

        private readonly FinancialApiDbContext _context;
        public AuthController()
        {

            
        }
    }

}

