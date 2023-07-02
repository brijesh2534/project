<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Project.ipoandsmedetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ipo And Sme Details</title>
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
#sme{
            color:black;
            align-items:center;
            font-family: Arial, Helvetica, sans-serif;
            margin: auto;
            width: 50%;
            border: 3px solid white;
            padding: 10px;
}
    </style>
</head>
<body>
     
    <form id="form1" runat="server">
          <h1>Ipo Details</h1>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView><br />
    <h1 id="sme">Sme Details</h1>
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    </form>
</body>
</html>
