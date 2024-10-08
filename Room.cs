using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public interface IRoomManagement
    {
        void OccupyRoom(); // Method to mark the room as occupied
        void VacateRoom(); // Method to mark the room as available
        bool CheckOccupancy(); // Method to check if the room is occupied
    }

    public enum RoomType // An enumeration that defines a set of named constants.
    {
        General,
        ICU,
        OperationTheater,
        IPR, // In Patient Room
        OPR  // Out Patient Room
    }

    public class Room : IRoomManagement // Room class Implementing IRoomManagement
    {
        public int RoomNumber {  get; set; } // Holds the unique identifier for the room
        public RoomType RoomType { get; set; } // A property of type RoomType from enumeration
        public bool IsOccupied { get; set; } // Indicates whether the room is currently occupied by a patient


        public Room (int roomNumber, RoomType roomType)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsOccupied = false;
        }

        public void OccupyRoom() // Sets the room status to occupied
        {
            IsOccupied = true;
        }

        public void VacateRoom() // Sets the room status to not occupied
        {
            IsOccupied = false;
        }

        public bool CheckOccupancy()  // Return the Occupancy status
        {
            return IsOccupied;
        }

        public void DisplayRoomInfo()
        {
            Console.WriteLine($"Room Number: {RoomNumber}, Is Occupied: {IsOccupied}, Type: {RoomType}");
        }
    }
}
