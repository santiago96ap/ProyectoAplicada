<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateDeleteProducts.aspx.cs" Inherits="CoreVisesProyectoI.UpdateDeleteProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <div class="login">
        <div class="main-agileits">
            <div class="form-w3agile form1">
                <h3>Register Products</h3>
                <form id="form1" runat="server">
                    <div class="key">
                        <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" required="" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbCategoryUpdateDeleteProduct" value="category" type="text" name="category" runat="server" placeholder="Category" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbPriceUpdateDeleteProduct" value="price" type="text" name="price" runat="server" placeholder="Price" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbQuantityUpdateDeleteProduct" value="quantity" type="text" name="quantity" runat="server" placeholder="Quantity" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbStateUpdateDeleteProduct" type="text" value="state" name="state" runat="server" placeholder="State" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" value="Submit" runat="server" Text="Update" OnClick="Button2_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" value="Submit" runat="server" Text="Delete" OnClick="Button1_Click"  />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br/><asp:Label ID="Label1" runat="server"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</div>
</asp:Content>
