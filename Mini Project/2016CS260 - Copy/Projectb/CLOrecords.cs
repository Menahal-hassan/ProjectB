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
    public partial class CLOrecords : Form
    {
        public CLOrecords()
        {
            InitializeComponent();
        }
        DataSet ds = new System.Data.DataSet();
        public string clo_id;
        public string connectionstr = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
        private void btnaddclos_Click(object sender, EventArgs e)
        {
            CLOs form = new CLOs();
            form.Show();
            this.Hide();

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void CLOrecords_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstr);
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Clo", con);

            data.Fill(ds, "Clo");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                clo_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                SqlConnection con = new SqlConnection(connectionstr);
                con.Open();

              
                string q = ("SELECT Id FROM Rubric WHERE CloId='" +  clo_id+ "'");
                SqlCommand edit = new SqlCommand(q, con);
                object result = edit.ExecuteScalar();
                result = (result == DBNull.Value) ? null : result;
                int a = Convert.ToInt32(result);



                string q2 = ("SELECT Id FROM RubricLevel WHERE RubricId='" + a+ "'");
                edit = new SqlCommand(q2, con);
                 result = edit.ExecuteScalar();
                result = (result == DBNull.Value) ? null : result;
                int aa = Convert.ToInt32(result);


                string qu2 = "DELETE FROM StudentResult WHERE RubricMeasurementId='" + aa + "'";
                SqlCommand cmd = new SqlCommand(qu2, con);
                cmd.ExecuteNonQuery();

                string qu1 = "DELETE FROM RubricLevel WHERE RubricId='" + a+ "'";
                 cmd = new SqlCommand(qu1, con);
                cmd.ExecuteNonQuery();
                string qu22 = "DELETE FROM AssessmentComponent WHERE RubricId='" + a + "'";
                cmd = new SqlCommand(qu22, con);
                cmd.ExecuteNonQuery();
                string qu = "DELETE FROM Rubric WHERE CloId='" + clo_id + "'";
                 cmd = new SqlCommand(qu, con);
                cmd.ExecuteNonQuery();

                string query = "DELETE FROM Clo WHERE Id='" + clo_id + "'";
                cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                dataGridView1.Update();
                MessageBox.Show("Record has been deleted");
                con.Close();

                con.Open();
                using (SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Clo", con))
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
                clo_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string name= dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                DateTime created= Convert.ToDateTime( dataGridView1.Rows[e.RowIndex].Cells["DateCreated"].Value.ToString());
                DateTime updated = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["DateUpdated"].Value.ToString());
                CLOs stu = new CLOs(name,created,updated);
                stu.Show();
                this.Hide();
            }
            else if (e.ColumnIndex==2)
            {              
                clo_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                Add_Rubric rubric = new Add_Rubric(clo_id);
                rubric.Show();
                this.Hide();

            }
            else if(e.ColumnIndex == 3)
            {
                clo_id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                RubricsAgainstclo rubric = new RubricsAgainstclo(clo_id);
                rubric.Show();
                this.Hide();


            }
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
            RubricDetails a = new RubricDetails();
            a.Show();
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

        private void btnattendence_Click(object sender, EventArgs e)
        {
            ClassAttendenceRecords c = new ClassAttendenceRecords();
            c.Show();
            this.Hide();
        }
    }
}
