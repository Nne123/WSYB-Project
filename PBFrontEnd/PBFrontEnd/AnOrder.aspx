<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblFirstMenuItem" runat="server" Text="First Menu Item"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlFirstChoice" runat="server" Height="20px" Width="128px">
    </asp:DropDownList>
&nbsp;&nbsp;
    <asp:TextBox ID="txtFirstPrice" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblSecondMenuItem" runat="server" Text="Second Menu Item"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlSecondChoice" runat="server" Height="19px" Width="130px">
    </asp:DropDownList>
&nbsp;
    <asp:TextBox ID="txtSecondPrice" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblThirdMenuItem" runat="server" Text="Third Menu Item"></asp:Label>
&nbsp;
    <asp:DropDownList ID="ddlThirdChoice" runat="server" Height="16px" Width="131px" OnSelectedIndexChanged="ddlThirdMenuItem_SelectedIndexChanged">
    </asp:DropDownList>
&nbsp;
    <asp:TextBox ID="txtThirdPrice" runat="server"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtOrderTotal" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="74px" />
&nbsp;&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
</asp:Content>

