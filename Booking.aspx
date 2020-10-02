<%@ Page Title="Booking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Landlyst_2.Booking" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Begynd din ferie her</h3>
    
    <form id="bookingInformation">
        <h4>Vælg dit værelse</h4>
        <input type="radio" id="singleRoom" name="room" runat="server"/>
        <label for="singleRoom">Enkeltværelse</label><br />
        <input type="radio" id="doubleRoom" name="room" runat="server"  />
        <label for="doubleRoom">Dobbelt værelse</label><br />
        <input type="radio" id="doubleLuxusRoom" name="room" runat="server"/>
        <label for="doubleLuxusRoom">Dobbel Luxus værelse</label><br />
        <input type="radio" id="suite" name="room" runat="server" />
        <label for="suite">Suite</label> <br />

        <label for="startDate">Vælg Ankomst dag</label><br />
        <input type="date" id="startDate" name="startDate" runat="server" /> <br />
        <label for="endDate">Vælg afrejse dag</label><br />
        <input type="date" id="endDate" name="endDate" runat="server"/>

        <h4>Tilvalg</h4>
        <input type="checkbox" id="golf" name="adds" runat="server"/>
        <label for="adds">All-in-one ( <a href="#">golf tilbud læs mere her</a>)</label><br />
        <input type="checkbox" id="minibar" name="adds" runat="server" />
        <label for="adds">Minibar</label><br />
        <input type="checkbox" id="aircondition" name="adds" runat="server"/>
        <label for="adds">Aircondition</label><br />
        <input type="checkbox" id="pet" name="adds"  runat="server"/>
        <label for="adds">Kæledyr</label><br />
    </form>

  
    <form id="personInformation">
     <h4>Om dig</h4>
        <label for="firstName">For navn</label><br />
        <input type="text" id="firstName" name="firstName" runat="server" /><br />
        <label for="lastName">Efter navn</label><br />
        <input type="text" id="lastName" name="lastName" runat="server"/><br />
        <label for="address">Adresse</label><br />
        <input type="text" id="address" name="address" runat="server" /> <br />
        <label for="zip">Postnummer</label><br />
        <input type="number" id="zip" name="zip" runat="server" /><br />
        <label for="city">By</label><br />
        <input type="text" id="city" name="city" runat="server" /><br />
        <label for="phone">Telefon nummer</label><br />
        <input type="number" id="phone" name="phone" runat="server" /><br />
        <label for="mail">E-Mail</label><br />
        <input type="email" id="mail" name="mail" runat="server" /><br />
        <label for="comment">Eventuel kommentar til din booking</label><br />
        <input type="text" id="comment" name="comment" runat="server" /><br />
        <input type="checkbox" id="acceptConditions" name="acceptConditions" runat="server" />
        <label for="acceptConditions"><a href="#">Accepter vores handelsbetingelser og privatlivs politik</a></label>


    </form>
    

</asp:Content>
