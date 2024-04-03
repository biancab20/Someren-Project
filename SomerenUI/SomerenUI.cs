using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.LinkLabel;
using SomerenDAL;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()                                //dashboard related
        {

            // hide all other panels
            pnlStudents.Hide();
            pnlRooms.Hide();
            panelLec.Hide();
            pnlDrinks.Hide();
            pnlActivities.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()                               // student related
        {
            listViewStudents.Items.Clear();
            // hide all other panels
            pnlDashboard.Hide();
            pnlRooms.Hide();
            panelLec.Hide();
            pnlDrinks.Hide();
            pnlActivities.Hide();

            // show sudents
            pnlStudents.Show();

            try
            {
                // get and display all rooms
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }

        }

        private List<Student> GetStudents()                                                //student related
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)                                              //student related
        {
            // clear the listview before filling it
            // listViewStudents.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.Tag = student;   // link student object to listview item
                li.SubItems.Add(student.Lastname);
                li.SubItems.Add(student.Firstname);
                listViewStudents.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)          //dashboard related
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)        //exiter related
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)   //student related
        {
            ShowStudentsPanel();
        }

        // ROOMS PART ******************************************************************************


        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();                              ///still not sure why it doesn't work how it's supposed to   (ask teacher later)

            string typeOfPerson = "";

            foreach (Room room in rooms)
            {
                if (room.Type == true)
                {
                    typeOfPerson = "Lecturer";
                }
                else if (room.Type == false)
                {
                    typeOfPerson = "Student";
                }


                ListViewItem li = new ListViewItem(room.Number.ToString());
                li.Tag = room;   // link room object to listview item
                li.SubItems.Add(room.Capacity.ToString());
                li.SubItems.Add(typeOfPerson);

                listViewRooms.Items.Add(li);
            }
        }
        private void ShowRoomPanel()
        {
            // show rooms
            pnlRooms.Show();

            // hide all other panels
            pnlStudents.Hide();
            panelLec.Hide();
            pnlDashboard.Hide();
            pnlDrinks.Hide();
            pnlActivities.Hide();

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowRoomPanel();
        }

        // Lecturer Part ******************************************************************************

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecService = new LecturerService();
            List<Lecturer> lecturers = lecService.GetLecturers();
            return lecturers;
        }

        private void ShowLecturerPanel()
        {
            listViewLecturers.Items.Clear();
            // show
            panelLec.Show();

            // hide other panels
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlActivities.Hide();

            try
            {
                // get and display all 
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }

        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            foreach (var l in lecturers)
            {
                ListViewItem li = new ListViewItem(l.ID.ToString());
                li.SubItems.Add(l.lastName);
                li.SubItems.Add(l.firstName);
                listViewLecturers.Items.Add(li);
            }
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashRegister childForm = new CashRegister();

            childForm.Show();

        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevenueReport revenueReport = new RevenueReport();
            revenueReport.ShowDialog();
        }

        private void drinkSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void ShowDrinksPanel()
        {


            pnlActivities.Hide();
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();
            panelLec.Hide();

            pnlDrinks.Show();

            try
            {
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
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
                ListViewItem li = new ListViewItem(drink.name);
                li.Tag = drink;
                li.SubItems.Add(drink.typeOfDrink);
                li.SubItems.Add(drink.stock.ToString());
                li.SubItems.Add(drink.soldNumber.ToString());
                li.SubItems.Add(drink.stockString);
                listView1.Items.Add(li);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void activitySupervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivitySupervisorsForm childForm = new ActivitySupervisorsForm();
            childForm.Show();
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParticipantsForm participant = new ParticipantsForm();
            participant.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteDrinkForm deleteForm = new DeleteDrinkForm();
            deleteForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModifyDrinkForm modifyDrinkForm = new ModifyDrinkForm();
            modifyDrinkForm.ShowDialog();
        }

        private void ShowActivityPanel()
        {
            listViewActivities.Items.Clear();

            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();
            panelLec.Hide();
            pnlDrinks.Hide();

            pnlActivities.Show();

            try
            {
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
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
                ListViewItem li = new ListViewItem(activity.id.ToString());
                li.Tag = activity;
                li.SubItems.Add(activity.activityName);
                li.SubItems.Add(activity.activityStartTime.ToString());
                li.SubItems.Add(activity.activityEndTime.ToString());
                listViewActivities.Items.Add(li);
            }
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivityPanel();
        }

        private void buttonModifyActivity_Click(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an activity to modify.");
                return;
            }
            Activity selectedActivity = (Activity)listViewActivities.SelectedItems[0].Tag;
            ModifyActivitiesForm modifyActivities = new ModifyActivitiesForm(selectedActivity);
            if (modifyActivities.ShowDialog() == DialogResult.Cancel)
            {
                listViewActivities.Items.Clear();
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            addActivity addActivity = new addActivity();
            addActivity.ShowDialog();
            listViewActivities.Items.Clear();
            List<Activity> activities = GetActivities();
            DisplayActivities(activities);
        }

        private void buttonDeleteActivity_Click(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count == 0)
            {
                MessageBox.Show("You did not select an activity in order to delete");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this activity?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Activity deleted successfully");
                    ListViewItem list = (listViewActivities.SelectedItems[0]);
                    Activity selectedACtivity = (Activity)list.Tag;
                    ActivityDao activitiesDao = new ActivityDao();
                    activitiesDao.DeleteDataFromDatabase(selectedACtivity);
                    listViewActivities.Items.Clear();
                    List<Activity> activities = GetActivities();
                    DisplayActivities(activities);

                }

            }
        }
    }
}