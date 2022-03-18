using FinancialApiDataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialApiProject.Controllers
{

    public class TransactionController : BaseController
    {

        private readonly FinancialApiDbContext _context;
        public TransactionController(FinancialApiDbContext context)
        {

            _context = context;
        }

    }



}
