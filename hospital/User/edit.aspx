<%@ Page Title="" Language="C#" MasterPageFile="~/User/user.master" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="User_Default2" %>

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
                            <div class="col-sm-6">                     
                                 <asp:Label ID="Label1" runat="server" Text="Specialist :-  " CssClass="control-label"></asp:Label><asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                             <div class="col-sm-12">
                                <div class="col-sm-6">
                                    <asp:Label ID="Label4" runat="server" Text="State :-  " CssClass="control-label"></asp:Label><asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="col-sm-6">
                                    <asp:Label ID="Label6" runat="server" Text="City :-  " CssClass="control-label"></asp:Label><asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class=" col-sm-12">
                                <div class="col-sm-6">
                                    <asp:Label ID="Label8" runat="server" Text="Contact No :-  " CssClass="control-label"></asp:Label><asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-sm-6">
                                    <asp:Label ID="Label10" runat="server" Text="E-mail :-  " CssClass="control-label"></asp:Label><asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:Label ID="Label12" runat="server" Text="Address :-  " CssClass="control-label"></asp:Label><asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
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
                                <center><h2>Update Display Photo</h2>
                                <asp:FileUpload ID="FileUpload2" runat="server" />&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Upload" CssClass="btn btn-success" OnClick="Button1_Click" />
                                <h2>Your Photo</h2>
                                <asp:Image ID="Image2" runat="server" CssClass="img-thumbnail" Width="400" Height="300" /></center>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="well">
                            <div class="row">
                                <center><h2>Update Location photo</h2>
                                <asp:FileUpload ID="FileUpload1" runat="server" />&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Upload" CssClass="btn btn-success" OnClick="Button2_Click" />
                                <h2>Your Location</h2>
                                <asp:Image ID="Image1" runat="server" CssClass="img-thumbnail" Width="400" Height="300" /></center>
                            </div>
                        </div>
                    </div>
                    <center><asp:Button ID="Button3" runat="server" Text="Submit" CssClass="btn btn-info" OnClick="Button3_Click" /></center>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

