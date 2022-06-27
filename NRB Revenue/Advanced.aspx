<%@ Page Title="" Language="C#" MasterPageFile="~/Revenue1.Master" AutoEventWireup="true" CodeBehind="Advanced.aspx.cs" Inherits="NRB_Revenue.Advanced" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col">
        <h4 class=""><strong>ADVANCED:</strong></h4>
        <div class="container-sm">
             <div class="row">
                <div class="col-2 text-center mt-2"><asp:RadioButton ID="reportRadioButton1" runat="server" CssClass="form-check-input alert-secondary" GroupName="report" AutoPostBack="true" /></div>
                <div class="col-10 row">
                    <div class="col">
                        <asp:DropDownList ID="allreports" runat="server" CssClass="form-control fs-5">
                            <asp:ListItem>Monthly Report</asp:ListItem>
                            <asp:ListItem>Annualy Report</asp:ListItem>
                            <asp:ListItem Value="April and June">First Quarter</asp:ListItem>
                            <asp:ListItem Value="July and September">Second Quarter</asp:ListItem>
                            <asp:ListItem Value="October and December">Third Quarter</asp:ListItem>
                            <asp:ListItem Value="January and March">Fourth Quarter</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col">
                        <asp:DropDownList ID="districtdroplist" DataValueField="name" DataMember="districtid" runat="server" CssClass="form-control fs-5">
                            <asp:ListItem>Select District</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col">
                        <asp:DropDownList ID="TransactionType" CssClass="form-control fs-5" runat="server">
                            <asp:ListItem>Select Transaction Type</asp:ListItem>
                            <asp:ListItem Value="1">Damaged</asp:ListItem>
                            <asp:ListItem Value="2">Defaced</asp:ListItem>
                            <asp:ListItem Value="3">Expired</asp:ListItem>
                            <asp:ListItem Value="4">Name Change</asp:ListItem>
                            <asp:ListItem Value="5">Other Changes</asp:ListItem>
                            <asp:ListItem Value="6">Lost</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>                
            </div>
            
            <div class="row mt-2">
                <div class="col-2 text-center mt-2"><asp:RadioButton ID="reportRadioButton2" runat="server" CssClass="form-check-input alert-secondary" GroupName="report" AutoPostBack="true" /></div>
                <div class="row col-10">
                    <div class="col">
                        <asp:DropDownList ID="districtdroplist2" DataValueField="name" DataMember="districtid" runat="server" CssClass="form-control fs-5">
                            <asp:ListItem>Select District</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col"><asp:TextBox ID="txtreportdatestart" runat="server" CssClass="form-control fs-5" Type="date" Font-size="Larger"></asp:TextBox></div>
                    <div class="col"><asp:TextBox ID="txtreportdateend" runat="server" CssClass="form-control fs-5" Type="date" Font-Size="Larger"></asp:TextBox></div>
                </div>
            </div>

            <div class="mt-2 row">
                <div class="col-10"></div>
                <div class="col-2">
                    <asp:Button ID="btnreportsearch" runat="server" CssClass="btn btn-primary fs-3 col-8" Text="Seach" /> 
                    <asp:Label ID="MSGLabel" runat="server" Text="" />
                </div>
            </div>
        </div>
           
    </div>
    
    <%--GridView for reports results--%>
    <div class="container mt-3 card">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer Width="800px" Height="900" ID="ReportViewer1" runat="server" CssClass="container mt-2" BackColor="White" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">
            <LocalReport ReportPath="Reports\Report1.rdlc"></LocalReport>
        </rsweb:ReportViewer>

    </div>
</asp:Content>
