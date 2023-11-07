<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Guide</title>
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
    <h1>Welcome to User Guide</h1>
    <p>How to Use:</p>
      <p>1 You can see in the top of the page you have four option &quot;Clip View&quot;,&quot;Map View&quot;,&quot;User Guide&quot;,&quot;Admin&quot;, from their you can navigate throug the app.</p>
      <p>2. By Clicking on Clip view you will see Videos for the location so you will need to play them to see the direction</p>
      <p>3.By Clicking on Map View you will see Maps for the location.</p>
    </div>
    </form>
</body>
</html>
