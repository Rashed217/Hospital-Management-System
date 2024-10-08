using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public enum Specialization
    {
        Cardiology, // For Doctors
        Neurology, // For Doctors
        Dermatology, // For Doctors
        General, // For Nurses
        Pediatrics, // For Nurses
        Surgery // For Nurses
    }

    public enum Clinics
    {
        Cardiology,
        Neurology,
        Dermatology
    }
    public class Clinic : IDisplayInfo
    {
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public Specialization Specialization { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
        public Dictionary<Doctor, List<Appointment>> AvailableAppointments { get; set; } = new Dictionary<Doctor, List<Appointment>>();

        public Clinic(int clinicID, string clinicName, Specialization specialization)
        {
            ClinicID = clinicID;
            ClinicName = clinicName;
            Specialization = specialization;
            Rooms = new List<Room>();
            AvailableAppointments = new Dictionary<Doctor, List<Appointment>>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void AddAvailableAppointments(Doctor doctor, DateTime appointmentDay, TimeSpan period)
        {
            if (!AvailableAppointments.ContainsKey(doctor))
            {
                AvailableAppointments[doctor] = new List<Appointment>();
            }

            for (int i = 0; i < 8; i++) // Generate 8 one-hour slots
            {
                var appointment = new Appointment
                {
                    AppointmentDate = appointmentDay,
                    AppointmentTime = period.Add(TimeSpan.FromHours(i)),
                    Patient = null,
                    IsBooked = false
                };
                AvailableAppointments[doctor].Add(appointment);
            }
        }

        public void BookAppointment(Patient patient, Doctor doctor, DateTime appointmentDay, TimeSpan appointmentTime)
        {
            DateTime appointmentDateTime = appointmentDay.Date + appointmentTime;

            if (AvailableAppointments.ContainsKey(doctor))
            {
                var appointment = AvailableAppointments[doctor].Find(a => a.AppointmentDate == appointmentDay && a.AppointmentTime == appointmentTime && !a.IsBooked);
                if (appointment != null)
                {
                    appointment.Patient = patient;
                    appointment.IsBooked = true;
                    Console.WriteLine("Appointment booked successfully!");
                }
                else
                {
                    Console.WriteLine("Appointment slot is not available.");
                }
            }
            else
            {
                Console.WriteLine("Doctor not available.");
            }
        }

        public void DisplayInfo()
        {
            foreach (var doctor in AvailableAppointments.Keys)
            {
                Console.WriteLine($"Doctor: {doctor.Name}");
                foreach (var appointment in AvailableAppointments[doctor])
                {
                    Console.WriteLine($"  Date: {appointment.AppointmentDate.ToShortDateString()}, Time: {appointment.AppointmentTime}, Is Booked: {appointment.IsBooked}");
                }
            }
        }
    }
}
