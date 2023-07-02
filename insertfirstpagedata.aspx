<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminhelp.aspx.cs" Inherits="Project.adminhelp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
     <style>
        h1{
            color:black;
            align-items:center;
            font-family: Arial, Helvetica, sans-serif;
            margin: auto;
            width: 50%;
            border: 3px solid white;
            padding: 10px;
        }
        body{
           background-color: #d5f4e6;
        }
        #GridView1{
             margin: auto;
            width: 50%;
            border: 3px solid white;
            padding: 10px;
            font-size:larger;
            font-family:Verdana;
        }
        h2{
            color:black;
            align-items:center;
            font-family: Arial, Helvetica, sans-serif;
            margin: auto;
            width: 50%;
            border: 3px solid white;
            padding: 10px;
        }
        #GridView2{
             margin: auto;
            width: 50%;
            border: 3px solid white;
            padding: 10px;
            font-size:larger;
            font-family:Verdana;
        }
        ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #333;
}

li {
  float: left;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

li a:hover {
  background-color: #111;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>