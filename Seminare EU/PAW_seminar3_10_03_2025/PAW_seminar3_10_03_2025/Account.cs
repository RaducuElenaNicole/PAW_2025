using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar3_10_03_2025
{
    public class Account
    {
        // delegat care nu returneaza nimic 
        public delegate void Operation(double amount);
        private Operation _operation;

        // actiuni = timp special de delegate ACTIONS 
        // public Action<double> OperationWithAction;

        // evenimente 
        public delegate void DepositDelegate(double amount, double balance, double difference);
        public event DepositDelegate OnDeposit;

        private double _balance;

        public Account() { 
            _balance = 0;
        }

        private void Deposit(double amount) // depunere bani 
        {
            _balance += amount;
            OnDeposit?.Invoke(amount, _balance, 10000 - _balance); // ? -> verifica daca expresia din stanga e != NULL, daca e o executa 
        }

        private void Withdraw(double amount) // retragere bani
        {
            _balance -= amount;
        }

        public void Process(double amount) 
        {
            if (amount % 2 == 0)
            {
               // Deposit(amount);
               _operation = Deposit;
               // OperationWithAction(amount);
            }
            else
            {
               // Withdraw(amount);
               _operation = Withdraw;
               // OperationWithAction(amount);
            }

            _operation(amount);
        }

        // tipul de date Object 
        public override string ToString() { 
            return $"This account has a balance of {_balance}";
        }
    }
}
