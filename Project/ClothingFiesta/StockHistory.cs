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
    public partial class StockHistory : Form
    {
        public StockHistory()
        {
            InitializeComponent();
        }

        private void StockHistory_Load(object sender, EventArgs e)
        {
            SqlDataAdapter Adapter = DataAccess.ViewHistory();
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            dataGridViewHistory.DataSource = dt;
        }
    }
}
