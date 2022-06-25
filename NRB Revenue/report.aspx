<%@ Page Title="" Language="C#" MasterPageFile="~/Revenue1.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="NRB_Revenue.report" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col">
        <h4 class=""><strong>REPORTS:</strong></h4>
        <div class="container-sm">
             <div class="row">
                <div class="col-2 text-center mt-2"><asp:RadioButton ID="reportRadioButton1" runat="server" CssClass="form-check-input alert-secondary" GroupName="report" OnCheckedChanged="reportRadioButton1_CheckedChanged" AutoPostBack="true" /></div>
                <div class="col-10 row">
                    <div class="col">
                        <asp:DropDownList ID="allreports" runat="server" CssClass="form-control fs-5">
                            <asp:ListItem>Monthly Report</asp:ListItem>
                            <asp:ListItem>Annualy Report</asp:ListItem>
                            <asp:ListItem>Quarter Report</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col">
                        <asp:DropDownList ID="districtdroplist" runat="server" CssClass="form-control fs-5">
                            <asp:ListItem>National</asp:ListItem>
                            <asp:ListItem>Districts droplist</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>                
            </div>
            
            <div class="row mt-2">
                <div class="col-2 text-center mt-2"><asp:RadioButton ID="reportRadioButton2" runat="server" CssClass="form-check-input alert-secondary" GroupName="report" OnCheckedChanged="reportRadioButton2_CheckedChanged" AutoPostBack="true" /></div>
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
                    <asp:Button ID="btnreportsearch" runat="server" CssClass="btn btn-primary fs-3 col-8" Text="Seach" OnClick="btnreportsearch_Click"/> 
                    <asp:Label ID="MSGLabel" runat="server" Text="" />
                </div>
            </div>
        </div>
           
    </div>
    
    <%--GridView for reports results--%>
    <div class="mt-3 card">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer Width="1200px" ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226">
            <%--<LocalReport ReportPath="Reports\Report1.rdlc"></LocalReport>--%>
        </rsweb:ReportViewer>

    </div>
</asp:Content>
