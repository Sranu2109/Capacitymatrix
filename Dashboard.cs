using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capacitymatrix
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void customizeDesign()
        {
            panelMasterDataSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMasterDataSubmenu.Visible == true)
                panelMasterDataSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMasterDataSubmenu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //......codes
            openChildForm(new Capacity2());

            hideSubMenu();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //.....codes
            Dashboard dsa = new Dashboard();
            dsa.Show();
            this.Hide();
            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            if(MessageBox.Show("Are you Sure you want to logout?","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                login.Show();
                this.Hide();
            }
            //.....codes

            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm( Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(labelVisible == true)
            {
                hmsLabel1.Visible = true;
                hmslabel2.Visible = true;
                hmslabel3.Visible = true;
                labelVisible = false;
            }
            else
            {
                hmsLabel1.Visible = false;
                hmslabel2.Visible = false;
                hmslabel3.Visible = false;
                labelVisible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
