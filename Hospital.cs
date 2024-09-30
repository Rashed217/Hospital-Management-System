using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class Hospital
    {
        public List<Doctor> DoctorsList {  get; private set; } = new List<Doctor>();

        public List<Patient> PatientsList { get; private set;} = new List<Patient>();

        public List<Room> RoomsList { get; private set; } = new List<Room>();

        public void AddDoctor(Doctor doctor)
        {
            DoctorsList.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            PatientsList.Add(patient);
        }

        public void AssignRoomToPatient(Patient patient, Room room)
        {
            if (!room.IsOccupied)
            {
                patient.AssignRoom(room);
            }

            else
            {
                Console.WriteLine("Room is already occupied.");
            }
        }

        public void GetDoctorPatient(Doctor doctor)
        {
            Console.WriteLine($"Patient assigned to Dr. {doctor.Name}:");

            foreach (var patient in doctor.PatientsList)
            {
                patient.DisplayInfo();
            }
        }
    }
}
