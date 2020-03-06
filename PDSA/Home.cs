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
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\edu2.mdf;Integrated Security=True;Connect Timeout=30");
        int length = 0;
        List<int> marksol = new List<int>();
        int tot = 0;
        float mean = 0;
        int len = 0;
        float std = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void calculateStaticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void regressionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void forecastErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void calculateStaticsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Calculation().Show();
            this.Hide();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into marks values('" + txtsindex.Text + "','" + txtmarksol.Text + "','" + txtmarksendturm.Text + "','" + txtyear.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("inserted");

                int x = Convert.ToInt32(txtmarksol.Text);
                marksol.Add(x);
                tot = tot + x;
                len = marksol.Count;

                //MessageBox.Show(Convert.ToString(len));
                //MessageBox.Show(Convert.ToString(tot));

            }
            catch (Exception ex) { 
            
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {

                float answer = 0;
                int x = 0;

                mean = tot / len;

                // MessageBox.Show(Convert.ToString(mean));
                // int l = marksol[0];
                // MessageBox.Show(Convert.ToString(l));

                for (int i = 0; i < len; i++)
                {
                    x = marksol[i];
                    answer = answer + (x - mean) * (x - mean);

                }

                std = answer / len;
                lblmin.Text = Convert.ToString(mean);
                lblstd.Text = Convert.ToString(std);
                // MessageBox.Show(Convert.ToString(std));

                con.Open();
                SqlCommand cmd = new SqlCommand(" insert into data1 values('" + lblmin.Text + "','" + lblstd.Text + "','" + txtyear.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();

            
            }
            catch (Exception ex)
            {

            }
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try {

                con.Open();
                SqlCommand cmd = new SqlCommand(" delete from marks where sindex = '" + txtsindex.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted");

            }

            catch (Exception ex)
            {

            }
            

        }

        private void calculateStaticsToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            new Calculation().Show();
            this.Hide();
        }

        private void txtmarksol_Leave(object sender, EventArgs e)
        {
            if (txtmarksol.Text.All(char.IsDigit) != true)
            {
                MessageBox.Show("check  o/l text value", "only number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtmarksendturm_Leave(object sender, EventArgs e)
        {
            if (txtmarksendturm.Text.All(char.IsDigit) != true)
            {
                MessageBox.Show("check  end turm text value", "only number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void oldDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new details().Show();
            this.Hide();
        }
    }
}
