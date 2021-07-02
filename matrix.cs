using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capacitymatrix
{
    public partial class matrix : Form
    {
        public matrix()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dashboard dsa = new Dashboard();
            if (MessageBox.Show("Are you Sure you want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dsa.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void matrix_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel1.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-UI4FHMJ\\SQLEXPRESS ; database=Capacitymatrix ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select Plant_code, Process_code, Year_week, Plant_capacity, Order_quantity, (Plant_capacity - Order_quantity) as ATP from Matrix";
           SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int Plant_code;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Plant_code = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;
            panel6.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-UI4FHMJ\\SQLEXPRESS; database =Capacitymatrix ; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Matrix where Plant_code=" + Plant_code + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtProcess.Text = ds.Tables[0].Rows[0][1].ToString();
            txtYrwk.Text = ds.Tables[0].Rows[0][2].ToString();
            txtCapacity.Text = ds.Tables[0].Rows[0][3].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation Dialogue", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-UI4FHMJ\\SQLEXPRESS; database =Capacitymatrix; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Matrix where Plant_code="+rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be edited only for Year Week and Plant Capacity. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                Int64 Year_week = Int64.Parse(txtYrwk.Text);
                Int64 Plant_capacity = Int64.Parse(txtCapacity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-UI4FHMJ\\SQLEXPRESS; database =Capacitymatrix; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Matrix set Year_week=" + Year_week + ", Plant_capacity=" + Plant_capacity + " where Plant_code = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
