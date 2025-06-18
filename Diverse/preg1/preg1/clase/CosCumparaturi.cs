using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg1.clase
{
    public class CosCumparaturi
    {
        public List<Produs> produse = new List<Produs>();
        public int numarProduse;
        public decimal valoareTotala;

        public CosCumparaturi()
        {
        }

        public decimal calculeazaValoareTotala(List<Produs> produse)
        {
            decimal valoareTotala = 0;

            foreach (Produs produs in produse)
            {
                valoareTotala += produs.cantitate * produs.pret;
            }

            return valoareTotala;
        }

        public CosCumparaturi actualizareDetalii(List<Produs> produse)
        {
            CosCumparaturi cosActualizat = new CosCumparaturi();

            cosActualizat.valoareTotala = calculeazaValoareTotala(produse); 
            cosActualizat.numarProduse = produse.Count();
            cosActualizat = new CosCumparaturi(produse);

            return cosActualizat;
        }

        public CosCumparaturi(List<Produs> produse)
        {
            this.produse = produse;
            this.numarProduse = produse.Count;
            this.valoareTotala = calculeazaValoareTotala(produse);
        }

        public void adaugaProdus(Produs produsNou)
        {
            produse.Add(produsNou);
            actualizareDetalii(produse);
        }

        public void stergeProdus(Produs produsDeSters)
        {
            produse.Remove(produsDeSters);
            actualizareDetalii(produse);
        }

        public List<Produs> getProduse()
        {
            return produse;
        }

        public override string ToString()
        {
            string rezultat = "COS DE CUMPARATURI -> produse: \n";

            foreach (Produs produs in produse)
            {
                rezultat += "   " + produs.ToString();
            }

            return rezultat;
        }
    }
}
