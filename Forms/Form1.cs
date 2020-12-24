using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingCenterProject
{
    public partial class Form1 : Form
    {
        TrainingCenterEntities model = new TrainingCenterEntities();
        Trainee T = new Trainee();
        Login L = new Login();
        public Form1()
        {
            InitializeComponent();
        }
        // login button in home page  to select SigninPanel
        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = false;
            SigninPanel.Visible = true;
        }
        // Register button in home page to select RegisterPanel
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
            SigninPanel.Visible = false;
        }

        //////////////////////////////Registration Panal/////////////////////////////
        // Register button in Registration Panal
        private void button4_Click(object sender, EventArgs e)
        {
            if (FNametext.Text == "")
                MessageBox.Show("Enter First Name");
            else if (LNametext.Text == "")
                MessageBox.Show("Enter Last Name");
            else if (Emailtext.Text == "")
                MessageBox.Show("Enter Email");
            else if (Phonetext.Text == "")
                MessageBox.Show("Enter Phone");
            else if (CheckEmailValid(Emailtext.Text) == true && CheckPassword() == true)
            {

                GetRegistrationData();
                model.Trainees.Add(T);
                model.SaveChanges();
                L.LoginID = T.TraineeID;
                model.Logins.Add(L);
                model.SaveChanges();
                ClearForm();
            }
        }

        public void GetRegistrationData()
        {
            T.FirstName = FNametext.Text;
            T.LastName = LNametext.Text;
            T.PhoneNo = Phonetext.Text;
            L.Username = T.Email;
            L.Role = 0;

            if (MaleradioButton1.Checked)
            {
                T.Gender = "M";
            }
            else if (FemaleradioButton2.Checked)
            {
                T.Gender = "F";
            }
        }

        public bool CheckPassword()
        {
            if (Passwordtext.Text == AgainPasswordtext.Text)
            {
                L.Password = Passwordtext.Text;
                label10.Visible = false;
                return true;
            }
            else
            {
                label10.Visible = true;//Please make sure your passwords match
                return false;
            }

        }

        public bool CheckEmailValid(string Email)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(Email, pattern))
            {
                label11.Visible = false;
                
                if (CheckEmailExist(Email) == false)
                {
                    T.Email = Email;
                    L.Username = Email;
                    label12.Visible = false;
                    return true;
                }
                else
                {
                    label12.Visible = true;//The email address you have entered is already registered
                    return false;
                }
            }
            else
            {

                label11.Visible = true;//Please enter valid email address
                label12.Visible = false;
                return false;
            }
        }

        //Check if this email is in DB
        bool CheckEmailExist(string Email)
        {
            var exist = model.Trainees.Where(E=> E.Email== Email).FirstOrDefault();
            if (exist != null)
                return true;
            else
                return false;
        }

        void ClearForm()
        {
            FNametext.Text = "";
            LNametext.Text = "";
            Emailtext.Text = "";
            Phonetext.Text = "";
            Passwordtext.Text = "";
            AgainPasswordtext.Text = "";
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            if (MaleradioButton1.Checked)
                MaleradioButton1.Checked = false;
            else
                FemaleradioButton2.Checked = false;
        }

        //////////////////////////////Login Panal/////////////////////////////
        int [] CheckLogin()
        {
            int[] arr = new int[2];
            var email = model.Logins.Where(E => E.Username == LoginEmailTextBox.Text).FirstOrDefault();
            if (email != null)
            {
                if (email.Password == LoginPassTextBox.Text)
                {
                    arr[0] = email.Role;
                    arr[1] = email.LoginID;
                    return arr;
                }
                else
                    return null;
            }
            else
                return null;
        }
        // login button in Login Panal
        private void button3_Click(object sender, EventArgs e)
        {
            int [] arr = CheckLogin();
            if (arr != null)
            {
                label13.Visible = false;// incorrect username or password 
                if (arr[0] == 1)//Admin
                {
                    this.Hide();
                    AdminForm AF = new AdminForm(arr[1]);// Pass Admin id to AdminForm
                    AF.Show();
                    ClearForm();
                }
                else if (arr[0] == 0)//Trainee
                {
                    this.Hide();
                    TraineeForm TF = new TraineeForm(arr[1]); //Pass Trainee id to TraineeForm
                    TF.Show();
                    ClearForm();
                }
            }
            else
            {
                label13.Visible = true;// incorrect username or password 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
