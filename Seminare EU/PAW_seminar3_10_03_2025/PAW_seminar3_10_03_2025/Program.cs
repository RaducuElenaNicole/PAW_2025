using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar3_10_03_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Account account = new Account();

            // account.Process(50); // aduna 
            // account.Process(21); // scade 
            // Console.WriteLine(account.ToString());

            Individual ion = new Individual("Ion", true);
            ion.Account.Process(50);
            ion.Account.Process(21);
            Console.WriteLine(ion.Account.ToString());

            Individual maria = new Individual("Maria", false);
            maria.Account.Process(50);
            maria.Account.Process(21);
            Console.WriteLine(maria.Account.ToString());


            Console.ReadKey();
        }
    }
}
