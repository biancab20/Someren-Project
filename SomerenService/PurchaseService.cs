using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class PurchaseService
    {
        private PurchaseDao Purchasedb;

        public PurchaseService()
        {
            Purchasedb = new PurchaseDao();
        }

        public List<Purchase> GetPurchase()
        {
            List<Purchase> Purchase = Purchasedb.GetAllPurchase();
            return Purchase;
        }

        public void AddPurchaseToDB(Purchase purchase)
        {
            PurchaseDao purchaseDao = new PurchaseDao();
            purchaseDao.SendDataToDB(purchase);
        }

        public List<int> GetAllPurchaseIDs()
        {
            PurchaseDao purchaseDao = new PurchaseDao();
            return purchaseDao.GetAllPurchaseID_s(); ;
        }
    }
}
