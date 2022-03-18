using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApiModel.Models
{
    public class Account
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string AccountBalance { get; set; }
    }
}
