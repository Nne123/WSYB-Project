﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="StaffDefault.aspx.cs" Inherits="StaffDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="lblStaffList" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Staff List" ForeColor="Black"></asp:Label>
    </p>
    <p>
        <asp:ListBox ID="lstStaff" runat="server" Height="226px" Width="363px"></asp:ListBox>
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>
        <br /> <br />
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; width: 169px"></asp:TextBox>
        <br />
    </p>
    <p>
&nbsp;<asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
        &nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" />
    </p>
<p style="height: 64px">
    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;
    <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    <br />
</p>
</asp:Content>

