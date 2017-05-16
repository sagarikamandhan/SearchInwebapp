<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="specialist.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="margin">
            <div class="container">
                <div class="jumbotron">
                    <center><h2> Add Categories</h2><br />
                        <div class="form-group form-group-sm form-inline">
                            <asp:Label ID="Label1" runat="server" Text="Category : " CssClass="control-label"></asp:Label>&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" CssClass="control-label"></asp:Label>
                        </div>
                        <div class="form-group form-group-sm form-inline">
                            <asp:Label ID="Label3" runat="server" Text="Add Speciality : " CssClass="control-label "></asp:Label><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="submit" OnClick="Button1_Click"></asp:Button>
                    </center>
                </div>
                    <div class="table table-responsive well">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered" OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting">
                                <Columns>
                                    <asp:TemplateField HeaderText="S.No.">
                                        <ItemTemplate>
                                            <%#Eval("spid") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                   <asp:TemplateField HeaderText="Specialist Name">
                                        <ItemTemplate>
                                            <%#Eval("spname") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="edit" CommandArgument='<%#Eval("spid") %>'>Edit</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="delete" CommandArgument='<%#Eval("spid") %>'>Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div><!--end row-->
                    
                </div>
            </div>
</asp:Content>

