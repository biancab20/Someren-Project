using SomerenDAL;
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

namespace SomerenUI
{
    public partial class ModifyDrink : Form
    {
        private Drink selectdrink;

        public ModifyDrink(Drink selectdrink)
        {

            InitializeComponent();
            this.textBox1.Text = selectdrink.id.ToString();
            this.textBox2.Text = selectdrink.name;
            this.textBox3.Text = selectdrink.typeOfDrink;
            this.textBox4.Text = selectdrink.price.ToString();
            this.textBox5.Text = selectdrink.stock.ToString();
            this.selectdrink = selectdrink;
        }

        private void ModifyDrink_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrinksDao drinkDao = new DrinksDao();
            selectdrink.id = int.Parse(this.textBox1.Text);
            selectdrink.name = this.textBox2.Text;
            selectdrink.typeOfDrink = this.textBox3.Text;
            selectdrink.price = decimal.Parse(this.textBox4.Text);
            selectdrink.stock = int.Parse(this.textBox5.Text);
            drinkDao.UpdateDatabase(selectdrink);
            MessageBox.Show("Drink modified successfully!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = selectdrink.id.ToString();
            this.textBox2.Text = selectdrink.name;
            this.textBox3.Text = selectdrink.typeOfDrink;
            this.textBox4.Text = selectdrink.price.ToString();
            this.textBox5.Text = selectdrink.stock.ToString();
            this.Close();
        }
    }
}
