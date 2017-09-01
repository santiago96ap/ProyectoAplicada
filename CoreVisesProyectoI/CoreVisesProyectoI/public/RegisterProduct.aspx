<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterProduct.aspx.cs" Inherits="CoreVisesProyectoI.RegisterProduct" %>
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
                        <asp:TextBox ID="tbNameRegisterProduct" type="text" value="name" name="name" runat="server" placeholder="Name" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbCategoryRegisterProduct" value="category" type="text" name="category" runat="server" placeholder="Category" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbPriceRegisterProduct" value="price" type="text" name="price" runat="server" placeholder="Price" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbQuantityRegisterProduct" value="quantity" type="text" name="quantity" runat="server" placeholder="Quantity" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <div class="key">
                        <asp:TextBox ID="tbStateRegisterProduct" type="text" value="state" name="state" runat="server" placeholder="State" required=""></asp:TextBox>
                        <div class="clearfix"></div>
                    </div>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" value="Submit" runat="server" Text="Register" OnClick="Button2_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br/><asp:Label ID="Label1" runat="server"></asp:Label>
                </form>
            </div>
        </div>
    </div>
</div>
</asp:Content>
