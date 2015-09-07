<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Report14.aspx.vb" Inherits=".Report14" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>รายงานที่ 14 ทะเบียนผู้ซื้อเมล็ดพันธุ์</title>
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
                ทะเบียนผู้ซื้อเมล็ดพันธุ์ 
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
                        <tr runat="server">
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
                            <td style="text-align: right">
                                <label>
                                    วันที่อนุมัติ :
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
                        <dx:GridViewDataTextColumn Caption="วันที่รับโอน" Name="SaleDate" FieldName="SaleDate" VisibleIndex="1">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <DataItemTemplate>
                                <%#DataUtil.GatDateString(Eval("SaleDate"))%>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="พืช" FieldName="PlantName" VisibleIndex="2" Name="PlantName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="พันธุ์" FieldName="SeedName" VisibleIndex="3" Name="SeedName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ชั้นพันธุ์" FieldName="ClassName" VisibleIndex="4" Name="ClassName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ฤดู" FieldName="SeasonName" VisibleIndex="5" Name="SeasonName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ปี" FieldName="SeedYear" VisibleIndex="6" Name="SeedYear">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ประเภทผู้ซื้อ" FieldName="MemberType" VisibleIndex="7" Name="MemberType">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ชื่อผู้ซื้อ" FieldName="MemberName" VisibleIndex="8" Name="MemberName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="เลขที่" FieldName="AddressNo" VisibleIndex="9" Name="AddressNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="หมู่ที่" FieldName="Moo" VisibleIndex="10" Name="Moo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ตำบล" Name="SubDistrictName" FieldName="SubDistrictName" VisibleIndex="11">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="อำเภอ" Name="DistrictName" FieldName="DistrictName" VisibleIndex="12">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="จังหวัด" Name="ProvinceName" FieldName="ProvinceName" VisibleIndex="13">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="โทรศัพท์" FieldName="Tel" VisibleIndex="14" Name="Tel">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="โทรสาร" FieldName="Fax" VisibleIndex="15" Name="Fax">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="น้ำหนัก (กก.)" Name="Quantity" FieldName="Quantity" VisibleIndex="16">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager PageSize="20">
                        <PageSizeItemSettings Visible="True">
                        </PageSizeItemSettings>
                    </SettingsPager>
                    <Settings ShowFooter="True" />
                    <TotalSummary>
                        <dx:ASPxSummaryItem FieldName="Quantity" ShowInColumn="Quantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                    </TotalSummary>
                    <SettingsText EmptyDataRow="ไม่พบข้อมูลที่ต้องการแสดง" />
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
            </div>
        </div>
    </form>
</body>
</html>

