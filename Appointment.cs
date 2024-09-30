using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class Appointment
    {
        public Patient Patient { get; set; }

        public Doctor Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }

        public Appointment(Patient patient, Doctor doctor)
        {
            Patient = patient;
            Doctor = doctor;
        }

        public void ScheduleAppointment(DateTime date)
        {
            AppointmentDate = date;
        }

        public void CancelAppointment()
        {
            AppointmentDate = default(DateTime);
        }

        public void GetAppointmentDetails()
        {
            Console.WriteLine($"Appointment for Patient: {Patient.Name}, Doctor: {Doctor.Name}, Date: {AppointmentDate}");
        }
    }
}
