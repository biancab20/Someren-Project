using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public  class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT ACTIVITY_ID, ACTIVITY_NAME, START_DATE_TIME, END_DATE_TIME  FROM [Activity] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int activityId = (int)dr["ACTIVITY_ID"];
                string activityName = (string)dr["ACTIVITY_NAME"];
                DateTime startDate = (DateTime)dr["START_DATE_TIME"];
                DateTime endDate = (DateTime)dr["END_DATE_TIME"];

                Activity activity = new Activity(activityId, activityName, startDate, endDate);

                activities.Add(activity);
            }
            return activities;
        }

        public void SendDataToDatabase(Activity activity)
        {
            string querry = "INSERT INTO [Activity] (ACTIVITY_ID, ACTIVITY_NAME, START_DATE_TIME, END_DATE_TIME) " +
                            "VALUES (@ACTIVITY_ID, @ACTIVITY_NAME, @START_DATE_TIME, @END_DATE_TIME);";

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = activity.id };
            sqlParameters[1] = new SqlParameter("@ACTIVITY_NAME", SqlDbType.VarChar) { Value = activity.activityName };
            sqlParameters[2] = new SqlParameter("@START_DATE_TIME", SqlDbType.DateTime) { Value = activity.activityStartTime };
            sqlParameters[3] = new SqlParameter("@END_DATE_TIME", SqlDbType.DateTime) { Value = activity.activityEndTime };
            ExecuteEditQuery(querry, sqlParameters);
        }
        public void DeleteDataFromDatabase(Activity activity)
        {
            string querry = "DELETE FROM [ACTIVITY] WHERE [ACTIVITY_ID] = @ACTIVITY_ID";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = activity.id };
            sqlParameters[1] = new SqlParameter("@ACTIVITY_NAME", SqlDbType.VarChar) { Value = activity.activityName };
            sqlParameters[2] = new SqlParameter("@START_DATE_TIME", SqlDbType.DateTime) { Value = activity.activityStartTime };
            sqlParameters[3] = new SqlParameter("@END_DATE_TIME", SqlDbType.DateTime) { Value = activity.activityEndTime };
            ExecuteEditQuery(querry, sqlParameters);

        }
        public void UpdateDatabase(Activity activity)
        {
            string querry = "UPDATE [ACTIVITY] SET [ACTIVITY_NAME] = @ACTIVITY_NAME, [START_DATE_TIME] = @START_DATE_TIME, [END_DATE_TIME] = @END_DATE_TIME WHERE [ACTIVITY_ID] = @ACTIVITY_ID";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@ACTIVITY_ID", SqlDbType.Int) { Value = activity.id };
            sqlParameters[1] = new SqlParameter("@ACTIVITY_NAME", SqlDbType.VarChar) { Value = activity.activityName };
            sqlParameters[2] = new SqlParameter("@START_DATE_TIME", SqlDbType.DateTime) { Value = activity.activityStartTime };
            sqlParameters[3] = new SqlParameter("@END_DATE_TIME", SqlDbType.DateTime) { Value = activity.activityEndTime };
            ExecuteEditQuery(querry, sqlParameters);
        }
    }
}
