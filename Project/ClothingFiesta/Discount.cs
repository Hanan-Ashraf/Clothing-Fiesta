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
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT * FROM PRODUCT;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSelectItem.Items.Add(reader["Product_Name"].ToString());
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = DataAccess.GetProductsDetails(Convert.ToString(comboBoxSelectItem.SelectedItem));
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewDiscount.DataSource = dt;

            comboBoxSelectItem.ResetText();
        }

        private void btn_Show_MouseHover(object sender, EventArgs e)
        {
            btn_Show.BackColor = Color.Tomato;
            btn_Show.ForeColor = Color.White;
        }

        private void btn_Show_MouseLeave(object sender, EventArgs e)
        {
            btn_Show.BackColor = Color.White;
            btn_Show.ForeColor = Color.Tomato;
        }

        private void btn_ApplyDiscount_MouseHover(object sender, EventArgs e)
        {
            btn_ApplyDiscount.BackColor = Color.Tomato;
            btn_ApplyDiscount.ForeColor = Color.White;
        }

        private void btn_ApplyDiscount_MouseLeave(object sender, EventArgs e)
        {
            btn_ApplyDiscount.BackColor = Color.White;
            btn_ApplyDiscount.ForeColor = Color.Tomato;
        }

        private void btn_ApplyDiscount_Click(object sender, EventArgs e)
        {
            int OldPrice = (int)DataAccess.GetProductPrice(txt_NewPrice.Text);

            if (txt_NewPrice.Text != "" && txt_NewPrice.Text != "0")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataAccess.SetPrice(int.Parse(txt_NewPrice.Text), Convert.ToString(comboBoxSelectItem.SelectedItem));
                    MessageBox.Show("Price Updated Successfully!");
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("Please Enter Valid Price", "Incorrect Price");
                txt_NewPrice.Text = "";
            }
        }
    }
}
