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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Attendence_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            DateTime t = DateTime.Now;
            string query = "INSERT INTO ClassAttendance(AttendanceDate)values('"+t+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            int status =0 ;
            int c=dataGridView1.Rows.Count;
            int s=0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["Id"].Value != null)
                {
                    string student_id = Convert.ToString(row.Cells["Id"].Value);

                    s = Convert.ToInt32(student_id);




                    if (Convert.ToString(row.Cells["AttendenceStatus"].Value) == "Present")
                    {
                        status = 1;
                    }
                    else if (Convert.ToString(row.Cells["AttendenceStatus"].Value) == "Absent")
                    {
                        status = 2;
                    }
                    else if (Convert.ToString(row.Cells["AttendenceStatus"].Value) == "Leave")
                    {
                        status = 3;

                    }
                    else if (Convert.ToString(row.Cells["AttendenceStatus"].Value) == "Late")
                    {
                        status = 4;
                    }
                    string q = ("SELECT Id FROM ClassAttendance WHERE AttendanceDate='" + t + "'");
                    SqlCommand edit = new SqlCommand(q, con);
                    int a = (Int32)edit.ExecuteScalar();

                    string query1 = "INSERT INTO StudentAttendance(AttendanceId,StudentId,AttendanceStatus)values('" + a + "','" + s + "','" + status + "')";
                    cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Attendance marked");
        }

        private void btnevaluation_Click(object sender, EventArgs e)
        {
            StudentResultRecords a = new StudentResultRecords();
            a.Show();
            this.Hide();
        }

        private void btnattendence_Click(object sender, EventArgs e)
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
