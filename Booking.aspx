<%@ Page Title="Booking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Landlyst_2.Booking" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Begynd din ferie her</h3>
    
    <form id="bookingInformation">
        <h4>Vælg dit værelse</h4>
        <input type="radio" id="singleRoom" name="room"/>
        <label for="singleRoom">Enkeltværelse</label><br />
        <input type="radio" id="doubleRoom" name="room" />
        <label for="doubleRoom">Dobbelt værelse</label><br />
        <input type="radio" id="doubleLuxusRoom" name="room" />
        <label for="doubleLuxusRoom">Dobbel Luxus værelse</label><br />
        <input type="radio" id="suite" name="room" />
        <label for="suite">Suite</label> <br />

        <label for="startDate">Vælg Ankomst dag</label><br />
        <input type="date" id="startDate" name="startDate" /> <br />
        <label for="endDate">Vælg afrejse dag</label><br />
        <input type="date" id="endDate" name="endDate" />

        <h4>Tilvalg</h4>
        <input type="checkbox" id="golf" name="adds"/>
        <label for="adds">All-in-one ( <a href="#">golf tilbud læs mere her</a>)</label><br />
        <input type="checkbox" id="minibar" name="adds" />
        <label for="adds">Minibar</label><br />
        <input type="checkbox" id="aircondition" name="adds" />
        <label for="adds">Aircondition</label><br />
        <input type="checkbox" id="pet" name="adds" />
        <label for="adds">Kæledyr</label><br />
    </form>

    <form id="personInformation">
        <label for="firstName">For navn</label><br />
        <input type="text" id="firstName" name="firstName" /><br />
        <label for="lastName">Efter navn</label><br />
        <input type="text" id="lastName" name="lastName" /><br />




    </form>
    

</asp:Content>
