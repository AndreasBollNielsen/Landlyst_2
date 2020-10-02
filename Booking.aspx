<%@ Page Title="Booking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Landlyst_2.Booking" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Begynd din ferie her</h3>
    <form class="booking">
        <h4>Vælg dit værelse</h4>
        <asp:RadioButtonList ID="chooseRoom" runat="server" AutoPostBack="true" OnSelectedIndexChanged ="chooseRoom_SelectedIndexChanged">
            <asp:ListItem> Enkelt værelse</asp:ListItem>
            <asp:ListItem> Dobbelt værelse</asp:ListItem>
            <asp:ListItem> Dobbelt Luxus Værelse</asp:ListItem>
            <asp:ListItem> Suite</asp:ListItem>
        </asp:RadioButtonList>
        <label for="startDate">Vælg Ankomst dag</label><br />
        <asp:Calendar ID="starteDate" runat="server"></asp:Calendar>
        <label for="endDate">Vælg afrejse dag</label><br />
        <asp:Calendar ID="endDate" runat="server"></asp:Calendar>
       
        <h4>Tilvalg</h4>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged ="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem> All-in-one (<a href="#">golf tilbud læs mere her</a>) </asp:ListItem>
            <asp:ListItem> Minibar</asp:ListItem>
            <asp:ListItem> Aircondition</asp:ListItem>
            <asp:ListItem> K&#230;ledyr</asp:ListItem>
        </asp:CheckBoxList>
    </form>

  
    <form class="booking">
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
