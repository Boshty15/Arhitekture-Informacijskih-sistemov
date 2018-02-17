using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IzberiPodjetje : System.Web.UI.Page
{
    string pod;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();

        localhost.Podjetje[] podjetje = services.getPodjetjeAll();

        GridView1.DataSource = podjetje;
        GridView1.DataBind();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
       

    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        
    }

    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row = GridView1.Rows[e.NewSelectedIndex];
        Label1.Text = row.Cells[2].Text;
        pod = row.Cells[2].Text;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Response.Redirect("Default.aspx?Podjetje="  )
        HttpCookie cookName = new HttpCookie("Podjetje");
        cookName.Value = Label1.Text;

    }
}