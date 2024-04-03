using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SomerenDAL
{
    public class DrinksDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT DRINK_ID, DRINK_NAME, DRINK_CATEGORY, DRINK_STOCK, DRINK_AMOUNT = (SELECT COUNT(PURCHASE_ID) FROM PURCHASE WHERE PURCHASE.DRINK_ID = DRINK.DRINK_ID), DRINK_PRICE  FROM[DRINK] ORDER BY DRINK_NAME ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            
        }
        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int drinkId = (int)dr["DRINK_ID"];
                string drinkName = (string)dr["DRINK_NAME"];
                string category = (string)dr["DRINK_CATEGORY"];
                int stockNr = (int)dr["DRINK_STOCK"];
                int soldNr = (int)dr["DRINK_AMOUNT"];
                decimal price = (decimal)dr["DRINK_PRICE"];
                string stockAmount = null;
                if (stockNr < 10)
                {
                    stockAmount = "Stock nearly depleted";
                }
                else
                {
                    stockAmount = "Stock sufficient";
                }

                Drink drink = new Drink(drinkName, stockNr, price,category, drinkId, stockAmount, soldNr);

                drinks.Add(drink);
            }
            return drinks;
        }
        
        public void SendDataToDatabase(Drink drink)
        {
            string querry = "INSERT INTO [Drink] (DRINK_ID, DRINK_NAME, DRINK_CATEGORY, DRINK_PRICE, DRINK_STOCK) " +
                            "VALUES (@DRINK_ID, @DRINK_NAME, @DRINK_CATEGORY, @DRINK_PRICE, @DRINK_STOCK);";

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@DRINK_ID", SqlDbType.Int) { Value = drink.id };
            sqlParameters[1] = new SqlParameter("@DRINK_NAME", SqlDbType.VarChar) { Value = drink.name };
            sqlParameters[2] = new SqlParameter("@DRINK_CATEGORY", SqlDbType.VarChar) { Value = drink.typeOfDrink };
            sqlParameters[3] = new SqlParameter("@DRINK_PRICE", SqlDbType.Money) { Value = drink.price };
            sqlParameters[4] = new SqlParameter("@DRINK_STOCK", SqlDbType.Int) { Value = drink.stock };
            ExecuteEditQuery(querry, sqlParameters);
        }

        public void DeleteDataFromDatabase(Drink drink)
        {
            string querry = "DELETE FROM [DRINK] WHERE [DRINK_ID] = @DRINK_ID";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@DRINK_ID", SqlDbType.Int) { Value = drink.id };
            sqlParameters[1] = new SqlParameter("@DRINK_NAME", SqlDbType.VarChar) { Value = drink.name };
            sqlParameters[2] = new SqlParameter("@DRINK_CATEGORY", SqlDbType.VarChar) { Value = drink.typeOfDrink };
            sqlParameters[3] = new SqlParameter("@DRINK_PRICE", SqlDbType.Money) { Value = drink.price };
            sqlParameters[4] = new SqlParameter("@DRINK_STOCK", SqlDbType.Int) { Value = drink.stock };
            ExecuteEditQuery(querry, sqlParameters);

        }
        public void UpdateDatabase(Drink drink)
        {
            string querry = "UPDATE [DRINK] SET [DRINK_NAME] = @DRINK_NAME, [DRINK_CATEGORY] = @DRINK_CATEGORY, [DRINK_PRICE] = @DRINK_PRICE, [DRINK_STOCK] = @DRINK_STOCK WHERE [DRINK_ID] = @DRINK_ID";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@DRINK_ID", SqlDbType.Int) { Value = drink.id };
            sqlParameters[1] = new SqlParameter("@DRINK_NAME", SqlDbType.VarChar) { Value = drink.name };
            sqlParameters[2] = new SqlParameter("@DRINK_CATEGORY", SqlDbType.VarChar) { Value = drink.typeOfDrink };
            sqlParameters[3] = new SqlParameter("@DRINK_PRICE", SqlDbType.Money) { Value = drink.price };
            sqlParameters[4] = new SqlParameter("@DRINK_STOCK", SqlDbType.Int) { Value = drink.stock };
            ExecuteEditQuery(querry, sqlParameters);
        }


    }
}