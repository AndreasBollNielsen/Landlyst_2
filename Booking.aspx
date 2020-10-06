<%@ Page Title="Booking" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Landlyst_2.Booking" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Begynd din ferie her</h3>

    <div class="booking">
    <form>
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
    </div>

    <div class="person">
    <form class="person">
     <h4>Om dig</h4>

        <asp:Label for="firstname" runat="server" Text="Fornavn"></asp:Label><br />
        <asp:TextBox ID="firstname" runat="server"></asp:TextBox><br />
        <asp:Label for="lastname" runat="server" Text="Efternavn"></asp:Label><br />
        <asp:TextBox ID="lastname" runat="server"></asp:TextBox><br />
        <asp:Label for="address" runat="server" Text="Adresse"></asp:Label><br />
        <asp:TextBox ID="address" runat="server"></asp:TextBox><br />
        <asp:Label for="zipCode" runat="server" Text="Post nummer"></asp:Label><br />
        <asp:TextBox type="number" ID="zipCode" runat="server"></asp:TextBox><br />
        <asp:Label for="city" runat="server" Text="By"></asp:Label><br />
        <asp:TextBox ID="city" runat="server"></asp:TextBox><br />
        <asp:Label for="email" runat="server" Text="E-Mail"></asp:Label><br />
        <asp:TextBox ID="email" runat="server"></asp:TextBox><br />
        <asp:Label for="phone" runat="server" Text="Telefon nummer"></asp:Label><br />
        <asp:TextBox type="number" ID="phone" runat="server"></asp:TextBox><br />
        <asp:Label for="comment" runat="server" Text="Øvrige commentar"></asp:Label><br />
        <asp:TextBox ID="comment" runat="server"></asp:TextBox><br />

        <asp:CheckBox ID="accept" runat="server" />
        <asp:Label for="accept" runat="server" Text=""><a href="#">Accepter handelsbetingelser og privatlivs politik</a></asp:Label>



    </form>
    

</asp:Content>
