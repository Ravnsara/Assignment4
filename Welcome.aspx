<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table>
         <tr>
           <td>
              <h1><asp:Label ID="lblWelcome" runat="server" Text=""></asp:Label> </h1></td>
        </tr>
        <tr>
           <td>
              <asp:Label ID="Label1" runat="server" Text="Your Current and Past Donations. Thank You!"></asp:Label></td>
        </tr>
        <tr>
           <td>          
               <asp:GridView ID="GridView1" runat="server">
               </asp:GridView></td>                           
        </tr>
        <tr>
           <td>          
              <asp:Label ID="Label3" runat="server" Text="Would you like to donate today?"></asp:Label></td>     
        </tr>
        <tr>
           <td>          
              <asp:LinkButton ID="lbDonation" runat="server" PostBackUrl="~/GetDonations.aspx" OnClick="lbDonation_Click">Donate</asp:LinkButton></td>       
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
