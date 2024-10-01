using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public class Doctor : Person // Inheriting attributes of base class (Person)
    {
        public int DoctorID {  get; set; } // ID to identify the patients
        public string Specialization {  get; set; } // Specify the medical specialization of the doctor
        public List<Clinic> AssignedClinics { get; set; } = new List<Clinic>();
        public List<Patient> PatientsList { get; private set; } = new List<Patient>(); // Holds the patients assigned to the doctor


        // // Passing attributes from base class (Person), and adding new attributes
        public Doctor(int doctorID, string name, int age, Gender gender, string specialization, Clinic clinic) : base(name, age, gender)
        {
            DoctorID = doctorID;
            Specialization = specialization;
        }

        public void AssignToClinic(Clinic clinic, DateTime day, TimeSpan period)
        {
            AssignedClinics.Add(clinic);
            clinic.AddAvailableAppointments(this, day, period);
        }

        public void DisplayAssignedClinics()
        {
            Console.WriteLine("Assigned Clinics:");
            foreach (var clinic in AssignedClinics)
            {
                Console.WriteLine(clinic.ClinicName);
            }
        }

        public void AddPatient(Patient patient) // Determines the Patient to be added
        {
            PatientsList.Add(patient); // Adds Patient to the Patients List
        }

        public void RemovePatient(Patient patient) // Determines the Patient to be removed
        {
            PatientsList.Remove(patient); // Removes Patient from the Patients List
        }

        public override void DisplayInfo() // Override(DisplayInfo) Method
        {
            base.DisplayInfo(); //Calls the base method to print (Name, Age and Gender).
            Console.WriteLine($"Doctor ID: {DoctorID}, Specialization: {Specialization}");
        }
    }
}
