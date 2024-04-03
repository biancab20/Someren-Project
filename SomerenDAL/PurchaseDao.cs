using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class PurchaseDao : BaseDao
    {
        public void SendDataToDB(Purchase purchase)
        {
            string querry = "INSERT INTO [Purchase] (PURCHASE_ID, STUDENT_ID,DATE ,DRINK_ID) " +
            "VALUES (@PURCHASE_ID, @STUDENT_ID,@DATE, @DRINK_ID);";

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@PURCHASE_ID", SqlDbType.Int) { Value = purchase.purchaseID };
            sqlParameters[1] = new SqlParameter("@STUDENT_ID", SqlDbType.Int) { Value = purchase.studentID };
            sqlParameters[2] = new SqlParameter("@DRINK_ID", SqlDbType.Int) { Value = purchase.drinkID };
            sqlParameters[3] = new SqlParameter("@DATE", SqlDbType.Date) { Value = purchase.date };
            ExecuteEditQuery(querry, sqlParameters);
        }

         public List<int> GetAllPurchaseID_s()                                         //cezar's methods
        {
            string query = "SELECT PURCHASE_ID FROM [Purchase]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesID_s(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<int> ReadTablesID_s(DataTable dataTable)
        {
            List<int> id_s = new List<int>();

            foreach (DataRow dr in dataTable.Rows)
            {            
                int nr = (int)dr["PURCHASE_ID"];
                id_s.Add(nr);
            }
            return id_s;
        }

        public List<Purchase> GetAllPurchase()                                        //diego's methods
        {

            string query = "SELECT PURCHASE_ID, STUDENT_ID , DATE , DRINK_ID FROM [PURCHASE]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Purchase> ReadTables(DataTable dataTable)
        {
            List<Purchase> Purchase = new List<Purchase>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int Purchase_id = (int)dr["PURCHASE_ID"];
                int Student_id = (int)dr["STUDENT_ID"];
                DateTime date = (DateTime)dr["DATE"];
                int Drink_id = (int)dr["DRINK_ID"];

                Purchase purchase = new Purchase(Purchase_id, Student_id, Drink_id, date);
                Purchase.Add(purchase);
            }
            return Purchase;
        }

    }
}
