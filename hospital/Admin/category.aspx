<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="category.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="margin">
            <div class="container">
                <div class="jumbotron">
                    <center><h2> Add Categories</h2><br />
                        <div class="form-group form-group-sm form-inline">
                            <asp:Label ID="Label1" runat="server" Text="Add Registration for : " CssClass="control-label"></asp:Label><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="submit" OnClick="Button1_Click"></asp:Button>
                    </center>
                </div>
                    <div class="table table-responsive well">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                                <Columns>
                                    <asp:TemplateField HeaderText="S.No.">
                                        <ItemTemplate>
                                            <%#Eval("catid") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                   <asp:TemplateField HeaderText=" Category Name">
                                        <ItemTemplate>
                                            <%#Eval("catname") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="edit" CommandArgument='<%#Eval("catid") %>'>Edit</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="delete" CommandArgument='<%#Eval("catid") %>'>Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div><!--end row-->
                    
                </div>
            </div>
</asp:Content>

