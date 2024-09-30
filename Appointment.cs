using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class Appointment
    {
        public Patient Patient { get; set; } // Holds an instance of the Patient class 

        public Doctor Doctor { get; set; } // Holds an instance of the Doctor class

        public DateTime AppointmentDate { get; set; } // Holds the date and time of the appointment

        public Appointment(Patient patient, Doctor doctor)
        {
            Patient = patient;
            Doctor = doctor;
        }

        public void ScheduleAppointment(DateTime date) // Sets the date and time for the appointment
        {
            AppointmentDate = date;
        }

        public void CancelAppointment() // Cancel the appointment
        {
            AppointmentDate = default(DateTime);
        }

        public void GetAppointmentDetails() // Prints appointment's details
        {
            Console.WriteLine($"Appointment for Patient: {Patient.Name}, Doctor: {Doctor.Name}, Date: {AppointmentDate}");
        }
    }
}
