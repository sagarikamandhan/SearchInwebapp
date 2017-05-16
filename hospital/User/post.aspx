<%@ Page Title="" Language="C#" MasterPageFile="~/User/user.master" AutoEventWireup="true" CodeFile="post.aspx.cs" Inherits="User_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="marginupper">
        <div id="page-content-wrapper">
            <div class="container">
                <div class="col-sm-offset-2">
                    <div class="well">
                <asp:DataList ID="DataList1" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal" RepeatColumns="3" CssClass="hidebr">
                    <HeaderTemplate><center><h1>Entire List</h1></center></HeaderTemplate>
                    <ItemTemplate>
                        <div class="col-sm-4">
                            <div class="card-container">
                                <div class="cards">
                                    <div class="front">       
                                        <div class="content">
                                            <div class="main">
                                                <h3 class="name">
                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("heading") %>' CssClass="control-label"></asp:Label>
                                                </h3>
                                                <p>
                                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("content") %>' CssClass="control-label"></asp:Label>
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
        </div>
    </div>
</asp:Content>

