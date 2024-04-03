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
    public class ActivitySupervisorDao : BaseDao
    {
        public List<ActivitySupervisor> GetAllSupervisors()
        {
            string query = "SELECT ACTIVITY_ID, LECTURER_ID  FROM [ACTIVITY_SUPERVISOR] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<ActivitySupervisor> ReadTables(DataTable dataTable)
        {
            List<ActivitySupervisor> Supervisors = new List<ActivitySupervisor>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int activityId = (int)dr["ACTIVITY_ID"];
                int lecturerId = (int)dr["LECTURER_ID"];

                ActivitySupervisor Supervisor = new ActivitySupervisor(lecturerId, activityId);

                Supervisors.Add(Supervisor);
            }
            return Supervisors;
        }

        public void DeleteSupervisors(int activityID, int lecturerID)
        {
            string querry = "DELETE FROM [ACTIVITY_SUPERVISOR] WHERE [LECTURER_ID] = @LECTURER_ID AND [ACTIVITY_ID] = @ACTIVITY_ID;";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = activityID };
            sqlParameters[1] = new SqlParameter("@LECTURER_ID", SqlDbType.Int) { Value = lecturerID };
            ExecuteEditQuery(querry, sqlParameters);
        }

        public void AddSupervisors(int activityID, int lecturerID)
        {
            string querry = "INSERT INTO [ACTIVITY_SUPERVISOR] (LECTURER_ID,ACTIVITY_ID) VALUES (@LECTURER_ID, @ACTIVITY_ID);";



            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@LECTURER_ID", SqlDbType.Int) { Value = lecturerID };
            sqlParameters[1] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = activityID };
        
            ExecuteEditQuery(querry, sqlParameters);
        }
    }
}
