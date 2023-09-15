using System;
using System.Collections.Generic;

namespace Epicode_S3_L5_BackEnd_Project
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Prodotto> prodotti = Database.GetProdotti();
                productRepeater.DataSource = prodotti;
                productRepeater.DataBind();
            }
        }

        protected void AddCarrello_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int productId;
                if (int.TryParse(Request.QueryString["id"], out productId))
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
}
