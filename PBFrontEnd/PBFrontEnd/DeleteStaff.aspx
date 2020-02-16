<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <br />
            <asp:Label ID="lblAddressNo" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this address?"></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; width: 59px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" Width="57px" />
</asp:Content>

