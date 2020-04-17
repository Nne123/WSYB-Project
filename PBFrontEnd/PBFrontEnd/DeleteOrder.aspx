<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this order?"></asp:Label>
    <br />
    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="81px" />
&nbsp;&nbsp;
    <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="77px" />
</asp:Content>

