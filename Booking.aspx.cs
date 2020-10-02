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
            singleRoom.con
        }

        
    }
}