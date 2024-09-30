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
        // These lists can only be modified within Hospital class because of the (private set).

        // A list holds Doctor objects
        public List<Doctor> DoctorsList {  get; private set; } = new List<Doctor>();

        // A list holds Patient objects
        public List<Patient> PatientsList { get; private set;} = new List<Patient>();

        // A list to manage Room objects
        public List<Room> RoomsList { get; private set; } = new List<Room>();


        // This method adds Doctors to Doctors List
        public void AddDoctor(Doctor doctor)
        {
            DoctorsList.Add(doctor);
        }


        // This method adds Patients to Patients List
        public void AddPatient(Patient patient)
        {
            PatientsList.Add(patient);
        }


        // 
        public void AssignRoomToPatient(Patient patient, Room room) // Determines the Patient and the Room
        {
            if (!room.IsOccupied) // Checks if room is already occupied
            {
                patient.AssignRoom(room); // Assign patient to the room
            }

            else
            {
                Console.WriteLine("Room is already occupied."); // If room is occupied
            }
        }


        // This method displays information about the patients assigned to a specific doctor
        public void GetDoctorPatient(Doctor doctor) // Determines the Doctor
        {
            Console.WriteLine($"Patient assigned to Dr. {doctor.Name}:");

            foreach (var patient in doctor.PatientsList)
            {
                patient.DisplayInfo(); // This inherited method will display info of the patient
            }
        }
    }
}
