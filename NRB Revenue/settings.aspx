    <%@ Page Title="" Language="C#" MasterPageFile="~/Revenue1.Master" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="NRB_Revenue.settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="">
          <h4 class=""><strong>SETTINGS:</strong></h4>
        <div class="col row">
            <div class="col"></div>
            <div class="col row">
                <div class="col-8"><asp:TextBox ID="searchtxtbox" runat="server" CssClass="form-control fs-4" Font-Size="X-Large" Placeholder="Search by Username" ></asp:TextBox></div>
                <div class="col-4"><asp:Button ID="btnsearch" runat="server" CssClass="btn btn-primary fs-4 col-8" Text="Search"  OnClick="btnsearch_Click"/></div> 
            </div>
        </div>

        <div class="mt-4 row">
            <%--GridView section--%>
            <div class="col card">

            </div>

            <%--add user section--%>
            <div class="col">
                <div class="row">                    
                    <div class="col"><asp:TextBox ID="txtfirstname" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Firstname"></asp:TextBox></div>
                    <div class="col"><asp:TextBox ID="txtsurname" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Surname"></asp:TextBox></div>
                </div>
                <div class="row mt-2">
                    <div class="col"><asp:DropDownList ID="dropUsertype" runat="server" CssClass="form-control" Font-Size="X-Large">
                                        <asp:ListItem>Any User</asp:ListItem>
                                        <asp:ListItem>Accounts</asp:ListItem>
                                        <asp:ListItem>Acountant General</asp:ListItem>
                                        <asp:ListItem>Administrator</asp:ListItem>
                                     </asp:DropDownList>
                    </div>
                    <div class="col"><asp:TextBox ID="txtposition" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Position"></asp:TextBox></div>
                </div>
                <div class="col mt-2">
                        <asp:DropDownList ID="dropInstution" runat="server" CssClass="form-control" Font-Size="X-Large">
                            <asp:ListItem>National Registration Bureau</asp:ListItem>
                            <asp:ListItem>Accountant General</asp:ListItem>
                            <asp:ListItem>Ministry of Finance</asp:ListItem>
                        </asp:DropDownList>              
                </div>
                <div class="row mt-2">
                    <div class="col">
                         <div class="col"><asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Password" Type="Password"></asp:TextBox></div>                        
                    </div>
                    <div class="col"><asp:TextBox ID="txtinstution" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Username"></asp:TextBox></div>                    
                </div>
                
                <div class="row mt-2">
                    <div class="col"></div>
                    <div class="col text-center">                        
                        <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-info fs-3 col-4 mr-2" Text="Update" OnClick="btnUpdate_Click" /> 
                        <asp:Button ID="btnsubimt" runat="server" CssClass="btn btn-success fs-3 col-4" Text="Save" OnClick="btnsubimt_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
