using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Doe";
            string id = "123456789";
            string phoneNumber = "555-1234";
            DateTime date = new DateTime(2023, 04, 20, 10, 30, 00);
            string appointmentPlace = "ABC Clinic";
            string doctorName = "Dr. Jane Smith";

            string result = Library.AppointmentCreator.CreateAppointment(name, id, phoneNumber, date, appointmentPlace, doctorName);

            MessagePrinter.Print(result);
        }
    }

    public static class MessagePrinter
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}