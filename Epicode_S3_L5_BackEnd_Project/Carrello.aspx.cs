using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Epicode_S3_L5_BackEnd_Project
{
    public partial class Carrello : System.Web.UI.Page
    {
        private Carrello carrello;

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

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Session["Carrello"] = null;
            Response.Redirect("Carrello.aspx");
        }

        protected void EliminaProdotto_Click(object sender, EventArgs e)
        {
            //ho provato di tutto ma non ci sono riuscito, forse con un pochino di tempo in più ci sarei riuscito
        }
    }
}
