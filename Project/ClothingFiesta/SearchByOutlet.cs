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
    public partial class SearchByOutlet : Form
    {
        public SearchByOutlet()
        {
            InitializeComponent();
        }

        public void addRow(string id, string name, string quantity, string price, string color)
        {
            string[] row = { id, name, quantity, price, color };
            dataGridView1.Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchByOutlet_Load(object sender, EventArgs e)
        {
            SqlConnection connection = DataAccess.GetConnection();
            string query = "SELECT * FROM OUTLET_STOCK;";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxItems.Items.Add(reader["Product_Name"].ToString());
            }

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "MaterialType";
            dataGridView1.Columns[3].Name = "Item Type";
            dataGridView1.Columns[4].Name = "Available At";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //-----Getting Category Value From Product Table--------
            string ProductMaterialType = DataAccess.GetOutletProductMaterialType(Convert.ToString(comboBoxItems.SelectedItem));

            //-----Getting Item Type Value From Product Table--------
            string ProductItemType = DataAccess.GetOutletProductItemType(Convert.ToString(comboBoxItems.SelectedItem));

            //-----Getting Available At Value From Product Table--------
            string AvaialableAt = DataAccess.GetOutletProductAvailableAt(Convert.ToString(comboBoxItems.SelectedItem));

            //-----Getting ID Value From Product Table--------
            object PID= DataAccess.GetOutletProductID(Convert.ToString(comboBoxItems.SelectedItem));
            string ProductID = Convert.ToString(PID);

            if (Convert.ToString(comboBoxItems.SelectedItem) == "")
            {
                MessageBox.Show("Please Select An Item To Search");
            }
            else
            {
                //---------------SHOWING DETAILS ON DATA GRID VIEW----------------------
                addRow(ProductID, Convert.ToString(comboBoxItems.SelectedItem), ProductMaterialType, ProductItemType, AvaialableAt);
            }
            
        }
    }
}
