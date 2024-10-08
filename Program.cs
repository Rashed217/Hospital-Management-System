﻿namespace Hospital_MS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor(1, "Dr. John Smith", 45, Gender.Male, Specialization.Cardiology, Clinics.Cardiology);
            Doctor doctor2 = new Doctor(2, "Dr. Alice Brown", 38, Gender.Female, Specialization.Neurology, Clinics.Neurology);

            // Create clinics
            Clinic cardiologyClinic = new Clinic(1, "Cardiology Clinic", Specialization.Cardiology);
            Clinic neurologyClinic = new Clinic(2, "Neurology Clinic", Specialization.Neurology);

            // Create rooms for clinics
            Room room1 = new Room(101, RoomType.IPR);  // Room for in-patients
            Room room2 = new Room(102, RoomType.OPR);  // Room for out-patients

            // Assign doctors to clinics and generate appointment slots (9 AM - 12 PM)
            doctor1.AssignToClinic(cardiologyClinic, new DateTime(2024, 10, 5), TimeSpan.FromHours(9)); // Expected: Appointments generated for 9 AM, 10 AM, 11 AM
            doctor2.AssignToClinic(neurologyClinic, new DateTime(2024, 10, 6), TimeSpan.FromHours(9));  // Expected: Appointments generated for 9 AM, 10 AM, 11 AM

            cardiologyClinic.AddRoom(room1); // Expected: Room 101 added to Cardiology Clinic
            neurologyClinic.AddRoom(room2);  // Expected: Room 102 added to Neurology Clinic

            // Create patients
            InPatient inpatient1 = new InPatient(101, "Jane Doe", 30, Gender.Female, "Cardiac Arrest", doctor1, DateTime.Now);


            OutPatient outpatient1 = new OutPatient(102, "Mark Doe", 28, Gender.Male, "Mirgaine", doctor1, neurologyClinic);

            // Assign room to in-patient
            inpatient1.AssignRoom(room1); // Expected: Room 101 becomes occupied

            // Book an appointment for out-patient in Cardiology Clinic
            outpatient1.BookAppointment(cardiologyClinic, new DateTime(2024, 10, 5), TimeSpan.FromHours(10)); // Expected: Appointment at 10 AM booked

            // View doctor's assigned clinics
            doctor1.DisplayAssignedClinics(); // Expected: Cardiology Clinic is displayed

            // View available appointments in Cardiology Clinic
            cardiologyClinic.DisplayAvailableAppointments();
            // Expected: Show available slots for Dr. John Smith at 9 AM, 11 AM (10 AM is booked)

            // Discharge in-patient
            inpatient1.Discharge(); // Expected: Room 101 becomes available, patient discharged

            // Book another appointment for the same out-patient in Cardiology Clinic
            outpatient1.BookAppointment(cardiologyClinic, new DateTime(2024, 10, 5), TimeSpan.FromHours(11)); // Expected: Appointment at 11 AM booked

            // Try booking a time outside available slots
            outpatient1.BookAppointment(cardiologyClinic, new DateTime(2024, 10, 5), TimeSpan.FromHours(12)); // Expected: No available appointments for this time

            // Cancel an appointment
            cardiologyClinic.BookAppointment(outpatient1, doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(10)); // Expected: Appointment cancellation message for 10 AM

            // View available appointments after booking and cancellation
            cardiologyClinic.DisplayAvailableAppointments();
            // Expected: 10 AM slot available again, 9 AM and 11 AM booked
        }
    }

}

