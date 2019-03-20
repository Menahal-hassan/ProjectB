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
    public partial class CLOs : Form
    {
        public CLOs()
        {
            InitializeComponent();
        }
        public int count = 0;
        public CLOs(string name,DateTime c,DateTime updated)
        {
            InitializeComponent();
            txtname.Text = name;
            dateTimePicker1.Text = Convert.ToString(c);
            string d = Convert.ToString( updated);
            count = 1;

        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
       

        private void btnaddclos_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            if (count == 0)
            {
                if (con.State == ConnectionState.Open)
                {

                    if (txtname.Text != "")
                    {

                        DateTime d = Convert.ToDateTime(dateTimePicker1.Text);
                        string query = "INSERT INTO Clo(Name,DateCreated,DateUpdated)values('" + txtname.Text.ToString() + "','" + d + "', '" + d + "' )";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been inserted");
                        CLOrecords a = new CLOrecords();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please fill all records");
                    }
                }
            }
            else if (count==1)
            {
                string query = "UPDATE Clo set Name='" + txtname.Text.ToString() + "', DateCreated='" + Convert.ToDateTime(dateTimePicker1.Text) + "',DateUpdated='" + Convert.ToString(DateTime.Now) +"'";
                SqlCommand edit = new SqlCommand(query, con);
                edit.ExecuteNonQuery();
                MessageBox.Show("Record has been Updated");
            }
            


        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
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
        private void button_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();
        }

        private void btnassessment_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();

        }

        private void btnattendance_Click(object sender, EventArgs e)
        {


            ClassAttendenceRecords c = new ClassAttendenceRecords();
            c.Show();
            this.Hide();
        }

        private void btnevaluation_Click(object sender, EventArgs e)
        {
            StudentResultRecords a = new StudentResultRecords();
            a.Show();
            this.Hide();
        }
    }
}

