using Landlyst_2.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Landlyst_2
{
    public partial class Booking : System.Web.UI.Page
    {
        public BookingManager manager;
        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new BookingManager();
            manager.CreateRoom();

           
            //update selected room
            if(singleRoom.Checked)
            {
                manager.BookedRoom.Roomtype = RoomType.Type.singleRoom;
            }
            else if(doubleRoom.Checked)
            {
                manager.BookedRoom.Roomtype = RoomType.Type.DoubleRoom;
            }
            else if (doubleLuxusRoom.Checked)
            {
                manager.BookedRoom.Roomtype = RoomType.Type.LuxuryRoom;
            }
            else if (suite.Checked)
            {
                manager.BookedRoom.Roomtype = RoomType.Type.Suite;
            }


            //update arrivel/departure dates
            string arrival = startDate.Value;
            string departure = endDate.Value;
            if(arrival != " " || departure !=" ")
            {
                Debug.WriteLine(arrival);
                DateTime Arrivaldate = new DateTime();
                DateTime Departuredate = new DateTime();
               
                Departuredate.AddDays(2);
                if (Departuredate > Arrivaldate)
                {
                    //add dates to manager
                    Debug.WriteLine($"arrival date{Arrivaldate} departure date{Departuredate}");
                }
                else
                {
                    // give error
                    Debug.WriteLine("departure date is wrong");
                    Debug.WriteLine($"arrival date{Arrivaldate} departure date{Departuredate}");
                }
            }
            

            //update extra commodities
            if(golf.Checked)
            {
                manager.BookedRoom.Golf = true;
            }
            else if(minibar.Checked)
            {
                manager.BookedRoom.Minibar = true;
            }
            else if(aircondition.Checked)
            {
                manager.BookedRoom.Aircondition = true;
            }
            else if(pet.Checked)
            {
                manager.BookedRoom.Pet = true;
            }

        }

        
    }
}