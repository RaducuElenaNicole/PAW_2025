using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg1.clase
{
    public class Produs : IComparable<Produs>, INotifyPropertyChanged
    {
        public int id { get; set; }
        public string denumire { get; set; }
        public decimal pret { get; set; }
        public int cantitate { get; set; }

        public Produs(int id, string denumire, decimal pret, int cantitate)
        {
            this.id = id;
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        // ?????? 
        public event PropertyChangedEventHandler PropertyChanged;


        public override string ToString()
        {
            return $"PRODUS -> Id: {id} | Denumire: {denumire} | Pret: {pret} | Cantitate: {cantitate}\n";
        }

        public int CompareTo(Produs other)
        {
            return(this.denumire.CompareTo(other.denumire));    
        }
    }
}
