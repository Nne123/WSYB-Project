<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblStaffDetails" runat="server" Font-Size="X-Large" Text="Staff Details"></asp:Label>
    <br />
    <br />
    First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtFirstName" runat="server" Width="127px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" Width="100px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblAddressLine" runat="server"  Text="Address Line " Width="122px"></asp:Label>
            &nbsp;
            &nbsp;<asp:TextBox ID="txtAddressLine" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblPostCode" runat="server" Text="PostCode"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCounty" runat="server" Text="County" Width="100px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlCounty" runat="server" style="z-index: 1; "></asp:DropDownList>
            <br />
            <asp:Label ID="lblPhoneNo" runat="server" Text="Phone No" Width="100px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:TextBox ID="txtPhoneNo" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1;" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

</asp:Content>

