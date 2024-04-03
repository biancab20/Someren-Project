using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class ActivityStudents
    {
        public int studentID;
        public int activityID;

        public ActivityStudents(int studentID, int activityID)
        {
            this.activityID = activityID;
            this.studentID = studentID;
        }
    }
}
