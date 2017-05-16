<%@ Page Title="" Language="C#" MasterPageFile="~/nav.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        $(document).ready(function () {
            $("#submit").click(function (event) {
                $('#signup').modal('show');
            })
        });
    </script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container loginimg">
        <div class="row">
            <div class="col-sm-8 col-sm-offset-2">
                <div class="wizard-container">
                    <div class="card">
                        <center>
                            <h3><b style="color : #18bc9c;">BUILD YOUR PROFILE </b><br/>
                            <small>This information will let us know more about you.</small></h3>
                        </center>   
                        <div class="col-sm-11 col-sm-offset-1">
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label1" runat="server" Text="Register for :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"  AutoPostBack="true"></asp:DropDownList>
                            </div>
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label2" runat="server" Text="Specialist :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>  
                        <div class="col-sm-11 col-sm-offset-1">
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label3" runat="server" Text="Name :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Name" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label4" runat="server" Text="Contact no :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Contact no." Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-sm-11 col-sm-offset-1">
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label5" runat="server" Text="Email :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label6" runat="server" Text="Username :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Username" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-sm-11 col-sm-offset-1">
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label7" runat="server" Text="Password :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>

                                <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter Password" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label8" runat="server" Text="Confirm Password :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:TextBox ID="TextBox6" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Re-enter password" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ErrorMessage="Password doesn't match" Font-Italic="True" ForeColor="#FF5050"></asp:CompareValidator>
                            </div>
                        </div>
                        <div class="col-sm-11 col-sm-offset-1">
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label9" runat="server" Text="state :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList3" CssClass="required" Display="Dynamic" ErrorMessage="Select State" Font-Italic="True" ForeColor="#FF5050" InitialValue="0"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label10" runat="server" Text="City :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList4" CssClass="required" Display="Dynamic" ErrorMessage="Select City" Font-Italic="True" ForeColor="#FF5050" InitialValue="0"></asp:RequiredFieldValidator>
                            </div>
                        </div> 
                        <div class ="col-sm-9 col-sm-offset-1">
                            <asp:Label ID="Label11" runat="server" Text="Address :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                            <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox7" CssClass="active" ErrorMessage="Enter address" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                        </div><br /><br />
                        <div class="col-sm-11 col-sm-offset-1">
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label12" runat="server" Text="Display Picture :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Upload Display Picture" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                                <br />
                            </div>
                            <div class="form-group form-group-sm col-sm-5">
                                <asp:Label ID="Label13" runat="server" Text="Map Picture :-" CssClass="control-label" ForeColor="#FFFFCC"></asp:Label>
                                <asp:FileUpload ID="FileUpload2" runat="server" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="FileUpload2" ErrorMessage="Enter Map Location" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                            </div>
                        </div> <br /><br /><br />
                        <center>
                            <div class="col-sm-5 col-sm-offset-3">
                                <asp:Button ID="submit" runat="server" Text="  Submit  " CssClass=" btn btn-success " OnClick="Button1_Click"></asp:Button>
                            </div>
                        </center>
                    </div>
                </div>
            </div>
        </div>
      </div>
    <div class="modal fade" id="signup" tabindex="-1" role="dialog" aria-labelledby="signup-label">
        <div class="modal-dialog" role="document">
            <div class="modal-content">      
                <div class="modal-body">
                    <p>
                        <asp:Label ID="Label14" runat="server" CssClass="control-label"></asp:Label></p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>

