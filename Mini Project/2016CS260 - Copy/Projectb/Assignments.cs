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
    public partial class Assignments : Form
    {
        public Assignments()
        {
            InitializeComponent();
        }
        public int count = 0;
        public int ide;
        public Assignments(string d,string name, string  marks,string weightage)
        {
            InitializeComponent();
            ide = Convert.ToInt32(d);
            txttitle.Text = name;
            txtmarks.Text = marks.ToString();
            txtweightage.Text = weightage.ToString();
         
            count = 1;

        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            if (count == 0)
            {
                if (con.State == ConnectionState.Open)
                {

                    if (txttitle.Text != "")
                    {

                        DateTime d = DateTime.Now;
                        string query = "INSERT INTO Assessment(Title,DateCreated,TotalMarks,TotalWeightage)values('" + txttitle.Text.ToString() + "','" + d + "', '" + Convert.ToInt32( txtmarks.Text) + "','"+ Convert.ToInt32( txtweightage.Text)+"' )";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been inserted");
                        Assessment_records a = new Assessment_records();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please fill all records");
                    }
                }
            }
            else if (count == 1)
            {
                string query = "UPDATE Assessment set Title='" + txttitle.Text.ToString() + "', TotalMarks='" +Convert.ToInt32( txtmarks.Text) + "',TotalWeightage='"+Convert.ToInt32( txtweightage.Text)+"' WHERE Id='"+ide+"'";

                SqlCommand edit = new SqlCommand(query, con);
                edit.ExecuteNonQuery();
                MessageBox.Show("Record has been Updated");
                Assessment_records a = new Assessment_records();
                a.Show();
                this.Hide();
                
            }

        }

        private void Assignments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnevaluation_Click(object sender, EventArgs e)
        {
            StudentResultRecords a = new StudentResultRecords();
            a.Show();
            this.Hide();
        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails d = new RubricDetails();
            d.Show();
            this.Hide();
        }
    }
}
