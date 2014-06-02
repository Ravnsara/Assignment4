using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ViewDonation
/// </summary>
public class ViewDonation
{
    Customer c;
    int pk;
    
    SqlConnection connect;
    public ViewDonation(int PersonKey)
	{


        pk = PersonKey;
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
        
}

    public DataTable GetCustomer()
    {
       
        Customer c = new Customer();
        string sql = "Select DonationDate, DonationAmount from Donation d inner join Person p on d.PersonKey=p.PersonKey where d.PersonKey=@personKey";
           

        SqlCommand cmd = new SqlCommand(sql, connect);
        
        cmd.Parameters.AddWithValue("@personKey", pk);
        
        SqlDataReader reader;
        DataTable dt = new DataTable();
        connect.Open();
        reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            dt.Load(reader);  
        }
        reader.Close();
        connect.Close();

        return dt;
    
	}
}