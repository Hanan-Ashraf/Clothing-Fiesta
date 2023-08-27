using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingFiesta.DataLayer
{
    class DataAccess
    {
        /*------------------Setting Connection---------------------*/
        public static SqlConnection GetConnection(){
            string ConnectionString = "Data Source=DESKTOP-120T5BR\\SQLEXPRESS;Initial Catalog=ClothingFiesta;Integrated Security=True";
            SqlConnection mySQLConnection = new SqlConnection(ConnectionString);
            try
            {
                mySQLConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting Database");
            }
            return mySQLConnection;
        }

        /*------------------View STOCK HISTORY------------------*/
        public static SqlDataAdapter ViewHistory()
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "SELECT * FROM STOCK_DELIVERY;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter readProducts = new SqlDataAdapter(query, connection);
                connection.Close();
                return readProducts;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting Database");
                throw;
            }
        }

        /*------------------Set Values To StockDelivery---------------------*/
        public static void SetToStockDelivery(string ProductID, string ProductName, string ItemType, string Date, int Quantity)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string SetToStockquery = "INSERT INTO STOCK_DELIVERY VALUES('"+ProductID+"', '"+ProductName+"', '"+ItemType+"', '"+Date+"', '"+Quantity+"');";
                SqlCommand cmdSetToStock = new SqlCommand(SetToStockquery, connection);
                cmdSetToStock.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        /*------------------Get Outlet Names From OutletInfo---------------------*/
        public static SqlDataReader readFromOutlet()
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT * FROM OUTLET_INFO;";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        public static SqlDataReader getProductName(string ItemType)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT * FROM PRODUCT WHERE Product_ItemType = '" + ItemType + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        /*------------------Set Values To OutletStock---------------------*/
        public static void SetToOutletStock(string productID, string productName, int Quantity, int price, string color, string material, string itemType, string availableAt)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string SetToOutletquery = "INSERT INTO OUTLET_STOCK VALUES('" + productID + "', '" + productName + "', '" + Quantity + "', '" + price + "', '" + color + "', '" + material + "', '" + itemType + "', '" + availableAt + "');";
                SqlCommand cmdSetToOutlet = new SqlCommand(SetToOutletquery, connection);
                cmdSetToOutlet.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
            }
        }

        /*---------------Get Product ID From Products Table---------------*/
        public static string GetProductID(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string ProductIDQuery = "SELECT Product_ID FROM PRODUCT WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand command = new SqlCommand(ProductIDQuery, connection);
                object pID = command.ExecuteScalar();
                connection.Close();
                string ProductID = Convert.ToString(pID);
                return ProductID;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Get Material Type From Products Table---------------*/
        public static string GetMaterialType(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string ProductMaterialQuery = "SELECT Product_MaterialType FROM PRODUCT WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand comm = new SqlCommand(ProductMaterialQuery, connection);
                object pMaterial = comm.ExecuteScalar();
                connection.Close();
                string ProductMaterial = Convert.ToString(pMaterial);
                return ProductMaterial;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Databse", "Error");
                throw;
            }
        }

        /*---------------Get Price From Products Table---------------*/
        public static int GetProductPrice(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string ProductPriceQuery = "SELECT Product_Price FROM PRODUCT WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand Comnd = new SqlCommand(ProductPriceQuery, connection);
                object pPrice = Comnd.ExecuteScalar();
                connection.Close();
                int ProductPrice = Convert.ToInt32(pPrice);
                return ProductPrice;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Get Color From Products Table---------------*/
        public static string GetProductColor(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string ProductColorQuery = "SELECT Product_Color FROM PRODUCT WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand ComndColor = new SqlCommand(ProductColorQuery, connection);
                object pColor = ComndColor.ExecuteScalar();
                connection.Close();
                string ProductColor = Convert.ToString(pColor);
                return ProductColor;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Update Quantity In Products Table---------------*/
        public static void SetQuantity(int newQuantity, string comboProductName)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "UPDATE PRODUCT SET Product_Quantity = '" + newQuantity + "' WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Apply Discount---------------*/
        public static void SetPrice(int newQuantity, string comboProductName)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "UPDATE PRODUCT SET Product_Price = '" + newQuantity + "' WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Update Quantity In STOCK DELIVERY Table---------------*/
        public static void SetOutletQuantity(int newQuantity, string comboProductName)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "UPDATE STOCK_DELIVERY SET Product_Quantity = '" + newQuantity + "' WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*---------------Update Quantity In OUTLET Table---------------*/
        public static void UpdateOutletQuantity(int newQuantity, string comboProductName)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "UPDATE OUTLET_STOCK SET Product_Quantity = '" + newQuantity + "' WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }

        }

        /*---------------Update Quantity In OUTLET STOCK Table---------------*/
        public static void SetOutletStockQuantity(int newQuantity, string comboProductName)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "UPDATE OUTLET_STOCK SET Product_Quantity = '" + newQuantity + "' WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*---------------Getting Outlet Quantity From OUTLET STOCK TABLE---------------*/
        public static int GetOutletProductQuantity(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_Quantity FROM OUTLET_STOCK WHERE Product_Name = '" + comboProductName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oQuantity = cmd.ExecuteScalar();
                int OutletQuantity = (int)oQuantity;
                return OutletQuantity;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");   
                throw;
            }
        }

        /*---------------Getting Outlet Quantity From PRODUCT TABLE---------------*/
        public static int GetStockProductQuantity(string product)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_Quantity FROM PRODUCT WHERE Product_Name = '" + product + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oQuantity = cmd.ExecuteScalar();
                int OutletQuantity = (int)oQuantity;
                return OutletQuantity;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }
        /*---------------Getting Outlet Price From OUTLET STOCK TABLE---------------*/
        public static int GetOutletProductPrice(string comboProductID)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_Price FROM OUTLET_STOCK WHERE Product_ID = '" + comboProductID + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oPrice = cmd.ExecuteScalar();
                connection.Close();
                int OutletPrice = (int)oPrice;
                return OutletPrice;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*---------------Getting Outlet Product Name From OUTLET STOCK TABLE---------------*/
        public static string GetOutletProductName(string comboProductID)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_Name FROM OUTLET_STOCK WHERE Product_ID = '" + comboProductID + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oName = cmd.ExecuteScalar();
                connection.Close();
                string OutletName = Convert.ToString(oName);
                return OutletName;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Getting Outlet Product Color From OUTLET STOCK TABLE---------------*/
        public static string GetOutletProductColor(string comboProductID)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_Color FROM OUTLET_STOCK WHERE Product_ID = '" + comboProductID + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oColor = cmd.ExecuteScalar();
                connection.Close();
                string OutletColor = Convert.ToString(oColor);
                return OutletColor;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Getting Outlet Product Category From OUTLET STOCK TABLE---------------*/
        public static string GetOutletProductMaterialType(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_MaterialType FROM OUTLET_STOCK WHERE Product_Name = '" + comboProductName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oMaterialType = cmd.ExecuteScalar();
                connection.Close();
                string OutletMaterialType = Convert.ToString(oMaterialType);
                return OutletMaterialType;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*---------------Getting Outlet Product Item Type From OUTLET STOCK TABLE---------------*/
        public static string GetOutletProductItemType(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_ItemType FROM OUTLET_STOCK WHERE Product_Name = '" + comboProductName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oItemType = cmd.ExecuteScalar();
                connection.Close();
                string OutletItemType = Convert.ToString(oItemType);
                return OutletItemType;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*---------------Getting Outlet Product Available At From OUTLET STOCK TABLE---------------*/
        public static string GetOutletProductAvailableAt(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT AvailableAt FROM OUTLET_STOCK WHERE Product_Name = '" + comboProductName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oAvailableAt = cmd.ExecuteScalar();
                connection.Close();
                string OutletAvailableAt = Convert.ToString(oAvailableAt);
                return OutletAvailableAt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*---------------Getting Outlet Product ID From OUTLET STOCK TABLE---------------*/
        public static object GetOutletProductID(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_ID FROM OUTLET_STOCK WHERE Product_Name = '" + comboProductName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object OutpID = cmd.ExecuteScalar();
                connection.Close();
                return OutpID;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*---------------Getting Product Quantity From Products TABLE---------------*/
        public static object GetProductQuantity(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_Quantity FROM PRODUCT WHERE Product_Name = '" + comboProductName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object pQuantity = cmd.ExecuteScalar();
                connection.Close();
                return pQuantity;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Getting Outlet Quantity From STOCK DELIVERY TABLE---------------*/
        public static int GetOutletQuantity(string comboProductName)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT Product_Quantity FROM STOCK_DELIVERY WHERE Product_Name = '" + comboProductName + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                object oQuantity = cmd.ExecuteScalar();
                connection.Close();
                int OutletQuantity = (int)oQuantity;
                return OutletQuantity;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }

        /*---------------Storing Data to Outlet Stock TABLE---------------*/
        public static void SaveDataGridViewToOutletStock(DataGridView dataGridView, string ProductID, string name, int Quantity, int Price, string color, string materialType, string itemType, string availableAt)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string StrQuery = @"INSERT INTO OUTLET_STOCK VALUES ('" + dataGridView.Rows[i].Cells["Product ID"].Value + "', '" + dataGridView.Rows[i].Cells["Name"].Value + "', " + dataGridView.Rows[i].Cells["Quantity"].Value + ", " + dataGridView.Rows[i].Cells["Price"].Value + ", '" + dataGridView.Rows[i].Cells["Color"].Value + "', '" + dataGridView.Rows[i].Cells["Material"].Value + "', '" + dataGridView.Rows[i].Cells["Item Type"].Value + "', '" + dataGridView.Rows[i].Cells["Deliver To"].Value + "');";

                try
                {
                    using (SqlConnection conn = GetConnection())
                    {
                        using (SqlCommand comm = new SqlCommand(StrQuery, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                        conn.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error in Database", "Error");
                    throw;
                }
            }
        }

        /*---------------Storing Data to Stock Delivery TABLE---------------*/
        public static void SaveDataGridViewToStockDelivery(DataGridView dataGridView, string stockID, string ProductID, string name, int Quantity, string itemType, string date)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string StrQuery = @"INSERT INTO STOCK_DELIVERY VALUES ('" + stockID + "', '" + dataGridView.Rows[i].Cells["Product ID"].Value + "', '" + dataGridView.Rows[i].Cells["Name"].Value + "', '" + dataGridView.Rows[i].Cells["Item Type"].Value + "', '" + date + "', " + dataGridView.Rows[i].Cells["Quantity"].Value + ");";

                try
                {
                    using (SqlConnection conn = GetConnection())
                    {
                        using (SqlCommand comm = new SqlCommand(StrQuery, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                        conn.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error in Database", "Error");
                    throw;
                }
            }
        }

        /*---------------Storing Data to Receipt TABLE---------------*/
        public static void SaveDataGridViewToReceipt(DataGridView dataGridView, string receiptID, string ProductID, string Quantity, int Price, int Total)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string StrQuery = @"INSERT INTO RECEIPT VALUES ('" + receiptID + "', '" + dataGridView.Rows[i].Cells["Product ID"].Value + "', " + dataGridView.Rows[i].Cells["Quantity"].Value + ", " + dataGridView.Rows[i].Cells["Price"].Value + ", " + dataGridView.Rows[i].Cells["Total"].Value + ");";

                try
                {
                    using (SqlConnection conn = GetConnection())
                    {
                        using (SqlCommand comm = new SqlCommand(StrQuery, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in Database", "Error");
                    throw;
                }
            }
        }

        /*---------------Deleting Outlet Product From OUTLET STOCK TABLE---------------*/
        public static void DeleteProduct(string comboProductID)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "DELETE FROM OUTLET_STOCK WHERE Product_ID = '" + comboProductID + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        /*------------------Products---------------------*/
        public static SqlDataAdapter getProducts(string product)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "SELECT * FROM PRODUCT WHERE Product_ItemType = '" + product + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter readProducts = new SqlDataAdapter(query, connection);
                connection.Close();
                return readProducts;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
        }
        public static SqlDataAdapter GetProductsDetails(string comboProductName)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "SELECT Product_ID, Product_Name, Product_MaterialType, Product_Price FROM PRODUCT WHERE Product_Name = '" + comboProductName + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter readProducts = new SqlDataAdapter(query, connection);
                connection.Close();
                return readProducts;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }

        }

        /*------------------OUTLET STOCK---------------------*/
        public static SqlDataAdapter GetOUTLETProducts(string product)
        {
            try
            {
                SqlConnection connection = GetConnection();
                string query = "SELECT * FROM OUTLET_STOCK WHERE Product_ItemType = '" + product + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter readProducts = new SqlDataAdapter(query, connection);
                connection.Close();
                return readProducts;
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Database", "Error");
                throw;
            }
            
        }

        public static SqlDataReader GetOutletItemName(string itemtype)
        {
            try
            {
                SqlConnection connection = DataAccess.GetConnection();
                string query = "SELECT * FROM OUTLET_STOCK WHERE Product_ItemType = '" + itemtype + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
