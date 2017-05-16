<%@ Page Title="" Language="C#" MasterPageFile="~/User/user.master" AutoEventWireup="true" CodeFile="Gallery.aspx.cs" Inherits="User_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="marginupper">
        <div id="page-content-wrapper">
            <div class="container">
                <div class="col-sm-offset-2">
                    <div class="well">
                        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="hidebr">
                            <HeaderTemplate><center><h1>Gallery</h1></center></HeaderTemplate>
                            <ItemTemplate>
                                <div class="col-sm-4">
                                    <div class="cards-container">
                                        <div class="cardds">
                                            <div class="fronts">
                                                <div class="content">
                                                    <div class=" main">
                                                        <asp:Image ID="Image1" runat="server" CssClass="img-thumbnail" ImageUrl='<%#Eval("photo") %>' />
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

