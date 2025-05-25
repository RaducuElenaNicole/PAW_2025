using PAW_seminar2_07_03_2025.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar2_07_03_2025
{
    internal class Program
    // internal - public doar la nivelul proiectului din solutie 
    {
        static void Main(string[] args)
        {
            Activity paw = new Activity("PAW", 2);
            Activity java = new Activity("Java", 4);
            Activity poo = new Activity("Poo", 5);
            Console.WriteLine(paw.GetName() + " | " + paw.Duration);
            Console.WriteLine($"Activity -> Name: {paw.Name} | Duration: {paw.Duration}");

            paw.Name = "SDD";
            Console.WriteLine(paw.GetName());

            Student george = new Student("George", 20);
            Student ioana = new Student("Ioana", 25);

            george.Activities.Add(poo);
            george.Activities.Add(java); 

            ioana.Activities.Add(poo);
            ioana.Activities.Add(java);
            ioana.Activities.Add(paw);

            ioana.Display();
            Console.WriteLine("\n");
            ioana.DisplayAfterRule();

            Console.ReadKey();
        }
    }
}
