using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregatire_test_1.clase
{
    public class Doctor : IComparable<Doctor>
    {
        public int _id {  get; set; }
        public string _nume {  get; set; }
        public float _salariu { get; set; }
        public string _specializare { get; set; }

        public Doctor(int id, string nume, float salariu, string specializare)
        {
            this._id = id;
            this._nume = nume;
            this._salariu = salariu;
            this._specializare = specializare;
        }

        public override string ToString()
        {
            return $"ID: {_id} | " +
                $"Nume: {_nume} | " +
                $"Salariu: {_salariu} | " +
                $"Specializare: {_specializare}";
        }

        public int CompareTo(Doctor otherDoctor)
        {
            /*
              a < b => -1 
              a > b => 1
              a == b => 0
             */

            return (this._nume.CompareTo(otherDoctor._nume));
        }
    }
}
