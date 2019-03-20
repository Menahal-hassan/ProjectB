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
    public partial class AddAssessmentComponents : Form
    {
        public AddAssessmentComponents()
        {
            InitializeComponent();
            Fillcombo();
        }
        public int count = 0;
        public int c_id;
        public AddAssessmentComponents(string id, string n, string marks,DateTime d)
        {
            InitializeComponent();
            c_id = Convert.ToInt32(id);
            txtname.Text = n;
            textBox1.Text = marks;
           
            Fillcombo();
            count = 1;
        }

        public int id;
        public AddAssessmentComponents(string Id)
        {
            InitializeComponent();
            id = Convert.ToInt32(Id);
            Fillcombo();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        void Fillcombo()
        {
            string query = "SELECT * FROM Rubric";
            SqlConnection con = new SqlConnection(connectionstr);

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string clo = reader.GetString(1);
                    comboBox1 .Items.Add(clo);
                }

            }
            catch
            {

            }
        }

        private void btnaddrubric_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string q = ("SELECT Id FROM Rubric WHERE Details='" + comboBox1.Text + "'");
                SqlCommand edit = new SqlCommand(q, con);
                int a = (Int32)edit.ExecuteScalar();
                string query = "INSERT INTO AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId)values('" + txtname.Text.ToString() + "','" + a + "','" + textBox1.Text.ToString() + "','" + Convert.ToDateTime(DateTime.Now) + "','" + Convert.ToDateTime(DateTime.Now) + "', '" + id + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been inserted");
            }
            else if (count==1)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string q = ("SELECT Id FROM Rubric WHERE Details='" + comboBox1.Text + "'");
                SqlCommand edit = new SqlCommand(q, con);
                int a = (Int32)edit.ExecuteScalar();
                string query = "UPDATE AssessmentComponent set Name='" + txtname.Text.ToString() + "', TotalMarks='" + Convert.ToInt32(textBox1.Text) + "',RubricId='" + a + "' WHERE Id='" + c_id + "'";

                 edit = new SqlCommand(query, con);
                edit.ExecuteNonQuery();
                MessageBox.Show("Record has been Updated");
                Assessment_records aa = new Assessment_records( );
                aa.Show();
                this.Hide();
            }

        }

        private void AddAssessmentComponents_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();
        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails r = new RubricDetails();
            r.Show();
            this.Hide();
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords r = new CLOrecords();
            r.Show();
            this.Hide();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records r = new Student_records();
            r.Show();
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
    }
}
