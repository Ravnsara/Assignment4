using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["person"] != null)
        {

            lblWelcome.Text = "Welcome.";
          GetDonationInfo();
           
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    private void GetDonationInfo()
    {
        int pk = (int)Session["person"];
        ViewDonation vd = new ViewDonation(pk);
        DataTable dt = vd.GetCustomer();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void lbDonation_Click(object sender, EventArgs e)
    {
        Response.Redirect("GetDonations.aspx");
    }
}