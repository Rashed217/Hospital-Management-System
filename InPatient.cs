using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class InPatient : Patient
    {

        public Room Room { get; set; }
        public Doctor AssignedDoctor { get; set; }
        public DateTime AdmissionDate { get; set; }

        public InPatient(int patientId, string name, int age, Gender gender, string ailment, Doctor assignedDoctor) : base(patientId, name, age, gender, ailment, assignedDoctor)
        {
            AssignedDoctor = assignedDoctor;
            AdmissionDate = DateTime.Now;
        }

        public void AssignRoom(Room room)
        {
            Room = room;
            room.OccupyRoom();
        }

        public void Discharge()
        {
            Room.VacateRoom();
            Room = null;
            AssignedDoctor = null;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Room: {Room?.RoomNumber}, Assigned Doctor: {AssignedDoctor?.Name}");
        }
    }
}
