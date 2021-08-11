<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchItembyCode.aspx.cs" Inherits="SaberWebApplication.SearchItembyCode" %>

<!DOCTYPE html>
<style type="text/css">
       .style1
       {
           
           text-align: center;
       }
       .style2
       {
           
           text-align: center;
       }
    .auto-style1 {
        
        text-align: center;
    }
</style>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="/style.css" />
    <title>Saber Silk Stock Process</title>
</head>
<body>
     <div id="header">
      <div id="logo">
        <div id="logo_text">

          <h1><a href="/AddItem.aspx"><span class="logo_colour">Saber Silk</span></a></h1>
          <h2>" We Dress the World "</h2>
        </div>
      </div>
      <div id="menubar">
        <ul id="menu">
          <li class="selected"><a href="/AddItem.aspx">Add to Items</a></li>
          <li><a href="/AddStock.aspx">Add to Stock</a></li>
          <li><a href="/PlaceOrder.aspx">Place the Order</a></li>
          <li><a href="/SearchIteambyName.aspx">Search By Name</a></li>
          <li><a href="/SearchItembyCode.aspx">Search By Code</a></li>
        </ul>
      </div>
    </div>
    <form id="form1" runat="server">
         <h2>
            <br />
            Search Item By Name
        </h2>
    <div>
    <table class="style1">
        <tr>
            <td class="style2">
                Prduct Id
            </td>
            <td>
        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
            </td>
             <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Product Id is Required" ClientIDMode="AutoID" ControlToValidate="txtProductId" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="buttons" />
            </td>
        </tr>
            <asp:GridView ID="dlProduct" runat="server"></asp:GridView>
        </table>
    </div>
    </form>
     <br />
    <br />
    <br />
    <div id="content_footer"></div>
    <div id="footer">
      <p><a href="/AddItem.aspx">Add to Items</a> | <a href="/AddStock.aspx"">Add to Stock</a> | <a href="/PlaceOrder.aspx">Place the Order</a> | <a href="/SearchIteambyName.aspx"> Search By Name</a> | <a href="/SearchItembyCode.aspx">Search By Code</a></p>
      <p>Copyright &copy; 2021 Saber silk | Design and Developed by Shamal Wijesinghe</a></p>
    </div>
</body>
</html>
