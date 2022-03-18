using FinancialApiDataAccess;
using FinancialApiModel.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinancialApiProject
{
    public class Seeder
    {

        private readonly FinancialApiDbContext _context;
      
        public Seeder(FinancialApiDbContext context)
        {
            _context = context;
          
        }

        public async Task SeedInData()
        {
            _context.Database.EnsureCreated();
       
         var path_UserSeeds = @"./Seeds.json";

            var userData = File.ReadAllText(path_UserSeeds);
            var users = JsonSerializer.Deserialize<List<User>>(userData);
            if (!_context.Users.Any())
            {
                _context.Users.AddRange(users);
               


            }

            _context.SaveChanges();






        } 
    }
}
