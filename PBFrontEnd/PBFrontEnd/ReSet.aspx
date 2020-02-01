<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="ReSet.aspx.cs" Inherits="ReSet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div>
            <br />
            <h1>Re-Set Password<br />
            </h1>
            <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
&nbsp;<asp:TextBox ID="txtEMail" runat="server" Width="283px"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
&nbsp;</div>
&nbsp;<asp:Button ID="btnReSet" runat="server" Text="Re-set Password" OnClick="btnReSet_Click" />
&nbsp;<asp:Button ID="btnDone" runat="server" Text="Done" OnClick="btnDone_Click" />
&nbsp;<asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Email" />
</asp:Content>

