using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Landlyst_2.Model
{
    public class BookingManager
    {
        public Room BookedRoom;
        // method to create a room and fill it with data
        public void CreateRoom()
        {
            BookedRoom = new Room();
        }

        // executes the booking with the data from room object. Using stored Procedure to add data into database
        public DataTable CreateReservation()
        {
            SqlConnection con = new SqlConnection("data source = (local); initial catalog =test; integrated security = sspi") ;
           
            if(BookedRoom != null)
            {
                //run stored procedure 
                con.Open();
                SqlCommand cmd = new SqlCommand("SelectAll", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                return table;
            }
            else
            {
                //add warning that nothing has been filled out
                Debug.WriteLine("please fill out all information to proceed booking");
                return null;
            }
        }
    }
}