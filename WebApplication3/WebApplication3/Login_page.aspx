<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_page.aspx.cs" Inherits="WebApplication3.Login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin_Login</title>
    <style>
.center {
  margin: auto;
  width: 60%;
  border: 3px solid #73AD21;
  padding: 10px;
}
 body {
            background-image: url('bl.jpg');
            background-repeat: no-repeat;
            background-size: cover;
            background-attachment: fixed;
        }
  .navbar {
      background-color: transparent;
      position: fixed;
      top: 0;
      left: 0;
      right: 0;
      z-index: 999;
      height: 70px;
      
    }
    
    .navbar ul {
      list-style-type: none;
      margin: 0;
      padding: 0;
      display: flex;
      justify-content: space-around;
      align-items: center;
      height: 60px;
    }
    
    .navbar li {
      display: inline;
      font-size: 30px;
    }
    
    .navbar a {
      text-decoration: none;
      color: black;
      transition: background-color 0.3s, transform 0.3s;
    }
    
    .navbar a:hover {
      background-color: blue;
      transform: scale(1.6);
      

    }
    
    .content {
      margin-top: 70px;
      padding: 20px;
      background-color: transparent;
      text-align: center;
    }
</style>
</head>
<body>


    <form id="form1" runat="server">
         <div>
        <nav class="navbar">
    <ul>
      <li><a href="WebForm2.aspx">Clip View</a></li>
      <li><a href="Map_Tab.aspx">Map View</a></li>
      <li><a href="WebForm3.aspx">User Guide</a></li>
      <li><a href="Login_page.aspx">Admin</a></li>
    </ul>
  </nav>
  
  <div class="content">
    <h1>Welcome to Admin Login</h1>
    <p>Put Id and Password below.</p>
  </div>
    <div class="center">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Admin Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="313px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Admin Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="310px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="Blue" BorderColor="#3366FF" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Login" OnClick="Button1_Click" />
    
        <asp:Label ID="Label3" runat="server"></asp:Label>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
