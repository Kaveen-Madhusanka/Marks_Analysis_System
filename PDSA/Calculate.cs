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

namespace PDSA
{
    public partial class Calculation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\edu2.mdf;Integrated Security=True;Connect Timeout=30");
        public Calculation()
        {
            InitializeComponent();
        }

        private void Calculation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edu2DataSet.data1' table. You can move, or remove it, as needed.
            this.data1TableAdapter.Fill(this.edu2DataSet.data1);
            // TODO: This line of code loads data into the 'edu2DataSet.marks' table. You can move, or remove it, as needed.
            this.marksTableAdapter1.Fill(this.edu2DataSet.marks);
            // TODO: This line of code loads data into the 'marksanalysisDataSet.wp' table. You can move, or remove it, as needed.
            //this.wpTableAdapter.Fill(this.marksanalysisDataSet.wp);
            // TODO: This line of code loads data into the 'marksanalysisDataSet.marks' table. You can move, or remove it, as needed.
           // this.marksTableAdapter.Fill(this.marksanalysisDataSet.marks);


        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from data1", con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Database connection error");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from data1 where year like '%" + txtsearch.Text + "%' ", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
        }
    }
}
