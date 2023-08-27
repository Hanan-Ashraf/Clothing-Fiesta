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
    public partial class OutletStock : Form
    {
        public OutletStock()
        {
            InitializeComponent();
        }

        public void DisplayInDataGrid(string product)
        {
            SqlDataAdapter adapter = DataAccess.GetOUTLETProducts(product);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("This Product Is Not Available");
            }
        }

        //Panel Main
        private void pictureBoxBoysWinterWear_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Winter");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Winter");
        }

        private void pictureBoxGirlsPants_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Pants");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Pants");
        }

        private void pictureBoxBoysTShirts_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys TShirts");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys TShirts");
        }

        private void pictureBoxMenJacketsAndCoats_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Jackets and Coats");
        }

        private void labelMenJacketsAndCoats_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Jackets and Coats");
        }

        private void pictureBoxMenWaistCoats_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Waist Coats");
        }

        private void labelMenWaistCoats_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Waist Coats");
        }

        private void pictureBoxMenPants_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Pants");
        }

        private void labelMenPants_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Pants");
        }

        private void pictureBoxWomenHoodies_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Hoodies");
            
        }

        private void labelWomenHoodies_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Hoodies");
        }

        private void pictureBoxWomenShawls_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Shawls");
        }

        private void labelWomenShawls_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Shawls");
        }

        private void pictureBoxWomenTops_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Tops and Shirts");
        }

        private void labelWomenTops_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Tops and Shirts");
        }

        //Panel Kids
        private void pictureBoxKidsWinter_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Winter");
        }

        private void labelKidsWinter_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Winter");
        }

        private void pictureBoxKidsPant_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Pants");
        }

        private void labelKidsPant_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Pants");
        }

        private void pictureBoxKidsTSirt_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys TShirts");
        }

        private void labelKidsTShirt_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys TShirts");
        }

        private void pictureBoxKidsFrocks_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Frocks");
        }

        private void labelKidsFrocks_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Frocks");
        }

        private void pictureBoxKidsKurtaShalwar_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Kurta and Shalwar Kameez");
        }

        private void labelKidsKurtaShalwars_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Kurta and Shalwar Kameez");
        }

        private void pictureBoxKidsJeans_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Jeans");
        }

        private void labelKidsJeans_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Jeans");
        }

        private void pictureBoxKidsBackToMain_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = false;
            panelMain.BringToFront();
            dataGridView1.DataSource = null;
        }

        //Panel Men
        private void pictureBoxMenJacketAndCOat_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Jackets and Coats");
        }

        private void labelMenJacketAndCoat_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Jackets and Coats");
        }

        private void pictureBoxMenWaistCoat_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Waist Coats");
        }

        private void labelMenWaistCoat_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Waist Coats");
        }

        private void pictureBoxMenPant_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Pants");
        }

        private void labelMenPant_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Pants");
        }

        private void pictureBoxMenKurta_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kurtas");
        }

        private void labelMenKurtas_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kurtas");
        }

        private void pictureBoxMenShalwarKameez_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kamiz Shalwar");
        }

        private void labelMenShalwarKameez_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kamiz Shalwar");
        }

        private void pictureBoxMenShirts_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Shirts");
        }

        private void labelMenShirts_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Shirts");
        }

        private void pictureBoxMenTShirt_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men TShirts");
        }

        private void labelMenTShirt_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men TShirts");
        }

        private void pictureBoxMenHoodie_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Hoodies");
        }

        private void labelMenHoodie_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Hoodies");
        }

        private void pictureBoxMenSweater_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Sweaters");
        }

        private void labelMenSweater_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Sweaters");
        }

        private void pictureBoxMenBackToMain_Click(object sender, EventArgs e)
        {
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.BringToFront();
            dataGridView1.DataSource = null;
        }

        //Panel Women
        private void pictureBoxWomenHoodie_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Hoodies");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Hoodies");
        }

        private void pictureBoxWomenShawl_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Shawls");
        }

        private void labelWomenShawl_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Shawls");
        }

        private void pictureBoxWomenTopShirt_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Tops and Shirts");
        }

        private void labelTopShirt_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Tops and Shirts");
        }

        private void pictureBoxWomenAbaayaHijab_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Abaaya and Hijab");
        }

        private void pictureBoxWomenPlazzoes_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Pants and Plazzoes");
        }

        private void labelWomenAbaayaHijab_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Abaaya and Hijab");
        }

        private void labelWomenPlazzoes_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Pants and Plazzoes");
        }

        private void pictureBoxWomenJeans_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jeans");
        }

        private void labelWomenJeans_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jeans");
        }

        private void pictureBoxWomenTShirt_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women TShirts");
        }

        private void labelWomenTShirt_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women TShirts");
        }

        private void pictureBoxWomenJacketCoat_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jackets and Coats");
        }

        private void labelWomenJacketCoat_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jackets and Coats");
        }

        private void pictureBoxWomenBackToMain_Click(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.BringToFront();
            dataGridView1.DataSource = null;
        }

        //Show More Buttons
        private void labelKidsShowMore_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = true;
        }

        private void labelMenShowMore_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = true;
            panelMenItems.Visible = true;
        }

        private void labelWomenShowMore_Click(object sender, EventArgs e)
        {
            panelKidsItems.Visible = true;
            panelMenItems.Visible = true;
            panelWomenItems.Visible = true;
        }

        //Show Main Panel On Load
        private void OutletStock_Load(object sender, EventArgs e)
        {
            panelWomenItems.Visible = false;
            panelMenItems.Visible = false;
            panelKidsItems.Visible = false;
            panelMain.Visible = true;
        }

        //Data Grid Back To Main
        private void labelBackToMain_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
        }

        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
        }

        private void pictureBoxWomenHoodie_Click_1(object sender, EventArgs e)
        {

        }
    }
}
