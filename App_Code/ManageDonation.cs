using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ManageDonation
/// </summary>
public class ManageDonation
{
    Customer c; 
   SqlConnection connect;
	public ManageDonation(Customer cust)
    {
        c = cust;
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
    }
    public void WriteDonation(int personKey)
    {
        string sqlDonation = "Insert into Donation(DonationAmount, DonationDate, PersonKey) " + "Values(@Donation, @DonDate, @personKey)";

        SqlCommand donationCmd = new SqlCommand(sqlDonation, connect);
        donationCmd.Parameters.AddWithValue("@personKey", personKey);
        donationCmd.Parameters.AddWithValue("@Donation", c.Donation);
        donationCmd.Parameters.AddWithValue("@DonDate", DateTime.Now);


        connect.Open();       
        donationCmd.ExecuteNonQuery();
        connect.Close();
    }
}