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
    public partial class AddRubriclevel : Form
    {
        public AddRubriclevel()
        {
            InitializeComponent();
        }
        public int ide;
        public int count = 0;
        public AddRubriclevel(string ng)
        {
            InitializeComponent();
            ide = Convert.ToInt32(ng);
           
        }
        public AddRubriclevel(string id,string d,string m)
        {
            InitializeComponent();
            txtname.Text = d;
            textBox1.Text = m;
            count = 1;
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string query = "INSERT INTO RubricLevel(Details,RubricId,MeasurementLevel)values('" + txtname.Text.ToString() + "','" + ide + "','" + textBox1.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been inserted");
            }
            else if (count==1)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                string query = "UPDATE RubricLevel set Details='" + txtname.Text.ToString() + "', MeasurementLevel='" +textBox1.Text.ToString( )+ "'";
                SqlCommand edit = new SqlCommand(query, con);
                edit.ExecuteNonQuery();
                MessageBox.Show("Record has been Updated");
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (count == 0)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string query = "INSERT INTO RubricLevel(Details,RubricId,MeasurementLevel)values('" + txtname.Text.ToString() + "','" + ide + "','" + textBox1.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been inserted");
            }
            else if (count == 1)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                string query = "UPDATE RubricLevel set Details='" + txtname.Text.ToString() + "', MeasurementLevel='" + textBox1.Text.ToString() + "'";
                SqlCommand edit = new SqlCommand(query, con);
                edit.ExecuteNonQuery();
                MessageBox.Show("Record has been Updated");
            }

        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails a = new RubricDetails();
            a.Show();
            this.Hide();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClassAttendenceRecords c = new ClassAttendenceRecords();
            c.Show();
            this.Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            StudentResultRecords a = new StudentResultRecords();
            a.Show();
            this.Hide();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records form = new Student_records();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords a = new CLOrecords();
            a.Show();
            this.Hide();
        }
    }
    }

