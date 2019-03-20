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
    public partial class AssessmentComponentRecords : Form
    {
        public AssessmentComponentRecords()
        {
            InitializeComponent();
        }
        public int id;
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        public AssessmentComponentRecords(string ID)
        {
            InitializeComponent();
            id = Convert.ToInt32(ID);
        }


        private void AssessmentComponentRecords_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM AssessmentComponent WHERE AssessmentId='"+id+"'", con))
            {
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
            }
            con.Close();


        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records r = new Student_records();
            r.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string query = "DELETE FROM AssessmentComponent WHERE Id='" + id + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                MessageBox.Show("Record has been deleted");
                con.Close();

                con.Open();
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM AssessmentComponent WHERE AssessmentId='"+id+"'", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string Title = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string tmarks = dataGridView1.Rows[e.RowIndex].Cells["TotalMarks"].Value.ToString();
                DateTime d = DateTime.Now;
                AddAssessmentComponents stu = new AddAssessmentComponents(id, Title, tmarks,d);
                stu.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnattendence_Click(object sender, EventArgs e)
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
