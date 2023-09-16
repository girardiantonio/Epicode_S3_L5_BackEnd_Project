using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.UI.WebControls;

namespace Epicode_S3_L5_BackEnd_Project
{
    public partial class Carrello : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carrello = Session["Carrello"] as Carrello;

                if (carrello != null)
                {
                    CarrelloRepeater.DataSource = carrello.Prodotti;
                    CarrelloRepeater.DataBind();
                    TotaleLabel.Text = carrello.CalcolaTotale().ToString("0.00");
                }
            }
        }

        protected void EliminaProdotto(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int productIdToRemove = Convert.ToInt32(e.CommandArgument);
                Carrello carrello = Session["Carrello"] as Carrello;

                if (carrello != null)
                {
                    Prodotto prodottoDaRimuovere = carrello.Prodotti.FirstOrDefault(p => p.IdProdotto == productIdToRemove);

                    if (prodottoDaRimuovere != null)
                    {
                        carrello.RimuoviProdotto(prodottoDaRimuovere);
                        AggiornaCarrello(carrello);
                    }
                }
            }
        }

        private void AggiornaCarrello(Carrello carrello)
        {
            CarrelloRepeater.DataSource = carrello.Prodotti;
            CarrelloRepeater.DataBind();
            TotaleLabel.Text = carrello.CalcolaTotale().ToString("0.00");
            Session["Carrello"] = carrello;
        }


        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Session["Carrello"] = null;
            Response.Redirect("Carrello.aspx");
        }
    }
}
