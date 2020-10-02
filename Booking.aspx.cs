using Landlyst_2.Model;
using System;
using System.Collections.Generic;
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




           
        }


    }
}