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
    public partial class AdminForm : Form
    {
        TrainingCenterEntities model = new TrainingCenterEntities();
        Staff S = new Staff();
        Login L = new Login();
        public AdminForm(int id)
        {
            InitializeComponent();
            S.StaffID = id;
        }

        private void AddStaffpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //public void GetRegistrationData()
        //{
        //    S.StaffFirstName = FNametext.Text;
        //    S.StaffLastName = LNametext.Text;
        //   S.StaffPhone = Phonetext.Text;
        //    S.StaffAddress = AddresstextBox.Text;
        //    S.StaffSalary =int.Parse( SalarytextBox.Text);
        //    S.StaffPosition = PostiontextBox.Text;
        //    S.StaffBirth_date = dateTimePicker1.Value;
        //    L.Username = S.StaffEmail;
        //    L.TheRole = "2";


        //    if (MaleradioButton1.Checked)
        //    {
        //        S.StaffGender = "M";
        //    }
        //    else if (FemaleradioButton2.Checked)
        //    {
        //        S.StaffGender = "F";
        //    }
        //}

        //public bool CheckPassword()
        //{
        //    if (Passwordtext.Text == AgainPasswordtext.Text)
        //    {
        //        L.Password = Passwordtext.Text;
        //        label10.Visible = false;
        //        return true;
        //    }
        //    else
        //    {
        //        label10.Visible = true;
        //        return false;
        //    }

        //}

        //public bool CheckEmailValid(string Email)
        //{
        //    string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        //    if (Regex.IsMatch(Email, pattern))
        //    {
        //        label11.Visible = false;
        //        if (CheckEmailExist(Email) == false)
        //        {
        //           S.StaffEmail = Email;
        //            L.Username = Email;
        //            label12.Visible = false;
        //            return true;
        //        }
        //        else
        //        {
        //            label12.Visible = true;
        //            return false;
        //        }
        //    }
        //    else
        //    {

        //        label11.Visible = true;
        //        label12.Visible = false;
        //        return false;
        //    }
        //}

        //bool CheckEmailExist(string Email)
        //{
        //    var exist = model.Staffs.Where(s=> s.StaffEmail == Email).FirstOrDefault();
        //    if (exist != null)
        //        return true;
        //    else
        //        return false;
        //}
        void ClearForm()
        {
            FNametext.Text = "";
            LNametext.Text = "";
            Emailtext.Text = "";
            Phonetext.Text = "";
            Passwordtext.Text = "";
            AgainPasswordtext.Text = "";
            PostiontextBox.Text = "";
            AddresstextBox.Text = "";
            SalarytextBox.Text = "";
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            if (MaleradioButton1.Checked)
                MaleradioButton1.Checked = false;
            else
                FemaleradioButton2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (FNametext.Text == "")
                MessageBox.Show("Enter First Name");
            else if (LNametext.Text == "")
                MessageBox.Show("Enter Last Name");
            else if (Emailtext.Text == "")
                MessageBox.Show("Enter Email");
            else if (Phonetext.Text == "")
                MessageBox.Show("Enter Phone");
            else if (AddresstextBox.Text == "")
                MessageBox.Show("Enter Address");
            else if (Phonetext.Text == "")
                MessageBox.Show("Enter Phone");
            //else if (CheckEmailValid(Emailtext.Text) == true && CheckPassword() == true)
            //{

            //    GetRegistrationData();
            //    model.Staffs.Add(S);
            //    model.SaveChanges();
            //    L.ID = S.StaffID;
            //    model.LoginDatas.Add(L);
            //    model.SaveChanges();
            //    ClearForm();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staffpanel.Visible = true;
            Addlabel.Text = "Add Staff";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trainerpanel.Visible = true;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddStaffpanel.Visible = false;
            Trainerpanel.Visible = false;
            Staffpanel.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Staffpanel.Visible = false;
            Trainerpanel.Visible = false;
            AddStaffpanel.Visible = true;
            Addlabel.Text = "Add Staff";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Staffpanel.Visible = false;
            Trainerpanel.Visible = false;
            AddStaffpanel.Visible = true;
            Addlabel.Text = "Add Trainer";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
