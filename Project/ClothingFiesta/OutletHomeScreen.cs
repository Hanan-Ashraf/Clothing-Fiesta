using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingFiesta
{
    public partial class OutletHomeScreen : Form
    {
        public OutletHomeScreen()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        bool sidebarExpand;

        //SideBar Animation
        private void timerSideMenu_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelSideMenu.Width -= 10;
                if (panelSideMenu.Width == panelSideMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerSideMenu.Stop(); 
                }
            }
            else
            {
                panelSideMenu.Width += 10;
                if (panelSideMenu.Width == panelSideMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerSideMenu.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            timerSideMenu.Start();
        }

        //ChildForm
        private void OpenChildFrom(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new OutletStock());
        }

        //Logout
        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to Logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                this.Close();
                SplashScreen login = new SplashScreen();
                login.Show();
            }
            else if (exit == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new DeleteRecord());
        }

        private void btn_DeliverStock_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new SearchByOutlet());
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btn_Items_MouseHover(object sender, EventArgs e)
        {
            btn_Items.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btn_Items_MouseLeave(object sender, EventArgs e)
        {
            btn_Items.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btn_SearchByOutlet_MouseHover(object sender, EventArgs e)
        {
            btn_SearchByOutlet.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btn_SearchByOutlet_MouseLeave(object sender, EventArgs e)
        {
            btn_SearchByOutlet.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GenerateBillOutlet());
        }

        private void btn_RECEIPT_MouseHover(object sender, EventArgs e)
        {
            btn_RECEIPT.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btn_RECEIPT_MouseLeave(object sender, EventArgs e)
        {
            btn_SearchByOutlet.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btn_RECEIPT_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new GenerateBillOutlet());
        }

        
    }
}
