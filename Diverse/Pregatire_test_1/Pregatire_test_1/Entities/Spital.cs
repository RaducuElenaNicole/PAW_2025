using Pregatire_test_1.clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pregatire_test_1.Entities
{
    public class Spital
    {
        private string _id {  get; set; }
        private string _numeSpital {  get; set; }
        private List<Doctor> _doctori {  get; set; }

        public Spital(string id, string numeSpital, List<Doctor> doctori)
        {
            _id = id;
            _numeSpital = numeSpital;
            _doctori = doctori;
        }

        public void addDoctor(Doctor doctorNew)
        {
            this._doctori.Add(doctorNew);
        }

        public void removeDoctor(Doctor doctorToRemove) { 
            this._doctori.Remove(doctorToRemove);
        }

        public override string ToString()
        {
            String rezultat;

            rezultat = "Spital id: " + this._id + " | Nume spital: "
                + this._numeSpital + " | Medicii spitalului: \n";
            foreach (Doctor doctor in this._doctori) { 
                rezultat += doctor.ToString() + "\n";
            }

            return rezultat;
        }

        public List<Doctor> GetDoctori()
        {
            return _doctori;
        }
    }
}
