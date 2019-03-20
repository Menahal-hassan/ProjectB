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
    public partial class StudentResultRecords : Form
    {
        public StudentResultRecords()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void StudentResultRecords_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            using (SqlDataAdapter data = new SqlDataAdapter("SELECT stu.FirstName,stu.LastName,AC.Name ,AC.TotalMarks As ComponentMarks, r.MeasurementLevel As StudentRubricLevel   FROM  StudentResult As s  JOIN  Student As stu On stu.Id=s.StudentId   JOIN AssessmentComponent As AC on AC.Id=s.AssessmentComponentId JOIN RubricLevel As r on r.ID=s.RubricMeasurementId", con))
            {
                DataTable table = new DataTable();
                data.Fill(table);
                dataGridView1.DataSource = table;
            }
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                int component_marks =Convert.ToInt32( row.Cells["ComponentMarks"].Value);
                
                int student_rubric_level = Convert.ToInt32(row.Cells["StudentRubricLevel"].Value);
                row.Cells["ObtainMarks"].Value = (student_rubric_level / 4) * component_marks;


            }

            //IronPdf.AspxToPdf.RenderThisPageAsPDF();

            //PdfPrintOptions PdfOptions = new PdfPrintOptions()
            //{
            //    DPI = 300,
            //    EnableJavaScript = false,
            //    //.. many more options available
            //};
            //AspxToPdf.RenderThisPageAsPDF(AspxToPdf.FileBehaviour.Attachment, "MyPdfFile.pdf", PdfOptions);



        }

        private void btnaddrecord_Click(object sender, EventArgs e)
        {
            StudentEvaluation a = new StudentEvaluation();
            a.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
