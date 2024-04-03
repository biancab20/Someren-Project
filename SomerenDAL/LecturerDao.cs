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
    public class LecturerDao : BaseDao
    {


        public List<Lecturer> GetAllLecturers()
        {
            string query = "SELECT LECTURER_ID, LAST_NAME, FIRST_NAME FROM [LECTURER]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int Number = (int)dr["LECTURER_ID"];
                string LastName = (string)dr["LAST_NAME"];
                string FirstName = (string)dr["FIRST_NAME"];

                Lecturer lecturer = new Lecturer(LastName, FirstName, Number);
              
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
        
      

    }
}
