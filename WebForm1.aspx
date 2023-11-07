<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdminPanel</title>
    <style type="text/css">
        .auto-style1 {
            width: 68%;
            height: 291px;
        }
        .auto-style2 {
            width: 419px;
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
    <h1>Welcome to Admin Panel</h1>
    <p>From Here you can make modifications in the App Content.</p>
  </div>
       
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Interior route assist"></asp:Label>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Video Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="245px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Author Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Upload video</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="save" />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm2.aspx">View all uploaded videos</asp:HyperLink>
        <br />
        <br />
        <br />

         <table class="auto-style1">
            <tr>
                <td class="auto-style2">Map Name</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                
            </tr>
            <tr>
                <td class="auto-style2">Map image</td>
                <td>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="save" />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
                </td>
            </tr>
             <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Map_Tab.aspx">View all uploaded images</asp:HyperLink>
        </table>
    </form>
</body>
</html>
