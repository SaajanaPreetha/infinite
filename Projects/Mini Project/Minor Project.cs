using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationMinorProject
{
    class Program
    {
        static RailwayReservationMiniProjectEntities1 db = new RailwayReservationMiniProjectEntities1();
        static Train tr = new Train();
        static Class_Details cd = new Class_Details();

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO RAILWAY RESERVATION SYSTEM");

            while (true)
            {

                Console.WriteLine("Click  1 for Admin Login");
                Console.WriteLine("Click 2 for User Login");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        AdminLogin();
                        break;
                    case 2:
                        UserLogin();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }


        static void AdminLogin()
        {
            Console.WriteLine("Admin Login");
            Console.Write("Enter Admin Name: ");
            string Admin_Name = Console.ReadLine();
            Console.Write("Enter Password: ");

            String Admin_Password_Input = Console.ReadLine();

            

            int Admin_Password;
            if (int.TryParse(Admin_Password_Input, out Admin_Password))
            {
                Console.WriteLine("Welcome to the admin page");

                if (Admin_Name == "Saajana" && Admin_Password == 2601)
                {

                    Console.WriteLine("Click 1 to add train details");
                    Console.WriteLine("Click 2 to update train details");
                    Console.WriteLine("Click 3 to delete train details");
                    Console.WriteLine("Click 4 to book on behalf of passengers");
                    Console.WriteLine("Click 5 to cancel booked tickets");
                    Console.WriteLine("Click 6 to display details of all the ongoing trains");
                    Console.WriteLine("Click 7 to display details about all the current bookings");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Kindly update new train details");
                            AddTrain();
                            Console.WriteLine("New train details added to admin page");
                            Display_Train();
                            break;
                        case 2:
                            Console.WriteLine("Update any changes made to existing train working");
                            Display_Train();
                            Console.WriteLine("Details have been updated");
                            Update_Train();
                            break;
                        case 3:
                            Delete_Train();
                            Display_Train();
                            Console.WriteLine("Train details have been deleted successfully");
                            break;
                        case 4:
                            Booking_Ticket();
                            break;
                        case 5:
                            Cancel_train();
                            break;
                        case 6:
                            DisplayAllTrains();
                            break;
                        case 7:
                            DisplayAllOngoingBookings();
                            break;
                        default:
                            Console.WriteLine("Enter a valid number");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" Invalid credentials, try again later");
                }
            }
            else
            {
                Console.WriteLine(" Invalid password, try again later");
            }
        }


        
        static void UserLogin()
        {

            Console.WriteLine("Click 1 to Book Tickets");
            Console.WriteLine("Click 2 to display Tickets");
            Console.WriteLine("Click 3 to Cancel Tickets");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Display_Train();
                    Console.WriteLine();
                    BookingTicket();
                    break;
                case 2:
                    DisplayBooking_Details();
                    Console.WriteLine("Booking has been successfully done");
                    break;
                case 3:
                    DisplayAllBookings();
                    CancelTicket();
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }
            Console.WriteLine("User operations go here...");
            Console.WriteLine("Returning to main menu...");
            Console.WriteLine();
        }

        static void AddTrain()
        {

            Console.Write("Enter Train No.: ");
            tr.Train_No = int.Parse(Console.ReadLine());
            Console.Write("Enter Train Name: ");
            tr.Train_Name = Console.ReadLine();
            Console.Write("Enter From Station: ");
            tr.From_station = Console.ReadLine();
            Console.Write("Enter To Station: ");
            tr.To_Station = Console.ReadLine();
            tr.Status = "Active";
            db.Trains.Add(tr);
            db.SaveChanges();
            var classname = new string[] { "A1", "A2", "A3", "B1", "B2", "B3", "SL" };
            foreach (var ClassName in classname)
            {
                cd.Train_No = tr.Train_No;
                cd.Class_Name = ClassName;
                Console.Write($"Enter Total seats {ClassName} :");
                cd.Total_no_of_seats = int.Parse(Console.ReadLine());
                Console.Write("Available number of seats: ");
                cd.Available_no_of_seats = int.Parse(Console.ReadLine());
                Console.Write("Enter Price Amount: ");
                cd.Price = int.Parse(Console.ReadLine());

                db.Class_Details.Add(cd);
                db.SaveChanges();
                Console.WriteLine();
            }
        }


        static void Display_Train()
        {
            var trains = db.Trains.ToList();

            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("| Train No |    Train Name    |   From Station       |         To Station     | Status      |");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════════════");

            foreach (var tr in trains)
            {
                Console.WriteLine($"| {tr.Train_No,-20} | {tr.Train_Name,-20} | {tr.From_station,-20} | {tr.To_Station,-20} | {tr.Status,-8} |");
            }

            Console.WriteLine("═════════════════════════════════════════════════════════════════════════════════════════════");
        }

        public static void Update_Train()
        {
            Console.Write("Enter Train No.: ");
            int train_No = int.Parse(Console.ReadLine());

            var trainToUpdate = db.Trains.FirstOrDefault(t => t.Train_No == train_No);
            if (trainToUpdate != null)
            {
                Console.Write("Enter Train Name: ");
                trainToUpdate.Train_Name = Console.ReadLine();
                Console.Write("Enter towards Train Station: ");
                trainToUpdate.From_station = Console.ReadLine();
                Console.Write("Enter Train Destination Station: ");
                trainToUpdate.To_Station = Console.ReadLine();
                Console.Write("Enter Status: ");
                trainToUpdate.Status = Console.ReadLine();
                db.SaveChanges();
                Console.WriteLine("Updated Trains Successfully");

                Display_Train();
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Train do not exist ");
                AdminLogin();
            }
        }
        public static void Delete_Train()
        {
            Console.Write("Enter Train No: ");
            int train_No = int.Parse(Console.ReadLine());

            var trainToDelete = db.Trains.FirstOrDefault(t => t.Train_No == train_No);
            if (trainToDelete != null)
            {

                trainToDelete.Status = "InActive";
                db.SaveChanges();
                Console.WriteLine("Train information deleted successfully.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Train do not exist");
                AdminLogin();
            }
        }

        public static void Booking_Ticket()
        {
            try
            {
                Console.Write("Enter Train Number: ");
                int Train_No = Convert.ToInt32(Console.ReadLine());

                var train = db.Trains.FirstOrDefault(t => t.Train_No == Train_No && t.Status == "Active");
                if (train == null)
                {
                    Console.WriteLine("Sorry! This train is not running at this time");
                    return;
                }

                Console.Write("Enter Passenger Name: ");
                string Passenger_Name = Console.ReadLine();

                Console.Write("Enter Class Name: ");
                string Class_Name = Console.ReadLine();

                Console.Write("Enter Date of Travel (YYYY-MM-DD): ");
                DateTime Date_of_travel = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter Number of Tickets: ");
                int No_of_tickets = Convert.ToInt32(Console.ReadLine());

                db.BookTrainTicket(Train_No, Passenger_Name, Class_Name, Date_of_travel, No_of_tickets);
                db.SaveChanges();

                var booking = db.Bookings.OrderByDescending(b => b.Booking_ID).FirstOrDefault();
                if (booking != null)
                {
                    Console.WriteLine("Ticket Booked Successfully! Your Booking ID is: " + booking.Booking_ID);
                }
                else
                {
                    Console.WriteLine("Ticket Booked Successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void Cancel_train()
        {
            Console.Write("Enter Booking ID:");
            int Booking_ID = int.Parse(Console.ReadLine());

            var bookingToDelete = db.Bookings.FirstOrDefault(b => b.Booking_ID == Booking_ID);
            if (bookingToDelete != null)
            {
                Console.Write("Enter Passenger Name:");
                string Passenger_Name = Console.ReadLine();

                Console.Write("Enter Train Number:");
                int Train_No = int.Parse(Console.ReadLine());

                Console.Write("Enter Class Name:");
                string Class_Name = Console.ReadLine();

                Console.Write("Enter Number of Tickets to Cancel:");
                int No_of_tickets = int.Parse(Console.ReadLine());

                try
                {

                    db.CancelTicket(Booking_ID, Passenger_Name, Train_No, Class_Name, No_of_tickets);
                    db.SaveChanges();
                    Console.WriteLine("Ticket Cancelled Successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Booking not found with this Booking ID.");
            }

            private static void DisplayAllBookings()
        {
            throw new NotImplementedException();
        }

        static void displaytickeDisplayTicketClass_Detail()
        {

            Console.Write("Enter Train No.: ");
            tr.Train_No = int.Parse(Console.ReadLine());
            var trainVal = db.Class_Details.Where(t => t.Train_No == tr.Train_No).ToList();

            foreach (var Class_Details in trainVal)
            {
                Console.WriteLine($"Train_No: {Class_Details.Train_No}, Class_Name: {Class_Details.Class_Name}, Total_Seats: {Class_Details.Total_no_of_seats}, Available_Seats: {Class_Details.Available_no_of_seats}, Price: {Class_Details.Price}");
            }

        }


        public static void BookingTicket()
        {
            try
            {
                Console.Write("Enter Train Number: ");
                int Train_No = Convert.ToInt32(Console.ReadLine());

                var train = db.Trains.FirstOrDefault(t => t.Train_No == Train_No && t.Status == "Active");
                if (train == null)
                {
                    Console.WriteLine("Sorry! This train is not running at this time");
                    return;
                }

                Console.Write("Enter Passenger Name: ");
                string Passenger_Name = Console.ReadLine();

                Console.Write("Enter Class Name: ");
                string Class_Name = Console.ReadLine();

                Console.Write("Enter Date of Travel (YYYY-MM-DD): ");
                DateTime Date_of_travel = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter Number of Tickets: ");
                int No_of_tickets = Convert.ToInt32(Console.ReadLine());

                if (No_of_tickets >3) 
                {
                    Console.WriteLine("You can only book  a maximum of 3 tickets");
                }

                db.BookTrainTicket(Train_No, Passenger_Name, Class_Name, Date_of_travel, No_of_tickets);
                db.SaveChanges();

                var booking = db.Bookings.OrderByDescending(b => b.Booking_ID).FirstOrDefault();
                if (booking != null)
                {
                    Console.WriteLine("Ticket Booked Successfully! Your Booking ID is: " + booking.Booking_ID);
                }
                else
                {
                    Console.WriteLine("Ticket Booked Successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

       
        static void DisplayAllOngoingBookings()
        {
            var allBookings = db.Bookings.ToList();

            Console.WriteLine("All Bookings:");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Booking ID | Passenger Name       | Train No | Class Name | Date of travel| Number of tickets | Total Amount |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

            foreach (var booking in allBookings)
            {
                Console.WriteLine($"| {booking.Booking_ID,-11} | {booking.Passenger_Name,-20} | {booking.Train_No,-8} | {booking.Class_Name,-10} | {booking.Date_of_travel,-12:d} | {booking.No_of_tickets,-13} | {booking.Total_Amount,-13} |");
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
        }

        static void CancelTicket()
        {
            Console.Write("Enter Booking ID:");
            int Booking_ID = int.Parse(Console.ReadLine());

            var bookingToDelete = db.Bookings.FirstOrDefault(b => b.Booking_ID == Booking_ID);
            if (bookingToDelete != null)
            {
                Console.Write("Enter Passenger Name:");
                string Passenger_Name = Console.ReadLine();

                Console.Write("Enter Train Number:");
                int Train_No = int.Parse(Console.ReadLine());

                Console.Write("Enter Class Name:");
                string Class_Name = Console.ReadLine();

                Console.Write("Enter Number of Tickets to Cancel:");
                int No_of_tickets = int.Parse(Console.ReadLine());

                try
                {

                    db.CancelTicket(Booking_ID, Passenger_Name, Train_No, Class_Name, No_of_tickets);
                    db.SaveChanges();
                    Console.WriteLine("Ticket Cancelled Successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Booking not found with this Booking ID.");
            }
        }
        static void DisplayBooking_Details()
        {
            Console.Write("Enter Booking ID:");
            int Booking_ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Ticket");

            var booking = db.Bookings.FirstOrDefault(b => b.Booking_ID == Booking_ID);
            if (booking != null)
            {
                Console.WriteLine(" ╔══════════════════════════════════════════════╗");
                Console.WriteLine(" ║             BOOKING DETAILS                  ║");
                Console.WriteLine(" ╠══════════════════════════════════════════════╣");
                Console.WriteLine($"║ Booking ID: {booking.Booking_ID}             ║");
                Console.WriteLine($"║ Passenger Name: {booking.Passenger_Name}     ║");
                Console.WriteLine($"║ Train Number: {booking.Train_No}             ║");
                Console.WriteLine($"║ Class Name: {booking.Class_Name}             ║");
                Console.WriteLine($"║ Date of Travel: {booking.Date_of_travel}        ║");
                Console.WriteLine($"║ Number of Tickets: {booking.No_of_tickets}   ║");
                Console.WriteLine($"║ Total Amount: {booking.Total_Amount}         ║");
                Console.WriteLine($"║ Status: {booking.Status}                     ║");
                Console.WriteLine(" ╚══════════════════════════════════════════════╝");
            }
            else
            {
                Console.WriteLine("Booking not found.");
            }
        }
    }
}