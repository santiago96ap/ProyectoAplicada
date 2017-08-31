<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CoreVisesProyectoI.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <div class="login">
        <div class="main-agileits">
            <div class="form-w3agile form1">
                <h3>Register</h3>
                <form id="form1" runat="server">
                    <div class="key">
                        <i class="fa fa-envelope" aria-hidden="true"></i>
                        <asp:TextBox ID="tbEmailRegister" value="email" type="text" name="email" runat="server" placeholder="Email" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <i class="fa fa-lock" aria-hidden="true"></i>
                        <asp:TextBox ID="tbPassRegister" value="password" type="password" name="password" runat="server" placeholder="Password" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" value="Submit" runat="server" Text="Register" OnClick="Button2_Click" />
                    <br/><asp:Label ID="Label1" runat="server"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</div>
</asp:Content>
