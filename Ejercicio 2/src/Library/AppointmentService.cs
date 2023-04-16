using System;
using System.Text;

namespace Library
{
    public class AppointmentValidator
    {
        public static bool ValidateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName, out string errorMessage)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            bool isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (!isValid)
            {
                errorMessage = stringBuilder.ToString();
                return false;
            }

            errorMessage = null;
            return true;
        }
    }

    public class AppointmentCreator
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            string errorMessage;
            if (!AppointmentValidator.ValidateAppointment(name, id, phoneNumber, date, appoinmentPlace, doctorName, out errorMessage))
            {
                return errorMessage;
            }

            // Create appointment logic here

            return "Appointment scheduled";
        }
    }
}