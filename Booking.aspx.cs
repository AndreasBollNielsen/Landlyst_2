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

            
        }

        protected void chooseRoom_Event(object sender, EventArgs e)
        {
            Debug.WriteLine(sender.ToString());
            string text = chooseRoom.SelectedValue;
            Debug.WriteLine("hej");
        }

        protected void chooseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("changed");
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}