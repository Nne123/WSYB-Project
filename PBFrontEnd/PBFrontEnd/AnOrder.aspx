<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblFirstMenuItem" runat="server" Text="First Menu Item"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlFirstMenuItem" runat="server" Height="20px" Width="128px">
    </asp:DropDownList>
&nbsp;&nbsp;
    <asp:Label ID="lblFirstPrice" runat="server" Text="First Price"></asp:Label>
    <br />
    <asp:Label ID="lblSecondMenuItem" runat="server" Text="Second Menu Item"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlSecondMenuItem" runat="server" Height="19px" Width="130px">
    </asp:DropDownList>
&nbsp;
    <asp:Label ID="lblSecondPrice" runat="server" Text="Second Price"></asp:Label>
    <br />
    <asp:Label ID="lblThirdMenuItem" runat="server" Text="Third Menu Item"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlThirdMenuItem" runat="server" Height="16px" Width="131px">
    </asp:DropDownList>
&nbsp;
    <asp:Label ID="lblThirdPrice" runat="server" Text="Third Price"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblOrderTotal" runat="server" Text="Order Total"></asp:Label>
    <br />
    <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="74px" />
&nbsp;&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
</asp:Content>

