    <%@ Page Title="" Language="C#" MasterPageFile="~/Revenue1.Master" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="NRB_Revenue.settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
          <h4 class=""><strong>SETTINGS:</strong></h4>
           <div class="col mt-2">
               <div class="row">
                   <div class="col-8"><asp:TextBox ID="searchtxtbox" runat="server" CssClass="form-control fs-4" Font-Size="X-Large" Placeholder="Search by Username" ></asp:TextBox></div>
                    <div class="col-4"><asp:Button ID="btnsearch" runat="server" CssClass="btn btn-primary fs-4 col-8" Text="Search"  OnClick="btnsearch_Click"/></div>
               </div>
               <div class="mt-3">
                   <asp:Button ID="allSystemUser" runat="server" CssClass="btn btn-info fs-5 col-3" Text="All Users" OnClick="allSystemUser_Click"/>
               </div> 
           </div>
        <div class="col row mt-2">
             <%--add user section--%>
            <div class="col">
                <div class="row">                    
                    <div class="col"><asp:TextBox ID="txtfirstname" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Firstname"></asp:TextBox></div>
                    <div class="col"><asp:TextBox ID="txtsurname" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Surname"></asp:TextBox></div>
                </div>
                <div class="row mt-2">
                    <div class="col"><asp:DropDownList ID="dropUsertype" runat="server" CssClass="form-control" Font-Size="X-Large">                                       
                                        <asp:ListItem>Accounts</asp:ListItem>
                                        <asp:ListItem>Administrator</asp:ListItem>
                                     </asp:DropDownList>
                    </div>
                    <div class="col"><asp:TextBox ID="txtposition" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Position"></asp:TextBox></div>
                </div>
                <div class="col mt-2">
                        <asp:DropDownList ID="dropInstitution" runat="server" CssClass="form-control" Font-Size="X-Large">
                            <asp:ListItem>National Registration Bureau</asp:ListItem>
                            <asp:ListItem>Accountant General</asp:ListItem>
                        </asp:DropDownList>              
                </div>
                <div class="row mt-2">
                    <div class="col">
                         <div class="col"><asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Password" Type="Password"></asp:TextBox></div>                        
                    </div>
                    <div class="col"><asp:TextBox ID="txtusername" runat="server" CssClass="form-control" Font-Size="X-Large" placeholder="Username"></asp:TextBox></div>                    
                </div>
                
                <div class="row mt-2">
                    <div class="col"></div>
                    <div class="col text-center">                        
                        <asp:Button ID="btnUpdate" runat="server" CssClass="btn btn-info fs-3 col-4" Text="Update" OnClick="btnUpdate_Click" /> 
                        <asp:Button ID="btnsubimt" runat="server" CssClass="btn btn-success fs-3 col-4" Text="Save" OnClick="btnsubimt_Click"/>
                    </div>
                </div>
            </div>
        </div>
          
        </div>

        <div class="mt-4 row">
            <%--GridView section--%>
            <div class="col card">
                <asp:GridView ID="RevuserGridView" OnSelectedIndexChanged="RevuserGridView_SelectedIndexChanged" CssClass="col-12 fs-4" runat="server" AutoGenerateColumns="false" BorderStyle="None">
                    <Columns>
                        <asp:BoundField DataField="UserID" HeaderText="User ID" />
                        <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                        <asp:BoundField DataField="Surname" HeaderText="Surname" />
                        <asp:BoundField DataField="Position" HeaderText="Position" />
                        <asp:BoundField DataField="usertype" HeaderText="User Type" />
                        <asp:BoundField DataField="Institution" HeaderText="Institution" />
                        <asp:BoundField DataField="Username" HeaderText="Username" />
                        <%--<asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="revEdituserbtn" runat="server" CssClass="btn btn-info" Text="Edit User" CommandArgument='<%# Eval("UserID") %>' OnClick="revEdituserbtn_Click"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>  --%>    
                        
                <asp:CommandField ShowSelectButton="true"  ControlStyle-CssClass="btn btn-info" />
                        <asp:CommandField ShowSelectButton="true"  ControlStyle-CssClass="btn btn-info" />
                    </Columns>
                </asp:GridView>
            </div>
    </div>
</asp:Content>
