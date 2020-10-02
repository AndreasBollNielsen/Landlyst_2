using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Landlyst_2.Model
{
    public class Room
    {
        // private fields
        private Client customer;
        DateTime dateBooked;
        float price;
        string checkinDate;
        string checkOutDate;
        bool minibar;
        bool aircondition;
        bool pet;
        bool golf;
        RoomType.Type roomtype;

        // properties
        public Client Customer { get => customer; set => customer = value; }
        public DateTime DateBooked { get => dateBooked; set => dateBooked = value; }
        public float Price { get => price; set => price = value; }
        public string CheckinDate { get => checkinDate; set => checkinDate = value; }
        public string CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public bool Minibar { get => minibar; set => minibar = value; }
        public bool Aircondition { get => aircondition; set => aircondition = value; }
        public bool Pet { get => pet; set => pet = value; }
        public bool Golf { get => golf; set => golf = value; }
        public RoomType.Type Roomtype { get => roomtype; set => roomtype = value; }

        //constructor
        public Room()
        {
            customer = Customer;
            dateBooked = DateBooked;
            price = Price;
            checkinDate = CheckinDate;
            checkOutDate = CheckOutDate;
            minibar = Minibar;
            aircondition = Aircondition;
            pet = Pet;
            roomtype = Roomtype;
        }
    }
}