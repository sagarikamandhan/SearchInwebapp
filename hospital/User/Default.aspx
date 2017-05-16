<%@ Page Title="" Language="C#" MasterPageFile="~/User/user.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="marginupper">
    
        <div id="page-content-wrapper">
            <div class="container">
                <div class="col-sm-offset-2 col-sm-11">
                    <div class="well">
                        <div class="row">
                            <h1><center>Welcome, <asp:Label ID="Label2" runat="server" CssClass="control-label"></asp:Label></center></h1>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <strong><cite>
                            <asp:Label ID="Label3" runat="server" CssClass="control-label"></asp:Label></cite>
                        </strong>
                            </div>
                        </div>
                        <div class="row">
                             <div class="col-sm-12">
                                <div class="col-sm-6">
                                    <asp:Label ID="Label4" runat="server" Text="State :-  " CssClass="control-label"></asp:Label><asp:Label ID="Label5" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:Label ID="Label6" runat="server" Text="City :-  " CssClass="control-label"></asp:Label><asp:Label ID="Label7" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class=" col-sm-12">
                                <div class="col-sm-6">
                                    <asp:Label ID="Label8" runat="server" Text="Contact No :-  " CssClass="control-label"></asp:Label><asp:Label ID="Label9" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                                <div class="col-sm-6">
                                    <asp:Label ID="Label10" runat="server" Text="E-mail :-  " CssClass="control-label"></asp:Label><asp:Label ID="Label11" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:Label ID="Label12" runat="server" Text="Address :-  " CssClass="control-label"></asp:Label><asp:Label ID="Label13" runat="server" CssClass="control-label"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="col-sm-11 col-sm-offset-2">
                    <div class="col-sm-6">
                        <div class="well">                    
                       <div class="row">
                           <center><h2>Add Article</h2></center>
                       <h3>
                         <asp:Label ID="Label14" runat="server" Text="Heading : " CssClass="control-label"></asp:Label>
                       </h3>
                         <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                       </div>
                         
                        <div class="row">
                            <h3>
                         <asp:Label ID="Label15" runat="server" Text="Content : " CssClass="control-label"></asp:Label>
                       </h3>
                         <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Columns="30" Rows="10" CssClass="form-control"></asp:TextBox>
                        </div>
                            <asp:Label ID="Label1" runat="server" Text="Upload Photo :- " CssClass="control-label"></asp:Label><asp:FileUpload ID="FileUpload2" runat="server" />
                        <center><asp:Button ID="Button1" runat="server" Text="Post" CssClass="btn btn-success" OnClick="Button1_Click" /></center>
                    </div>
                        </div>
                    <div class="col-sm-6">
                        <div class="well">
                            <div class="row">
                                <center><h2>Add Photos</h2>
                                <asp:FileUpload ID="FileUpload1" runat="server" />&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Upload" CssClass="btn btn-success" OnClick="Button2_Click" />
                                <h2>Your Location</h2>
                                <asp:Image ID="Image1" runat="server" CssClass="img-thumbnail" Width="400" Height="300" /></center>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
 
 </div>

</asp:Content>

