<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectBank.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div>
            <br />
            <h1>Account Sign Up</h1>
                <table style="width: 100%;">
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtEMail" runat="server" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword1" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblConfirm" runat="server" Text="Confirm Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br />
                <br />
        </div>
&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSignUp" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" />
            <asp:Button ID="btnDone" runat="server" Text="Done" />
            <asp:Button ID="btnResetPassword" runat="server" Text="Re-set Password" />
            <asp:Button ID="btnViewEmail" runat="server" Text="View Email" />
</asp:Content>

