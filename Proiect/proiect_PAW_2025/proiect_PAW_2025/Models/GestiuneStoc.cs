using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_PAW_2025.Models
{
    public class GestiuneStoc
    {
        public int CodProdus { get; set; }
        public string CategorieNume {  get; set; }
        public int CategorieID { get; set; }
        public string Stare {  get; set; } // nou, defect, reambalat, returnat 

        public GestiuneStoc()
        {
        }

        public GestiuneStoc(int codProdus, string categorieNume, int categorieID, string stare)
        {
            CodProdus = codProdus;
            CategorieNume = categorieNume;
            CategorieID = categorieID;
            Stare = stare;
        }

        public override string ToString()
        {
            return $"CodProdus: {CodProdus} | " + 
                $"Categorie: {CategorieNume} | " +
                $"(ID: {CategorieID}) | " +
                $"Stare: {Stare}";
        }
    }
}
