<%@ Page Title="" Language="C#" MasterPageFile="~/Revenue1.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="NRB_Revenue.report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col">
        <h4 class=""><strong>REPORTS:</strong></h4>
        <div class="container-sm">
             <div class="row">
                <div class="col-2 text-center mt-2"><asp:RadioButton ID="reportRadioButton1" runat="server" CssClass="form-check-input alert-secondary" GroupName="report" OnCheckedChanged="reportRadioButton1_CheckedChanged" AutoPostBack="true" /></div>
                <div class="col-10">
                        <asp:DropDownList ID="allreports" runat="server" CssClass="form-control fs-5">
                            <asp:ListItem>Weekly Report</asp:ListItem>
                            <asp:ListItem>Monthly Report</asp:ListItem>
                            <asp:ListItem>Annualy Report</asp:ListItem>
                            <asp:ListItem>Quarterly Report</asp:ListItem>
                        </asp:DropDownList>
                </div>
            </div>
            
            <div class="row mt-2">
                <div class="col-2 text-center mt-2"><asp:RadioButton ID="reportRadioButton2" runat="server" CssClass="form-check-input alert-secondary" GroupName="report" OnCheckedChanged="reportRadioButton2_CheckedChanged" AutoPostBack="true" /></div>
                <div class="row col-10">
                    <div class="col"><asp:TextBox ID="txtreportdatestart" runat="server" CssClass="form-control fs-5" Type="date" Font-size="Larger"></asp:TextBox></div>
                    <div class="col"><asp:TextBox ID="txtreportdateend" runat="server" CssClass="form-control fs-5" Type="date" Font-Size="Larger"></asp:TextBox></div>
                </div>
            </div>

            <div class="mt-2 row">
                <div class="col-10"></div>
                <div class="col-2">
                    <asp:Button ID="btnreportsearch" runat="server" CssClass="btn btn-primary fs-3 col-8" Text="Seach" OnClick="btnreportsearch_Click"/>  
                </div>
            </div>
        </div>
           
    </div>
    
    <%--GridView for reports results--%>
    <div class="mt-3 alert-info card">

    </div>
</asp:Content>
