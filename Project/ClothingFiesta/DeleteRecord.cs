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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("Men Fashion");
            comboBoxCategory.Items.Add("Women Fashion");
            comboBoxCategory.Items.Add("Kids Fashion");

            dataGridViewShowStock.ColumnCount = 5;
            dataGridViewShowStock.Columns[0].Name = "Product ID";
            dataGridViewShowStock.Columns[1].Name = "Name";
            dataGridViewShowStock.Columns[2].Name = "Quantity";
            dataGridViewShowStock.Columns[3].Name = "Price";
            dataGridViewShowStock.Columns[4].Name = "Color";

            dataGridViewShowStock.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewShowStock.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewShowStock.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewShowStock.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewShowStock.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void addRow(string id, string name, string quantity, string price, string color)
        {
            string[] row = { id, name, quantity, price, color };
            dataGridViewShowStock.Rows.Add(row);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridViewShowStock.Rows.Clear();
            //-----Getting Quantity Value From Product Table--------
            object ProductQuantity = DataAccess.GetProductQuantity(Convert.ToString(comboBoxItem.SelectedItem));

            //-----Getting Price Value From Product Table--------
            int ProductPrice = DataAccess.GetOutletProductPrice(Convert.ToString(comboBoxItem.SelectedItem));

            //-----Getting Color Value From Product Table--------
            string ProductColor = DataAccess.GetOutletProductColor(Convert.ToString(comboBoxItem.SelectedItem));

            //-----Getting Name Value From Product Table--------
            string ProductName = DataAccess.GetOutletProductName(Convert.ToString(comboBoxItem.SelectedItem));

            //---------------SHOWING DETAILS ON DATA GRID VIEW----------------------
            addRow(Convert.ToString(comboBoxItem.SelectedItem), ProductName, Convert.ToString(ProductQuantity), Convert.ToString(ProductPrice), ProductColor);

            comboBoxCategory.ResetText();
            comboBoxItem.ResetText();
            comboBoxItemType.ResetText();
            comboBoxSubCategory.ResetText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubCategory.Items.Clear();
            comboBoxItemType.Items.Clear();
            comboBoxItem.Items.Clear();
            if (Convert.ToString(comboBoxCategory.SelectedItem) == "Men Fashion")
            {
                comboBoxSubCategory.Items.Add("Western Clothing");
                comboBoxSubCategory.Items.Add("Pakistani Clothing");
                comboBoxSubCategory.Items.Add("Winter Wear");
            }
            else if (Convert.ToString(comboBoxCategory.SelectedItem) == "Women Fashion")
            {
                comboBoxSubCategory.Items.Add("Western Clothing");
                comboBoxSubCategory.Items.Add("Pakistani Clothing");
                comboBoxSubCategory.Items.Add("Winter Wear");
            }
            else if (Convert.ToString(comboBoxCategory.SelectedItem) == "Kids Fashion")
            {
                comboBoxSubCategory.Items.Add("Boys Fashion");
                comboBoxSubCategory.Items.Add("Girls Fashion");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxItemType.Items.Clear();
            comboBoxItem.Items.Clear();

                                                        //Men Parts

            if (Convert.ToString(comboBoxCategory.SelectedItem) == "Men Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Western Clothing")
            {
                comboBoxItemType.Items.Add("Men TShirts");
                comboBoxItemType.Items.Add("Men Shirts");
                comboBoxItemType.Items.Add("Men Pants");
            }
            else if (Convert.ToString(comboBoxCategory.SelectedItem) == "Men Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Pakistani Clothing")
            {
                comboBoxItemType.Items.Add("Men Kamiz Shalwar");
                comboBoxItemType.Items.Add("Men Kurtas ");
                comboBoxItemType.Items.Add("Men Waist Coats");
            }
            else if (Convert.ToString(comboBoxCategory.SelectedItem) == "Men Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Winter Wear")
            {
                comboBoxItemType.Items.Add("Men Jackets and Coats");
                comboBoxItemType.Items.Add("Men Sweaters");
                comboBoxItemType.Items.Add("Men Hoodies");
            }


                                                  //Women Parts


            if (Convert.ToString(comboBoxCategory.SelectedItem) == "Women Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Western Clothing")
            {
                comboBoxItemType.Items.Add("Women Tops and Shirts");
                comboBoxItemType.Items.Add("Women TShirts");
                comboBoxItemType.Items.Add("Women Jeans");
            }
            else if (Convert.ToString(comboBoxCategory.SelectedItem) == "Women Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Pakistani Clothing")
            {
                comboBoxItemType.Items.Add("Women Abaaya and Hijab");
                comboBoxItemType.Items.Add("Women Shawls");
                comboBoxItemType.Items.Add("Women Pants and Plazzoes");

            }
            else if (Convert.ToString(comboBoxCategory.SelectedItem) == "Women Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Winter Wear")
            {
                comboBoxItemType.Items.Add("Women Jackets and Coats");
                comboBoxItemType.Items.Add("Women Hoodies");
            }

                                                     //Kids Parts


            if (Convert.ToString(comboBoxCategory.SelectedItem) == "Kids Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Boys Fashion")
            {
                comboBoxItemType.Items.Add("Boys TShirts");
                comboBoxItemType.Items.Add("Boys Jeans");
                comboBoxItemType.Items.Add("Boys Winter");
            }
            else if (Convert.ToString(comboBoxCategory.SelectedItem) == "Kids Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Girls Fashion")
            {
                comboBoxItemType.Items.Add("Girls Kurta and Shalwar Kameez");
                comboBoxItemType.Items.Add("Girls Pants");
                comboBoxItemType.Items.Add("Girls Frocks");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxItem.Items.Clear();
            SqlDataReader reader = DataAccess.GetOutletItemName(Convert.ToString(comboBoxItemType.SelectedItem));
            while (reader.Read())
            {
                comboBoxItem.Items.Add(reader["Product_ID"].ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess.DeleteProduct(Convert.ToString(comboBoxItem.SelectedItem));
            MessageBox.Show("Product Deleted Successfully!", "Message");
            
            dataGridViewShowStock.Rows.Clear();
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            btnShow.BackColor = Color.Tomato;
            btnShow.ForeColor = Color.White;
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            btnShow.BackColor = Color.White;
            btnShow.ForeColor = Color.Tomato;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Tomato;
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Tomato;
        }
    }
}