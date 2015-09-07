<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="jQuerTest.ascx.vb" Inherits=".jQuerTest" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<script src="/Scripts/jquery/jquery.js" type="text/javascript"></script>
<script type="text/javascript">
    $(function () {
        $('#div1').click(function () {
            alert('');
        });
    });

</script>
<div id="div1">
    Test div click
</div>
<dx:ASPxRoundPanel ID="ASPxRoundPanel1" ShowHeader="true" EnableAnimation="true" AllowCollapsingByHeaderClick="true"  ClientInstanceName="roundPanel" HeaderText="ASP.NET WebForms" runat="server" Width="270">
    <PanelCollection>
        <dx:PanelContent>
            <h4>95+ ASP.NET Controls</h4>
            <br />
            The controls that ship as part of the DevExpress ASP.NET Subscription help you create engaging,
                        interactive and touch-enabled web experiences that emulate
                        the capabilities of today’s most popular web applications and
                        maintain the highest performance standards regardless of the demands placed upon
                        your web application by your end-users.
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxRoundPanel>
