
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityStudentsDao : BaseDao
    {
        public List<ActivityStudents> GetAllStudent()
        {
            string query = "SELECT ACTIVITY_ID, STUDENT_ID  FROM [ACTIVITY_STUDENT] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<ActivityStudents> ReadTables(DataTable dataTable)
        {
            List<ActivityStudents> Students = new List<ActivityStudents>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int activityId = (int)dr["ACTIVITY_ID"];
                int studentId = (int)dr["STUDENT_ID"];

                ActivityStudents Student = new ActivityStudents(studentId, activityId);

                Students.Add(Student);
            }
            return Students;
        }

        public void DeleteParticipant(int activityID, int studentID)
        {
            string querry = "DELETE FROM [ACTIVITY_STUDENT] WHERE [STUDENT_ID] = @STUDENT_ID AND [ACTIVITY_ID] = @ACTIVITY_ID;";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = activityID };
            sqlParameters[1] = new SqlParameter("@STUDENT_ID", SqlDbType.Int) { Value = studentID };
            ExecuteEditQuery(querry, sqlParameters);
        }

        public void AddParticipant(int activityID, int studentID)
        {
            string querry = "INSERT INTO [ACTIVITY_STUDENT] (STUDENT_ID,ACTIVITY_ID) VALUES (@STUDENT_ID, @ACTIVITY_ID);";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@STUDENT_ID", SqlDbType.Int) { Value = studentID };
            sqlParameters[1] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = activityID };

            ExecuteEditQuery(querry, sqlParameters);
        }

    }
}
