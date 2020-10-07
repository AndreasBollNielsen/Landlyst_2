<%@ Page Title="Kontakt" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Landlyst_2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Skriv til os</h3>
    <div class="contactForm">

        <asp:Label for="name" runat="server" Text="Navn"></asp:Label><br />
        <asp:TextBox ID="name" runat="server" Width="152px"></asp:TextBox>
        <br />
        <br />
        <asp:Label for="mail" runat="server" Text="Mail"></asp:Label><br />
        <asp:TextBox type="email" ID="mail" runat="server" Width="330px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Label for="message" runat="server" Text="Din besked"></asp:Label><br />
        <asp:TextBox ID="message" runat="server" Height="170px" Width="330px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="submit" runat="server" Text="Send" />
    </div>
</asp:Content>
