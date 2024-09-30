using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{

    public enum Gender // A set of named constants (Enumerator List)
    {
        Male,
        Female,
        Other
    }

    public class Person
    {
        // Person's Attributes
        public string Name {  get; set; }
        public int Age { get; set; }
        public Gender Gender {  get; set; }

        public Person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        // Will be called to Display Info of Patients or Doctors.
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }


    }

}
