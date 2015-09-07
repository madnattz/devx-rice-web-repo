<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Report15.aspx.vb" Inherits=".Report15" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>รายงานที่ 15 ทะเบียนรายชื่อตัวแทนจำหน่ายเมล็ดพันธุ์พืช</title>
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
                ทะเบียนรายชื่อตัวแทนจำหน่ายเมล็ดพันธุ์พืช
            </div>
            <div id="div_search_panel">
                <div style="margin-left: 5px; padding: 5px;">
                    <table>
                        <tr runat="server">
                            <td style="text-align: right">จังหวัด :</td>
                            <td>
                                <dx:ASPxComboBox ID="cmbProvince" ClientInstanceName="cmbProvince" runat="server" ValueType="System.String">
                                    <ClientSideEvents SelectedIndexChanged="function(s,e){cmbDistric.PerformCallback(cmbProvince.GetValue().toString());}" />
                                    <Items>
                                        <dx:ListEditItem Text="ทั้งหมด" Value="-1" Selected="true" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </td>
                            <td style="text-align: right">&nbsp;อำเภอ :</td>
                            <td>
                                <dx:ASPxComboBox ID="cmbDistric" ClientInstanceName="cmbDistric" runat="server" ValueType="System.String">
                                    <ClientSideEvents SelectedIndexChanged="function(s,e){cmbSubDistric.PerformCallback(cmbDistric.GetValue().toString());}" />
                                    <Items>
                                        <dx:ListEditItem Text="ทั้งหมด" Value="-1" Selected="true" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </td>
                            <td style="text-align: right">&nbsp;ตำบล :</td>
                            <td>
                                <dx:ASPxComboBox ID="cmbSubDistric" ClientInstanceName="cmbSubDistric" runat="server" ValueType="System.String">
                                    <Items>
                                        <dx:ListEditItem Text="ทั้งหมด" Value="-1" Selected="true" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </td>
                        </tr>


                        <tr>
                            <td style="text-align: right">
                                <label>
                                    วันที่อนุมัติ :
                                </label>
                            </td>
                            <td>
                                <dx:ASPxDateEdit ID="dpkApproveStartDate" runat="server"></dx:ASPxDateEdit>
                            </td>
                            <td style="text-align: right">
                                <label>
                                    ถึง&nbsp;</label></td>
                            <td>
                                <dx:ASPxDateEdit ID="dpkApproveEndDate" runat="server"></dx:ASPxDateEdit>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                <label>
                                    วันที่หมดอายุ :
                                </label>
                            </td>
                            <td>
                                <dx:ASPxDateEdit ID="dpkExpireStartDate" runat="server"></dx:ASPxDateEdit>
                            </td>
                            <td style="text-align: right">
                                <label>
                                    ถึง&nbsp;</label></td>
                            <td>
                                <dx:ASPxDateEdit ID="dpkExpireEndDate" runat="server"></dx:ASPxDateEdit>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr id="Tr1" runat="server">
                            <td style="text-align: right">
                                <label>
                                    ศูนย์:
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbSite" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                            </td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <div style="padding-top: 5px;">
                                    <dx:ASPxButton ID="btnSearch" Width="80px" runat="server" ClientInstanceName="btnSearch" AutoPostBack="False" Text="ค้นหา">
                                        <ClientSideEvents Click="function(s, e) {OnSearchClick(); }" />
                                        
                                        
                                    </dx:ASPxButton>
                                </div>
                            </td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
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
                        <dx:GridViewDataTextColumn Caption="ศูนย์" FieldName="SiteName" VisibleIndex="0" Name="SiteName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="วันที่อนุมัติ" Name="AgentStartDate" FieldName="AgentStartDate" VisibleIndex="2">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <DataItemTemplate>
                                <%#DataUtil.GatDateString(Eval("AgentStartDate"))%>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="วันที่หมดอายุ" Name="AgentExpireDate" FieldName="AgentExpireDate" VisibleIndex="3">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <DataItemTemplate>
                                <%#DataUtil.GatDateString(Eval("AgentExpireDate"))%>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ทะเบียนตัวแทน" FieldName="AgentNo" VisibleIndex="1" Name="AgentNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ชื่อผู้สนับสนุนกิจการ" FieldName="FullName" VisibleIndex="8" Name="FullName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ชื่อร้าน" FieldName="OrgName" VisibleIndex="9" Name="OrgName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="เลขที่" FieldName="AddressNo" VisibleIndex="10" Name="AddressNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="หมู่ที่" FieldName="Moo" VisibleIndex="11" Name="Moo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ตำบล" Name="SubDistrictName" FieldName="SubDistrictName" VisibleIndex="12">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="อำเภอ" Name="DistrictName" FieldName="DistrictName" VisibleIndex="13">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="จังหวัด" Name="ProvinceName" FieldName="ProvinceName" VisibleIndex="14">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="โทรศัพท์" FieldName="TelNo" VisibleIndex="15" Name="TelNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="โทรสาร" FieldName="FaxNo" VisibleIndex="16" Name="FaxNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager PageSize="20">
                        <PageSizeItemSettings Visible="True">
                        </PageSizeItemSettings>
                    </SettingsPager>
                    <Settings ShowFooter="False" />
                    <%-- <TotalSummary>
                        <dx:ASPxSummaryItem FieldName="Quantity" ShowInColumn="Quantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                    </TotalSummary>--%>
                    <SettingsText EmptyDataRow="ไม่พบข้อมูลที่ต้องการแสดง" />
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
            </div>
        </div>
    </form>
</body>
</html>

