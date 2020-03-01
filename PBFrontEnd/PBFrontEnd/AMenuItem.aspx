<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="AMenuItem.aspx.cs" Inherits="AMenuItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblMenuItem" runat="server" Text="Menu Item"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="txtMenuItem" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    <br />
    <br />
&nbsp;<asp:Button ID="btnOK" runat="server" Text="OK" Width="67px" OnClick="btnOK_Click" />
    &nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
</asp:Content>

