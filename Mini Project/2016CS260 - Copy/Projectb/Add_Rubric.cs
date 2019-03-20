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
    public partial class Add_Rubric : Form
    {
        public Add_Rubric()
        {
            InitializeComponent();
        }
        public Add_Rubric(string rubricid,string detail,string cliod)
        {
            InitializeComponent();

        }
        public int Id;
        public int count = 0;
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        public Add_Rubric(string id)
        {
            InitializeComponent();
            Id = Convert.ToInt32( id);

        }

        private void btnaddrubric_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            
                if (con.State == ConnectionState.Open)
                {

                    if (txtrubricdetail.Text != "")
                    {
                        string query = "INSERT INTO Rubric(Details,CloId)values('" + txtrubricdetail.Text.ToString() + "','" + Id + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been inserted");
                    RubricDetails d = new RubricDetails();
                    d.Show();
                    this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Please fill all records");
                    }
                }
            




        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails d = new RubricDetails();
            d.Show();
            this.Hide();
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords c = new CLOrecords();
            c.Show();
            this.Hide();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records s = new Student_records();
            s.Show();
            this.Hide();
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
    }
    }

