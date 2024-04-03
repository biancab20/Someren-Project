using SomerenDAL;
using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace SomerenUI
{
    public partial class DeleteDrinkForm : Form
    {
        public DeleteDrinkForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            try
            {
                List<Drink> drinks  = GetDrinks();
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
            if (listView1.SelectedItems.Count > 0)
            {
                //MessageBox.Show("Are you sure you want to delete this drink?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this drink?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ListViewItem list = (listView1.SelectedItems[0]);
                    Drink drinkselected = (Drink)list.Tag;
                    DrinksDao drinkDao = new DrinksDao();
                    drinkDao.DeleteDataFromDatabase(drinkselected);
                    listView1.Items.Clear();
                    List<Drink> drinks = GetDrinks();
                    DisplayDrinks(drinks);
                }
                else if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("You did not select an item in order to delete");
            }
        }

    }
}
