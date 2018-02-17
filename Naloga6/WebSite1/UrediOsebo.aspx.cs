using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UrediOsebo : System.Web.UI.Page
{
    localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["UrediOsebo"] != null)
        {
            if ((bool)Session["UrediOsebo"])
            {
                txtBIme.Text = Session["UrediOseboIme"].ToString();
                txtBPriimek.Text = Session["UrediPriimek"].ToString();
                txtBLetoDo.Text = Session["UredILetoDo"].ToString();
                Session["UrediOsebo"] = false;
            }
        }
    }

    protected void bttPotrdi_Click(object sender, EventArgs e)
    {
        Session["UrediOsebo"] = true;
        services.UpdateOsebe(Session["UrediOseboIme"].ToString(), Session["UrediPriimek"].ToString(), txtBIme.Text, txtBPriimek.Text, Convert.ToInt16(txtBLetoDo.Text));
        Server.Transfer("Default.aspx", true);
    }
}