﻿<%@ Page Title="" Language="C#" MasterPageFile="~/nav.master" AutoEventWireup="true" CodeFile="searched.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="margindown">
        <div class="container">
            <div class="row">
                <div class="well">
                    <center><div class="form-group form-inline form-group-lg">
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn btn-primary btn-lg" />
                             </div>
                    </center>
                 </div>
            </div>
        </div>
        <div class="container-fluid">
            <div class="well">
                <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal" RepeatColumns="3" CssClass="hidebr">
                    <HeaderTemplate><center><h1>Entire List</h1></center></HeaderTemplate>
                    <ItemTemplate>
                        <div class="col-sm-4">
                            <div class="card-container">
                                <div class="cards">
                                    <div class="front">
                                        <div class="cover">
                                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("udp") %>' Height="150"/>
                                        </div>
                                        <div class="content">
                                            <div class="main">
                                                <h3 class="name">
                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("uname") %>' CssClass="control-label"></asp:Label>
                                                </h3>
                                                <p>
                                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("uno") %>' CssClass="control-label"></asp:Label>
                                                </p>
                                                <p>
                                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("address") %>'  CssClass="control-label"></asp:Label>
                                                </p>
                                                <p>
                                                    <asp:Button ID="Button2" runat="server" Text="View Details" CssClass="btn btn-success btn-sm" />
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </div>
    
</asp:Content>

