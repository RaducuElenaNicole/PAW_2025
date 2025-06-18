using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_PAW_2025.Models
{
    public class Productie
    {
        public int CodProdus { get; set; }
        public decimal Cost { get; set; }
        public int TimpProductie { get; set; }

        public Productie()
        {
        }

        public Productie(int codProdus, decimal cost, int timpProductie)
        {
            CodProdus = codProdus;
            Cost = cost;
            TimpProductie = timpProductie;
        }

        public override string ToString()
        {
            return $"Cod produs: {CodProdus} | " +
                $"Cost: {Cost} | " +
                $"Timp productie: {TimpProductie}";
        }
    }
}
