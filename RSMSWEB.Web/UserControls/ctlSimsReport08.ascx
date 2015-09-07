<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctlSimsReport08.ascx.vb" Inherits=".ctlSimsReport08" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<script type="text/javascript" id="dxss_script08">
    $(document).ready(function () {
        //alert(screen.width);
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
        

        $('#lblTypingSeed').click(function () {
            rdoTypingSeed.SetChecked(true);
            SelectIndexChange(false);
            txtSeedId.Focus();
        });
        $('#lblSelectSeed').click(function () {
            rdoSelectSeed.SetChecked(true);
            SelectIndexChange(true);
            cmbPlant.Focus();
        });
        $('#lblTypingSeed').css('cursor', 'pointer');
        $('#lblSelectSeed').css('cursor', 'pointer');

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

    //ตัวแปลสำหรับแปลงค่าของ Dropdown เป็น Header Text
    var SeedTypeIDGrobal = '-1';
    var seedStatus = "2";
    var plant = "-1";
    var seedType = "-1";
    var seedClass = "-1";
    var season = "-1";
    var year_value = "-1";
    var moneyType = "-1";
    var lot = "-1";

    function SelectIndexChange(val) {
        txtSeedId.SetEnabled(!val);
        cmbPlant.SetEnabled(val);
        //cmbSeedStatus.SetEnabled(val);
        cmbSeedType.SetEnabled(val);
        cmbSeedClass.SetEnabled(val);
        cmbSeason.SetEnabled(val);
        cmbYear.SetEnabled(val);
        cmbMoneyType.SetEnabled(val);
        txtLotNo.SetEnabled(val);
    }

    function SetDropdownValue(text) {
        var strFormTextBox = text;
        var arrayID = strFormTextBox.split("-");

        plant = arrayID[0];
        //seedStatus = arrayID[2];
        seedType = arrayID[2];
        seedClass = arrayID[3];
        season = arrayID[4];
        year_value = arrayID[5];
        moneyType = arrayID[6];
        lot = arrayID[7];


        SetSelectedValue(cmbPlant, arrayID[0]);
        cmbSeedType.PerformCallback(arrayID[0]);

        SeedTypeIDGrobal = arrayID[2];
        //SetSelectedValue(cmbSeedType, arrayID[2]); //change to endCallBack

        SetSelectedValue(cmbSeedClass, arrayID[3]);
        SetSelectedValue(cmbSeason, arrayID[4]);
        SetSelectedValue(cmbYear, arrayID[5]);
        SetSelectedValue(cmbMoneyType, arrayID[6]);

        if (arrayID[7] != 'XXX') {
            txtLotNo.SetText(FormatNumberLength(arrayID[7], 3));
        } else {
            txtLotNo.SetText('XXX');
        }
    }

    function SetSelectedValue(combo, val) {
        var item = combo.FindItemByValue(parseInt(val));

        if (item) {
            combo.SetSelectedItem(item);
        } else {
            combo.SetSelectedIndex(0);
        }

        switch (combo) {
            case cmbPlant:
                plant = (item) ? val : '-1';
                break;
            case cmbSeedType:
                seedType = (item) ? val : '-1';
                break;
            case cmbSeedClass:
                seedClass = (item) ? val : '-1';
                break;
            case cmbSeason:
                season = (item) ? val : '-1';
                break;
            case cmbYear:
                year_value = (item) ? val : '-1';
                break;
            case cmbMoneyType:
                moneyType = (item) ? val : '-1';
                break;
        }
    }

    function SetSeedIdBySelected(s) {
        switch (s) {
            case cmbPlant:
                plant = s.GetValue();
                break;
                //case cmbSeedStatus:
                //    seedStatus = s.GetValue();
                //    break;
            case cmbSeedType:
                seedType = s.GetValue();
                break;
            case cmbSeedClass:
                seedClass = s.GetValue();
                break;
            case cmbSeason:
                season = s.GetValue();
                break;
            case cmbYear:
                year_value = s.GetValue();
                break;
            case cmbMoneyType:
                moneyType = s.GetValue();
                break;
            case txtLotNo:
                lot = s.GetValue();
                break;
        }

        if (SeedTypeIDGrobal != '-1' && seedType == '-1') seedType = SeedTypeIDGrobal;

        var seedIdText = String.format("{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}",
                (plant != '-1') ? plant : "X",
                (seedStatus != '-1') ? seedStatus : "X",
                (seedType != '-1') ? FormatNumberLength(seedType, 2) : "XX",
                (seedClass != '-1') ? seedClass : "X",
                (season != '-1') ? season : "X",
                (year_value != '-1') ? year_value : "XXXX",
                (moneyType != '-1') ? moneyType : "X",
                (lot != '-1') ? lot : "XXX");

        txtSeedId.SetText(seedIdText);
        HeaderPanel.SetHeaderText("เมล็ดพันธุ์ : " + seedIdText);
    }

    function SetSeedTypeValue(val) {
        if (SeedTypeIDGrobal == '-1') {
            SeedTypeIDGrobal = val;
        }
    }

    function OnEndCallback(s) {
        SetSelectedValue(s, SeedTypeIDGrobal);
    }

    function OnPlantChanged(cmbPlant) {
        cmbSeedType.PerformCallback(cmbPlant.GetValue().toString());
        SetSeedIdBySelected();
    }

    function SetLotNoWithFormat(s) {
        if (s.GetValue() == null) {
            s.SetText('XXX');
        }
        if (s.GetValue() == 000) {
            s.SetText('XXX');
        }
        s.SetText(FormatNumberLength(s.GetValue(), 3));
        SetSeedIdBySelected(s);
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
        <dx:ASPxRoundPanel ID="HeaderPanel" ShowHeader="true" EnableAnimation="true"
            AllowCollapsingByHeaderClick="true" ClientInstanceName="HeaderPanel" ShowCollapseButton="true"
            HeaderText="เมล็ดพันธุ์ : X-2-XX-X-X-XXXX-X-XXX" runat="server" Width="100%" ClientVisible="True" Collapsed="True">
            <HeaderStyle Font-Bold="True" />
            <ClientSideEvents Init="function(s,e){txtSeedId.SetEnabled(false);}" />
            <PanelCollection>
                <dx:PanelContent>
                    <div id="divSeedID">
                        <table>
                            <tr>
                                <td>
                                    <dx:ASPxRadioButton ID="rdoTypingSeed" GroupName="SelectSeedID" ClientInstanceName="rdoTypingSeed" runat="server">
                                    </dx:ASPxRadioButton>
                                </td>
                                <td>
                                    <label id="lblTypingSeed">
                                        รหัสรายการ :
                                    </label>
                                </td>
                                <td colspan="5">
                                    <dx:ASPxTextBox ID="txtSeedId" runat="server" ClientInstanceName="txtSeedId" Width="170px" Text="X2XXXXXXXXXXXX">
                                        <MaskSettings Mask="#-#-##-#-#-####-#-###" IncludeLiterals="DecimalSymbol" PromptChar="X" />
                                        <ClientSideEvents LostFocus="function(s,e){SetDropdownValue(s.GetText());}" />
                                    </dx:ASPxTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <dx:ASPxRadioButton ID="rdoSelectSeed" runat="server" GroupName="SelectSeedID" Checked="true" ClientInstanceName="rdoSelectSeed">
                                        <ClientSideEvents CheckedChanged="function(s, e) {SelectIndexChange(s.GetChecked());}" />
                                    </dx:ASPxRadioButton>
                                </td>
                                <td>
                                    <label id="lblSelectSeed">
                                        พืช :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbPlant" runat="server" ClientInstanceName="cmbPlant">
                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { 
                                                cmbSeedType.PerformCallback(s.GetValue().toString());
                                                SetSeedIdBySelected(s);
                                             }" />
                                    </dx:ASPxComboBox>
                                </td>
                                <td style="text-align: right">
                                    <label>
                                        สถานะเมล็ดพันธุ์ :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbSeedStatus" Enabled="false" runat="server" ClientInstanceName="cmbSeedStatus" ValueType="System.String"></dx:ASPxComboBox>
                                </td>
                                <td style="text-align: right">
                                    <label for=''>
                                        พันธุ์ :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbSeedType" runat="server" ClientInstanceName="cmbSeedType">
                                        <ClientSideEvents EndCallback="function(s,e) {OnEndCallback(s);}" SelectedIndexChanged="function(s, e) {SetSeedTypeValue(s.GetValue()); SetSeedIdBySelected(s);  }" />
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="text-align: right">
                                    <label for=''>
                                        ชั้นพันธุ์ :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbSeedClass" runat="server" ClientInstanceName="cmbSeedClass" ValueType="System.String">
                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(s); }" />

                                    </dx:ASPxComboBox>
                                </td>
                                <td style="text-align: right">
                                    <label for=''>
                                        ฤดู :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbSeason" runat="server" ClientInstanceName="cmbSeason" ValueType="System.String">
                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(s); }" />
                                    </dx:ASPxComboBox>
                                </td>
                                <td style="text-align: right">
                                    <label for=''>
                                        ปี :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbYear" runat="server" ClientInstanceName="cmbYear" ValueType="System.String">
                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(s); }" />
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="text-align: right">
                                    <label for=''>
                                        ประเภทเงิน :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cmbMoneyType" runat="server" ClientInstanceName="cmbMoneyType" ValueType="System.String">
                                        <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(s); }" />
                                    </dx:ASPxComboBox>
                                </td>
                                <td style="text-align: right">
                                    <label for=''>
                                        ล็อตที่ :
                                    </label>
                                </td>
                                <td>
                                    <dx:ASPxTextBox ID="txtLotNo" ClientInstanceName="txtLotNo" MaxLength="3" runat="server" Width="170px" Text="XXX">
                                        <ClientSideEvents LostFocus="function(s,e) {SetLotNoWithFormat(s);}" />
                                    </dx:ASPxTextBox>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>
                    </div>
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxRoundPanel>
        <div style="padding-top: 3px;">
            <dx:ASPxRoundPanel ID="ASPxRoundPanel1" ShowHeader="false" EnableAnimation="true" AllowCollapsingByHeaderClick="true" ClientInstanceName="roundPanel" runat="server" Width="100%">
                <PanelCollection>
                    <dx:PanelContent>

                        <div style="margin-left: 5px; padding: 5px;">
                            <table>
                                <tr>
                                    <td style="text-align: right">
                                        <label>
                                            ศูนย์ :
                                        </label>
                                    </td>
                                    <td>
                                        <dx:ASPxComboBox ID="cmbSite" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <label>
                                            วันที่ :
                                        </label>
                                    </td>
                                    <td>
                                        <table style="border-spacing: 0px">
                                            <tr>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dpkStartDate" runat="server">
                                                        <CalendarProperties TodayButtonText="วันนี้" ClearButtonText="ลบ">
                                                        </CalendarProperties>
                                                    </dx:ASPxDateEdit>
                                                </td>
                                                <td>
                                                    <label>
                                                        &nbsp;ถึง&nbsp;</label>
                                                </td>
                                                <td>
                                                    <dx:ASPxDateEdit ID="dpkEndDate" runat="server">
                                                        <CalendarProperties TodayButtonText="วันนี้" ClearButtonText="ลบ">
                                                        </CalendarProperties>
                                                    </dx:ASPxDateEdit>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
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
                            <dx:GridViewDataTextColumn Caption="ศูนย์ฯ" FieldName="SiteName" VisibleIndex="0" Name="SiteName">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="พืช" FieldName="PlantName" VisibleIndex="1" Name="PlantName">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="พันธุ์" FieldName="SeedName" VisibleIndex="2" Name="SeedName">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="ชั้นพันธุ์" FieldName="ClassName" VisibleIndex="3" Name="ClassName">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="ฤดู" FieldName="SeasonName" VisibleIndex="4" Name="SeasonName">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="ปี" FieldName="SeedYear" VisibleIndex="5" Name="SeedYear">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                            </dx:GridViewDataTextColumn>
                            <%--<dx:GridViewDataTextColumn Caption="ประเภทเงินทุน" FieldName="MoneyTypeName" VisibleIndex="6" Name="MoneyTypeName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>--%>
                            <%--<dx:GridViewDataTextColumn Caption="ล็อตที่" FieldName="LotNo" VisibleIndex="7" Name="LotNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>--%>
                            <dx:GridViewBandColumn Caption="สถานการณ์การผลิตและจำหน่าย (กก.)" VisibleIndex="6">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="เมล็ดพันธุ์ดี<br />ที่ผลิตได้<br />(สะสม)" Name="SeedCollectionQuantity" FieldName="SeedCollectionQuantity" VisibleIndex="0">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="รับโอน<br />จากศูนย์อื่น <br />(สะสม)" Name="TransferInQuantity" FieldName="TransferInQuantity" VisibleIndex="1">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="จำนวนที่<br />จำหน่ายแล้ว<br />(สะสม)" Name="SaledQuantity" FieldName="SaledQuantity" VisibleIndex="2">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="โอน<br />ให้ศูนย์อื่น<br />(สะสม)" Name="TransferOutQuantity" FieldName="TransferOutQuantity" VisibleIndex="3">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                </Columns>
                                <HeaderStyle HorizontalAlign="Center" />
                            </dx:GridViewBandColumn>

                            <dx:GridViewBandColumn Caption="เมล็ดพันธุ์คงคลัง" VisibleIndex="7">
                                <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />

                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="เมล็ดพันธุ์ดิบ<br />คงคลัง<br />(กก.)" Name="RawTotalStockAmount" FieldName="RawTotalStockAmount" VisibleIndex="0">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="เมล็ดพันธุ์ดี<br />คงคลัง<br />(กก.)" Name="GoodTotalStockAmount" FieldName="GoodTotalStockAmount" VisibleIndex="1">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="เมล็ดพันธุ์ดี<br />ที่จัดจำหน่ายได้<br />(กก.)" Name="AvailableAmount" FieldName="AvailableAmount" VisibleIndex="3">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="ความงอก<br />เฉลี่ย<br />(%)" Name="SeedGrowValue" FieldName="SeedGrowValue" VisibleIndex="4">
                                        <HeaderStyle HorizontalAlign="Center" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewBandColumn Caption="การสำรอง (กก.)" VisibleIndex="2">
                                        <HeaderStyle HorizontalAlign="Center" />
                                        <Columns>
                                            <dx:GridViewDataTextColumn Caption="โดยส่วนกลาง" Name="CentralReseveQuantity" FieldName="CentralReseveQuantity" VisibleIndex="0">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewBandColumn Caption="โดยศูนย์" VisibleIndex="1">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <Columns>
                                                    <dx:GridViewDataTextColumn Caption="ทำแปลง" Name="LocalReseveGrowQuantity" FieldName="LocalReseveGrowQuantity" VisibleIndex="0">
                                                        <HeaderStyle HorizontalAlign="Center" />
                                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn Caption="จำหน่าย" Name="LocalReseveSaleQuantity" FieldName="LocalReseveSaleQuantity" VisibleIndex="1">
                                                        <HeaderStyle HorizontalAlign="Center" />
                                                        <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                                    </dx:GridViewDataTextColumn>
                                                </Columns>
                                            </dx:GridViewBandColumn>
                                            <dx:GridViewDataTextColumn Caption="รวมสำรอง" VisibleIndex="2" Name="TotalReserveQuantity" FieldName="TotalReserveQuantity">
                                                <HeaderStyle HorizontalAlign="Center" />
                                                <PropertiesTextEdit DisplayFormatString="N0"></PropertiesTextEdit>
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                    </dx:GridViewBandColumn>
                                </Columns>
                                <HeaderStyle HorizontalAlign="Center" />
                            </dx:GridViewBandColumn>
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
                            <dx:ASPxSummaryItem FieldName="SeedCollectionQuantity" ShowInColumn="SeedCollectionQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="TransferInQuantity" ShowInColumn="TransferInQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="SaledQuantity" ShowInColumn="SaledQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="TransferOutQuantity" ShowInColumn="TransferOutQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="RawTotalStockAmount" ShowInColumn="RawTotalStockAmount" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="GoodTotalStockAmount" ShowInColumn="GoodTotalStockAmount" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="AvailableAmount" ShowInColumn="AvailableAmount" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="CentralReseveQuantity" ShowInColumn="CentralReseveQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="LocalReseveGrowQuantity" ShowInColumn="LocalReseveGrowQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="LocalReseveSaleQuantity" ShowInColumn="LocalReseveSaleQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <dx:ASPxSummaryItem FieldName="TotalReserveQuantity" ShowInColumn="TotalReserveQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />
                            <%--<dx:ASPxSummaryItem FieldName="ReceiveQuantity" ShowInColumn="ReceiveQuantity" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>" />--%>
                        </TotalSummary>
                        <SettingsText EmptyDataRow="ไม่พบข้อมูลที่ต้องการแสดง" />
                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                    </dx:ASPxGridView>
                </div>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
</div>
