using AutoMapper;
using FinancialApiDataAccess;
using FinancialApiModel.Dtos;
using FinancialApiService.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialApiProject.Controllers
{

    public class TransactionController : BaseController
    {
        private readonly IUserTransactionService _transService;
        public TransactionController(IUserTransactionService transService)
        {
            _transService = transService;
        }

        [HttpGet("user-transactions/{userId}")]
        public async Task<IActionResult> GetAllUserTransaction(string userId)
            => Ok(await _transService.GetTransactionsByUserI(userId));

        [HttpGet("get-transactions-as-csv/{userId}")]
        public async Task<FileResult> DownloadAsCSV(string userId)
        {
            var path = await _transService.GetTransactionsAsCSV(userId);
            var file = System.IO.File.ReadAllBytes(path);
            return File(file, System.Net.Mime.MediaTypeNames.Application.Octet, "transactions.csv");
        }
     }
}
