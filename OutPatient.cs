using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class OutPatient : Patient
    {

        public Clinic ClinicAssigned { get; set; }

        public OutPatient(int patientId, string name, int age, Gender gender, string ailment, Doctor assignedDoctor, Clinic ClinicAssigned) : base(patientId, name, age, gender, ailment, assignedDoctor) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Clinic Assigned: {ClinicAssigned.ClinicName}");
        }

        public void BookAppointment(Clinic ClinicAssigned, DateTime appointmentDay, TimeSpan appointmentTime) { }
    }
}
