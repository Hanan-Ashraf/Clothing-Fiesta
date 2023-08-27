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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
        bool sidebarExpand;
        private Form activeForm = null;

        //SideBar Animation
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelSideMenu.Width -= 10;
                if (panelSideMenu.Width == panelSideMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panelSideMenu.Width += 10;
                if (panelSideMenu.Width == panelSideMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //ChildForm Styling
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
        /*-----------------------Buttons Styling-----------------------------*/
        private void btnProducts_MouseHover(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btnProducts_MouseLeave(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.FromArgb(11, 7, 17);
        }

        //private void btn_Items_MouseHover(object sender, EventArgs e)
        //{
        //    btn_Items.BackColor = Color.FromArgb(24, 24, 24); ;
        //}

        //private void btn_Items_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_Items.BackColor = Color.FromArgb(11, 7, 17);
        //}

        private void btn_About_MouseHover(object sender, EventArgs e)
        {
            btn_About.BackColor = Color.FromArgb(24, 24, 24); ;
        }

        private void btn_About_MouseLeave(object sender, EventArgs e)
        {
            btn_About.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void btn_DeliverStock_MouseHover(object sender, EventArgs e)
        {
            btn_DeliverStock.BackColor = Color.FromArgb(24, 24, 24);
        }
        private void btn_DeliverStock_MouseLeave(object sender, EventArgs e)
        {
            btn_DeliverStock.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void btn_logout_MouseHover(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(24, 24, 24);
        }
        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(11, 7, 17);
        }

        /*-------------------------Opening Forms------------------------*/
        private void btn_About_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new About());
        }

        private void btn_DeliverStock_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new StockDelivery());
        }

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
            OpenChildFrom(new Items());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Products());
        }

        private void btn_Discount_MouseHover(object sender, EventArgs e)
        {
            btn_Discount.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btn_Discount_MouseLeave(object sender, EventArgs e)
        {
            btn_Discount.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btn_Discount_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Discount());
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new StockHistory());
        }

        private void btn_History_MouseHover(object sender, EventArgs e)
        {
            btn_History.BackColor = Color.FromArgb(24, 24, 24);
        }

        private void btn_History_MouseLeave(object sender, EventArgs e)
        {
            btn_History.BackColor = Color.FromArgb(11, 7, 17);
        }

        
    }
}
