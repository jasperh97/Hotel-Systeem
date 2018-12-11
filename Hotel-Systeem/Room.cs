using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Systeem
{
    class Room
    {
        public Room(int roomNr, int roomSize)
        {
            RoomNr = roomNr;
            RoomSize = roomSize;
        }

        public int RoomNr { get; }
        public int RoomSize { get; }

        public int CountCustomersInRoom(int roomNr)
        {
            return 0;
        }
    }
}
