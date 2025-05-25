using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar3_10_03_2025
{
    public class Individual
    {
        public string Name { get; set; }
        public Account Account {  get; }

        public Individual(string name, bool registerDepositEventHandler) {
            Name = name;
            Account = new Account();

            if (registerDepositEventHandler == true)
            {
                Account.OnDeposit += OnDepositEventHandler;
            }
                
    }

        private void OnDepositEventHandler(double amount, double balance, double difference)
        {
            Console.WriteLine($"User {Name} deposited {amount} and now has {balance} ({difference} until {amount})");
        }
    }
}
