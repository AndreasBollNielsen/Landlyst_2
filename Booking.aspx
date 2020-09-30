<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="Landlyst_2.Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h1>Book en Reservation</h1>

    <h2>Værelses type</h2>
    <select name="Choice">
        <option value= 1>Enkelt værelse</option>
        <option value=2>Standard dobbelt værelse</option>
        <option value=3>Luksus dobbelt værelse</option>
        <option value=>Suite</option>
    </select>
    <input type="text" name="numrooms" value="" />


    <%--<form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
</body>
</html>
