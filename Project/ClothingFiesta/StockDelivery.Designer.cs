namespace ClothingFiesta
{
    partial class StockDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDelivery));
            this.labelStock = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelSubCategory = new System.Windows.Forms.Label();
            this.labelItemType = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.labelDated = new System.Windows.Forms.Label();
            this.printStockInvoice = new System.Drawing.Printing.PrintDocument();
            this.printPreviewStockInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.labelSelectOutlet = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.comboBoxOutlet = new System.Windows.Forms.ComboBox();
            this.clothingFiestaDataSet = new ClothingFiesta.ClothingFiestaDataSet();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingFiestaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStock
            // 
            this.labelStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.Tomato;
            this.labelStock.Location = new System.Drawing.Point(321, 33);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(248, 24);
            this.labelStock.TabIndex = 0;
            this.labelStock.Text = "Deliver Stock To Outlet";
            this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(10, 103);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "DateDisplay";
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(129, 75);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(78, 20);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Select Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSubCategory
            // 
            this.labelSubCategory.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubCategory.Location = new System.Drawing.Point(390, 75);
            this.labelSubCategory.Name = "labelSubCategory";
            this.labelSubCategory.Size = new System.Drawing.Size(99, 20);
            this.labelSubCategory.TabIndex = 2;
            this.labelSubCategory.Text = "Select Sub-Category";
            this.labelSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelItemType
            // 
            this.labelItemType.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemType.Location = new System.Drawing.Point(656, 75);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(84, 20);
            this.labelItemType.TabIndex = 2;
            this.labelItemType.Text = "Select Item Type";
            this.labelItemType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelItems
            // 
            this.labelItems.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(129, 130);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(75, 20);
            this.labelItems.TabIndex = 2;
            this.labelItems.Text = "Select Item";
            this.labelItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Add.Location = new System.Drawing.Point(721, 139);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(129, 34);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.MouseLeave += new System.EventHandler(this.btn_Add_MouseLeave);
            this.btn_Add.MouseHover += new System.EventHandler(this.btn_Add_MouseHover);
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.Color.White;
            this.btn_Bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bill.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Bill.Location = new System.Drawing.Point(733, 588);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(118, 39);
            this.btn_Bill.TabIndex = 8;
            this.btn_Bill.Text = "Generate Bill";
            this.btn_Bill.UseVisualStyleBackColor = false;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            this.btn_Bill.MouseLeave += new System.EventHandler(this.btn_Deliver_MouseLeave);
            this.btn_Bill.MouseHover += new System.EventHandler(this.btn_Deliver_MouseHover);
            // 
            // labelDated
            // 
            this.labelDated.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDated.Location = new System.Drawing.Point(10, 81);
            this.labelDated.Name = "labelDated";
            this.labelDated.Size = new System.Drawing.Size(38, 20);
            this.labelDated.TabIndex = 2;
            this.labelDated.Text = "Dated";
            this.labelDated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printStockInvoice
            // 
            this.printStockInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // printPreviewStockInvoice
            // 
            this.printPreviewStockInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewStockInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewStockInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewStockInvoice.Enabled = true;
            this.printPreviewStockInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewStockInvoice.Icon")));
            this.printPreviewStockInvoice.Name = "printPreviewStockInvoice";
            this.printPreviewStockInvoice.ShowIcon = false;
            this.printPreviewStockInvoice.Visible = false;
            // 
            // dataGridStock
            // 
            this.dataGridStock.AllowUserToAddRows = false;
            this.dataGridStock.AllowUserToDeleteRows = false;
            this.dataGridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(27, 189);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.ReadOnly = true;
            this.dataGridStock.Size = new System.Drawing.Size(835, 384);
            this.dataGridStock.TabIndex = 9;
            // 
            // labelSelectOutlet
            // 
            this.labelSelectOutlet.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectOutlet.Location = new System.Drawing.Point(531, 130);
            this.labelSelectOutlet.Name = "labelSelectOutlet";
            this.labelSelectOutlet.Size = new System.Drawing.Size(75, 20);
            this.labelSelectOutlet.TabIndex = 2;
            this.labelSelectOutlet.Text = "Select Outlet";
            this.labelSelectOutlet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.SystemColors.Window;
            this.comboCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCategory.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(132, 96);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(191, 24);
            this.comboCategory.TabIndex = 10;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSubCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSubCategory.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(393, 96);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(191, 24);
            this.comboBoxSubCategory.TabIndex = 11;
            this.comboBoxSubCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategory_SelectedIndexChanged);
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxItemType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxItemType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItemType.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(659, 96);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(191, 24);
            this.comboBoxItemType.TabIndex = 12;
            this.comboBoxItemType.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // label_Quantity
            // 
            this.label_Quantity.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Quantity.Location = new System.Drawing.Point(324, 130);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(75, 20);
            this.label_Quantity.TabIndex = 2;
            this.label_Quantity.Text = "Select Quantity";
            this.label_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxOutlet
            // 
            this.comboBoxOutlet.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxOutlet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxOutlet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxOutlet.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOutlet.FormattingEnabled = true;
            this.comboBoxOutlet.Location = new System.Drawing.Point(534, 149);
            this.comboBoxOutlet.Name = "comboBoxOutlet";
            this.comboBoxOutlet.Size = new System.Drawing.Size(152, 24);
            this.comboBoxOutlet.TabIndex = 12;
            this.comboBoxOutlet.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutlet_SelectedIndexChanged);
            // 
            // clothingFiestaDataSet
            // 
            this.clothingFiestaDataSet.DataSetName = "ClothingFiestaDataSet";
            this.clothingFiestaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItems.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(132, 149);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(152, 24);
            this.comboBoxItems.TabIndex = 12;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(325, 149);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(163, 20);
            this.numericUpDownQuantity.TabIndex = 46;
            // 
            // StockDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 639);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.comboBoxOutlet);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.comboBoxSubCategory);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.dataGridStock);
            this.Controls.Add(this.btn_Bill);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.labelSelectOutlet);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelItemType);
            this.Controls.Add(this.labelSubCategory);
            this.Controls.Add(this.labelDated);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockDelivery";
            this.Text = "Stock Delivery";
            this.Load += new System.EventHandler(this.StockDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingFiestaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelSubCategory;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.Label labelDated;
        private System.Drawing.Printing.PrintDocument printStockInvoice;
        private System.Windows.Forms.PrintPreviewDialog printPreviewStockInvoice;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.Label labelSelectOutlet;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.Label label_Quantity;
        private ClothingFiestaDataSet clothingFiestaDataSet;
        private System.Windows.Forms.ComboBox comboBoxOutlet;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
    }
}