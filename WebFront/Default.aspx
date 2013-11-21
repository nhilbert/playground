<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFront.Default" %>

<asp:Content ID="DinoContent" ContentPlaceHolderID="Main" Runat="Server">

    Dinosaurier müssen migriert werden!<br />
<br />
Status:
<asp:Label ID="MigrationStatus" runat="server" Text="MigStatus"></asp:Label>
<br />
<br />
<asp:Button ID="ContinueButton" runat="server" OnClick="MigrationButtonClick" Text="Migriere!" />
&nbsp;
</asp:Content>
