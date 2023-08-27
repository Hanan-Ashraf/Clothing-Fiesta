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
    public partial class GenerateBillOutlet : Form
    {
        public GenerateBillOutlet()
        {
            InitializeComponent();
        }

        private void GenerateBillOutlet_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            comboCategory.Items.Add("Kids Fashion");
            comboCategory.Items.Add("Men Fashion");
            comboCategory.Items.Add("Women Fashion");

            dataGridStock.ColumnCount = 4;
            dataGridStock.Columns[0].Name = "Product ID";
            dataGridStock.Columns[1].Name = "Quantity";
            dataGridStock.Columns[2].Name = "Price";
            dataGridStock.Columns[3].Name = "Total";

            dataGridStock.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridStock.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private Random random = new Random();
        private string receiptNo;
        private string ProductID;
        private int productPrice;
        private int SubTotal = 0;
        private int GrandTotal = 0;

        Bitmap bitmap;
        private void btn_Bill_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            receiptNo = new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            int height = dataGridStock.Height;
            dataGridStock.Height = dataGridStock.RowCount * dataGridStock.RowTemplate.Height * 2;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dataGridStock.Width, this.dataGridStock.Height);
            dataGridStock.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridStock.Width, this.dataGridStock.Height));

            //Resize DataGridView back to original height.
            dataGridStock.Height = height;
            
            //Storing Data To RECEIPT
            DataAccess.SaveDataGridViewToReceipt(dataGridStock, receiptNo, ProductID, numericUpDownQuantity.Value.ToString(), productPrice, SubTotal);

            printPreviewDialogBill.Document = PrintReceipt;
            printPreviewDialogBill.PrintPreviewControl.Zoom = 1;
            printPreviewDialogBill.ShowDialog();

            GrandTotal = 0;
            dataGridStock.Rows.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SubTotal = 0;
            productPrice = DataAccess.GetProductPrice(Convert.ToString(comboBoxItem.SelectedItem));

            SubTotal = (SubTotal + productPrice) * (int)numericUpDownQuantity.Value;

            GrandTotal = GrandTotal + (productPrice * (int)numericUpDownQuantity.Value);

            ProductID = DataAccess.GetProductID(Convert.ToString(comboBoxItem.SelectedItem));
            dataGridStock.Rows.Add(ProductID, numericUpDownQuantity.Value, productPrice, SubTotal);

            object obj = DataAccess.GetOutletProductQuantity(Convert.ToString(comboBoxItem.SelectedItem));
            int ProductQuantity = (int)obj;

            //Updating Product Quantity
            int newQuantity = ProductQuantity - (int)numericUpDownQuantity.Value;
            DataAccess.UpdateOutletQuantity(newQuantity, Convert.ToString(comboBoxItem.SelectedItem));

            //Deleting From OutletStock
            if (ProductQuantity == 0)
            {
                DataAccess.DeleteProduct(Convert.ToString(comboBoxItem.SelectedItem));
            }

            comboBoxItem.ResetText();
            comboBoxItem.Items.Clear();
            comboBoxItemType.ResetText();
            comboBoxItemType.Items.Clear();
            comboBoxSubCategory.ResetText();
            comboBoxSubCategory.Items.Clear();
            comboCategory.ResetText();
            numericUpDownQuantity.Value = numericUpDownQuantity.Minimum;

        }

        private void PrintPage_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bitmap, 60, 20);

            

            e.Graphics.DrawString("Clothing Fiesta", new Font("Arial",20,FontStyle.Bold),Brushes.Tomato, new Point(290, 30));
            e.Graphics.DrawString("Bill Receipt", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(320, 70));

            e.Graphics.DrawString("__________________________________________________________________________________________________________________________________", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(0, 200));

            e.Graphics.DrawString("Customer Name :", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 240));
            e.Graphics.DrawString(textBoxCustomerName.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 240));

            e.Graphics.DrawString("Date :", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 270));
            e.Graphics.DrawString(labelDate.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 270));
            e.Graphics.DrawImage(bitmap, 60, 320);

            e.Graphics.DrawString("Total :", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 270));
            e.Graphics.DrawString("Rs. " + GrandTotal.ToString() + "\\-", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 270));
        }


        private void printPreviewDialogBill_Load(object sender, EventArgs e)
        {

        }


        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubCategory.Items.Clear();
            comboBoxSubCategory.ResetText();
            comboBoxItemType.Items.Clear();
            comboBoxItemType.ResetText();
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
            comboBoxItemType.Items.Clear();
            comboBoxItemType.ResetText();

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

        private void comboBoxIteemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxItem.Items.Clear();
            comboBoxItem.ResetText();
            SqlDataReader reader = DataAccess.GetOutletItemName(Convert.ToString(comboBoxItemType.SelectedItem));
            while (reader.Read())
            {
                comboBoxItem.Items.Add(reader["Product_Name"].ToString());
            }
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownQuantity.Value = numericUpDownQuantity.Minimum;
            object obj = DataAccess.GetOutletProductQuantity(Convert.ToString(comboBoxItem.SelectedItem));
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

        private void btn_Bill_MouseHover(object sender, EventArgs e)
        {
            btn_Bill.BackColor = Color.Tomato;
            btn_Bill.ForeColor = Color.White;
        }

        private void btn_Bill_MouseLeave(object sender, EventArgs e)
        {
            btn_Bill.BackColor = Color.White;
            btn_Bill.ForeColor = Color.Tomato;
        }

    }
}
