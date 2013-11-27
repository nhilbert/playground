<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DinosaurCard.ascx.cs" Inherits="Playground.WebFront.DinosaurCard" %>
<link href="Master.css" rel="stylesheet" />

<div id="DinoCard" class="DinoCardDiv">
<asp:Image ID="DinoImage" runat="server" CssClass="DinoImage" />
<br />
<asp:Label ID="DinoName" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="MigrateButton" runat="server" CausesValidation="False" OnClick="Button1_Click" Text="Migrieren!" />
</div>


