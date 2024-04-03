using SomerenModel;
using SomerenService;
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

namespace SomerenUI
{
    public partial class ModifyDrinkForm : Form
    {
        public ModifyDrinkForm()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyDrinkForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            try
            {
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong while loading the drinks: " + ex.Message);
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
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a drink to modify.");
                return;
            }
                Drink selectedDrink = (Drink)listView1.SelectedItems[0].Tag;            
            
                ModifyDrink editForm = new ModifyDrink(selectedDrink);
            if (editForm.ShowDialog() == DialogResult.Cancel)
            {

                listView1.Items.Clear();
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }

        }
    }
}
