using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_S3_L5_BackEnd_Project
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["id"], out int productId))
                {
                    Prodotto prodotto = Database.GetProdottoById(productId);

                    if (prodotto != null)
                    {
                        NomeProdotto.Text = prodotto.Nome;
                        DescrizioneProdotto.Text = prodotto.Descrizione;
                        DescrizioneDettagliata.Text = prodotto.DescrizioneDettagliata;
                        Prezzo.Text = prodotto.Prezzo.ToString("0.00");
                        ImgUrl.ImageUrl = prodotto.ImgUrl;
                    }
                }
            }
        }

        protected void AddCarrello_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["id"], out int productId))
            {
                Prodotto prodotto = Database.GetProdottoById(productId);

                if (prodotto != null)
                {
                    Carrello carrello = Session["Carrello"] as Carrello ?? new Carrello();
                    carrello.AggiungiProdotto(prodotto);
                    Session["Carrello"] = carrello;
                }
            }
        }
    }
}