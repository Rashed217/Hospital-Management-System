using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class Patient : Person  // Inheriting attributes of base class (Person)
    {
        public int PatientID { get; set; } // ID to identify the patients
        public string Ailment {  get; set; } // Property to describe patient medical condition
        public Doctor AssignedDoctor { get; set; } // Holds a reference to the doctor assigned to the patient
        public Room Room { get; private set; } // Stores the room assigned to the patient


        // Passing attributes from base class (Person), and adding new attributes
        public Patient(int patientId, string name, int age, Gender gender, string ailment, Doctor assignedDoctor) : base(name, age, gender)
        {
            PatientID = patientId;
            Ailment = ailment;
            AssignedDoctor = assignedDoctor;
            assignedDoctor.AddPatient(this); // Automatically assign the patient to the doctor
        }

        public void AssignRoom(Room room) // Assign Room to the Patient
        {
            Room = room;
            Console.WriteLine($"{Name} has been assigned to room {Room.RoomNumber}.");
        }

        public void Discharge() // Removes the patients from their assigned rooms
        {
            Room = null; // Sets Room property to null (Empty)
            Console.WriteLine($"{Name} has been discharged");
        }

        public override void DisplayInfo() // Override (DisplayInfo) Method
        {
            base.DisplayInfo();
            Console.WriteLine($"PatientID: {PatientID}, Ailment: {Ailment}, Assigned Doctor: {AssignedDoctor.Name}");
            if (Room != null)
            {
                Console.WriteLine($"Room: {Room.RoomNumber}");
            }

            else
            {
                Console.WriteLine("Room: not assigned");
            }
        }
    }
}
