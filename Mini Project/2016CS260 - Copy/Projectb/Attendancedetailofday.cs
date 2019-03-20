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
    public partial class Attendancedetailofday : Form
    {
        public Attendancedetailofday()
        {
            InitializeComponent();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        public string id;
        public Attendancedetailofday(string ID)
        {
            InitializeComponent();

            id = ID;
        }

        private void Attendancedetailofday_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM StudentAttendance WHERE AttendanceId='" + id + "'", con))
            {
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
            }
            con.Close();
        }

        private void btnalltendance_Click(object sender, EventArgs e)
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
