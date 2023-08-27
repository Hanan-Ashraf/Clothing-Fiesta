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
    public partial class StockDelivery : Form
    {
        public void addRow(string id, string name, string price, string quantity, string material, string color, string itemType, string deliverTo, string date)
        {
            string[] row = { id, name, price, quantity, material, color, itemType, deliverTo, date };
            dataGridStock.Rows.Add(row);
        }
        public StockDelivery()
        {
            InitializeComponent();
        }

        /*--------------------------------Current Date--------------------------------*/
        private void StockDelivery_Load(object sender, EventArgs e)
        {
            timerDate.Start();
            comboCategory.Items.Add("Kids Fashion");
            comboCategory.Items.Add("Men Fashion");
            comboCategory.Items.Add("Women Fashion");

            SqlDataReader reader = DataAccess.readFromOutlet();
            while (reader.Read())
            {
                comboBoxOutlet.Items.Add(reader["OutletName"].ToString());
            }
            dataGridStock.ColumnCount = 8;
            dataGridStock.Columns[0].Name = "Product ID";
            dataGridStock.Columns[1].Name = "Name";
            dataGridStock.Columns[2].Name = "Price";
            dataGridStock.Columns[3].Name = "Quantity";
            dataGridStock.Columns[4].Name = "Material";
            dataGridStock.Columns[5].Name = "Color";
            dataGridStock.Columns[6].Name = "Item Type";
            dataGridStock.Columns[7].Name = "Deliver To";

            dataGridStock.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /*--------------------------------Current Date--------------------------------*/
        private void timerDate_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
        }

        /*--------------------------------Buttons Styling--------------------------------*/
        private void btn_Add_MouseHover(object sender, EventArgs e)
        {
            btn_Add.BackColor = Color.Tomato;
            btn_Add.ForeColor = Color.White;
        }

        private void btn_Add_MouseLeave(object sender, EventArgs e)
        {
            btn_Add.BackColor = Color.White;
            btn_Add.ForeColor = Color.Tomato;
        }

        private void btn_Deliver_MouseHover(object sender, EventArgs e)
        {
            btn_Bill.BackColor = Color.Tomato;
            btn_Bill.ForeColor = Color.White;
        }

        private void btn_Deliver_MouseLeave(object sender, EventArgs e)
        {
            btn_Bill.BackColor = Color.White;
            btn_Bill.ForeColor = Color.Tomato;
        }

        /*--------------------------------Printing Invoice--------------------------------*/
        Bitmap bitmap;
        private Random random = new Random();
        private string stockID;
        private string ProductID;
        private int ProductPrice;
        private string ProductMaterial;
        private string ProductColor;


        
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 60, 20);
        }


        //-------------------------Add Item Button-------------------------//
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboCategory.SelectedItem) != "" && Convert.ToString(comboBoxSubCategory.SelectedItem) != "" && Convert.ToString(comboBoxItemType.SelectedItem) != "" && Convert.ToString(comboBoxItems.SelectedItem) != "" && Convert.ToString(comboBoxOutlet.SelectedItem) != "")
            {
                //Getting Product ID From Products Table
                ProductID = DataAccess.GetProductID(Convert.ToString(comboBoxItems.SelectedItem));

                //-----Getting Price Value From Product Table--------
                ProductPrice = DataAccess.GetProductPrice(Convert.ToString(comboBoxItems.SelectedItem));

                //-----Getting Material Value From Product Table--------
                ProductMaterial = DataAccess.GetMaterialType(Convert.ToString(comboBoxItems.SelectedItem));

                //-----Getting Color Value From Product Table--------
                ProductColor = DataAccess.GetProductColor(Convert.ToString(comboBoxItems.SelectedItem));

                string Date = DateTime.Now.ToShortDateString();

                //Updating Product Quantity
                object pQuantity = DataAccess.GetProductQuantity(Convert.ToString(comboBoxItems.SelectedItem));
                int userInput = (int)numericUpDownQuantity.Value;
                int ProductQuantity = (int)(pQuantity);
                int newQuantity = ProductQuantity - (int)numericUpDownQuantity.Value;
                DataAccess.SetQuantity(newQuantity, Convert.ToString(comboBoxItems.SelectedItem));

                //---------------SHOWING DETAILS ON DATA GRID VIEW----------------------
                addRow(ProductID, Convert.ToString(comboBoxItems.SelectedItem), Convert.ToString(ProductPrice), Convert.ToString(numericUpDownQuantity.Value), ProductMaterial, ProductColor, Convert.ToString(comboBoxItemType.SelectedItem), Convert.ToString(comboBoxOutlet.SelectedItem), Date);

                comboBoxItems.ResetText();
                comboBoxItems.Items.Clear();
                comboBoxItemType.ResetText();
                comboBoxItemType.Items.Clear();
                comboBoxOutlet.ResetText();
                comboBoxSubCategory.ResetText();
                comboBoxSubCategory.Items.Clear();
                comboCategory.ResetText();
            }
            else
            {
                MessageBox.Show("Please  fill all the fields");
            }
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            stockID = new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            int height = dataGridStock.Height;
            dataGridStock.Height = dataGridStock.RowCount * dataGridStock.RowTemplate.Height * 2;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridStock.Width, this.dataGridStock.Height);
            dataGridStock.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridStock.Width, this.dataGridStock.Height));

            //Resize DataGridView back to original height.
            dataGridStock.Height = height;

            string date = DateTime.Now.ToShortDateString();
            //Set Values Ro Stock Delivery Table
            DataAccess.SaveDataGridViewToStockDelivery(dataGridStock, stockID, ProductID, Convert.ToString(comboBoxItems.SelectedItem), (int)numericUpDownQuantity.Value, Convert.ToString(comboBoxItemType.SelectedItem), date);

            //Set Values To OutletStock Table
            DataAccess.SaveDataGridViewToOutletStock(dataGridStock, ProductID, Convert.ToString(comboBoxItems.SelectedItem), (int)numericUpDownQuantity.Value, ProductPrice, ProductColor, ProductMaterial, Convert.ToString(comboBoxItemType.SelectedItem), Convert.ToString(comboBoxOutlet.SelectedItem));

            //Show the Print Preview Dialog.
            printPreviewStockInvoice.Document = printStockInvoice;
            printPreviewStockInvoice.PrintPreviewControl.Zoom = 1;
            printPreviewStockInvoice.ShowDialog();


            dataGridStock.Rows.Clear();
        }

        //Combo Boxes
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubCategory.ResetText();
            comboBoxSubCategory.Items.Clear();
            comboBoxItemType.ResetText();
            comboBoxItemType.Items.Clear();
            if (Convert.ToString(comboCategory.SelectedItem) == "Men Fashion")
            {
                comboBoxSubCategory.Items.Add("Western Clothing");
                comboBoxSubCategory.Items.Add("Pakistani Clothing");
                comboBoxSubCategory.Items.Add("Winter Wear");
            }
            else if (Convert.ToString(comboCategory.SelectedItem) == "Women Fashion")
            {
                comboBoxSubCategory.Items.Add("Western Clothing");
                comboBoxSubCategory.Items.Add("Pakistani Clothing");
                comboBoxSubCategory.Items.Add("Winter Wear");
            }
            else if (Convert.ToString(comboCategory.SelectedItem) == "Kids Fashion")
            {
                comboBoxSubCategory.Items.Add("Boys Fashion");
                comboBoxSubCategory.Items.Add("Girls Fashion");
            }
        }

        private void comboBoxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxItemType.ResetText();
            comboBoxItemType.Items.Clear();

            //Men Parts

            if (Convert.ToString(comboCategory.SelectedItem) == "Men Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Western Clothing")
            {
                comboBoxItemType.Items.Add("Men TShirts");
                comboBoxItemType.Items.Add("Men Shirts");
                comboBoxItemType.Items.Add("Men Pants");
            }
            else if (Convert.ToString(comboCategory.SelectedItem) == "Men Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Pakistani Clothing")
            {
                comboBoxItemType.Items.Add("Men Kamiz Shalwar");
                comboBoxItemType.Items.Add("Men Kurtas ");
                comboBoxItemType.Items.Add("Men Waist Coats");
            }
            else if (Convert.ToString(comboCategory.SelectedItem) == "Men Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Winter Wear")
            {
                comboBoxItemType.Items.Add("Men Jackets and Coats");
                comboBoxItemType.Items.Add("Men Sweaters");
                comboBoxItemType.Items.Add("Men Hoodies");
            }


            //Women Parts


            if (Convert.ToString(comboCategory.SelectedItem) == "Women Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Western Clothing")
            {
                comboBoxItemType.Items.Add("Women Tops and Shirts");
                comboBoxItemType.Items.Add("Women TShirts");
                comboBoxItemType.Items.Add("Women Jeans");
            }
            else if (Convert.ToString(comboCategory.SelectedItem) == "Women Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Pakistani Clothing")
            {
                comboBoxItemType.Items.Add("Women Abaaya and Hijab");
                comboBoxItemType.Items.Add("Women Shawls");
                comboBoxItemType.Items.Add("Women Pants and Plazzoes");

            }
            else if (Convert.ToString(comboCategory.SelectedItem) == "Women Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Winter Wear")
            {
                comboBoxItemType.Items.Add("Women Jackets and Coats");
                comboBoxItemType.Items.Add("Women Hoodies");
            }

            //Kids Parts


            if (Convert.ToString(comboCategory.SelectedItem) == "Kids Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Boys Fashion")
            {
                comboBoxItemType.Items.Add("Boys TShirts");
                comboBoxItemType.Items.Add("Boys Jeans");
                comboBoxItemType.Items.Add("Boys Winter");
            }
            else if (Convert.ToString(comboCategory.SelectedItem) == "Kids Fashion" && Convert.ToString(comboBoxSubCategory.SelectedItem) == "Girls Fashion")
            {
                comboBoxItemType.Items.Add("Girls Kurta and Shalwar Kameez");
                comboBoxItemType.Items.Add("Girls Pants");
                comboBoxItemType.Items.Add("Girls Frocks");
            }
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxItems.ResetText();
            comboBoxItems.Items.Clear();
            SqlDataReader reader = DataAccess.getProductName(Convert.ToString(comboBoxItemType.SelectedItem));
            while (reader.Read())
            {
                comboBoxItems.Items.Add(reader["Product_Name"].ToString());
            }
        }

        private void comboBoxOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownQuantity.Value = numericUpDownQuantity.Minimum;
            object obj = DataAccess.GetStockProductQuantity(Convert.ToString(comboBoxItems.SelectedItem));
            int pQuantity = (int)obj;

            if (pQuantity > 0)
            {
                int quantity = (int)pQuantity;
                numericUpDownQuantity.Minimum = 1;
                numericUpDownQuantity.Maximum = quantity;
            }
            else
            {
                MessageBox.Show("This Product Does Not Exist In The Inventory");
            }
        }
    }
}