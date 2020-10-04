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
            Debug.WriteLine("manager created");

        }



        //select room type & 
        protected void chooseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.BookedRoom.Roomtype = (RoomType.Type)chooseRoom.SelectedIndex;

            //enable/disable extra options
            if (manager.BookedRoom.Roomtype == RoomType.Type.singleRoom)
            {
                Disableoptions(true, false, true, false);
                SetOptions(false, true, false, false);
            }
            else if (manager.BookedRoom.Roomtype == RoomType.Type.DoubleRoom)
            {
                Disableoptions(true, false, true, false);
                SetOptions(false, true, false, false);
            }
            else if (manager.BookedRoom.Roomtype == RoomType.Type.LuxuryRoom)
            {
                Disableoptions(true, false, false, false);
                SetOptions(false, true, true, false);
            }
            else if (manager.BookedRoom.Roomtype == RoomType.Type.Suite)
            {
                Disableoptions(true, false, false, true);
                SetOptions(false, true, true, false);
            }
        }

        //update room options data
        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            manager.BookedRoom.Golf = CheckBoxList1.Items[0].Selected;
            manager.BookedRoom.Minibar = CheckBoxList1.Items[1].Selected;
            manager.BookedRoom.Aircondition = CheckBoxList1.Items[2].Selected;
            manager.BookedRoom.Pet = CheckBoxList1.Items[3].Selected;
            UpdatePrice();
        }

        //disable user input for extra options
        private void Disableoptions(bool golf, bool minibar, bool aircondition, bool pet)
        {
            // set all in one
            CheckBoxList1.Items[0].Enabled = golf;
            // set minibar
            CheckBoxList1.Items[1].Enabled = minibar;
            //set aircondition
            CheckBoxList1.Items[2].Enabled = aircondition;
            // set pet
            CheckBoxList1.Items[3].Enabled = pet;
        }

        /// <summary>
        /// set extra options in gui
        /// </summary>
        /// <param name="golf">enable golf option</param>
        /// <param name="minibar">enable the minibar</param>
        /// <param name="aircondition">enable aircondition</param>
        /// <param name="pet">enable pet option</param>
        private void SetOptions(bool golf, bool minibar, bool aircondition, bool pet)
        {
            // set all in one
            CheckBoxList1.Items[0].Selected = golf;
            // set minibar
            CheckBoxList1.Items[1].Selected = minibar;
            //set aircondition
            CheckBoxList1.Items[2].Selected = aircondition;
            // set pet
            CheckBoxList1.Items[3].Selected = pet;

            //run method that updates the price
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            Debug.WriteLine("price updated");
        }
        private void updateCustomer()
        {
            Debug.WriteLine($"first name {manager.Customer.Firstname}\n" +
                $"last name {manager.Customer.Lastname}\n" +
                $"address {manager.Customer.Address}\n" +
                $"zipcode {manager.Customer.Zipcode}\n" +
                $"city {manager.Customer.City}\n" +
                $"email {manager.Customer.Email}\n" +
                $"phone {manager.Customer.Phone}\n" +
                $"arrival date {manager.BookedRoom.CheckinDate} departure date {manager.BookedRoom.CheckOutDate}");
        }

        protected void starteDate_SelectionChanged(object sender, EventArgs e)
        {
            manager.BookedRoom.CheckinDate = starteDate.SelectedDate.ToString();

        }

        protected void endDate_SelectionChanged(object sender, EventArgs e)
        {
            manager.BookedRoom.CheckOutDate = endDate.SelectedDate.ToString();

        }

        protected void Click_submit(object sender, EventArgs e)
        {
            manager = new BookingManager();
            manager.CreateRoom();
            manager.BookedRoom.CheckinDate = starteDate.SelectedDate.ToString();
            manager.BookedRoom.CheckOutDate = endDate.SelectedDate.ToString();


            manager.Customer.Firstname = firstname.Text;
            manager.Customer.Lastname = lastname.Text;
            manager.Customer.Address = address.Text;
            manager.Customer.Phone = int.Parse(phone.Text);
            manager.Customer.Zipcode = int.Parse(zipCode.Text);
            manager.Customer.City = city.Text;
            manager.Customer.Email = email.Text;
            updateCustomer();
        }
    }
}