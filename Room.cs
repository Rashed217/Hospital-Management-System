using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_MS
{
    public enum RoomType
    {
        General,
        ICU,
        OperationTheater
    }

    public class Room
    {
        public int RoomNumber {  get; set; }
        public RoomType RoomType { get; set; }
        public bool IsOccupied { get; set; }


        public Room (int roomNumber, RoomType roomType)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsOccupied = false;
        }

        public void OccupyRoom()
        {
            IsOccupied = true;
        }

        public void VacateRoom()
        {
            IsOccupied = false;
        }
    }
}
