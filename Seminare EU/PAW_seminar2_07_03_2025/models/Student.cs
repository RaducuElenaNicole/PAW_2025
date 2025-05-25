using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar2_07_03_2025.models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // relatia HAS-A: studentul este inscris la activitati 
        // colectie de obiecte: lista de Activity 
        public List<Activity> Activities { get; set; } // lista generica cu o clasa template 

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Activities = new List<Activity>();
        }

        public void Display()
        {
            Console.WriteLine($"Student -> Name: {Name} | Ioana's activities: ");
            foreach (var activity in Activities)
            {
                Console.WriteLine($"Activity's name : {activity.Name} | Activity's Duration: {activity.Duration}");
            }

        }

        public void DisplayAfterRule()
        {
            Console.WriteLine($"Student -> Name: {Name} | Ioana's activities: ");
            foreach (var activity in Activities.Where(x => x.Duration <=4).OrderBy(x => x.Name))
            {
                Console.WriteLine($"Activity's name : {activity.Name} | Activity's Duration: {activity.Duration}");
            }

        }
    }
}
