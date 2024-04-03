using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT ROOM_NUMBER, ROOM_CAPACITY FROM [ROOM]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                bool studentOrLecturer;
                int capacity = (int)dr["ROOM_CAPACITY"];
                if (capacity == 1)
                {
                    studentOrLecturer = true;

                }
                else
                {
                    studentOrLecturer = false;
                }
                int roomNR = (int)dr["ROOM_NUMBER"];


                Room room = new Room(roomNR, capacity, studentOrLecturer);
                                                       // the stuff that a room has ROOM NUMBER, CAPACITY, LECTURER OR STUDENT TO DETERMINE THAT WITH BOOLEAN
             
                rooms.Add(room);
            }
            return rooms;
        }

    }

}
