<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Test1zx.ascx.vb" Inherits=".Test1zx" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px"></dx:ASPxTextBox>
<dx:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="false" Text="ASPxButton">
    <ClientSideEvents Click="function(s,e){
        CallBack1.PerformCallback('');
        }" />
</dx:ASPxButton>
<input type="button" onclick="CallBack1.PerformCallback('#ShortcutViewID=test1');" value="Click" />
<dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="ASPxLabel"></dx:ASPxLabel>

<dx:ASPxCallback ID="CallBack1" runat="server" ClientInstanceName="CallBack1">
</dx:ASPxCallback>
