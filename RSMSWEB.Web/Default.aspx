<%@ Page Language="VB" AutoEventWireup="true" Inherits="Default" EnableViewState="false"
    ValidateRequest="false" CodeBehind="Default.aspx.vb" Culture="th-TH" UICulture="th-TH" %>

<%@ Register Assembly="DevExpress.ExpressApp.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.ExpressApp.Web.Templates" TagPrefix="cc3" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.ExpressApp.Web.Controls" TagPrefix="cc4" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Main Page</title>
    <meta http-equiv="Expires" content="0" />
    <script src="/Scripts/jquery/jquery.js" type="text/javascript"></script>
    <script id="dxss_xx" type="text/javascript">

        $.getScript("Scripts/1_27.js")
        .done(function (script, textStatus) {
                console.log(textStatus);
                //console.log(script);
        })

    </script>
    <style type="text/css">
        #LPcell {
            width: 265px!important;
        }

        #Vertical_NC_NB {
            width: 265px!important;
        }

        #Vertical_NC {
            width: 265px!important;
        }

        .Layout {
            padding-left: 0px!important;
        }

        .dxrpcontent {
            padding: 0px!important;
        }
    </style>
</head>
<body class="VerticalTemplate">
    <form id="form2" runat="server">
        <cc3:XafUpdatePanel ID="UPPopupWindowControl" runat="server">
            <cc4:XafPopupWindowControl runat="server" ID="PopupWindowControl" />
        </cc3:XafUpdatePanel>
        <cc4:ASPxProgressControl ID="ProgressControl" runat="server" />
        <div runat="server" id="Content" />
    </form>
</body>
</html>
