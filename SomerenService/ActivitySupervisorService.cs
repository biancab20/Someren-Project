using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivitySupervisorService
    {
        private ActivitySupervisorDao supervisordb;

        public ActivitySupervisorService()
        {
            supervisordb = new ActivitySupervisorDao();
        }

        public List<ActivitySupervisor> GetSupervisors()
        {
            List<ActivitySupervisor> activities = supervisordb.GetAllSupervisors();
            return activities;
        }

        public void DeleteSupervisors(int activityID, int lecturerID)
        {
            ActivitySupervisorDao supervisorDao = new ActivitySupervisorDao();
            supervisorDao.DeleteSupervisors( activityID, lecturerID);
        }

        public void AddSupervisors(int activityID, int lecturerID)
        {
            ActivitySupervisorDao supervisorDao = new ActivitySupervisorDao();
            supervisorDao.AddSupervisors(activityID, lecturerID);
        }
    }
}
