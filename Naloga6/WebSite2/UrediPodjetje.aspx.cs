using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UrediPodjetje : System.Web.UI.Page
{
    localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
    ServiceReference1.Service1Client services2 = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (Session["UrediPodjetje"] != null)
        {
            if ((bool)Session["UrediPodjetje"])
            {
                txtNaziv.Text =    Session["UrediPodjetjePanoga"].ToString();
                txtPanoga.Text = Session["UredIPodjetjeLetoUstanovitve"].ToString();
                txtUstanovitev.Text = Session["UrediPodjetjeNaziv"].ToString();
                Session["UrediPodjetje"] = false;

            }
        }
    }

    protected void bttPotrdi_Click(object sender, EventArgs e)
    {
        Session["UrediPodjetje"] = true;
        services2.UpdatePodjetje(Session["UrediPodjetjePanoga"].ToString(), txtNaziv.Text, txtPanoga.Text, Convert.ToInt16(txtUstanovitev.Text));
        Server.Transfer("Default.aspx", true);
    }
}