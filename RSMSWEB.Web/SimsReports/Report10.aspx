<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Report10.aspx.vb" Inherits=".Report10" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>รายงานที่ 10 รายงานการจำหน่ายเมล็ดพันธุ์ผ่านตัวแทน </title>
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

            var val = $("#rdoSelectSeedId").is(":checked");
            txtSeedId.SetEnabled(!val);

            $("#divSeedID").hide();
            $("#dsh_header").hover(function () {
                $(this).css("cursor", "pointer");
            });
            $("#dsh_header").click(function () {
                $("#divSeedID").slideToggle("normal", function () {
                    if ($(this).is(":visible")) {
                        $("#img1").attr("src", $("#img1").attr("src").replace("up", "down"));
                        $("#img1").attr("title", "ปิด");
                    }
                    else {
                        $("#img1").attr("src", $("#img1").attr("src").replace("down", "up"));
                        $("#img1").attr("title", "เปิด");
                    }
                });
            });

            $(window.txtLotNo.GetInputElement()).blur(function () {
                if (txtLotNo.GetValue() == null) {
                    txtLotNo.SetText('XXX');
                }
                txtLotNo.SetText(FormatNumberLength(txtLotNo.GetValue(), 3));
            });

            //เลือก กรอกรหัสรายการ หรือเลือกตามหัวข้อ
            $("input[name=SelectSeedID]").change(function () {
                var val = $("#rdoSelectSeedId").is(":checked");
                txtSeedId.SetEnabled(!val);
                cmbPlant.SetEnabled(val);
                cmbSeedStatus.SetEnabled(val);
                cmbSeedType.SetEnabled(val);
                cmbSeedClass.SetEnabled(val);
                cmbSeason.SetEnabled(val);
                cmbYear.SetEnabled(val);
                cmbMoneyType.SetEnabled(val);
                txtLotNo.SetEnabled(val);
            });

            //เปลี่ยนค่า Header Text และ Dropdown ตามค่าที่กรอก
            $(window.txtSeedId.GetInputElement()).blur(function () {
                var strFormTextBox = txtSeedId.GetText();
                var arrayID = strFormTextBox.split("-");
                SeedTypeIDGrobal = arrayID[2];
                SetSelectedValue(cmbPlant, arrayID[0]);
                cmbSeedType.PerformCallback(cmbPlant.GetValue().toString());
                SetSelectedValue(cmbSeedStatus, arrayID[1]);
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

                //var seedIdText = String.format("เมล็ดพันธุ์ : {0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}",
                //    arrayID[0].replace("0", "X"),
                //    '1',
                //    arrayID[2].replace("00", "XX"),
                //    arrayID[3].replace("0", "X"),
                //    arrayID[4].replace("0", "X"),
                //    arrayID[5].replace("0000", "XXXX"),
                //    arrayID[6].replace("0", "X"),
                //    arrayID[7].replace("000", "XXX"));

                //var dshComment = document.getElementById("lblComment");
                //dshComment.innerHTML = seedIdText;

            });
        });

        function SetSeedIdBySelected() {
            var plant = "X";
            if (cmbPlant.GetSelectedIndex() != 0) {
                plant = cmbPlant.GetValue();
            }

            var seedStatus = "X";
            if (cmbSeedStatus.GetSelectedIndex() != 0) {
                seedStatus = FormatNumberLength(cmbSeedStatus.GetValue(), 2);
            }

            var seedType = "XX";
            //if (cmbSeedType.GetSelectedIndex() != 0) {
            //    seedType = FormatNumberLength(cmbSeedType.GetValue(), 2);
            //}
            if (SeedTypeIDGrobal) {
                seedType = FormatNumberLength(SeedTypeIDGrobal, 2);
            }

            var seedClass = "X";
            if (cmbSeedClass.GetSelectedIndex() != 0) {
                seedClass = cmbSeedClass.GetValue();
            }

            var season = "X";
            if (cmbSeason.GetSelectedIndex() != 0) {
                season = cmbSeason.GetValue();
            }

            var year_value = "XXXX";
            if (cmbYear.GetSelectedIndex() != 0) {
                year_value = cmbYear.GetValue();
            }

            var moneyType = "X";
            if (cmbMoneyType.GetSelectedIndex() != 0) {
                moneyType = cmbMoneyType.GetValue();
            }

            var lot = "XXX";
            if (txtLotNo.GetText() != "XXX" && txtLotNo.GetText() != '') {
                lot = FormatNumberLength(txtLotNo.GetText(), 3);
            }
            else {
                txtLotNo.SetText("XXX");
            }

            var seedIdText = String.format("เมล็ดพันธุ์ : {0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}", plant, seedStatus, seedType, seedClass, season, year_value, moneyType, lot);
            var dshComment = document.getElementById("lblComment");

            var numberOfSeedID = plant + '' + seedStatus + '' + seedType + '' + seedClass + '' + season + '' + year_value + '' + moneyType + '' + lot;

            numberOfSeedID = numberOfSeedID.replace(/X/g, "X");
            txtSeedId.SetText(numberOfSeedID);
            dshComment.innerHTML = seedIdText;
        }

        function SetSelectedValue(combo, val) {
            var item = combo.FindItemByValue(parseInt(val));

            if (item) {
                combo.SetSelectedItem(item);
            } else {
                combo.SetSelectedIndex(0);
            }
        }

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

        function OnSearchClick() {
            gvData.PerformCallback();
        }

        function OnEndCallback(s, e) {
            if (lastPlant) {
                cmbSeedType.PerformCallback(lastPlant);
                lastPlant = null;
            }
            SetSelectedValue(s, SeedTypeIDGrobal);
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">

        <div id="div_main">
            <div id="div_text_header">
                รายงานการจำหน่ายเมล็ดพันธุ์ผ่านตัวแทน
            </div>
            <div id="div_search_panel">
                <span id="dsh_header">
                    <img id="img1" src="/Images/togleup.gif" style="padding-right: 5px;" title="เปิด" />
                    <label id="lblComment" class="SubHead2">เมล็ดพันธุ์ : X-X-XX-X-X-XXXX-X-XXX</label>
                </span>
                <div id="divSeedID">
                    <table>
                        <tr>
                            <td>
                                <input type="radio" id="rdoTypingSeedId" name="SelectSeedID" />
                            </td>
                            <td>
                                <label for="rdoTypingSeedId">
                                    รหัสรายการ :
                                </label>
                            </td>
                            <td colspan="5">
                                <dx:ASPxTextBox ID="txtSeedId" runat="server" ClientInstanceName="txtSeedId" Width="170px" Text="XXXXXXXXXXXXXX">
                                    <MaskSettings Mask="#-#-##-#-#-####-#-###" IncludeLiterals="DecimalSymbol" PromptChar="X" />
                                </dx:ASPxTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <input type="radio" id="rdoSelectSeedId" checked="checked" name="SelectSeedID" />
                            </td>
                            <td>
                                <label for="rdoSelectSeedId">
                                    พืช:</label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbPlant" runat="server" ClientInstanceName="cmbPlant">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { OnPlantChanged(s); }" />
                                </dx:ASPxComboBox>
                            </td>
                            <td>
                                <label>
                                    สถานะเมล็ดพันธุ์ :
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbSeedStatus"  runat="server" ClientInstanceName="cmbSeedStatus" ValueType="System.String">
                                    <ClientSideEvents EndCallback="OnEndCallback" SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(); }" />
                                </dx:ASPxComboBox>
                            </td>
                            <td>
                                <label for=''>
                                    พันธุ์ :
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbSeedType" runat="server" ClientInstanceName="cmbSeedType">
                                    <ClientSideEvents EndCallback="OnEndCallback" SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(); }" />
                                </dx:ASPxComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <label for=''>
                                    ชั้นพันธุ์:
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbSeedClass" runat="server" ClientInstanceName="cmbSeedClass" ValueType="System.String">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(); }" />

                                </dx:ASPxComboBox>
                            </td>
                            <td>
                                <label for=''>
                                    ฤดู:
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbSeason" runat="server" ClientInstanceName="cmbSeason" ValueType="System.String">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(); }" />
                                </dx:ASPxComboBox>
                            </td>
                            <td>
                                <label for=''>
                                    ปี:
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbYear" runat="server" ClientInstanceName="cmbYear" ValueType="System.String">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(); }" />
                                </dx:ASPxComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <label for=''>
                                    ประเภทเงิน:
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbMoneyType" runat="server" ClientInstanceName="cmbMoneyType" ValueType="System.String">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { SetSeedIdBySelected(); }" />
                                </dx:ASPxComboBox>
                            </td>
                            <td>
                                <label for=''>
                                    ล็อตที่:
                                </label>
                            </td>
                            <td>
                                <dx:ASPxTextBox ID="txtLotNo" ClientInstanceName="txtLotNo" MaxLength="3" runat="server" Width="170px" Text="XXX">
                                    <ClientSideEvents LostFocus="function(s,e) {SetSeedIdBySelected();}" />
                                </dx:ASPxTextBox>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                    <hr />
                </div>
                <div style="margin-left: 5px; padding: 5px;">
                    <table>
                        <tr >
                            <td>
                                <label>
                                    ศูนย์ :
                                </label>
                            </td>
                            <td>
                                <dx:ASPxComboBox ID="cmbSite" runat="server" ValueType="System.String"></dx:ASPxComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>
                                    วันที่จำหน่าย :
                                </label>
                            </td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <dx:ASPxDateEdit ID="dpkStartDate" runat="server"></dx:ASPxDateEdit>
                                        </td>
                                        <td>
                                            <label>
                                                &nbsp;ถึง&nbsp;</label>
                                        </td>
                                        <td>
                                            <dx:ASPxDateEdit ID="dpkEndDate" runat="server"></dx:ASPxDateEdit>
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
                        <dx:GridViewDataTextColumn Caption="ชื่อร้าน" FieldName="OrgName" VisibleIndex="1" Name="OrgName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ทะเบียนตัวแทน" FieldName="AgentNo" VisibleIndex="2" Name="AgentNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="เลขที่จำหน่าย" FieldName="SaleNo" VisibleIndex="3" Name="SaleNo">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="พืช" FieldName="PlantName" VisibleIndex="4" Name="PlantName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="พันธุ์" FieldName="SeedName" VisibleIndex="5" Name="SeedName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ฤดู" FieldName="SeasonName" VisibleIndex="7" Name="SeasonName">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="ปี" FieldName="SeedYear" VisibleIndex="8" Name="SeedYear">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="น้ำหนัก (กก.)" FieldName="Quantity" VisibleIndex="9" Name="Quantity">
                            <PropertiesTextEdit DisplayFormatString="N0">
                            </PropertiesTextEdit>
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn Caption="จำหน่ายส่วนลด(%)" FieldName="DiscountPercentage" VisibleIndex="10" Name="DiscountPercentage">
                            <HeaderStyle HorizontalAlign="Center" Font-Bold="true" />
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager PageSize="20">
                        <PageSizeItemSettings Visible="True">
                        </PageSizeItemSettings>
                    </SettingsPager>
                    <Settings ShowFooter="True" />
                    <TotalSummary>
                        <%--<dx:ASPxSummaryItem FieldName="Bags" ShowInColumn="Bags" SummaryType="Sum" DisplayFormat="<b>{0:N0}</b>"  />--%>
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

