using SomerenDAL;
using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            try
            {
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + ee.Message);
            }
        }
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        private void DisplayDrinks(List<Drink> drinks)
        {


            foreach (Drink drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.id.ToString());
                li.Tag = drink;
                li.SubItems.Add(drink.name);
                li.SubItems.Add(drink.typeOfDrink);
                li.SubItems.Add($"{drink.price:0.00}");
                li.SubItems.Add(drink.stock.ToString());
                listView1.Items.Add(li);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string drinkName = this.textBox2.Text;
            string category = this.textBox3.Text;
            int drinkId = Convert.ToInt32(this.textBox1.Text);
            int stockNr = Convert.ToInt32(this.textBox5.Text);
            int soldNr = 0;
            string stockString = null;
            decimal price = Convert.ToDecimal(this.textBox4.Text);
            Drink drink = new Drink(drinkName, stockNr, price, category, drinkId, stockString, soldNr);
            

            DrinksDao newdrink = new DrinksDao();
            newdrink.SendDataToDatabase(drink);

            this.textBox1.Clear();
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();  
            this.textBox4.Clear();
            this.textBox5.Clear();

            ListViewItem li = new ListViewItem(drink.id.ToString());
            li.Tag = drink;
            li.SubItems.Add(drink.name);
            li.SubItems.Add(drink.typeOfDrink);
            li.SubItems.Add($"{drink.price:0.00}");
            li.SubItems.Add(drink.stock.ToString());
            listView1.Items.Add(li);
        }
    }
}
