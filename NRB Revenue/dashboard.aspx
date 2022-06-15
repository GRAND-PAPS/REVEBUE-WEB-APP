<%@ Page Title="" Language="C#" MasterPageFile="~/Revenue1.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="NRB_Revenue.dashboard" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h4 class=""><strong>DASHBOARD:</strong></h4>
        <div class="col card">
            <asp:Label ID="lblWeeklypiechart" runat="server" CssClass="fs-4 text-info" Font-Bold="true">Weekly Revenue Statistics</asp:Label>
            <%--Pie Chart--%>
            <div class="">
                <asp:Chart ID="Chart1" runat="server" Width="646px">
                    <Series>
                        <asp:Series Name="Series1" ChartType="Line"></asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>               
            </div>
            <div class="mt-2">
                 <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="531px">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>

        </div>
        <div class="col card">
            <asp:Label ID="lblMonthlypiechart" runat="server" CssClass="fs-4 text-info" Font-Bold="true">Monthly Revenue Statistics</asp:Label>
            <%--Pie Chart 2--%>
            <div class="">

            </div>
            <%--pie chart--%>
            <div class="mt-2">

            </div>
        </div>
    </div>
    <div class="col mt-3">
        <asp:Label ID="lblbargraphstat" CssClass="fs-4 text-info" runat="server" Font-Bold="true">Annualy Revenue Statistics</asp:Label>
        <%--Bar Graph--%>
        <div class="card">

        </div>
    </div>
</asp:Content>
