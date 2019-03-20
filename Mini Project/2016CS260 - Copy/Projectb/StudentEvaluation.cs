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
    public partial class StudentEvaluation : Form
    {
        public StudentEvaluation()
        {
            InitializeComponent();
            Fillcombo_registration();
            Fillcombo_rubricLevel();
            Fillcombo_Assessment();
        }
       
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        void Fillcombo_registration()
        {
            SqlConnection con = new SqlConnection(connectionstr);
            string query = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string clo = reader.GetString(5);
                    comboBox1 .Items.Add(clo);
                }

            }
            catch
            {

            }
        }
        void Fillcombo_rubricLevel()
        {
            SqlConnection con = new SqlConnection(connectionstr);
            string query = "SELECT * FROM RubricLevel";
            

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string clo = reader.GetString(2);
                    comborubriclevel .Items.Add(clo);
                }

            }
            catch
            {

            }
        }
        void Fillcombo_Assessment()
        {
            string query = "SELECT * FROM Assessment";
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
                    comboassessment .Items.Add(clo);
                }

            }
            catch
            {

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string assessment;
        public int count = 0;

        private void comboassessment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (count == 0)
            {
                comboassessemntcomponent.Items.Clear();

                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                assessment = comboassessment.Text;
                string q = "SELECT Id FROM Assessment WHERE Title='" + comboassessment.Text + "' ";
                SqlCommand edit = new SqlCommand(q, con);
                int a = (Int32)edit.ExecuteScalar();
                Fillcombo_AssessmentComponent(a);
                count = 1;
            }
            else if (count==1)
            {
                comboassessemntcomponent.Items.Clear();
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                assessment = comboassessment.Text;
                string q = "SELECT Id FROM Assessment WHERE Title='" + comboassessment.Text + "' ";
                SqlCommand edit = new SqlCommand(q, con);
                int a = (Int32)edit.ExecuteScalar();
                Fillcombo_AssessmentComponent(a);
                count = 1;
            }


        }
        void Fillcombo_AssessmentComponent(int id)
        {
            SqlConnection con = new SqlConnection(connectionstr);

            string query = "SELECT * FROM AssessmentComponent WHERE AssessmentId='"+id+"'";
            

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string clo = reader.GetString(1);
                    comboassessemntcomponent .Items.Add(clo);
                }

            }
            catch
            {

            }
        }

        private void btnaddrubric_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            string q = ("SELECT Id FROM Student WHERE RegistrationNumber='" + comboBox1 .Text + "'");
            SqlCommand edit = new SqlCommand(q, con);
            int a = (Int32)edit.ExecuteScalar();

            string q1 = ("SELECT Id FROM AssessmentComponent WHERE Name='" + comboassessemntcomponent .Text + "'");
             edit = new SqlCommand(q1, con);
            int aa = (Int32)edit.ExecuteScalar();

            string q2 = ("SELECT Id FROM RubricLevel WHERE Details='" + comborubriclevel .Text + "'");
             edit = new SqlCommand(q2, con);
            int aaa = (Int32)edit.ExecuteScalar();
            DateTime d = DateTime.Now;



            string query = "INSERT INTO StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate)values('" + a + "','" + aa+ "','" +aaa + "','" + d + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been inserted");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();
        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails d = new RubricDetails();
            d.Show();
            this.Hide();
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords f = new CLOrecords();
            f.Show();
            this.Hide();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records form = new Student_records();
            form.Show();
            this.Hide();
        }
    }
}
