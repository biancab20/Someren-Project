using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class ActivityStudentService
    {
        private ActivityStudentsDao studentdb;

        public ActivityStudentService()
        {
            studentdb = new ActivityStudentsDao();
        }

        public List<ActivityStudents> GetParticipants()
        {
            List<ActivityStudents> activities = studentdb.GetAllStudent();
            return activities;
        }

        public void DeleteParticipants(int activityID, int studentID)
        {
            ActivityStudentsDao ParticipantDao = new ActivityStudentsDao();
            ParticipantDao.DeleteParticipant(activityID, studentID);
        }

        public void AddParticipants(int activityID, int studentID)
        {
            ActivityStudentsDao ParticipantDao = new ActivityStudentsDao();
            ParticipantDao.AddParticipant(activityID, studentID);
        }
    }
}
