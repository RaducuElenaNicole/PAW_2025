using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_PAW_2025.Models
{
    public class Produs
    {
        public int Cod  {get; set; }
        public string Denumire { get; set; }
        public float Pret { get; set; }
        public int Cantitate { get; set; }

        public Produs()
        {
        }

        public Produs(int cod, string denumire, float pret, int cantitate)
        {
            Cod = cod;
            Denumire = denumire;
            Pret = pret;
            Cantitate = cantitate;
        }

        public override string ToString()
        {
            return $"COD: {Cod} | " +
                $"Denumire: {Denumire} | " +
                $"Pret: {Pret} | " +
                $"Cantitate: {Cantitate}";
        }
    }
}