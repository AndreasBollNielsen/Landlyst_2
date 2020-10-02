<%@ Page Title="Booking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Landlyst_2.Booking" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Begynd din ferie her</h3>
    
    
    <form>
        <label for="singleRoom">Enkeltværelse</label>
        <input type="radio" id="singleRoom" name="room"/>

        <label for="doubleRoom">Dobbelt værelse</label>
        <input type="radio" id="doubleRoom" name="room" />

        <label for="doubleLuxusRoom">Dobbel Luxus værelse</label>
        <input type="radio" id="doubleLuxusRoom" name="room" />

    </form>


    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
