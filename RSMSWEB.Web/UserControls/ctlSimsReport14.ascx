<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctlSimsReport14.ascx.vb" Inherits=".ctlSimsReport14" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<script type="text/javascript" id="dxss_script14">
    $(document).ready(function () {
        $(document).keypress(function (event) {
            var keycode = (event.keyCode ? event.keyCode : event.which);
            if (keycode == '13') {
                btnSearch.SetFocus();
                btnSearch.DoClick();
                return false;
            }
        });

        var gridDisplayWidth = 1019;
        switch (screen.width) {
            case 1366:
                gridDisplayWidth = 1019;
                break;
            case 1360:
                gridDisplayWidth = 1013;
                break;
            case 1280:
                gridDisplayWidth = 933;
                break;
            case 1024:
                gridDisplayWidth = 677;
        }
        $('#divGridDisplay').width(gridDisplayWidth);


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

    var order;
    function onSorting(s, e) {
        order = order == "ASC" ? "DESC" : "ASC";
        e.cancel = true;
        var args = [order, e.column.fieldName];
        s.PerformCallback(args);
    }
</script>
<div id="div_main">
    <div id="div_search_panel">
        <%--<dx:ASPxRoundPanel ID="HeaderPanel" ShowHeader="true" EnableAnimation="true"
            AllowCollapsingByHeaderClick="true" ClientInstanceName="HeaderPanel" ShowCollapseButton="true"
            HeaderText="เมล็ดพันธุ์ : X-X-XX-X-X-XXXX-X-XXX" runat="server" Width="100%" ClientVisible="True" Collapsed="True">
            <HeaderStyle Font-Bold="True" />
            <ClientSideEvents Init="function(s,e){txtSeedId.SetEnabled(false);}" />
            <PanelCollection>
                <dx:PanelContent>
                    xxxxxx
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxRoundPanel>--%>
        <div style="padding-top: 3px;">
            <dx:ASPxRoundPanel ID="ASPxRoundPanel1" ShowHeader="false" EnableAnimation="true" AllowCollapsingByHeaderClick="true" ClientInstanceName="roundPanel" runat="server" Width="100%">
                <PanelCollection>
                    <dx:PanelContent>

                        <div style="margin-left: 5px; padding: 5px;">
                            <table>
                                <tr id="Tr1" runat="server">
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
                                <tr id="Tr2" runat="server">
                                    <td style="text-align: right">
                                        <label>
                                            ศูนย์ :
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
                                        <dx:ASPxDateEdit ID="dpkStartDate" runat="server">
                                            <CalendarProperties TodayButtonText="วันนี้" ClearButtonText="ลบ">
                                            </CalendarProperties>
                                        </dx:ASPxDateEdit>
                                    </td>
                                    <td style="text-align: right">
                                        <label>
                                            ถึง&nbsp</label></td>
                                    <td>
                                        <dx:ASPxDateEdit ID="dpkEndDate" runat="server">
                                            <CalendarProperties TodayButtonText="วันนี้" ClearButtonText="ลบ">
                                            </CalendarProperties>
                                        </dx:ASPxDateEdit>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>

                                <tr>
                                    <td></td>
                                    <td>
                                        <div style="padding-top: 5px;">
                                            <dx:ASPxButton ID="btnSearch" Width="80px" runat="server" ClientInstanceName="btnSearch" AutoPostBack="False" Text="ค้นหา">
                                                <ClientSideEvents Click="function(s, e) {gvData.PerformCallback(''); }" />
                                                
                                                
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
                    </dx:PanelContent>
                </PanelCollection>
            </dx:ASPxRoundPanel>
        </div>
    </div>
</div>

<dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="gvData">
</dx:ASPxGridViewExporter>
<div style="padding-top: 3px;">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel2" ShowHeader="false" EnableAnimation="true" AllowCollapsingByHeaderClick="true" ClientInstanceName="roundPanel" runat="server" Width="100%">
        <PanelCollection>
            <dx:PanelContent>
                <div style="text-align: right; padding: 5px 5px 0 0;">
                    <dx:ASPxButton ID="btnExportData" runat="server" Text="แสดงไฟล์ Excel"></dx:ASPxButton>
                </div>
                <div id="divGridDisplay" style="padding: 5px; width: 1019px; overflow: auto; white-space: nowrap;">
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
                            <PrevPageButton TextFormatString="{0} ">
                            </PrevPageButton>
                            <Summary AllPagesText="หน้า : {0} จาก {1} ({2} รายการ)" Text="หน้า : {0} จาก {1} ({2} รายการ)" />
                            <PageSizeItemSettings Visible="True" Caption="แสดงหน้าละ (รายการ):" ShowPopupShadow="False">
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
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
</div>
