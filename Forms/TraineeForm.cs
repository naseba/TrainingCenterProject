using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingCenterProject
{
    public partial class TraineeForm : Form
    {
        TrainingCenterEntities model = new TrainingCenterEntities();
        Trainee T = new Trainee();
        Cours C = new Cours();

        // 
        public TraineeForm(int id)
        {
            InitializeComponent();
            T.TraineeID = id;
        }

        private void TraineeForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            BindDataGridView(comboBox1.SelectedItem.ToString());
            panel1.Visible = true;
            Backbutton.Visible = true;


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        ///the back button 
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Backbutton.Visible = false;
            panel2.Visible = false;
        }
        // get Course data from Database
        void BindDataGridView(string Catigory)
        {

            dataGridView1.AutoGenerateColumns = false;
            List<Cours> coursesList=model.Courses.Where(x => x.Category == Catigory).ToList();
            dataGridView1.DataSource = coursesList;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // when double click in datagridview display that course details
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    C.CourseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var course = model.Courses.Where(c => c.CourseID == C.CourseID).FirstOrDefault();
                CourseNamelabel.Text = course.CourseName;
                Descriptionlabel.Text = course.Description;
                Durationlabel.Text = (course.Duration).ToString();
                Pricelabel.Text = (course.Price).ToString();

                panel2.Visible = true;

                }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Durationlabel_Click(object sender, EventArgs e)
        {

        }

        private void CourseNamelabel_Click(object sender, EventArgs e)
        {

        }
        // courses button to display Trainee's courses
        private void button2_Click(object sender, EventArgs e)
        {
            var coursesList = model.Enrollments.Where(x => x.TraineeID == T.TraineeID).ToList();

            foreach (var item in coursesList)
            {
                var courses = model.Courses.Where(x => x.CourseID == item.CourseID).FirstOrDefault();
                listBox1.Items.Add(courses.CourseName);
            }
           


        }

        // Enroll button in course details panal
        private void button4_Click_1(object sender, EventArgs e)
        {
            Enrollment E = new Enrollment();
            E.CourseID = C.CourseID;
            E.TraineeID = T.TraineeID;
            model.Enrollments.Add(E);
            model.SaveChanges();
            MessageBox.Show("Done");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
