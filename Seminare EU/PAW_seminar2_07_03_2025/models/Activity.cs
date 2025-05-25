using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_seminar2_07_03_2025.models
{
    public class Activity
    // sealed -> nu poate fi mostenita 
    {
        private string _numeActivity; // membri privati se scriu cu _ si cu litera mica la inceput 
        private int _duration;


        // membri publici se scriu cu litera mare

        // Varianta 1 (get + set)
        public string GetName()
        {
            return _numeActivity;
        }

        public void SetName(string name)
        {
            _numeActivity = name;
        }

        // Varianta 2 (get + set)
        public string Name
        {
            get { return _numeActivity; }
            set { _numeActivity = value; }
        }

        // Varianta 3 (get + set)
        // eu in clasa pot pune direct asta: 
        public String NameGetSet { get; set; }
        public int DurationGetSet { get; set; }

        // Varianta 4 (get + set)
        public string NumeActivity { get => _numeActivity; set => _numeActivity = value; }
        public int Duration { get => _duration; set => _duration = value; }
 

        public Activity(string name, int duration) {
            // cu litera mica => parametri 
            _numeActivity = name;
            _duration = duration;
        }
    }
}
