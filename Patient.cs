using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class Patient : Person
    {
        public int PatientID { get; set; }
        public string Ailment {  get; set; }
        public Doctor AssignedDoctor { get; set; }
        public Room Room { get; set; }


        public Patient(string name, int age, Gender gender, int patientId, string ailment, Doctor assignedDoctor) : base(name, age, gender)
        {
            PatientID = patientId;
            Ailment = ailment;
            AssignedDoctor = assignedDoctor;
        }

        public void AssignRoom(Room room)
        {
            Room = room;
            Console.WriteLine($"{Name} has been assigned to room {Room.RoomNumber}.");
        }

        public void Discharge()
        {
            Room = null;
            Console.WriteLine($"{Name} has been discharged");
        }

        public override void DisplayInfo()
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
