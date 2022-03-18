using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace FinancialApiModel.Models
{
    public  class User:IdentityUser 
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNo { get; set; }
        public List<Account> Accounts { get; set; }
        public List<UserTransaction> UserTransactions { get; set; }
        public User()
        {
            Accounts = new List<Account>();
            UserTransactions = new List<UserTransaction>();
        }

    }
}
