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
        public RoomType.Type CurrentType;

        public int RoomID;
        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new BookingManager();
            manager.CreateRoom();
            Debug.WriteLine("manager created");

        }

        //select room type & set room number
        protected void chooseRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentType = (RoomType.Type)chooseRoom.SelectedIndex + 1;
            Debug.WriteLine("selected index " + chooseRoom.SelectedIndex);
            int currentAddId = 1;
           
            //enable/disable extra options
            if (CurrentType == RoomType.Type.singleRoom)
            {
                RoomNumber.Text = "1";
                Enableoptions(true, false, true, false);
                SetOptions(false, true, false, false);
               
                //check if aircondition is enabled for single room
                if (RoomOptions.Items[2].Selected)
                {
                    RoomNumber.Text = "2";
                    currentAddId = 3;
                }
                else if (RoomOptions.Items[0].Selected)
                {
                    currentAddId = 1;
                }
                currentAddId = 2;
            }
            else if (CurrentType == RoomType.Type.DoubleRoom)
            {
                RoomNumber.Text = "3";
                Enableoptions(true, false, true, false);
                SetOptions(false, true, false, false);
                currentAddId = 2;
            }
            else if (CurrentType == RoomType.Type.LuxuryRoom)
            {
                RoomNumber.Text = "4";
                Enableoptions(false, false, false, false);
                SetOptions(false, true, true, false);
                currentAddId = 5;
            }
            else if (CurrentType == RoomType.Type.Suite)
            {
                RoomNumber.Text = "5";
                Enableoptions(false, false, false, true);
                SetOptions(false, true, true, false);

                currentAddId = 5;
            }

            UpdatePrice(currentAddId);
        }

        //update room options data
        protected void RoomOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            CheckBoxList1.Items[0].Selected = Golf
            CheckBoxList1.Items[1].Selected = minibar
            CheckBoxList1.Items[2].Selected = aircondition
            CheckBoxList1.Items[3].Selected = pet
            */

            //update price when checkboxes are changed
            if (RoomOptions.Items[2].Selected)
            {
                //update price with aircondition
                CurrentType = (RoomType.Type)chooseRoom.SelectedIndex + 1;
                UpdatePrice(3);
            }
            else if (!RoomOptions.Items[2].Selected)
            {
                //update price without aircondition
                CurrentType = (RoomType.Type)chooseRoom.SelectedIndex + 1;
                UpdatePrice(2);
            }

            //update price for suite
            if (RoomOptions.Items[3].Selected)
            {
                //update price when pet is enabled
                CurrentType = (RoomType.Type)chooseRoom.SelectedIndex + 1;
                UpdatePrice(4);
            }
            else if (!RoomOptions.Items[3].Selected)
            {
                //update price when pet is disabled
                CurrentType = (RoomType.Type)chooseRoom.SelectedIndex + 1;
                UpdatePrice(5);
            }

        }

        //disable user input for extra options
        private void Enableoptions(bool golf, bool minibar, bool aircondition, bool pet)
        {
            // set all in one
            RoomOptions.Items[0].Enabled = golf;
            // set minibar
            RoomOptions.Items[1].Enabled = minibar;
            //set aircondition
            RoomOptions.Items[2].Enabled = aircondition;
            // set pet
            RoomOptions.Items[3].Enabled = pet;
        }

        /// set extra options in gui
        private void SetOptions(bool golf, bool minibar, bool aircondition, bool pet)
        {
            // set all in one
            RoomOptions.Items[0].Selected = golf;
            // set minibar
            RoomOptions.Items[1].Selected = minibar;
            //set aircondition
            RoomOptions.Items[2].Selected = aircondition;
            // set pet
            RoomOptions.Items[3].Selected = pet;

        }

        

        //update price on website
        private void UpdatePrice(int addid)
        {
            manager = new BookingManager();
            manager.CurrentType = (int)CurrentType;
            manager.CurrentAddId = addid;
            int price = manager.Roomprice();
            string outputprice = price.ToString() + " kr";
            //check discount
            if(manager.CurrentType == 3)
            {
                DateTime arrivalDate = starteDate.SelectedDate;
                DateTime departureDate = endDate.SelectedDate;
                double totaldays = (departureDate - arrivalDate).TotalDays;
               if(totaldays > 5)
                {
                    double discount = price / 100 * 20;
                    price = price - (int)discount;
                    outputprice = price.ToString() + $" discount({discount}) kr";
                }
            }


            Price.Text = outputprice;
        }

        // click submit to create the booking
        protected void Click_submit(object sender, EventArgs e)
        {
            manager = new BookingManager();
            manager.CreateRoom();
            manager.BookedRoom.Roomtype = (RoomType.Type)chooseRoom.SelectedIndex;
            manager.BookedRoom.RoomId = int.Parse(RoomNumber.Text);
            manager.BookedRoom.CheckinDate = starteDate.SelectedDate.ToString();
            manager.BookedRoom.CheckOutDate = endDate.SelectedDate.ToString();

            Debug.WriteLine(manager.BookedRoom.RoomId);
            manager.Customer.Firstname = firstname.Text;
            manager.Customer.Lastname = lastname.Text;
            manager.Customer.Address = address.Text;
            manager.Customer.Phone = int.Parse(phone.Text);
            manager.Customer.Zipcode = int.Parse(zipCode.Text);
            manager.Customer.City = city.Text;
            manager.Customer.Email = email.Text;
            bool booked = manager.CreateReservation();
            Debug.WriteLine($"is the room booked: {booked}");

        }

        //update price when dates change
        protected void Date_SelectionChanged(object sender, EventArgs e)
        {
            if(chooseRoom.SelectedIndex > 0)
            {
                chooseRoom_SelectedIndexChanged(sender, e);
            }
            
        }
    }
}