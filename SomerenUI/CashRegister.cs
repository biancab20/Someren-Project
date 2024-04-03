using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing.Text;
using SomerenDAL;

namespace SomerenUI
{
    public partial class CashRegister : Form
    {
        public CashRegister()
        {
            InitializeComponent();

            List<Student> students = GetStudents();
            DisplayStudents(students);

            List<Drink> drinks = GetDrinks();
            DisplayDrinkss(drinks);
            this.listViewDrinks.MultiSelect = false;
        }



        private void backToMainAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMainAppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int indexDetector()
        {
            int index = -1;
            foreach (ListViewItem item in listViewDrinks.Items)
            {
                if (item.Checked)
                {
                    index = listViewDrinks.Items.IndexOf(item);
                    return index;


                }
            }
            return index;
        }

        private void itemCheckDrinks(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in listViewDrinks.Items)
            {
                if (item.Checked)
                {
                    count++;
                    if (count >= 2)
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        private void itemCheckStudents(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in listViewStudents.Items)
            {
                if (item.Checked)
                {
                    count++;
                    if (count >= 2)
                    {
                        item.Checked = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = indexDetector();
            List<Drink> drinks = GetDrinks();
            if (index == -1)
            {
                MessageBox.Show("ERROR, ERROR!\n You must select a drink first!");
                return;
            }

            label4.Text = $"{drinks[index].price:0.00}";

        }

        //Student ************************************ Part

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.Tag = student;   // link student object to listview item
                li.SubItems.Add(student.Lastname);
                li.SubItems.Add(student.Firstname);
                listViewStudents.Items.Add(li);
            }
        }




        //Drinks ************************************ Part

        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        private void DisplayDrinkss(List<Drink> drinks)
        {
            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.name.ToString());
                li.Tag = drink;
                li.SubItems.Add($"{drink.price:0.00}");
                li.SubItems.Add(drink.stock.ToString());
                li.SubItems.Add(drink.typeOfDrink.ToString());
                li.SubItems.Add(drink.id.ToString());
                listViewDrinks.Items.Add(li);
            }
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {

            int drinkId = 0;
            int studentId = 0;

            foreach (ListViewItem item in listViewDrinks.Items)
            {
                if (item.Checked)
                {
                    foreach (ListViewItem student in listViewStudents.Items)
                    {
                        if (student.Checked)
                        {
                            studentId = int.Parse(student.SubItems[0].Text);
                            break; 
                        }
                    }

                    if (studentId == 0)
                    {
                        MessageBox.Show("ERROR, ERROR!\n Both students and drinks field must be checked!");
                        return;
                    }

                    drinkId = int.Parse(item.SubItems[4].Text);
                    break;
                }
            }

            if (drinkId == 0)
            {
                MessageBox.Show("ERROR, ERROR!\n Both students and drinks field must be checked!");
                return;
            }

            SendDataToDB(drinkId, studentId);

            this.listViewDrinks.Items.Clear();    // refreshing the stuff after the sending
            this.listViewStudents.Items.Clear();
            List<Student> students = GetStudents();
            DisplayStudents(students);
            List<Drink> drinks = GetDrinks();
            DisplayDrinkss(drinks);


        }

        //Sending the data ***********************


        private void SendDataToDB(int drinkId, int studentId)
        {
            PurchaseService purchaseService = new PurchaseService();
            List<int> purchaseID = purchaseService.GetAllPurchaseIDs();
            int currentPurchaseId = 0;
            Random rnd = new Random();      
            bool foundUniquePurchaseId = false;
            while (!foundUniquePurchaseId)
            {
                currentPurchaseId = rnd.Next(999, 10000);

                if (!purchaseID.Contains(currentPurchaseId))
                {
                    foundUniquePurchaseId = true;
                }
            }
            DateTime date = DateTime.Now;
            Purchase purchase = new Purchase(currentPurchaseId, studentId, drinkId, date);
            purchaseService.AddPurchaseToDB(purchase);
        }


    }
}
