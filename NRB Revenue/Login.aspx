<%@ Page Title="" Language="C#" MasterPageFile="~/Revenue.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NRB_Revenue.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-12 row">
        <div class="col-4"></div>
        <div class="col-4">
            <div class="col-12">
                <img src="govt.png" alt="Govt Logo" class="col-12" />
            </div>
            <div class="col-12 form-group">
                <asp:TextBox ID="LoginUsername" runat="server" CssClass="col-12 form-control fs-4 mt-2" Placeholder="USERNAME" Font-Size="X-Large"></asp:TextBox>
                <asp:TextBox ID="LoginPassword" runat="server" CssClass="col-12 form-control fs-4 mt-2" Placeholder="PASSWORD" Type="Password" Font-Size="X-Large"></asp:TextBox>
                <asp:Button ID="Loginbtn" runat="server" CssClass="btn btn-md btn-info mt-2 fs-3 col-12" Text="LOG IN" Font-Size="X-Large" OnClick="Loginbtn_Click" />
            </div>
        </div>
        <div class="col-4"></div>
    </div>

</asp:Content>
