using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class addActivity : Form
    {
        public addActivity()
        {
            InitializeComponent();
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.textBox1.Text);
            string description = this.textBox2.Text;
            DateTime startDate = Convert.ToDateTime(this.textBox3.Text);
            DateTime endDate = Convert.ToDateTime(this.textBox4.Text);

            Activity activity = new Activity(id, description, startDate, endDate);

            ActivityDao newactivity = new ActivityDao();

            newactivity.SendDataToDatabase(activity);

            MessageBox.Show("Activity added successfully");

            this.textBox1.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox2.Clear();
        }

        private void BackBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
