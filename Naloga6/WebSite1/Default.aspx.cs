using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    bool izpisOsebeVPod = false;
    localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
    string pod;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["Admin"] != null)
        {
            if ((bool)Session["Admin"])
            {
                bttIzpisVsehOseb.Enabled = true;
                bttVsaPodjetja.Enabled = true;
                bttDodajOseboVPodjetje.Enabled = true;
                bttOdstraniOseboIzPodjetja.Enabled = true;
                bttUrediOsebo.Enabled = true;
                bttUrediPodjetje.Enabled = true;
            }
        }
        if (Session["UrediOsebo"] != null)
        {
            if ((bool)Session["UrediOsebo"])
            {
                localhost.Oseba[] oseba = services.getOsebeAll();
                GridView1.DataSource = oseba;
                GridView1.DataBind();
            }
        }
        if (Session["UrediPodjetje"] != null)
        {
            if ((bool)Session["UrediPodjetje"])
            {

                localhost.Podjetje[] podjetje = services.getPodjetjeAll();

                GridView1.DataSource = podjetje;
                GridView1.DataBind();
            }
        }
    }

    protected void bttPrikazi_Click(object sender, EventArgs e)
    {
        // Label1.Text = DropDownList2.SelectedItem.Text;
        /* if (DropDownList2.SelectedItem.Text == "1")
         {
             izpisOsebeVPod = true;
            Response.Redirect("IzberiPodjetje.aspx");

             //string pod = Request.QueryString["Podjetje"];
             //Label1.Text = pod;
         }*/
       

    }

    protected void bttOsebeVPod_Click(object sender, EventArgs e)
    {
        GridViewPodjetje.Enabled = true;
        GridViewPodjetje.Visible = true;
        // GridView2.DataSource = 
        if (GridViewOseba.Enabled)
        {
            GridViewOseba.Visible = false;
        }


        localhost.Podjetje[] podjetje = services.getPodjetjeAll();

        GridViewPodjetje.DataSource = podjetje;
        GridViewPodjetje.DataBind();
    }

    protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        GridViewRow row = GridViewPodjetje.Rows[e.NewSelectedIndex];
        Label1.Text = row.Cells[2].Text;
        pod = row.Cells[2].Text;

        if (Session["DodajOseboVPodjetje"] != null)
        {
            if ((bool)Session["DodajOseboVPodjetje"])
            {
                GridViewRow row2 = GridViewPodjetje.Rows[e.NewSelectedIndex];
                Label1.Text = row2.Cells[2].Text;
                int index = Convert.ToInt16(row2.Cells[1].Text);


                Session["IndexPodjetja"] = index;
            }
        }
        if (Session["OdstraniOseboIzPodjetja"] != null)
        {
            if ((bool)Session["OdstraniOseboIzPodjetja"])
            {
                GridViewRow row2 = GridViewOseba.Rows[e.NewSelectedIndex];
                int index = Convert.ToInt16(row2.Cells[1].Text);

                Session["IndexOsebe"] = index;
            }
        }
        if (Session["OdstraniOseboIzPodjetja"] != null)
        {
            if ((bool)Session["OdstraniOseboIzPodjetja"])
            {
                GridViewRow row2 = GridViewPodjetje.Rows[e.NewSelectedIndex];
                Label1.Text = row2.Cells[2].Text;
                int index = Convert.ToInt16(row2.Cells[1].Text);


                Session["IndexPodjetja"] = index;
            }
        }
        if (Session["UrediPodjetje"] != null)
        {
            if ((bool)Session["UrediPodjetje"])
            {
                GridViewRow row2 = GridViewPodjetje.Rows[e.NewSelectedIndex];
                string naziv = row2.Cells[2].Text;
                string panoga = row2.Cells[3].Text;
                string letoUsta = row2.Cells[4].Text;

                Session["UrediPodjetjeNaziv"] = naziv;
                Session["UrediPodjetjePanoga"] = panoga;
                Session["UredIPodjetjeLetoUstanovitve"] = letoUsta;

                Server.Transfer("UrediPodjetje.aspx", true);

                localhost.Podjetje[] podjetje = services.getPodjetjeAll();
                GridView1.DataSource = podjetje;
                GridView1.DataBind();

            }
        }

        localhost.Oseba[] osebaVPod = services.listaOseb(pod);
        GridView1.DataSource = osebaVPod;
        GridView1.DataBind();
    }

    protected void bttvseosebePodjetje_Click(object sender, EventArgs e)
    {
        Session["OsebaVPod"] = true;
        GridViewOseba.Enabled = true;
        GridViewOseba.Visible = true;
        if (GridViewPodjetje.Enabled)
        {
            GridViewPodjetje.Visible = false;
        }


        localhost.Oseba[] oseba = services.getOsebeAll();
        GridViewOseba.DataSource = oseba;
        GridViewOseba.DataBind();

    }

    protected void GridViewOseba_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        
        GridViewRow row = GridViewOseba.Rows[e.NewSelectedIndex];
        Label1.Text = row.Cells[2].Text;
        string ime = row.Cells[2].Text;
        
        if(Session["OsebaVPod"] != null)
        {
            if ((bool)Session["OsebaVPod"])
            {
                localhost.Podjetje[] osebaVPod2 = services.listaPodjetja(ime);
                GridView1.DataSource = osebaVPod2;
                GridView1.DataBind();
            }
        }
        
        if(Session["ImeOsebePodrobnosti"] != null)
        {
            if ((bool)Session["ImeOsebePodrobnosti"])
            {
                localhost.Oseba o2 = services.getOsebaIme(ime);
                Label1.Text = o2.ime + " " + o2.priimek + " " + o2.letoRojstva;
            }

        }
        if(Session["DodajOseboVPodjetje"] != null)
        {
            if ((bool)Session["DodajOseboVPodjetje"])
            {
                GridViewRow row2 = GridViewOseba.Rows[e.NewSelectedIndex];
                int index = Convert.ToInt16(row2.Cells[1].Text);

                Session["IndexOsebe"] = index;

                if(Session["IndexPodjetja"] != null)
                {
                    services.AddOsebaVPodjetjeByIndex(Convert.ToInt16(Session["IndexOsebe"]), Convert.ToInt16(Session["IndexPodjetja"]), txtBDelovnoMesto.Text, Convert.ToInt16(txtBDatumDo.Text));
                    /*GridViewPodjetje.Enabled = true;
                    GridViewPodjetje.Visible = true;
                    // GridView2.DataSource = 
                    if (GridViewOseba.Enabled)
                    {
                        GridViewOseba.Visible = false;
                    }


                    localhost.Podjetje[] podjetje = services.getPodjetjeAll();

                    GridViewPodjetje.DataSource = podjetje;
                    GridViewPodjetje.DataBind();*/
                }

            }
        }
        if(Session["OdstraniOseboIzPodjetja"] != null)
        {
            if ((bool)Session["OdstraniOseboIzPodjetja"])
            {
                GridViewRow row2 = GridViewOseba.Rows[e.NewSelectedIndex];
                int index = Convert.ToInt16(row2.Cells[1].Text);

                Session["IndexOsebe"] = index;

                if(Session["IndexPodjetja"] != null)
                {

                    if (services.OdstraniOseboIzPodjetjaByIndex(Convert.ToInt16(Session["IndexOsebe"]), Convert.ToInt16(Session["IndexPodjetja"])) == 1)
                    {


                    }
                }


            }
        }
        if(Session["UrediOsebo"] != null)
        {
            if ((bool)Session["UrediOsebo"])
            {
                GridViewRow row2 = GridViewOseba.Rows[e.NewSelectedIndex];
                string i = row2.Cells[2].Text;
                string pr = row2.Cells[3].Text;
                string letoDo = row2.Cells[4].Text;

                Session["UrediOseboIme"] = i;
                Session["UrediPriimek"] = pr;
                Session["UredILetoDo"] = letoDo;

                Server.Transfer("UrediOsebo.aspx", true);

                localhost.Oseba[] oseba = services.getOsebeAll();
                GridView1.DataSource = oseba;
                GridView1.DataBind();

            }
        } 
        
        


    }

    protected void bttOsebaPodrobnosti_Click(object sender, EventArgs e)
    {
        GridViewOseba.Enabled = true;
        localhost.Oseba[] oseba = services.getOsebeAll();
        GridViewOseba.DataSource = oseba;
        GridViewOseba.DataBind();
        Session["ImeOsebePodrobnosti"] = true;
        
    }

    protected void bttPrijava_Click(object sender, EventArgs e)
    {
        if (services.isAdministrator(txtBPrijava.Text, txtBGeslo.Text))
        {
            // MessageBox.Show("Successful login for Admin");
            Session["admin"] = true;
            Response.Redirect(Request.RawUrl);
            bttPrijava.Enabled = false;
            txtBGeslo.Enabled = false;
            txtBPrijava.Enabled = false;
        }
    }

    protected void bttIzpisVsehOseb_Click(object sender, EventArgs e)
    {
        localhost.Oseba[] oseba = services.getOsebeAll();
        GridView1.DataSource = oseba;
        GridView1.DataBind();
        
    }

    protected void bttVsaPodjetja_Click(object sender, EventArgs e)
    {
        localhost.Podjetje[] podjetje = services.getPodjetjeAll();
        GridView1.DataSource = podjetje;
        GridView1.DataBind();
    }

    protected void bttDodajOseboVPodjetje_Click(object sender, EventArgs e)
    {
        GridViewPodjetje.Visible = true;
        GridViewOseba.Visible = true;
        GridViewPodjetje.Enabled = true;
        GridViewOseba.Enabled = true;
        txtBDatumDo.Enabled = true;
        txtBDelovnoMesto.Enabled = true;

        localhost.Oseba[] oseba = services.getOsebeAll();
        GridViewOseba.DataSource = oseba;
        GridViewOseba.DataBind();

        localhost.Podjetje[] podjetje = services.getPodjetjeAll();

        GridViewPodjetje.DataSource = podjetje;
        GridViewPodjetje.DataBind();
        Session["DodajOseboVPodjetje"] = true;

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label1.Text = Session["IndexOsebe"] + "  " + Session["IndexPodjetja"];


       
    }

    protected void bttOdstraniOseboIzPodjetja_Click(object sender, EventArgs e)
    {
        GridViewOseba.Enabled = true;
        GridViewPodjetje.Enabled = true;
        GridViewOseba.Visible = true;
        GridViewPodjetje.Visible = true;

        Session["OdstraniOseboIzPodjetja"] = true;
        Session["OsebaVPod"] = true;
        localhost.Oseba[] oseba = services.getOsebeAll();
        GridViewOseba.DataSource = oseba;
        GridViewOseba.DataBind();

        localhost.Podjetje[] podjetje = services.getPodjetjeAll();

        GridViewPodjetje.DataSource = podjetje;
        GridViewPodjetje.DataBind();




    }
    protected void GridViewPodjetje_RowEditing(object sender, GridViewEditEventArgs e)
    {
        
    }

    protected void bttUrediOsebo_Click(object sender, EventArgs e)
    {
        Session["UrediOsebo"] = true;
        GridViewOseba.Enabled = true;

        localhost.Oseba[] oseba = services.getOsebeAll();
        GridViewOseba.DataSource = oseba;
        GridViewOseba.DataBind();


    }

    protected void bttUrediPodjetje_Click(object sender, EventArgs e)
    {
        Session["UrediPodjetje"] = true;
        GridViewPodjetje.Enabled = true;
        localhost.Podjetje[] podjetje = services.getPodjetjeAll();

        GridViewPodjetje.DataSource = podjetje;
        GridViewPodjetje.DataBind();



    }
}