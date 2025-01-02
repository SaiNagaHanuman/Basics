using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniProject_Train_Ticket_Bookings
{
    class Program
    {
        static string connectionString = ("Data Source=ICS-LT-D244D6BX;Initial Catalog=Train_Ticket_Booking;" +
                    "Integrated Security=true;");
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****************-----------Train Ticket Bookings----------------*****************");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Signup For User");
                Console.WriteLine("2. Login For User");
                Console.WriteLine("3. Admin");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Signup();
                        break;
                    case 2:
                        Login();
                        break;
                    case 3:
                        AdminMenu();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Option! Please try again.");
                        break;
                }
            }
        }

        //User Signup

        static void Signup()
        {
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (Username, Password) VALUES (@Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Signup successful as User!");
            }
        }

        //User Login

        static void Login()
        {
            Console.WriteLine();
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter User Password: ");
            string password = Console.ReadLine();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                var role = cmd.ExecuteScalar();
                if (role != null)
                {
                    Console.WriteLine($"Login successful as User");
                    UserMenu();
                }
                else
                {
                    Console.WriteLine($"Invalid username or password.");
                }
            }
        }

        //Admin

        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n------Admin Menu------");
                Console.WriteLine();
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. Modify Train");
                Console.WriteLine("3. Delete Train (Soft Delete)");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddTrains();
                        break;
                    case 2:
                        ModifyTrain();
                        break;
                    case 3:
                        DeleteTrain();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Option! Please try again.");
                        break;
                }
            }
        }

        // Add Trains

        static void AddTrains()
        {
            Console.Write("Enter Train Number: ");
            int trainNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Train Name: ");
            string trainName = Console.ReadLine();
            Console.Write("Enter Total First Class Berths: ");
            int firstClass = int.Parse(Console.ReadLine());
            Console.Write("Enter Total Second Class Berths: ");
            int secondClass = int.Parse(Console.ReadLine());
            Console.Write("Enter Total Sleeper Class Berths: ");
            int sleeperClass = int.Parse(Console.ReadLine());
            Console.Write("Enter Source Station: ");
            string source = Console.ReadLine();
            Console.Write("Enter Destination Station: ");
            string destination = Console.ReadLine();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddTrains", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                cmd.Parameters.AddWithValue("@TrainName", trainName);
                cmd.Parameters.AddWithValue("@FirstClassTotalBerths", firstClass);
                cmd.Parameters.AddWithValue("@SecondClassTotalBerths", secondClass);
                cmd.Parameters.AddWithValue("@sleeperClassTotalBerths", sleeperClass);
                cmd.Parameters.AddWithValue("@FirstClassAvailableBerths", firstClass);
                cmd.Parameters.AddWithValue("@SecondClassAvailableBerths", secondClass);
                cmd.Parameters.AddWithValue("@sleeperClassAvailableBerths", sleeperClass);
                cmd.Parameters.AddWithValue("@Source", source);
                cmd.Parameters.AddWithValue("@Destination", destination);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Train added successfully.");
            }
        }

        // Modify Train

        static void ModifyTrain()
        {
            Console.Write("Enter Train Number to Modify: ");
            int trainNo = int.Parse(Console.ReadLine());
            Console.Write("Enter New Train Name: ");
            string trainName = Console.ReadLine();
            Console.Write("Enter New Total First Class Berths: ");
            int firstClass = int.Parse(Console.ReadLine());
            Console.Write("Enter New Total Second Class Berths: ");
            int secondClass = int.Parse(Console.ReadLine());
            Console.Write("Enter New Total Sleeper Class Berths: ");
            int sleeperClass = int.Parse(Console.ReadLine());
            Console.Write("Enter New Source Station: ");
            string source = Console.ReadLine();
            Console.Write("Enter New Destination Station: ");
            string destination = Console.ReadLine();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ModifyTrain", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                cmd.Parameters.AddWithValue("@TrainName", trainName);
                cmd.Parameters.AddWithValue("@FirstClassTotalBerths", firstClass);
                cmd.Parameters.AddWithValue("@SecondClassTotalBerths", secondClass);
                cmd.Parameters.AddWithValue("@SleeperClassTotalBerths", sleeperClass);
                cmd.Parameters.AddWithValue("@FirstClassAvailableBerths", firstClass);
                cmd.Parameters.AddWithValue("@SecondClassAvailableBerths", secondClass);
                cmd.Parameters.AddWithValue("@SleeperClassAvailableBerths", sleeperClass);
                cmd.Parameters.AddWithValue("@Source", source);
                cmd.Parameters.AddWithValue("@Destination", destination);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Train modified successfully.");
            }
        }

        // Delete Train

        static void DeleteTrain()
        {
            Console.Write("Enter Train Number to Delete: ");
            int trainNo = int.Parse(Console.ReadLine());
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteTrain", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Train deleted successfully.");
            }
        }

        // User Menu

        static void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== User Menu ===");
                Console.WriteLine();
                Console.WriteLine("1. Book Tickets");
                Console.WriteLine("2. Cancel Tickets");
                Console.WriteLine("3. Show All Trains");
                Console.WriteLine("4. Show Bookings/Cancellations");
                Console.WriteLine("5. Exit to Main Menu");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        BookTickets();
                        break;
                    case "2":
                        CancelTickets();
                        break;
                    case "3":
                        ShowAllTrains();
                        break;
                    case "4":
                        Show_BookingsAndCancellations();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Book Tickets

        static void BookTickets()
        {
            Console.Write("Enter Train Number: ");
            int trainNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Class (First/Second/Sleeper): ");
            string trainClass = Console.ReadLine();
            Console.Write("Enter Number of Tickets: ");
            int tickets = int.Parse(Console.ReadLine());
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                bool isTrainActive = false;
                using (SqlCommand checkCmd = new SqlCommand("SELECT IsActive FROM Trains WHERE TrainNo = @TrainNo", conn))
                {
                    checkCmd.Parameters.AddWithValue("@TrainNo", trainNo);
                    object result = checkCmd.ExecuteScalar();
                    if (result != null && (bool)result)
                    {
                        isTrainActive = true;
                    }
                }
                if (!isTrainActive)
                {
                    Console.WriteLine("Tickets not booked: The train is inactive or does not exist.");
                    return;
                }
                using (SqlCommand cmd = new SqlCommand("BookTickets", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                    cmd.Parameters.AddWithValue("@Class", trainClass);
                    cmd.Parameters.AddWithValue("@Tickets", tickets);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Tickets booked successfully.");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("Insufficient Berths"))
                        {
                            Console.WriteLine("Tickets not booked: " + ex.Message);
                        }
                        else if (ex.Message.Contains("Invalid Class Provided by the User"))
                        {
                            Console.WriteLine("Tickets not booked: Invalid class provided.");
                        }
                        else
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                }
            }
        }

        // Cancel Tickets

        static void CancelTickets()
        {
            try
            {
                Console.WriteLine("Enter Booking ID to cancel:");
                string bookingIdInput = Console.ReadLine();
                if (int.TryParse(bookingIdInput, out int bookingId))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("CancelTickets", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BookingID", bookingId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Ticket cancellation successful.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Booking ID or Ticket already canceled.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Booking ID. Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Show All Trains

        static void ShowAllTrains()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ShowAllTrains", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();        
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("\nTrainNo\tTrainName\tFirstClass\tSecondClass\tSleeperClass\tSource\tDestination\tIsActive");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["TrainNo"]}\t{reader["TrainName"]}\t{reader["FirstClassAvailableBerths"]}\t{reader["SecondClassAvailableBerths"]}\t{reader["sleeperClassAvailableBerths"]}\t{reader["Source"]}\t{reader["Destination"]}\t{(reader["isactive"])}");
                }
                conn.Close();
            }
        }

        // Show Bookings/Cancellations

        static void Show_BookingsAndCancellations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Show_BookingsandCancellations", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("\nBookingID\tTrainNo\tClass\tTickets\tStatus\t\tBookingDate");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Bookingid"]}\t{reader["TrainNo"]}\t{reader["Class"]}\t{reader["Tickets"]}\t{reader["Status"]}\t{reader["BookingDate"]}");
                }
                conn.Close();
            }
        }
    }
}