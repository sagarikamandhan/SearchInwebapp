<%@ Page Title="" Language="C#" MasterPageFile="~/nav.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="banner">
		<ul class="slider">
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
        </ul>
		<div class="v-center form-inline">
			<h1>Your Health, Our Responsibility</h1>
			<div class="input-group">
            <span class="input-group-addon">
                    <i class="fa fa-map-marker fa-1x"></i>
                </span>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
			</div>
            <div class="input-group">
            <span class="input-group-addon">
                    <i class="fa fa-map-marker fa-1x"></i>
                </span>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
			</div>
            <div class="input-group">
             <span class="input-group-addon">
                    <i class="fa fa-search fa-1x"></i>
                </span>
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>  
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="select category" ForeColor="Red" InitialValue="0" SetFocusOnError="true" CssClass="required" Display="Dynamic" ControlToValidate="DropDownList3"></asp:RequiredFieldValidator>  
            <div class="input-group"><asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="Button1_Click" /></div>
		</div>
	</section>
</asp:Content>

