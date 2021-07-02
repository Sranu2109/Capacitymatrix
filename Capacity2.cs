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
    public partial class Capacity2 : Form
    {
        public Capacity2()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=  DESKTOP-UI4FHMJ\\SQLEXPRESS ;database= Capacitymatrix; integrated security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "select * from Matrix where Plant_code = '" + textBox1.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
            {
                    matrix dsa = new matrix();
                    dsa.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Plant Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Mandatory!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Mandatory!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, "");
            }
        }

        private void btnAddRows_Click(object sender, EventArgs e)
        {
            
        }

    }
}
