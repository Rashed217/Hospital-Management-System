namespace Hospital_MS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            Doctor doctor1 = new Doctor("Alice", 35, Gender.Female, 1, "Cardiology");

            Doctor doctor2 = new Doctor("Bob", 45, Gender.Male, 2, "Neurology");

            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);

            Room room1 = new Room(101, RoomType.General);
            Room room2 = new Room(102, RoomType.ICU);
            hospital.RoomsList.Add(room1);
            hospital.RoomsList.Add(room2);

            Patient Patient1 = new Patient("John Doe", 30, Gender.Male, 1, "Heart Disease", doctor1);
            Patient Patient2 = new Patient("Jane Smith", 25, Gender.Female, 2, "Migraine", doctor2);

            hospital.AddPatient(Patient1);
            hospital.AddPatient(Patient2);

            hospital.AssignRoomToPatient(Patient1, room1);
            hospital.AssignRoomToPatient(Patient2 , room2);

            Patient1.DisplayInfo();
            Patient2.DisplayInfo();

            hospital.GetDoctorPatient(doctor1);
            hospital.GetDoctorPatient(doctor2);
        }
    }
}
