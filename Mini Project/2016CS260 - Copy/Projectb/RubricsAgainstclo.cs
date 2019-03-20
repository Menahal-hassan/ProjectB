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
    public partial class RubricsAgainstclo : Form
    {
        public RubricsAgainstclo()
        {
            InitializeComponent();
        }
        public static int ID;
        DataSet ds = new System.Data.DataSet();
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        public RubricsAgainstclo(string id)
        {
            ID = Convert.ToInt32( id);
            InitializeComponent();
        }

        private void RubricsAgainstclo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Rubric WHERE CloId='" + ID + "'", con);

            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                string rubric_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string query = "DELETE FROM Rubric WHERE Id='" + rubric_id + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                MessageBox.Show("Record has been deleted");
              
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Rubric WHERE CloId='" + ID + "'", con))
                {
                    DataTable table = new DataTable();
                    data.Fill(table);
                    dataGridView1.DataSource = table;
                }
               
                con.Close();

            }
            else if(e.ColumnIndex==1)
            {
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells["Details"].Value.ToString();
                string c = dataGridView1.Rows[e.RowIndex].Cells["CloId"].Value.ToString();
                Update_rubric stu = new Update_rubric (id,name,c);
                stu.Show();
                this.Hide();
            }
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            Student_records r = new Student_records();
            r.Show();
            this.Hide();
        }

        private void btnmanageclos_Click(object sender, EventArgs e)
        {
            CLOrecords r = new CLOrecords();
            r.Show();
            this.Hide();

        }

        private void btnrucric_Click(object sender, EventArgs e)
        {
            RubricDetails r = new RubricDetails();
            r.Show();
            this.Hide();
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
