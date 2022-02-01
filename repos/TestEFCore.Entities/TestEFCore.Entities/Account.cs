using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCore.Entities
{
    public  class Account
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool Balance { get; set; }
        //[Column("account_number")]
        //[StringLength(3)]
        public string AccountNumber { get; set; }
        public AccountHolder AccountHolder { get; set; }

        //[ForeignKey("account
    }
}
