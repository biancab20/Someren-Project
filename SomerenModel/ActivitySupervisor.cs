using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class ActivitySupervisor
    {
        public int lecturerID;
        public int activityID;

       public ActivitySupervisor(int lecturerID,int activityID)
        {
            this.activityID=activityID;
            this.lecturerID=lecturerID;
        }
    }
}
