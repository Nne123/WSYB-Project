<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div>
            <br />
            <h1>Sign-in<br />
            </h1>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 192px">
            <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="txtEMail" runat="server" Width="283px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 192px">
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="283px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 192px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
&nbsp;&nbsp;<br />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;<asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" Text="Sign In" />
&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
&nbsp;
            <asp:Button ID="btnResetPassword" runat="server" OnClick="btnResetPassword_Click" Text="Re-set Password" />
       </div>
</asp:Content>

