using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Purchase
    {
        public int purchaseID;
        public int studentID;
        public int drinkID;
        public DateTime date;


        public Purchase (int purchaseId,int studentID, int drinkId,DateTime date)
        {
            this.purchaseID = purchaseId;
            this.studentID = studentID;
            this.drinkID = drinkId;
            this.date = date;
        }
    }
}
