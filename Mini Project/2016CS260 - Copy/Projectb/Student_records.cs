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
    public partial class Student_records : Form
    {

        public Student_records()
        {
            InitializeComponent();
        }
       
        DataSet ds = new System.Data.DataSet();
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        public string stu_id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                stu_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string query1= "DELETE FROM StudentResult WHERE StudentId='" + stu_id + "'";
                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.ExecuteNonQuery();
                
                 string query2 = "DELETE FROM StudentAttendance WHERE StudentId='" + stu_id + "'";

                cmd = new SqlCommand(query2, con);
                cmd.ExecuteNonQuery();

                string query = "DELETE FROM Student WHERE Id='" + stu_id + "'";

                 cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                MessageBox.Show("Record has been deleted");
                con.Close();

                con.Open();
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Student", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                stu_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string fname = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                string lname = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                string contact = dataGridView1.Rows[e.RowIndex].Cells["Contact"].Value.ToString();
                string email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                string registration = dataGridView1.Rows[e.RowIndex].Cells["RegistrationNumber"].Value.ToString();
                student stu = new student(stu_id,fname,lname,contact,email,registration);
                stu.Show();
                this.Hide();
            }

        }

        private void Student_records_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
         
            using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Student", con))
            {
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student form = new student();
            form.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
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
            Student_records s = new Student_records();
            s.Show();
            this.Hide();
        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails d = new RubricDetails();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
