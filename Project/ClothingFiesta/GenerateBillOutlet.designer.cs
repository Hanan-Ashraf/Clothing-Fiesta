
namespace ClothingFiesta
{
    partial class GenerateBillOutlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateBillOutlet));
            this.clothingFiestaDataSet = new ClothingFiesta.ClothingFiestaDataSet();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.PrintReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogBill = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.labelSubCategory = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.labelDated = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clothingFiestaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // clothingFiestaDataSet
            // 
            this.clothingFiestaDataSet.DataSetName = "ClothingFiestaDataSet";
            this.clothingFiestaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintReceipt
            // 
            this.PrintReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage_PrintPage);
            // 
            // printPreviewDialogBill
            // 
            this.printPreviewDialogBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBill.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogBill.Enabled = true;
            this.printPreviewDialogBill.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogBill.Icon")));
            this.printPreviewDialogBill.Name = "printPreviewDialogBill";
            this.printPreviewDialogBill.Visible = false;
            this.printPreviewDialogBill.Load += new System.EventHandler(this.printPreviewDialogBill_Load);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBoxItemType);
            this.panel1.Controls.Add(this.comboBoxItem);
            this.panel1.Controls.Add(this.numericUpDownQuantity);
            this.panel1.Controls.Add(this.textBoxCustomerName);
            this.panel1.Controls.Add(this.labelCustomerName);
            this.panel1.Controls.Add(this.btn_Bill);
            this.panel1.Controls.Add(this.dataGridStock);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelQuantity);
            this.panel1.Controls.Add(this.labelItem);
            this.panel1.Controls.Add(this.comboBoxSubCategory);
            this.panel1.Controls.Add(this.labelSubCategory);
            this.panel1.Controls.Add(this.comboCategory);
            this.panel1.Controls.Add(this.labelDated);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelStock);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 917);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxItemType.DisplayMember = "Product_Name";
            this.comboBoxItemType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItemType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(522, 148);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(177, 20);
            this.comboBoxItemType.TabIndex = 46;
            this.comboBoxItemType.SelectedIndexChanged += new System.EventHandler(this.comboBoxIteemType_SelectedIndexChanged);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(118, 205);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(164, 20);
            this.comboBoxItem.TabIndex = 46;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(314, 205);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(176, 20);
            this.numericUpDownQuantity.TabIndex = 45;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(100, 81);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(124, 20);
            this.textBoxCustomerName.TabIndex = 44;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomerName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(9, 81);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(85, 20);
            this.labelCustomerName.TabIndex = 43;
            this.labelCustomerName.Text = "Customer Name";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.Color.White;
            this.btn_Bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bill.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Bill.Location = new System.Drawing.Point(603, 682);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(118, 39);
            this.btn_Bill.TabIndex = 36;
            this.btn_Bill.Text = "Generate Bill";
            this.btn_Bill.UseVisualStyleBackColor = false;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            this.btn_Bill.MouseLeave += new System.EventHandler(this.btn_Bill_MouseLeave);
            this.btn_Bill.MouseHover += new System.EventHandler(this.btn_Bill_MouseHover);
            // 
            // dataGridStock
            // 
            this.dataGridStock.AllowUserToAddRows = false;
            this.dataGridStock.AllowUserToDeleteRows = false;
            this.dataGridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(13, 257);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.ReadOnly = true;
            this.dataGridStock.RowHeadersWidth = 62;
            this.dataGridStock.Size = new System.Drawing.Size(708, 410);
            this.dataGridStock.TabIndex = 35;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Add.Location = new System.Drawing.Point(554, 196);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 30);
            this.btn_Add.TabIndex = 34;
            this.btn_Add.Text = "Add Item";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.MouseLeave += new System.EventHandler(this.btn_Add_MouseLeave);
            this.btn_Add.MouseHover += new System.EventHandler(this.btn_Add_MouseHover);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Select Item Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(311, 185);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(75, 20);
            this.labelQuantity.TabIndex = 25;
            this.labelQuantity.Text = "Select Quantity";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelItem
            // 
            this.labelItem.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem.Location = new System.Drawing.Point(115, 184);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(59, 20);
            this.labelItem.TabIndex = 26;
            this.labelItem.Text = "Select Item";
            this.labelItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSubCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubCategory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(314, 148);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(176, 20);
            this.comboBoxSubCategory.TabIndex = 31;
            this.comboBoxSubCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategory_SelectedIndexChanged);
            // 
            // labelSubCategory
            // 
            this.labelSubCategory.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubCategory.Location = new System.Drawing.Point(311, 127);
            this.labelSubCategory.Name = "labelSubCategory";
            this.labelSubCategory.Size = new System.Drawing.Size(99, 20);
            this.labelSubCategory.TabIndex = 27;
            this.labelSubCategory.Text = "Select Sub-Category";
            this.labelSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboCategory
            // 
            this.comboCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(118, 148);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(164, 20);
            this.comboCategory.TabIndex = 32;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // labelDated
            // 
            this.labelDated.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDated.Location = new System.Drawing.Point(10, 127);
            this.labelDated.Name = "labelDated";
            this.labelDated.Size = new System.Drawing.Size(38, 20);
            this.labelDated.TabIndex = 28;
            this.labelDated.Text = "Dated";
            this.labelDated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCategory
            // 
            this.labelCategory.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(115, 128);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(78, 20);
            this.labelCategory.TabIndex = 29;
            this.labelCategory.Text = "Select Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(10, 149);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 15);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "DateDisplay";
            // 
            // labelStock
            // 
            this.labelStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.Tomato;
            this.labelStock.Location = new System.Drawing.Point(254, 41);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(247, 24);
            this.labelStock.TabIndex = 23;
            this.labelStock.Text = "Generate Receipt";
            this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateBillOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 914);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateBillOutlet";
            this.Text = "GenerateBillOutlet";
            this.Load += new System.EventHandler(this.GenerateBillOutlet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothingFiestaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument PrintReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogBill;
        private ClothingFiestaDataSet clothingFiestaDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.Label labelSubCategory;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label labelDated;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStock;
    }
}