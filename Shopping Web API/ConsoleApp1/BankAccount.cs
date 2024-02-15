using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//base class
namespace ConsoleApp1
{
    public class BankAccount(string accountID, string owner)
    {
        public string AccountID { get; } = accountID;
        public string Owner { get; } = owner;

        public override string ToString() => $"Account ID: {AccountID}, Owner: {Owner}";
    }
}
