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
    public partial class Products : Form
    {     
        public Products()
        {
            InitializeComponent();
        }

        public void DisplayInDataGrid(string product)
        {
            SqlDataAdapter adapter = DataAccess.getProducts(product);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //KidsGirls
        private void BackToKids_Click(object sender, EventArgs e)
        {
            panelBoys.Visible = true;
            panelWomenWinterWear.Visible = true;
            panelWomenPakistaniClothing.Visible = true;
            panelWomenWesternClothing.Visible = true;
            panelMenWinterWear.Visible = true;
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
        }
        private void pictureBoxGirlsKurtaShalwar_Click_1(object sender, EventArgs e)
        {
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Kurta and Shalwar Kameez");

        }

        private void labelGirlsKurtaShalwar_Click(object sender, EventArgs e)
        {
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Kurta and Shalwar Kameez");
        }

        private void pictureBoxGirlsPants_Click(object sender, EventArgs e)
        {
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Pants");
        }

        private void labelGirlsPants_Click(object sender, EventArgs e)
        {
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Pants");
        }

        private void pictureBoxFrocks_Click(object sender, EventArgs e)
        {
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Frocks");
        }

        private void labelFrocks_Click(object sender, EventArgs e)
        {
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Girls Frocks");
        }
        //KidsBoys
        private void pictureBoxBoysBackToKids_Click(object sender, EventArgs e)
        {
            panelWomenWinterWear.Visible = true;
            panelWomenPakistaniClothing.Visible = true;
            panelWomenWesternClothing.Visible = true;
            panelMenWinterWear.Visible = true;
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
        }

        private void pictureBoxBoysTShirts_Click(object sender, EventArgs e)
        {
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys TShirts");
        }

        private void labelBoysTShirts_Click(object sender, EventArgs e)
        {
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys TShirts");
        }

        private void pictureBoxBoysJeans_Click(object sender, EventArgs e)
        {
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Jeans");
        }

        private void labelBoysJeans_Click(object sender, EventArgs e)
        {
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Jeans");
        }

        private void pictureBoxBoysWinterWear_Click(object sender, EventArgs e)
        {
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Winter");
        }

        private void labelBoysWinterWear_Click(object sender, EventArgs e)
        {
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Boys Winter");
        }

        //WomenWinterWear
        private void pictureBoxWinterBackToWomen_Click(object sender, EventArgs e)
        {
            panelWomenPakistaniClothing.Visible = true;
            panelWomenWesternClothing.Visible = true;
            panelMenWinterWear.Visible = true;
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
            panelWomen.Visible = true;
        }

        private void pictureBoxWomenJacketsCoats_Click(object sender, EventArgs e)
        {
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jackets and Coats");
        }

        private void labelWomenJacketsCoats_Click(object sender, EventArgs e)
        {
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jackets and Coats");
        }

        private void pictureBoxWomenHoodies_Click(object sender, EventArgs e)
        {
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Hoodies");
        }

        private void labelWomwnHoodies_Click(object sender, EventArgs e)
        {
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Hoodies");
        }

        //WomenPakistaniWear
        private void pictureBoxPakistaniBackToWomen_Click(object sender, EventArgs e)
        {
            panelWomenWesternClothing.Visible = true;
            panelMenWinterWear.Visible = true;
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
            panelWomen.Visible = true;
        }

        private void pictureBoxWomenAbaaya_Click(object sender, EventArgs e)
        {
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Abaaya and Hijab");
        }

        private void labelWomenAbaayaHijabs_Click(object sender, EventArgs e)
        {
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Abaaya and Hijab");
        }

        private void pictureBoxWomenShawls_Click(object sender, EventArgs e)
        {
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Shawls");
        }

        private void labelShawls_Click(object sender, EventArgs e)
        {
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Shawls");
        }

        private void pictureBoxWomenPlazzoes_Click(object sender, EventArgs e)
        {
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Pants and Plazzoes");
        }

        private void labelWomenPlazzoes_Click(object sender, EventArgs e)
        {
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Pants and Plazzoes");
        }

        //WomenWesternClothing
        private void pictureBoxWesternBackToWomen_Click(object sender, EventArgs e)
        {
            panelMenWinterWear.Visible = true;
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
            panelWomen.Visible = true;
        }

        private void pictureBoxWomenTopsShirts_Click(object sender, EventArgs e)
        {
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Tops and Shirts");
        }

        private void labelWomenTopsAndShirts_Click(object sender, EventArgs e)
        {
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Tops and Shirts");
        }

        private void pictureBoxWomenTShirts_Click(object sender, EventArgs e)
        {
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women TShirts");
        }

        private void labelWomenTShirts_Click(object sender, EventArgs e)
        {
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women TShirts");
        }

        private void pictureBoxWomenJeans_Click(object sender, EventArgs e)
        {
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jeans");
        }

        private void labelWomenJeans_Click(object sender, EventArgs e)
        {
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Women Jeans");
        }

        //MenWinterWear
        private void pictureBoxMenWinterBackToMen_Click(object sender, EventArgs e)
        {
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
            panelWomen.Visible = true;
            panelMen.Visible = true;
        }

        private void pictureBoxMenJacketsCoats_Click(object sender, EventArgs e)
        {
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Jackets and Coats");
        }

        private void labelMenJacketsCoats_Click(object sender, EventArgs e)
        {
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Jackets and Coats");
        }

        private void pictureBoxMenSweaters_Click(object sender, EventArgs e)
        {
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Sweaters");
        }

        private void labelMenSweaters_Click(object sender, EventArgs e)
        {
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Sweaters");
        }

        private void pictureBoxMenHoodies_Click(object sender, EventArgs e)
        {
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Hoodies");
        }

        private void labelMenHoodies_Click(object sender, EventArgs e)
        {
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Hoodies");
        }

        //MenPakistaniClothing
        private void pictureBoxMenPakistaniBackToMen_Click(object sender, EventArgs e)
        {
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
            panelWomen.Visible = true;
            panelMen.Visible = true;
        }

        private void pictureBoxMenKamizShalwar_Click(object sender, EventArgs e)
        {
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kamiz Shalwar");
        }

        private void labelMenKamizShalwar_Click(object sender, EventArgs e)
        {
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kamiz Shalwar");
        }

        private void pictureBoxMenKurtas_Click(object sender, EventArgs e)
        {
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kurtas");
        }

        private void labelMenKurtas_Click(object sender, EventArgs e)
        {
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Kurtas");
        }

        private void pictureBoxMenWaistCoats_Click(object sender, EventArgs e)
        {
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Waist Coats");
        }

        private void labelMenWaistCoats_Click(object sender, EventArgs e)
        {
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Waist Coats");
        }

        //MenWesternWear
        private void pictureBoxMenWesternBackToMen_Click(object sender, EventArgs e)
        {
            panelKids.Visible = true;
            panelWomen.Visible = true;
            panelMen.Visible = true;
        }

        private void pictureBoxMenTShirts_Click(object sender, EventArgs e)
        {
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men TShirts");
        }

        private void labelMenTShirts_Click(object sender, EventArgs e)
        {
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men TShirts");
        }

        private void pictureBoxMenShirts_Click(object sender, EventArgs e)
        {
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Shirts");
        }

        private void labelMenShirts_Click(object sender, EventArgs e)
        {
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Shirts");
        }

        private void pictureBoxMenPants_Click(object sender, EventArgs e)
        {
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Pants");
        }

        private void labelMenPants_Click(object sender, EventArgs e)
        {
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.Visible = false;
            panelDataGrid.BringToFront();
            DisplayInDataGrid("Men Pants");
        }

        //KidsCategory
        private void pictureBoxKidsBackToCategory_Click(object sender, EventArgs e)
        {
            panelMen.Visible = true;
            panelWomen.Visible = true;
            panelKids.Visible = true;
            panelCategory.Visible = true;
        }

        private void pictureBoxBoysFashion_Click(object sender, EventArgs e)
        {
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.BringToFront();
        }

        private void labelBoysFashion_Click(object sender, EventArgs e)
        {
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.BringToFront();
        }

        private void pictureBoxGirlsFashion_Click(object sender, EventArgs e)
        {
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.BringToFront();
        }

        private void labelGirlsFashion_Click(object sender, EventArgs e)
        {
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.Visible = false;
            panelBoys.Visible = false;
            panelGirls.BringToFront();
        }

        //WomenCategory
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelMen.Visible = true;
            panelCategory.Visible = true;
        }

        private void pictureBoxWomenWinterWear_Click(object sender, EventArgs e)
        {
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.BringToFront();
        }

        private void labelWomenWinter_Click(object sender, EventArgs e)
        {
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.Visible = false;
            panelWomenWinterWear.BringToFront();
        }

        private void pictureBoxWomenPakistaniClothing_Click(object sender, EventArgs e)
        {
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.BringToFront();
        }

        private void labelWomenPakistani_Click(object sender, EventArgs e)
        {
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.Visible = false;
            panelWomenPakistaniClothing.BringToFront();
        }

        private void pictureBoxWomenWesternClothing_Click(object sender, EventArgs e)
        {
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.BringToFront();
        }

        private void labelWomenWesternClothing_Click(object sender, EventArgs e)
        {
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.Visible = false;
            panelWomenWesternClothing.BringToFront();
        }

        //MenCategory
        private void pictureBoxMenBackToCategory_Click(object sender, EventArgs e)
        {
            panelCategory.Visible = true;
        }

        private void pictureBoxMenWinterWear_Click(object sender, EventArgs e)
        {
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.BringToFront();
        }

        private void labelMenWinterWear_Click(object sender, EventArgs e)
        {
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.Visible = false;
            panelMenWinterWear.BringToFront();
        }

        private void pictureBoxMenPakistani_Click(object sender, EventArgs e)
        {
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.BringToFront();
        }

        private void labelMenPakistani_Click(object sender, EventArgs e)
        {
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.Visible = false;
            panelMenPakistaniClothing.BringToFront();
        }

        private void pictureBoxMenWestern_Click(object sender, EventArgs e)
        {
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.BringToFront();
        }

        private void labelMenWestern_Click(object sender, EventArgs e)
        {
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.Visible = false;
            panelMenWesternWear.BringToFront();
        }

        //Category
        private void pictureBoxMenCategory_Click(object sender, EventArgs e)
        {
            panelCategory.Visible = false;
            panelMen.BringToFront();
        }

        private void labelMenCategory_Click(object sender, EventArgs e)
        {
            panelCategory.Visible = false;
            panelMen.BringToFront();
        }

        private void pictureBoxWomenCategory_Click(object sender, EventArgs e)
        {
            panelCategory.Visible = false;
            panelMen.Visible = false;
            panelWomen.BringToFront();
        }

        private void labelWomenCategory_Click(object sender, EventArgs e)
        {
            panelCategory.Visible = false;
            panelMen.Visible = false;
            panelWomen.BringToFront();
        }

        private void pictureBoxKidsCategory_Click(object sender, EventArgs e)
        {
            panelCategory.Visible = false;
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.BringToFront();
        }

        private void labelKidsCategory_Click(object sender, EventArgs e)
        {
            panelCategory.Visible = false;
            panelMen.Visible = false;
            panelWomen.Visible = false;
            panelKids.BringToFront();
        }

        //DataGrid Back To Home
        private void pictureBoxBackToHome_Click(object sender, EventArgs e)
        {

            panelGirls.Visible = true;
            panelBoys.Visible = true;
            panelWomenWinterWear.Visible = true;
            panelWomenPakistaniClothing.Visible = true;
            panelWomenWesternClothing.Visible = true;
            panelMenWinterWear.Visible = true;
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
            panelWomen.Visible = true;
            panelMen.Visible = true;
            panelCategory.Visible = true;
            dataGridView1.DataSource = null;
        }

        private void labelBackToHome_Click(object sender, EventArgs e)
        {
            panelGirls.Visible = true;
            panelBoys.Visible = true;
            panelWomenWinterWear.Visible = true;
            panelWomenPakistaniClothing.Visible = true;
            panelWomenWesternClothing.Visible = true;
            panelMenWinterWear.Visible = true;
            panelMenPakistaniClothing.Visible = true;
            panelMenWesternWear.Visible = true;
            panelKids.Visible = true;
            panelWomen.Visible = true;
            panelMen.Visible = true;
            panelCategory.Visible = true;
            dataGridView1.DataSource = null;
        }
    }
}
