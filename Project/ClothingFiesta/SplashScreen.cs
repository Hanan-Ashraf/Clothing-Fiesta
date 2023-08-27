using System;
using ClothingFiesta.DataLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingFiesta
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_Username;
        }
        /*---------------------------Buttons Styling----------------------------*/
        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.ForeColor = Color.White;
            btn_Exit.BackColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.ForeColor = Color.Red;
            btn_Exit.BackColor = Color.White;
        }
        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.Tomato;
            btn_Login.ForeColor = Color.White;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.White;
            btn_Login.ForeColor = Color.Tomato;
        }

        /*--------------------------------Login Button--------------------------------*/
        private void btn_Login_Click(object sender, EventArgs e)
        {
            object accType = comboAccType.SelectedItem;
            string getAccType = comboAccType.GetItemText(accType);

            string username, user_pass;
            username = txt_Username.Text;
            user_pass = txt_Password.Text;
            if (getAccType == "Admin")
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT AdminUsername, AdminPassword FROM ADMIN_T WHERE AdminUsername = '" + txt_Username.Text+ "' AND AdminPassword = '"+txt_Password.Text+"';";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);
                DataTable adminTable = new DataTable();
                sqlAdapter.Fill(adminTable);
                if (adminTable.Rows.Count > 0)
                {
                    username = txt_Username.Text;
                    user_pass = txt_Password.Text;

                    HomeScreen home = new HomeScreen();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                    txt_Username.Text = "";
                    txt_Password.Text = "";
                    txt_Username.Focus();
                }
            }
            else if (getAccType == "Outlet")
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT ManagerUsername, ManagerPassword FROM OUTLET_MANAGER WHERE ManagerUsername = '"+txt_Username.Text+"' AND ManagerPassword = '"+txt_Password.Text+ "';";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);
                DataTable managerTable = new DataTable();
                sqlAdapter.Fill(managerTable);
                if (managerTable.Rows.Count > 0)
                {
                    username = txt_Username.Text;
                    user_pass = txt_Password.Text;

                    OutletHomeScreen outletHome = new OutletHomeScreen();
                    outletHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                    txt_Username.Text = "";
                    txt_Password.Text = "";
                    txt_Username.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid Account Type");
                txt_Username.Text = "";
                txt_Password.Text = "";
                txt_Username.Focus();
            }
        }

        /*--------------------------------Exit Button--------------------------------*/
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (exit == DialogResult.No)
            {
                //Nothing to do
            }
        }
    }
}
