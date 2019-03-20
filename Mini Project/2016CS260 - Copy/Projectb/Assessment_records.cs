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
    public partial class Assessment_records : Form
    {
        public Assessment_records()
        {
            InitializeComponent();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Assessment_records_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Assessment", con))
            {
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string q2 = ("SELECT Id FROM AssessmentComponent WHERE AssessmentId='" + id + "'");
                SqlCommand edit = new SqlCommand(q2, con);
                Object result = edit.ExecuteScalar();
                result = (result == DBNull.Value) ? null : result;
                int aa = Convert.ToInt32(result);
                string query0 = "DELETE FROM StudentResult WHERE AssessmentComponentId='" + aa + "'";
                string query1 = "DELETE FROM AssessmentComponent WHERE AssessmentId='" + id + "'";
                string query = "DELETE FROM Assessment WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query0, con);
                cmd.ExecuteNonQuery();
                 cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                MessageBox.Show("Record has been deleted");
                con.Close();

                con.Open();
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Assessment", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            else if (e.ColumnIndex==1)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string Title = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                string tmarks = dataGridView1.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString();
                string Tweightage = dataGridView1.Rows[e.RowIndex].Cells["TotalWeightage"].Value.ToString();
                Assignments stu = new Assignments(id, Title, tmarks, Tweightage);
                stu.Show();
                this.Hide();
            }
            else if (e.ColumnIndex==2)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                AddAssessmentComponents a = new AddAssessmentComponents(id);
                a.Show();
                this.Hide();


            }
            else if (e.ColumnIndex==3)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                AssessmentComponentRecords a = new AssessmentComponentRecords(id);
                a.Show();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assignments a = new Assignments();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assessment_records r = new Assessment_records();
            r.Show();
            this.Hide();
        }

        private void btnattendence_Click(object sender, EventArgs e)
        {
            ClassAttendenceRecords c = new ClassAttendenceRecords();
            c.Show();
            this.Hide();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records a = new Student_records(); ;
            a.Show();
            this.Hide(); 
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords a = new CLOrecords();
            a.Show();
            this.Hide();


        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails d = new RubricDetails();
            d.Show();
            this.Hide();
        }

        private void btnEvaluation_Click(object sender, EventArgs e)
        {
            StudentResultRecords a = new StudentResultRecords();
            a.Show();
            this.Hide();
        }
    }
}
