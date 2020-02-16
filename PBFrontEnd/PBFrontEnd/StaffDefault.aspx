﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="StaffDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="lblStaffList" runat="server" Font-Bold="False" Font-Size="X-Large" Text="Staff List"></asp:Label>
    </p>
    <p>
        <asp:ListBox ID="lstStaff" runat="server" Height="226px" Width="363px"></asp:ListBox>
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>
        <br /> <br />
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; width: 169px"></asp:TextBox>
        <br />
    </p>
    <p>
&nbsp;<asp:Button ID="btnApply" runat="server" Text="Apply" />
        &nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
    </p>
<p style="height: 64px">
    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;
    <asp:Button ID="btnEdit" runat="server" Text="Edit" />
&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    <br />
</p>
</asp:Content>

