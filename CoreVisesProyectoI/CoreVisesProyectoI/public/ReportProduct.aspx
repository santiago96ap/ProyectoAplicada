<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ReportProduct.aspx.cs" Inherits="CoreVisesProyectoI.ReportProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
				<div class="typo-w3">
					<div class="container">
						<p>Report Product</p>
						<div class="bs-docs-example">
							<table class="table table-bordered">
								<thead>
									<tr>
										<th>#</th>
										<th>Total revenues</th>
										<th>Total expenditures</th>
										<th>Start date</th>
                                        <th>Ending date</th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td rowspan="2">1</td>
										<td>15000</td>
										<td>2000</td>
										<td>02-08-2017</td>
                                        <td>02-09-2017</td>
									</tr>
									<tr>
									</tr>
									<tr>
                                        <td>2</td>
										<td>20000</td>
										<td>10000</td>
										<td>02-07-2017</td>
                                        <td>02-08-2017</td>
									</tr>
									<tr>
										<td>3</td>
										<td>5000</td>
										<td>3000</td>
										<td>02-06-2017</td>
                                        <td>02-07-2017</td>
									</tr>
                                    <tr>
										<td>4</td>
										<td>9000</td>
										<td>2000</td>
										<td>02-05-2017</td>
                                        <td>02-06-2017</td>
									</tr>
                                    <tr>
										<td>5</td>
										<td>1000</td>
										<td>0</td>
										<td>02-04-2017</td>
                                        <td>02-05-2017</td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>
			</div>
		</div>
</asp:Content>
