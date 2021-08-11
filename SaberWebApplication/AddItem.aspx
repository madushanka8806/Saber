<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="SaberWebApplication.AddItem" %>

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
    <div>
        <h2>
            <br />
            Add Item
        </h2>
    <table id="style1">
        <tr>
            <td class="style2">
                Item Code
            </td>
            <td>
        <asp:TextBox ID="txtItemCode"  runat="server"></asp:TextBox>   
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Item Code is Required" ClientIDMode="AutoID" ControlToValidate="txtItemCode" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
            <td class="style2">
                Item Name</td>
            <td>
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
            </td>
        <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Item Name is Required" ClientIDMode="AutoID" ControlToValidate="txtItemName" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="style2">
                UOM</td>
            <td>
        <asp:TextBox ID="txtUOM" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" Unit of Measur is Required" ClientIDMode="AutoID" ControlToValidate="txtUOM" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="style2">
                Qty</td>
            <td>
        <asp:TextBox ID="txtAvailableQty" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Available Quantity is Required" ClientIDMode="AutoID" ControlToValidate="txtAvailableQty" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="buttons" />
        <asp:Label ID="lblResult" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
        <div id="content_footer"></div>
    <div id="footer">
      <p><a href="/AddItem.aspx">Add to Items</a> | <a href="/AddStock.aspx"">Add to Stock</a> | <a href="/PlaceOrder.aspx">Place the Order</a> | <a href="/SearchIteambyName.aspx"> Search By Name</a> | <a href="/SearchItembyCode.aspx">Search By Code</a></p>
      <p>Copyright &copy; 2021 Saber silk | Design and Developed by Shamal Wijesinghe</a></p>
    </div>
</body>
</html>
