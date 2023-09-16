using System;
using System.Collections.Generic;
using System.Linq;

namespace Epicode_S3_L5_BackEnd_Project
{
    public partial class Carrello
    {
        private Carrello carrello;

        public List<Prodotto> Prodotti { get; } = new List<Prodotto>();

        public void AggiungiProdotto(Prodotto prodotto)
        {
            Prodotti.Add(prodotto);
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            Prodotti.Remove(prodotto);
        }

        public decimal CalcolaTotale()
        {
            return Prodotti.Sum(prodotto => prodotto.Prezzo);
        }

        public void SvuotaProdotti()
        {
            Prodotti.Clear();
        }
    }
}
