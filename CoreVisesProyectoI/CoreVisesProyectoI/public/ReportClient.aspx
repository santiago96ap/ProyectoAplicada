<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ReportClient.aspx.cs" Inherits="CoreVisesProyectoI.ReportClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
				<div class="typo-w3">
					<div class="container">
						<p>Report Client</p>
						<div class="bs-docs-example">
							<table class="table table-bordered">
								<thead>
									<tr>
										<th>#</th>
										<th>Client</th>
										<th>Product</th>
										<th>Quantity</th>
                                        <th>Total</th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td rowspan="2">1</td>
										<td>mcalvo96@gmail.com</td>
										<td>Camisa</td>
										<td>1</td>
                                        <td>1500</td>
									</tr>
									<tr>
									</tr>
									<tr>
                                        <td>2</td>
										<td>franmarcr22@gmail.com</td>
										<td>Sueta</td>
										<td>3</td>
                                        <td>9000</td>
									</tr>
									<tr>
										<td>3</td>
										<td>ajohan16@gmail.com</td>
										<td>Camiseta</td>
										<td>2</td>
                                        <td>4000</td>
									</tr>
                                    <tr>
										<td>4</td>
										<td>kevinvarp18@gmail.com</td>
										<td>Vestimenta</td>
										<td>1</td>
                                        <td>3000</td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>
			</div>
		</div>
</asp:Content>
