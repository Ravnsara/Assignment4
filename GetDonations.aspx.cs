using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class GetDonations : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Customer c = new Customer();
        c.Donation = txtDonation.Text;


        ManageDonation md = new ManageDonation(c);

        
            int pk = (int)Session["person"];
            md.WriteDonation(pk);
            Response.Redirect("Welcome.aspx");
                
    }
}
