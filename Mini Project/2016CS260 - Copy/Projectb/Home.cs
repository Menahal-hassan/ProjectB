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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

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

        private void btnmanagettendence_Click(object sender, EventArgs e)
        {
            ClassAttendenceRecords c = new ClassAttendenceRecords();
            c.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentResultRecords a = new StudentResultRecords();
            a.Show();
            this.Hide();
        }

        private void btnassessmentresult_Click(object sender, EventArgs e)
        {
            AssessmentWiseResult a = new AssessmentWiseResult(1);
            a.Show();
            this.Hide();
            
        }

        private void btnclowiseResult_Click(object sender, EventArgs e)
        {
            AssessmentWiseResult a = new AssessmentWiseResult(2);
            a.Show();
            this.Hide();

        }
    }
}
