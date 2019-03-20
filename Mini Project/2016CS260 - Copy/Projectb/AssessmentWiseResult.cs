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
    public partial class AssessmentWiseResult : Form
    {
        public AssessmentWiseResult()
        {
            InitializeComponent();
        }
        public int count=0;
        public AssessmentWiseResult(int a)
        {
            InitializeComponent();

            count = a;

        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssessmentWiseResult_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();

            if (count == 1)
            {

                using (SqlDataAdapter data = new SqlDataAdapter("SELECT A.Title As AssessmentName ,stu.FirstName,stu.LastName,AC.Name ,AC.TotalMarks As ComponentMarks, r.MeasurementLevel As StudentRubricLevel   FROM  StudentResult As s  JOIN  Student As stu On stu.Id=s.StudentId   JOIN AssessmentComponent As AC on AC.Id=s.AssessmentComponentId JOIN RubricLevel As r on r.ID=s.RubricMeasurementId JOIN Assessment  As A On A.Id=AC.AssessmentID  ", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int component_marks = Convert.ToInt32(row.Cells["ComponentMarks"].Value);

                    int student_rubric_level = Convert.ToInt32(row.Cells["StudentRubricLevel"].Value);
                    row.Cells["ObtainMarks"].Value = (student_rubric_level / 4) * component_marks;


                }
            }
            else if (count==2)
            {
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT clo.Name As CLOName ,stu.FirstName,stu.LastName,AC.Name ,AC.TotalMarks As ComponentMarks, RL.MeasurementLevel As StudentRubricLevel   FROM  StudentResult As s  JOIN  Student As stu On stu.Id=s.StudentId   JOIN RubricLevel As RL on RL.Id=s.RubricMeasurementId JOIN AssessmentComponent As AC on AC.Id=s.AssessmentComponentId JOIN Rubric  As R On R.Id=RL.RubricId  JOIN Clo As clo on clo.Id=R.CloId", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int component_marks = Convert.ToInt32(row.Cells["ComponentMarks"].Value);

                    int student_rubric_level = Convert.ToInt32(row.Cells["StudentRubricLevel"].Value);
                    row.Cells["ObtainMarks"].Value = (student_rubric_level / 4) * component_marks;


                }

            }
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records form = new Student_records();
            form.Show();
            this.Hide();
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords f = new CLOrecords();
            f.Show();
            this.Hide();
        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails d = new RubricDetails();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
