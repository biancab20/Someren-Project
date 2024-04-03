using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class RevenueReport : Form
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTimeStart = dateTimePicker1.Value;
            DateTime dateTimeEnd = dateTimePicker2.Value;

            List<Purchase> purchases = new List<Purchase>();
            PurchaseService purchaseService = new PurchaseService();

            List<Purchase> purchaseCompleted = new List<Purchase>();

            purchases = purchaseService.GetPurchase();

            if (dateTimeEnd <= dateTimeStart || dateTimeEnd > DateTime.Now) //dateTimeEnd > DateTime ||
            {
                MessageBox.Show("NOT VALID!\n You need to insert a correct date.");
                return;
            }

            foreach (Purchase purchase in purchases)
            {
                if (purchase.date >= dateTimeStart && purchase.date <= dateTimeEnd)
                {
                    purchaseCompleted.Add(purchase);
                }
            }

            int totalsales = purchaseCompleted.Count();

            List<Purchase> uniqueList = new List<Purchase>();

            foreach (Purchase costumer in purchaseCompleted)
            {
                if (!uniqueList.Any(c => c.studentID == costumer.studentID))
                {
                    uniqueList.Add(costumer);
                }
            }

            int totalcostumers = uniqueList.Count();

            double turnover = 0;

            foreach (Purchase Turnover in purchaseCompleted)
            {
                if (Turnover.drinkID == 213)
                {
                    turnover = turnover + 8;
                }
                else if (Turnover.drinkID == 214)
                {
                    turnover = turnover + 2.23;
                }
                else if (Turnover.drinkID == 215)
                {
                    turnover = turnover + 9.84;
                }
                else if (Turnover.drinkID == 672)
                {
                    turnover = turnover + 9.20;
                }
                else if (Turnover.drinkID == 781)
                {
                    turnover = turnover + 16;
                }
                else if (Turnover.drinkID == 782)
                {
                    turnover = turnover + 18;
                }
                else if (Turnover.drinkID == 783)
                {
                    turnover = turnover + 16;
                }
                else if (Turnover.drinkID == 787)
                {
                    turnover = turnover + 6;
                }
                else if (Turnover.drinkID == 900)
                {
                    turnover = turnover + 10;
                }
            }
            ListViewItem li = new ListViewItem(totalsales.ToString());
            li.SubItems.Add(turnover.ToString());
            li.SubItems.Add(totalcostumers.ToString());
            listViewReport.Items.Add(li);
        }
    }
}
