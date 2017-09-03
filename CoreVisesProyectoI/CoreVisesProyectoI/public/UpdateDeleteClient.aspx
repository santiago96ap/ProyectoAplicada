<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateDeleteClient.aspx.cs" Inherits="CoreVisesProyectoI.UpdateDeleteClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <div class="login">
        <div class="main-agileits">
            <div class="form-w3agile form1">
                <h3>Delete/Update Clients</h3>
                <form id="form1" runat="server">
                    <div class="key">
                        <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" required="" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbNameUpdateDeleteClient" value="name" type="text" name="name" runat="server" placeholder="Name" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbPassUpdateDeleteClient" value="password" type="text" name="password" runat="server" placeholder="Password" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbCardUpdateDeleteClient" type="text" value="card" name="card" runat="server" placeholder="Card" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" value="Submit" runat="server" Text="Update" OnClick="Button2_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" value="Submit" runat="server" Text="Delete" OnClick="Button1_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br/><asp:Label ID="Label1" runat="server"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</div>
</asp:Content>
