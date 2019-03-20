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
    public partial class Update_rubric : Form
    {
        public Update_rubric()
        {
            InitializeComponent();
            Fillcombo();
        }
        public int Idee;
        public string n;
        public Update_rubric(string id,string deatil,string c)
        {
            InitializeComponent();
            Idee = Convert.ToInt32(id);
            
            txtrubricdetail.Text = deatil;
            combostatus.Text = c;
            Fillcombo();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        void Fillcombo()
        {
            string query ="SELECT * FROM Clo";
            SqlConnection con = new SqlConnection(connectionstr);
            
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string clo = reader.GetString(1);
                    combostatus.Items.Add(clo);
                }

            }
            catch
            {

            }
        }

        private void btnaddrubric_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            string q = ("SELECT Id FROM Clo WHERE Name='" + combostatus.Text + "'");
            SqlCommand edit = new SqlCommand(q, con);
            int a=(Int32)edit.ExecuteScalar();
            string query = "UPDATE Rubric SET Details='" + txtrubricdetail.Text.ToString() + "', CloId='" + a+ "' WHERE Id='"+Idee+"'";
            edit = new SqlCommand(query, con);
            edit.ExecuteNonQuery();
            MessageBox.Show("Record has been Updated");

        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records s = new Student_records();
            s.Show();
            this.Hide();
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords c = new CLOrecords();
            c.Show();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

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
