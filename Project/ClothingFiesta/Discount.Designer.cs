namespace ClothingFiesta
{
    partial class Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount));
            this.labelStock = new System.Windows.Forms.Label();
            this.comboBoxSelectItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDiscount = new System.Windows.Forms.DataGridView();
            this.btn_Show = new System.Windows.Forms.Button();
            this.txt_NewPrice = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiscountedPrice = new System.Windows.Forms.Label();
            this.btn_ApplyDiscount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStock
            // 
            this.labelStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.Tomato;
            this.labelStock.Location = new System.Drawing.Point(294, 68);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(278, 51);
            this.labelStock.TabIndex = 1;
            this.labelStock.Text = "Apply Discount";
            this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSelectItem
            // 
            this.comboBoxSelectItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSelectItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectItem.FormattingEnabled = true;
            this.comboBoxSelectItem.Location = new System.Drawing.Point(319, 178);
            this.comboBoxSelectItem.Name = "comboBoxSelectItem";
            this.comboBoxSelectItem.Size = new System.Drawing.Size(224, 23);
            this.comboBoxSelectItem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select An Item";
            // 
            // dataGridViewDiscount
            // 
            this.dataGridViewDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiscount.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscount.Location = new System.Drawing.Point(73, 237);
            this.dataGridViewDiscount.Name = "dataGridViewDiscount";
            this.dataGridViewDiscount.Size = new System.Drawing.Size(740, 210);
            this.dataGridViewDiscount.TabIndex = 4;
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.White;
            this.btn_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Show.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Show.Location = new System.Drawing.Point(568, 169);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(95, 40);
            this.btn_Show.TabIndex = 5;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            this.btn_Show.MouseLeave += new System.EventHandler(this.btn_Show_MouseLeave);
            this.btn_Show.MouseHover += new System.EventHandler(this.btn_Show_MouseHover);
            // 
            // txt_NewPrice
            // 
            this.txt_NewPrice.AllowPromptAsInput = false;
            this.txt_NewPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPrice.Location = new System.Drawing.Point(283, 502);
            this.txt_NewPrice.Mask = "0000";
            this.txt_NewPrice.Name = "txt_NewPrice";
            this.txt_NewPrice.Size = new System.Drawing.Size(72, 23);
            this.txt_NewPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Price";
            // 
            // lblDiscountedPrice
            // 
            this.lblDiscountedPrice.AutoSize = true;
            this.lblDiscountedPrice.Location = new System.Drawing.Point(108, 507);
            this.lblDiscountedPrice.Name = "lblDiscountedPrice";
            this.lblDiscountedPrice.Size = new System.Drawing.Size(165, 13);
            this.lblDiscountedPrice.TabIndex = 8;
            this.lblDiscountedPrice.Text = "Please Provide Discounted Price:";
            // 
            // btn_ApplyDiscount
            // 
            this.btn_ApplyDiscount.BackColor = System.Drawing.Color.White;
            this.btn_ApplyDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ApplyDiscount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplyDiscount.ForeColor = System.Drawing.Color.Tomato;
            this.btn_ApplyDiscount.Location = new System.Drawing.Point(380, 498);
            this.btn_ApplyDiscount.Name = "btn_ApplyDiscount";
            this.btn_ApplyDiscount.Size = new System.Drawing.Size(95, 31);
            this.btn_ApplyDiscount.TabIndex = 5;
            this.btn_ApplyDiscount.Text = "Apply";
            this.btn_ApplyDiscount.UseVisualStyleBackColor = false;
            this.btn_ApplyDiscount.Click += new System.EventHandler(this.btn_ApplyDiscount_Click);
            this.btn_ApplyDiscount.MouseLeave += new System.EventHandler(this.btn_ApplyDiscount_MouseLeave);
            this.btn_ApplyDiscount.MouseHover += new System.EventHandler(this.btn_ApplyDiscount_MouseHover);
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 639);
            this.Controls.Add(this.lblDiscountedPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NewPrice);
            this.Controls.Add(this.btn_ApplyDiscount);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.dataGridViewDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectItem);
            this.Controls.Add(this.labelStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Discount";
            this.Text = "Apply Discount";
            this.Load += new System.EventHandler(this.Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.ComboBox comboBoxSelectItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDiscount;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.MaskedTextBox txt_NewPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiscountedPrice;
        private System.Windows.Forms.Button btn_ApplyDiscount;
    }
}