﻿<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CoreVisesProyectoI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <div class="login">
        <div class="main-agileits">
            <div class="form-w3agile">
                <h3>Login To Gremlin Shop</h3>
                <form id="form1" runat="server">
                    <div class="key">
                        <i class="fa fa-envelope" aria-hidden="true"></i>
                        <asp:TextBox ID="tbEmailLogin" value="email" type="text" name="Email" runat="server" placeholder="Mail" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <i class="fa fa-lock" aria-hidden="true"></i>
                        <asp:TextBox ID="tbPasswordLogin" value="password" type="password" name="Name" runat="server" placeholder="Contraseña" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Buttonlogin_Click"/>
                    <br/><asp:Label ID="Label1" runat="server"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</div>
</asp:Content>
