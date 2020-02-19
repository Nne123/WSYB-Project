<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="MenuDefault.aspx.cs" Inherits="MenuDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Menu List" Font-Bold="True" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
    </p>
        <p>
        <asp:ListBox ID="lstOrders" runat="server" Height="226px" Width="363px"></asp:ListBox>
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>
        <br /> <br />
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; width: 169px"></asp:TextBox>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
    </p>
<p style="height: 64px">
    <asp:Button ID="btnAdd" runat="server" Text="Add" />
&nbsp;
    <asp:Button ID="btnEdit" runat="server" Text="Edit" />
&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    <br />
</p>
</asp:Content>

