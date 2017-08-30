<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CoreVisesProyectoI.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <div class="login">
        <div class="main-agileits">
            <div class="form-w3agile form1">
                <h3>Register</h3>
                <form action="?controlador=Default&accion=registerClient" method="post">
                    <div class="key">
                        <i class="fa fa-user" aria-hidden="true"></i>
                        <input  type="text" value="name" name="name" onfocus="this.value = '';" onblur="if (this.value == '') {
                                    this.value = 'Name';
                                }" required="">
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <i class="fa fa-lock" aria-hidden="true"></i>
                        <input  type="text" value="cardNumber" name="cardNumber" onfocus="this.value = '';" onblur="if (this.value == '') {
                                    this.value = 'CardNumber';
                                }" required="">
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <i class="fa fa-envelope" aria-hidden="true"></i>
                        <input  type="text" value="email" name="email" onfocus="this.value = '';" onblur="if (this.value == '') {
                                    this.value = 'Email';
                                }" required="">
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <i class="fa fa-lock" aria-hidden="true"></i>
                        <input  type="password" value="password" name="password" onfocus="this.value = '';" onblur="if (this.value == '') {
                                    this.value = 'Password';
                                }" required="">
                        <div class="clearfix"></div>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <input type="submit" value="Submit">
                </form>
            </div>
        </div>
    </div>
</div>
</asp:Content>
