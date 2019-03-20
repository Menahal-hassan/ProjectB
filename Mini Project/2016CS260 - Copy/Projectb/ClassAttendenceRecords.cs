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
    public partial class ClassAttendenceRecords : Form
    {
        public ClassAttendenceRecords()
        {
            InitializeComponent();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void ClassAttendenceRecords_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM ClassAttendance", con))
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
                string q1 = "DELETE FROM StudentAttendance WHERE AttendanceId='" +Convert.ToInt32( id) + "'";
                SqlCommand cmd = new SqlCommand(q1, con);
                cmd.ExecuteNonQuery();
                string query = "DELETE FROM ClassAttendance WHERE Id='" + Convert.ToInt32( id) + "'";

                 cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                MessageBox.Show("Record has been deleted");
                con.Close();

                con.Open();
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM ClassAttendance", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            else if (e.ColumnIndex==1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                Attendancedetailofday a = new Attendancedetailofday(id);
                a.Show();
                this.Hide();
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendence a = new Attendence();
            a.Show();
            this.Hide();
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
