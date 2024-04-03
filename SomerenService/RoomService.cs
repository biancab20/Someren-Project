using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomDB;

        public RoomService()
        {
            roomDB = new RoomDao();
        }

        public List<Room> GetRooms()
        {
            List<Room> Rooms = roomDB.GetAllRooms();
            return Rooms;
        }
    }
}
