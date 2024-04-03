using SomerenModel;
using SomerenService;
using System;
using System.Collections;
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
    public partial class ActivitySupervisorsForm : Form
    {
        public ActivitySupervisorsForm()
        {
            InitializeComponent();

            List<Activity> activities = GetActivities();
            DisplayActivities(activities);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMainAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void removeBt_Click(object sender, EventArgs e)                   // ----------Remove Button ______________
        {
            if (MessageBox.Show("Are you sure that you wish to remove this supervisor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActivitySupervisorService activitySupervisorService = new ActivitySupervisorService();
                activitySupervisorService.DeleteSupervisors(GetIDForActivity(), GetSelectedLecturerIdToRemove());
                MessageBox.Show("Supervisor removed with succes!");
            }
            else
            {
                return;
            }
            List<Lecturer> list = GetLecturers();
            DisplaySupervisors(list);
            DisplayNonSupervisors(list);
        }

        private void addBt_Click(object sender, EventArgs e)                  // ----------ADD Button ______________
        {
            ActivitySupervisorService activitySupervisorService = new ActivitySupervisorService();
            activitySupervisorService.AddSupervisors(GetIDForActivity(), GetLecturerIdToAdd());


            List<Lecturer> list = GetLecturers();
            DisplaySupervisors(list);

            listViewNotSupervising.Items.Clear();
            DisplayNonSupervisors(list);
        }

        ///////////////////////////////////////////////////// Activity Display Part ////////////////////////////////////

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private void DisplayActivities(List<Activity> activities)
        {
            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.activityName);
                li.Tag = activity;
                listViewActivities.Items.Add(li);
            }
        }



        ///////////////////////////////////////////////////// Supervisors List Views Display Part ///////////////////////////////////////////////////////////

        private void listViewActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count == 0)
                return;

            List<Lecturer> list = GetLecturers();
            DisplaySupervisors(list);

            DisplayNonSupervisors(list);
        }

        private List<ActivitySupervisor> GetSupervisors()
        {
            ActivitySupervisorService service = new ActivitySupervisorService();
            List<ActivitySupervisor> supervisors = service.GetSupervisors();
            return supervisors;
        }

        private void DisplayNonSupervisors(List<Lecturer> nonSupervisors)
        {
            listViewNotSupervising.Items.Clear();
            List<int> list = IDsOfActivitySupervisors();

            foreach (Lecturer lecturer in nonSupervisors)
            {
                if (!list.Contains(lecturer.ID))
                {
                    ListViewItem li = new ListViewItem(lecturer.ID.ToString());
                    li.Tag = lecturer;
                    li.SubItems.Add(lecturer.lastName);
                    li.SubItems.Add(lecturer.firstName);
                    listViewNotSupervising.Items.Add(li);
                }
            }
        }

        private void DisplaySupervisors(List<Lecturer> supervisors)
        {
            listViewSupervisors.Items.Clear();
            List<int> list = IDsOfActivitySupervisors();

            foreach (Lecturer supervisor in supervisors)
            {
                if (list.Contains(supervisor.ID))
                {
                    ListViewItem li = new ListViewItem(supervisor.ID.ToString());
                    li.Tag = supervisor;
                    li.SubItems.Add(supervisor.lastName);
                    li.SubItems.Add(supervisor.firstName);
                    listViewSupervisors.Items.Add(li);
                }
            }
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecService = new LecturerService();
            List<Lecturer> lecturers = lecService.GetLecturers();
            return lecturers;
        }

        private int GetIDForActivity()
        {
            try
            {
                Activity selectActivity = (Activity)listViewActivities.SelectedItems[0].Tag;
                return selectActivity.id;
            }
            catch (Exception ex) 
            {
                throw new Exception("ERROR! You must select an activity first!", ex);
            }
        }

        private List<int> IDsOfActivitySupervisors()
        {
            List<int> ids = new List<int>();

            List<ActivitySupervisor> list = GetSupervisors();

            foreach (ActivitySupervisor activitySupervisor in list)
            {
                if (GetIDForActivity() == activitySupervisor.activityID)
                {
                    ids.Add(activitySupervisor.lecturerID);
                }
            }
            return ids;
        }

        /////////////////////////// For Removing and Adding Supervisors ////////////////////////////////

        public int GetSelectedLecturerIdToRemove()
        {
            try
            {
                Lecturer selectLecturer = (Lecturer)listViewSupervisors.SelectedItems[0].Tag;
                return selectLecturer.ID;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR! You must select a lecturer first!", ex); 
            }
        }

        public int GetLecturerIdToAdd()
        {
            try
            {
                Lecturer selectLecturer = (Lecturer)listViewNotSupervising.SelectedItems[0].Tag;
                return selectLecturer.ID;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR! You must select a lecturer first!", ex);
            }
        }



    }
}
