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
    public partial class ModifyActivitiesForm : Form
    {
        private Activity selectedActivity;

        public ModifyActivitiesForm(Activity selectedActivity)
        {
            InitializeComponent();
            this.textBox1.Text = selectedActivity.id.ToString();
            this.textBox2.Text = selectedActivity.activityName;
            this.textBox3.Text = selectedActivity.activityStartTime.ToString();
            this.textBox4.Text = selectedActivity.activityEndTime.ToString();
            this.selectedActivity = selectedActivity;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = selectedActivity.id.ToString();
            this.textBox2.Text = selectedActivity.activityName;
            this.textBox3.Text = selectedActivity.activityStartTime.ToString();
            this.textBox4.Text = selectedActivity.activityEndTime.ToString();
            this.Close();
        }

        private void SaveModifications_btn_Click(object sender, EventArgs e)
        {
            ActivityDao activitiesDao = new ActivityDao();
            selectedActivity.id = int.Parse(this.textBox1.Text);
            selectedActivity.activityName = this.textBox2.Text;
            selectedActivity.activityStartTime = DateTime.Parse(this.textBox3.Text);
            selectedActivity.activityEndTime = DateTime.Parse(this.textBox4.Text); 
            activitiesDao.UpdateDatabase(selectedActivity);
            MessageBox.Show("Activity modified successfully!");
            this.Close();


        }
    }
}
