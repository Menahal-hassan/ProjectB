using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projectb
{
    public partial class student : Form
    {
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
       
        public student()
        {
            InitializeComponent();
        }
        public int row_id;
        int count=0;

        public student(string id,string fname,string lname,string contact ,string email,string reg)
        {
            InitializeComponent();
            row_id = Convert.ToInt32( id);
            txtfirstname.Text = fname;
            txtlastname.Text = lname;
            txtemail.Text = email;
            txtcontact.Text = contact;
            txtregistration.Text = reg;
            count = 1;

        }
      

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            if (count==0)
            {

                if (con.State == ConnectionState.Open)
                {
                    int sta;
                    if (txtfirstname.Text != "" && txtlastname.Text != "" && txtcontact.Text != "" && txtemail.Text != "" && txtregistration.Text != "")
                    {
                        if (combostatus.Text == "Active")
                        {
                            sta = 5;
                        }
                        else
                        {
                            sta = 6;
                        }
                        string query = "INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status)values('" + txtfirstname.Text.ToString() + "','" + txtlastname.Text.ToString() + "','" + txtcontact.Text.ToString() + "','" + txtemail.Text.ToString() + "','" + txtregistration.Text.ToString() + "', '" + sta + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been inserted");
                        Student_records s = new Student_records();
                        s.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please fill all records");
                    }
                }
                else
                {
                    MessageBox.Show("Student is not registered");
                }
                con.Close();
            }
            else if (count==1)
            {

                string query = "UPDATE Student set FirstName='" + txtfirstname.Text.ToString() + "', LastName='" + txtlastname.Text.ToString() + "',Contact='" + txtcontact.Text.ToString() + "',Email='" + txtemail.Text.ToString() + "', RegistrationNumber='" + txtregistration.Text.ToString() + "' Where Id='"+row_id+"'";
                SqlCommand edit = new SqlCommand(query, con);
                edit.ExecuteNonQuery();
                MessageBox.Show("Record has been Updated");
            }


            
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records s = new Student_records();
            s.Show();
            this.Hide();

        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords c = new CLOrecords();
            c.Show();
            this.Hide();
        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails d = new RubricDetails();
            d.Show();
            this.Hide();

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();

        }

        private void btnevaluation_Click(object sender, EventArgs e)
        {
            StudentResultRecords a = new StudentResultRecords();
            a.Show();
            this.Hide();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            ClassAttendenceRecords c = new ClassAttendenceRecords();
            c.Show();
            this.Hide();
        }

        private void btnassesseemnt_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();
        }
    }
}
