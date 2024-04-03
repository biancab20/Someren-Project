using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int id;
        public string activityName;
        public DateTime activityStartTime;
        public DateTime activityEndTime;

        public Activity(int id, string activityName, DateTime activityStartTime, DateTime activityEndTime) 
        { 
            this .id = id;
            this .activityName = activityName;
            this .activityStartTime = activityStartTime;
            this .activityEndTime = activityEndTime;
        }
    }
}
