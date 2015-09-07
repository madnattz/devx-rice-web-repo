<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Report16.aspx.vb" Inherits=".Report16" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>รายงานที่ 16 บัญชีการสั่งจอง/สำรองเมล็ดพันธุ์</title>
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
               บัญชีการสั่งจอง/สำรองเมล็ดพันธุ์
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
                        <dx:GridViewDataTextColumn Caption="วันที่จอง" Name="ReserveDateTime" FieldName="ReserveDateTime" VisibleIndex="1">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <DataItemTemplate>
                                <%#DataUtil.GatDateString(Eval("ReserveDateTime"))%>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="วันที่รับเมล็ดพันธุ์	" Name="ReceiveDateTime" FieldName="ReceiveDateTime" VisibleIndex="2">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            <DataItemTemplate>
                               <%#DataUtil.GatDateString(Eval("ReceiveDateTime"))%>
                            </DataItemTemplate>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="สำรองโดย" FieldName="ReserveBy" VisibleIndex="4" Name="ReserveBy">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ผู้จอง" FieldName="MemberName" VisibleIndex="5" Name="MemberName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="เลขที่" FieldName="AddressNo" VisibleIndex="6" Name="AddressNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="หมู่ที่" FieldName="Moo" VisibleIndex="7" Name="Moo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ตำบล" Name="SubDistrictName" FieldName="SubDistrictName" VisibleIndex="8">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="อำเภอ" Name="DistrictName" FieldName="DistrictName" VisibleIndex="9">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="จังหวัด" Name="ProvinceName" FieldName="ProvinceName" VisibleIndex="10">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="โทรศัพท์" FieldName="Tel" VisibleIndex="11" Name="Tel">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="โทรสาร" FieldName="Fax" VisibleIndex="12" Name="Fax">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="พืช" FieldName="PlantName" VisibleIndex="13" Name="PlantName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="พันธุ์" FieldName="SeedName" VisibleIndex="14" Name="SeedName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ชั้นพันธุ์" FieldName="ClassName" VisibleIndex="15" Name="ClassName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewBandColumn Caption="น้ำหนัก (กก.)" VisibleIndex="16">
                            <HeaderStyle Font-Bold="True" HorizontalAlign="Center" />
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="จอง" FieldName="Quantity" Name="Quantity" ShowInCustomizationForm="True" VisibleIndex="0">
                                    <PropertiesTextEdit DisplayFormatString="N0">
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="จำหน่าย" FieldName="SoldQuantity" Name="SoldQuantity" ShowInCustomizationForm="True" VisibleIndex="1">
                                    <PropertiesTextEdit DisplayFormatString="N0">
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="คงเหลือ" FieldName="RemainQuantity" Name="RemainQuantity" ShowInCustomizationForm="True" VisibleIndex="2">
                                    <PropertiesTextEdit DisplayFormatString="N0">
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:GridViewBandColumn>
                    </Columns>
                    <SettingsPager PageSize="20">
                            <PrevPageButton TextFormatString="{0} ">
                            </PrevPageButton>
                            <Summary AllPagesText="หน้า : {0} จาก {1} ({2} รายการ)" />
                            <PageSizeItemSettings Visible="True" Caption="แสดงหน้าละ (รายการ):" ShowPopupShadow="False">
                            </PageSizeItemSettings>
                        </SettingsPager>
                    <Settings ShowFooter="True" />
                    <TotalSummary>
                        <dx:ASPxSummaryItem FieldName="Quantity" ShowInColumn="Quantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                         <dx:ASPxSummaryItem FieldName="SoldQuantity" ShowInColumn="SoldQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                         <dx:ASPxSummaryItem FieldName="RemainQuantity" ShowInColumn="RemainQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                    </TotalSummary>
                    <SettingsText EmptyDataRow="ไม่พบข้อมูลที่ต้องการแสดง" />
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
            </div>
        </div>
    </form>
</body>
</html>

