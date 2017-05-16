<%@ Page Title="" Language="C#" MasterPageFile="~/User/user.master" AutoEventWireup="true" CodeFile="password.aspx.cs" Inherits="User_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  class="marginupper">
        <div id="page-content-wrapper">
            <div class="container">
                <div class="col-sm-offset-2">
                    <div class="row">
                        <div class="jumbotron">
                            <p class="col-sm-6">
                                <center><h2>Reset Your Password</h2>
                                <p class="col-sm-6"><asp:Label ID="Label1" runat="server" Text="Old Password :-" CssClass="control-label"></asp:Label><asp:TextBox ID="TextBox1" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox></p>
                                <p class="col-sm-6"><asp:Label ID="Label2" runat="server" Text="New Password :-" CssClass="control-label"></asp:Label><asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox></p>
                                <p><asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="Button1_Click"></asp:Button></p>
                                    <span><asp:Label ID="Label3" runat="server" CssClass="control-label" ForeColor="Red"></asp:Label></span>
                            </center>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

