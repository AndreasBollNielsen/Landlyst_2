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
        public Client Customer;
        public int CurrentType = 1;
        public int CurrentAddId = 1;
        // method to create a room and fill it with data
        public void CreateRoom()
        {
            BookedRoom = new Room();
            Customer = new Client();
            BookedRoom.Customer = Customer;
        }



        // executes the booking with the data from room object. Using stored Procedure to add data into database
        public bool CreateReservation()
        {
            SqlConnection con = new SqlConnection("data source = (local); initial catalog =Landlyst; integrated security = sspi");

            if (BookedRoom != null)
            {
                //run stored procedure for customers
                con.Open();
                SqlCommand cmd = new SqlCommand("CreateCustomer", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = Customer.Firstname;
                cmd.Parameters.Add("@lastname", SqlDbType.VarChar).Value = Customer.Lastname;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = Customer.Address;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = Customer.Email;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = Customer.Phone;
                cmd.Parameters.Add("@zipcode", SqlDbType.Int).Value = Customer.Zipcode;
                cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = Customer.City;
                cmd.Parameters.Add("@customerid", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.Parameters["@customerid"].Value.ToString());

                //run stored procedure for reservation
                cmd = new SqlCommand("CreateReservation", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@customerid", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@startdate", SqlDbType.VarChar).Value = BookedRoom.CheckinDate;
                cmd.Parameters.Add("@enddate", SqlDbType.VarChar).Value = BookedRoom.CheckOutDate;
                cmd.Parameters.Add("@roomid", SqlDbType.Int).Value = BookedRoom.RoomId;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                //add warning that nothing has been filled out
                Debug.WriteLine("please fill out all information to proceed booking");
                return false;
            }
        }

        //get booking price for room type
        public int Roomprice()
        {
            SqlConnection con = new SqlConnection("data source = (local); initial catalog =Landlyst; integrated security = sspi");
            Debug.WriteLine("current type " + CurrentType);
            Debug.WriteLine("current addid " + CurrentAddId);
            //run stored procedure that retrieves price on room
            con.Open();
            SqlCommand cmd = new SqlCommand("GetPrice", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@roomprice", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@ekstraprice", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@roomtypeid", SqlDbType.Int).Value = CurrentType;
            cmd.Parameters.Add("@addid", SqlDbType.Int).Value = CurrentAddId;
            cmd.ExecuteNonQuery();
            int roomprice = int.Parse(cmd.Parameters["@roomprice"].Value.ToString());
            int addprice = int.Parse(cmd.Parameters["@ekstraprice"].Value.ToString());

            

            Debug.WriteLine(roomprice);
            Debug.WriteLine(addprice);

            int sumprice = roomprice + addprice;




            con.Close();
            return sumprice;

            //if (BookedRoom != null)
            //{

            //}
            //else
            //{
            //    //add warning that nothing has been filled out
            //    Debug.WriteLine("please fill out all information to proceed booking");
            //    return 0;
            //}
        }
    }
}