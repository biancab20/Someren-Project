using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class ParticipantsForm : Form
    {
        public ParticipantsForm()
        {
            InitializeComponent();
            List<Activity> activities = GetActivities();
            DisplayActivities(activities);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you wish to remove this participant?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActivityStudentService activityStudentService = new ActivityStudentService();
                activityStudentService.DeleteParticipants(GetIDForActivity(), GetSelectedStudentIdToRemove());
                MessageBox.Show("Participant removed with succes!");
            }
            else
            {
                return;
            }
            List<Student> list = GetStudent();
            DisplayParticipants(list);
            DisplayNonParticipants(list);

        }

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
                Activitylist.Items.Add(li);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivityStudentService activityStudentService = new ActivityStudentService();
            activityStudentService.AddParticipants(GetIDForActivity(), GetStudentIdToAdd());


            List<Student> list = GetStudent();
            DisplayParticipants(list);

            SPnotinactivity.Items.Clear();
            DisplayNonParticipants(list);
        }

        private List<ActivityStudents> GetParticipant()
        {
            ActivityStudentService service = new ActivityStudentService();
            List<ActivityStudents> supervisors = service.GetParticipants();
            return supervisors;
        }

        private void DisplayNonParticipants(List<Student> nonParticipants)
        {
            SPnotinactivity.Items.Clear();
            List<int> list = IDsOfActivityParticipants();

            foreach (Student student in nonParticipants)
            {
                if (!list.Contains(student.Id))
                {
                    ListViewItem li = new ListViewItem(student.Id.ToString());
                    li.Tag = student;
                    li.SubItems.Add(student.Lastname);
                    li.SubItems.Add(student.Firstname);
                    SPnotinactivity.Items.Add(li);
                }
            }
        }

        private void DisplayParticipants(List<Student> participants)
        {
            SPinactivity.Items.Clear();
            List<int> list = IDsOfActivityParticipants();

            foreach (Student participant in participants)
            {
                if (list.Contains(participant.Id))
                {
                    ListViewItem li = new ListViewItem(participant.Id.ToString());
                    li.Tag = participant;
                    li.SubItems.Add(participant.Lastname);
                    li.SubItems.Add(participant.Firstname);
                    SPinactivity.Items.Add(li);
                }
            }
        }

        private List<Student> GetStudent()
        {
            StudentService stuService = new StudentService();
            List<Student> students = stuService.GetStudents();
            return students;
        }

        private int GetIDForActivity()
        {
            try
            {
                Activity selectActivity = (Activity)Activitylist.SelectedItems[0].Tag;
                return selectActivity.id;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR! You must select an activity first!", ex);
            }
        }

        private List<int> IDsOfActivityParticipants()
        {
            List<int> ids = new List<int>();

            List<ActivityStudents> list = GetParticipant();

            foreach (ActivityStudents activityStudent in list)
            {
                if (GetIDForActivity() == activityStudent.activityID)
                {
                    ids.Add(activityStudent.studentID);
                }
            }
            return ids;
        }

        public int GetSelectedStudentIdToRemove()
        {
            try
            {
                Student selectStudent = (Student)SPinactivity.SelectedItems[0].Tag;
                return selectStudent.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR! You must select a lecturer first!", ex);
            }
        }

        public int GetStudentIdToAdd()
        {
            try
            {
                Student selectStudent = (Student)SPnotinactivity.SelectedItems[0].Tag;
                return selectStudent.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR! You must select a lecturer first!", ex);
            }
        }

        private void Activitylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Activitylist.SelectedItems.Count == 0)
                return;

            List<Student> list = GetStudent();
            DisplayParticipants(list);

            DisplayNonParticipants(list);
        }
    }
}
