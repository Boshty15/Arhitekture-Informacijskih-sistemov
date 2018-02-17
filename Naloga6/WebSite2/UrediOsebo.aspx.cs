using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UrediOsebo : System.Web.UI.Page
{
    localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
    ServiceReference1.Service1Client services2 = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["UrediOsebo"] != null)
        {
            if ((bool)Session["UrediOsebo"])
            {
                txtBIme.Text = Session["UrediOseboIme"].ToString();
                txtBPriimek.Text =  Session["UredILetoDo"].ToString();
                txtBLetoDo.Text = Session["UrediPriimek"].ToString();
                Session["UrediOsebo"] = false;
            }
        }
    }

    protected void bttPotrdi_Click(object sender, EventArgs e)
    {
        Session["UrediOsebo"] = true;
        services2.UpdateOsebe(Session["UrediOseboIme"].ToString(), Session["UredILetoDo"].ToString(), txtBIme.Text, txtBPriimek.Text, Convert.ToInt16(txtBLetoDo.Text));
        Server.Transfer("Default.aspx", true);
    }
}