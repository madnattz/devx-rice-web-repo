<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Report17.aspx.vb" Inherits=".Report17" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>รายงานที่ 17 บัญชีวัสดุการผลิตคงคลัง</title>
    <script src="/Scripts/jquery/jquery.js" type="text/javascript"></script>
    <script>

        var SeedTypeIDGrobal = null;

        $(document).ready(function () {
            $(document).keypress(function (event) {
                var keycode = (event.keyCode ? event.keyCode : event.which);
                if (keycode == '13') {
                    btnSearch.SetFocus();
                    btnSearch.DoClick();
                    return false;
                }
            });
        });

        function FormatNumberLength(num, length) {
            var r = "" + num;
            while (r.length < length) {
                r = "0" + r;
            }
            return r;
        }

        String.format = function () {
            var s = arguments[0];
            for (var i = 0; i < arguments.length - 1; i++) {
                var reg = new RegExp("\\{" + i + "\\}", "gm");
                s = s.replace(reg, arguments[i + 1]);
            }

            return s;
        }

        var lastPlant = null;
        function OnPlantChanged(cmbPlant) {
            if (cmbSeedType.InCallback()) {
                lastPlant = cmbPlant.GetValue().toString();
            }
            else {
                cmbSeedType.PerformCallback(cmbPlant.GetValue().toString());
            }

            SetSeedIdBySelected();
        }

        function OnEndCallback(s, e) {
            if (lastPlant) {
                cmbSeedType.PerformCallback(lastPlant);
                lastPlant = null;
            }

        }

        function ComboCallback(s, e) {
            s.PerformCallback(s.GetValue().toString());
        }

        function OnSearchClick() {
            gvData.PerformCallback();
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div_main">
            <div id="div_text_header">
                บัญชีวัสดุการผลิตคงคลัง
            </div>
            <div id="div_search_panel">
                <div style="margin-left: 5px; padding: 5px;">
                    <table>
                        <tr>
                            <td style="text-align: right">
                                <label>
                                    วันที่ :
                                </label>
                            </td>
                            <td>
                                <dx:ASPxDateEdit ID="dpkStartDate" runat="server"></dx:ASPxDateEdit>
                            </td>
                            <td style="text-align: right">
                                <label>
                                    ถึง&nbsp</label></td>
                            <td>
                                <dx:ASPxDateEdit ID="dpkEndDate" runat="server"></dx:ASPxDateEdit>
                            </td>
                        </tr>
                        <tr id="Tr2" runat="server">
                            <td style="text-align: right">
                                <label>
                                    ประเภทเงินที่จัดซื้อ :
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbMoneyType" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                <label>
                                    วัสดุการผลิต :
                                </label>
                            </td>
                            <td colspan="3">
                                <dx:ASPxComboBox ID="cmbMaterial" Width="300px" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                            </td>

                        </tr>
                        <tr id="Tr1" runat="server">
                            <td style="text-align: right">
                                <label>
                                    ศูนย์:
                                </label>
                            </td>
                            <td colspan="3">
                                <dx:ASPxComboBox ID="cmbSite" Width="300px" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td colspan="3">
                                <div style="padding-top: 5px;">
                                    <dx:ASPxButton ID="btnSearch" Width="80px" runat="server" ClientInstanceName="btnSearch" AutoPostBack="False" Text="ค้นหา">
                                        <ClientSideEvents Click="function(s, e) {OnSearchClick(); }" />
                                        
                                        
                                    </dx:ASPxButton>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <script type="text/javascript">
            var order;
            function onSorting(s, e) {
                order = order == "ASC" ? "DESC" : "ASC";
                e.cancel = true;
                var args = [order, e.column.fieldName];
                s.PerformCallback(args);
            }

        </script>
        <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="gvData">
        </dx:ASPxGridViewExporter>
        <div id="div_search_result">
            <hr />
            <div style="padding: 5px;">
                <div style="text-align: right; padding: 0 0 5px 0;">
                    <dx:ASPxButton ID="btnExportData" runat="server" Text="Export to Excel"></dx:ASPxButton>
                </div>
                <dx:ASPxGridView ID="gvData" ClientInstanceName="gvData" Width="100%" runat="server" AutoGenerateColumns="False">
                    <ClientSideEvents ColumnSorting="onSorting" />
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="ศูนย์ฯ" FieldName="SiteName" VisibleIndex="0" Name="SiteName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="วันที่รับเมล็ดพันธุ์" FieldName="ReceiveDate" Name="ReceiveDate" VisibleIndex="1">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <DataItemTemplate>
                                <%#DataUtil.GatDateString(Eval("TransactionDate"))%>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ชนิด" FieldName="MaterialName" VisibleIndex="2" Name="MaterialName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ประเภทเงิน<br />ที่จัดซื้อ" FieldName="MoneyTypeName" VisibleIndex="3" Name="MoneyTypeName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ปี" FieldName="MaterialYear" VisibleIndex="4" Name="MaterialYear">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ล็อตที่" FieldName="LotNo" VisibleIndex="5" Name="LotNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="ประเภท" FieldName="TransactionType" VisibleIndex="5" Name="TransactionType">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="เลขที่รับ/จ่าย" FieldName="RefNo" VisibleIndex="6" Name="RefNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewBandColumn Caption="รายการรับ" VisibleIndex="7">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="ราคาต่อหน่วย<br />(บาท)" Name="IncomeCost" FieldName="IncomeCost" VisibleIndex="0">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="จำนวน<br />(หน่วย)" Name="Income" FieldName="Income" VisibleIndex="1">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="เป็นเงิน<br />(บาท)" Name="IncomeAmount" FieldName="IncomeAmount" VisibleIndex="2">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                            </Columns>
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewBandColumn>
                        <dx:GridViewBandColumn Caption="รายการจ่าย" VisibleIndex="9">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="ราคาต่อหน่วย<br />(บาท)" Name="OutcomeCost" FieldName="OutcomeCost" VisibleIndex="0">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="จำนวน<br />(หน่วย)" Name="OutcomeAmount" FieldName="OutcomeAmount" VisibleIndex="1">
                                    <HeaderStyle HorizontalAlign="Center"  />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="เป็นเงิน<br />(บาท)" Name="Outcome" FieldName="Outcome" VisibleIndex="2">
                                    <HeaderStyle HorizontalAlign="Center"  />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                            </Columns>
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewBandColumn>
                        <%--<dx:GridViewBandColumn Caption="คงเหลือ" VisibleIndex="10">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="กระสอบ/ถุง" Name="TotalBags" FieldName="TotalBags" VisibleIndex="0">
                                    <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="น้ำหนัก (กก.)" Name="TotalStockAmount" FieldName="TotalStockAmount" VisibleIndex="1">
                                    <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                                    <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                            </Columns>
                            <HeaderStyle HorizontalAlign="Center" />
                        </dx:GridViewBandColumn>--%>
                    </Columns>
                    <SettingsPager PageSize="20">
                        <PageSizeItemSettings Visible="True">
                        </PageSizeItemSettings>
                    </SettingsPager>
                    <Settings ShowFooter="True" />
                    <TotalSummary>
                        <dx:ASPxSummaryItem FieldName="IncomeCost" ShowInColumn="IncomeCost" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                        <dx:ASPxSummaryItem FieldName="Income" ShowInColumn="Income" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                        <dx:ASPxSummaryItem FieldName="IncomeAmount" ShowInColumn="IncomeAmount" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                        <dx:ASPxSummaryItem FieldName="Outcome" ShowInColumn="Outcome" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                        <dx:ASPxSummaryItem FieldName="OutcomeCost" ShowInColumn="OutcomeCost" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                        <dx:ASPxSummaryItem FieldName="OutcomeAmount" ShowInColumn="OutcomeAmount" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                    </TotalSummary>
                    <SettingsText EmptyDataRow="ไม่พบข้อมูลที่ต้องการแสดง" />
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
            </div>
        </div>
    </form>
</body>
</html>

