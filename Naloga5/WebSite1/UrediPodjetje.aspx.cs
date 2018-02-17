using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UrediPodjetje : System.Web.UI.Page
{
    localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (Session["UrediPodjetje"] != null)
        {
            if ((bool)Session["UrediPodjetje"])
            {
                txtNaziv.Text =  Session["UrediPodjetjeNaziv"].ToString();
                txtPanoga.Text =  Session["UrediPodjetjePanoga"].ToString();
                txtUstanovitev.Text = Session["UredIPodjetjeLetoUstanovitve"].ToString();
                Session["UrediPodjetje"] = false;

            }
        }
    }

    protected void bttPotrdi_Click(object sender, EventArgs e)
    {
        Session["UrediPodjetje"] = true;
        services.UpdatePodjetje(Session["UrediPodjetjeNaziv"].ToString(), txtNaziv.Text, txtPanoga.Text, Convert.ToInt16(txtUstanovitev.Text));
        Server.Transfer("Default.aspx", true);
    }
}