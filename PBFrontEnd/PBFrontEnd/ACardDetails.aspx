<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="ACardDetails.aspx.cs" Inherits="CardDetailsDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblCardNo1" runat="server" Text="Card No:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCardNo1" runat="server"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;
    &nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="."></asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
    <br />
</asp:Content>

