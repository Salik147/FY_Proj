<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clip View</title>
    <style type="text/css">
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
    <h1>Welcome to Clip View</h1>
    <p>Hire you can see the Clips for you desired location.</p>
  </div>
 <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Admin Only" Font-Italic="True" ForeColor="Blue" Width="79px" />
        </p>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Interior route assist" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="351px">
            <ItemTemplate>
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                AuthorName:
                <asp:Label ID="AuthorNameLabel" runat="server" Text='<%# Eval("AuthorName") %>' />
                <br />
                VideoLink:
                <asp:Label ID="VideoLinkLabel" runat="server" Text='<%# Eval("VideoLink") %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [VideoData]"></asp:SqlDataSource>
    
    </div>
       
    </form>
</body>
</html>
