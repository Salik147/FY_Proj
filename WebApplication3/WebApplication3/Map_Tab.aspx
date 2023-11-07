<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Map_Tab.aspx.cs" Inherits="WebApplication3.Map_Tab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Map View</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
         body {
            background-image: url('bl.jpg');
            background-repeat: no-repeat;
            background-size: cover;
            background-attachment: fixed;
             margin: 0;
             padding: 0;
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
    <h1>Welcome to Map View</h1>
    <p>Here You can see the Maps for the directions.</p>
  </div>
    
        Here You Can See Maps For Your Destinations<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
            <Columns>
                <asp:TemplateField HeaderText="Room Name">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Mapname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Destination Map">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Mapimage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
        <br />
        <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Back" />
    
    </div>
    </form>
</body>
</html>
