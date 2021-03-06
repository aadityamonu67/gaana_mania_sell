﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmsgs.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="admin_frmsgs" %>
<!DOCTYPE HTML>
<!--
	Projection by TEMPLATED
	templated.co @templatedco
	Released for free under the Creative Commons Attribution 3.0 license (templated.co/license)
-->
<html>
	<head>
		<title>Gaana Mania</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="stylesheet" href="../assets/css/main.css" />
	</head>
	<body>
        <form runat="server">
		<!-- Header -->
			<header id="header">
				<div class="inner">
					<a href="frmadmidx.aspx" class="logo"><strong>GAANA </strong> Mania</a>
					<nav id="nav">
						<a href="frmadmidx.aspx">Home</a>
						<a href="frmctg.aspx">Category</a>
						<a href="frmsgs.aspx">Songs</a>
                        <a href="frmsrch.aspx">Search</a>
                        <a href="frmlogout.aspx">Logout</a>
					</nav>
					<a href="#navPanel" class="navPanelToggle"><span class="fa fa-bars"></span></a>
				</div>
			</header>

		<!-- Banner -->	<section id="banner">
				<div class="inner">
					<header>
						<h1>SONGS</h1>
					</header>

					<div class="flex ">

						<div>
							<span class="icon fa-car"></span>
							<h3>Vocals</h3>
							<p>We Provide Best vocal support</p>
						</div>

						<div>
							<span class="icon fa-camera"></span>
							<h3>Mixing</h3>
							<p>We have also good feature of good mixing</p>
						</div>

						<div>
							<span class="icon fa-bug"></span>
							<h3>Mastering</h3>
							<p>We provide best music mastering</p>
						</div>

					</div>	<footer>
						<a href="#" class="button">||||</a>
					</footer>
				</div>
			</section>


		<!-- Three -->
		<%--	<section id="three" class="wrapper align-center">
				<div class="inner">
					<div class="flex flex-2">
						<article>
							<div class="image round">
								<img src="images/pic01.jpg" alt="Pic 01" />
							</div>
							<header>
								<h3>Lorem ipsum<br /> dolor amet nullam</h3>
							</header>
							<p>Morbi in sem quis dui placerat ornare. Pellentesquenisi<br />euismod in, pharetra a, ultricies in diam sed arcu. Cras<br />consequat  egestas augue vulputate.</p>
							<footer>
								<a href="#" class="button">Learn More</a>
							</footer>
						</article>
						<article>
							<div class="image round">
								<img src="images/pic02.jpg" alt="Pic 02" />
							</div>
							<header>
								<h3>Sed feugiat<br /> tempus adipicsing</h3>
							</header>
							<p>Pellentesque fermentum dolor. Aliquam quam lectus<br />facilisis auctor, ultrices ut, elementum vulputate, nunc<br /> blandit ellenste egestagus commodo.</p>
							<footer>
								<a href="#" class="button">Learn More</a>
							</footer>
						</article>
					</div>
				</div>
			</section>--%>

		<!-- Footer -->
			<footer id="footer">
				<div class="inner">

					<h3>Add your Song</h3>

					

						<div class="field half first">
                            <asp:TextBox ID="txttitle" placeholder="Title" runat="server"></asp:TextBox>
                           
						</div>
                    <div class="field half first">
                            <asp:TextBox ID="txtast" placeholder="Artist" runat="server"></asp:TextBox>
                           
						</div>
                    	<div class="field half first">
                            <asp:TextBox ID="txtlk" placeholder="URL of song" runat="server"></asp:TextBox>
                           
						</div>
                    <div class="field half first">
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="sgsctgnm" DataValueField="sgsctgid"></asp:DropDownList>
                           
						<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsgaanamania.clstbsgsctg"></asp:ObjectDataSource>
                           
						</div>
						
						<div class="field">
							
						 <asp:TextBox ID="txtdesc" placeholder="Description" TextMode="MultiLine" runat="server"></asp:TextBox>
                           
						</div>
						<ul class="actions">

							<li>
                                <asp:Button ID="btn_saverec" runat="server" CssClass="button alt" Text="Add" OnClick="btn_saverec_Click" /> <asp:Button ID="btncnl" CssClass="button alt" runat="server" Text="cancel" OnClick="btncnl_Click" /></li>
						</ul>
                    <div class="field">
							
                        <asp:GridView ID="GridView1" DataKeyNames="sgsid" datakeyfield="sgsid" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                            <Columns>
                                <asp:BoundField DataField="sgstitle" HeaderText="Title" SortExpression="sgstitle" />
                                <asp:BoundField DataField="sgsdesc" HeaderText="Description" SortExpression="sgsdesc" />
                                <asp:BoundField DataField="sgslk" HeaderText="URL" SortExpression="sgslk" />
                                <asp:TemplateField HeaderText="Action">
                                     <ItemTemplate>                   
                           <asp:LinkButton runat="server" id="lkedit" CssClass="button alt"  CommandName="edit"  Text="edit" /> <asp:LinkButton runat="server" CssClass="button alt" id="lkdelete" CommandName="delete" Text="delete" />
                                </ItemTemplate>
                             <EditItemTemplate>
                               <asp:linkbutton ID="btnupd" runat="server" CommandName="update" CssClass="button alt" Text="Update" />  <asp:linkbutton ID="Button1" CssClass="button alt" runat="server" CommandName="cancel" Text="Cancel" />
                            </EditItemTemplate>

                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="disp_rec" TypeName="nsgaanamania.clstbsgsdata"></asp:ObjectDataSource>
                           
						</div>
					

				
				</div>
			</footer>

		<!-- Scripts -->
			<script src="../assets/js/jquery.min.js"></script>
			<script src="../assets/js/skel.min.js"></script>
			<script src="../assets/js/util.js"></script>
			<script src="../assets/js/main.js"></script>
            </form>
	</body>
</html>
