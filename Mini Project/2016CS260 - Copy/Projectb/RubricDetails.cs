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
    public partial class RubricDetails : Form
    {
        public RubricDetails()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        DataSet ds = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

               string  rubric_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string query = "DELETE FROM Rubric WHERE Id='" + rubric_id + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                MessageBox.Show("Record has been deleted");
                con.Close();

                con.Open();
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Rubric", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            else if (e.ColumnIndex==1)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string rubric_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string detail = dataGridView1.Rows[e.RowIndex].Cells["Details"].Value.ToString();
                string clo_id = dataGridView1.Rows[e.RowIndex].Cells["CloId"].Value.ToString();
                Update_rubric a = new Update_rubric(rubric_id, detail, clo_id);
                a.Show();
                this.Hide();
            }
            else if (e.ColumnIndex==2)
            {
                string rubric_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                AddRubriclevel a = new AddRubriclevel(rubric_id);
                a.Show();
                this.Hide();

            }
            else if (e.ColumnIndex==3)
            {
                string rubric_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                RubricLevelRecords a = new RubricLevelRecords(rubric_id);
                a.Show();
                this.Hide();

            }

        }

        private void RubricDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Rubric", con);

            data.Fill(ds, "Clo");
            dataGridView1.DataSource = ds.Tables[0];
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

        private void btnaddRubric_Click(object sender, EventArgs e)
        {
            CLOrecords a = new CLOrecords();
            a.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
