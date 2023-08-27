
namespace ClothingFiesta
{
    partial class Items
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkedListBoxMaterial = new System.Windows.Forms.CheckedListBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.checkedListBoxClothing = new System.Windows.Forms.CheckedListBox();
            this.labelClothing = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.labelCategory2 = new System.Windows.Forms.Label();
            this.checkedListBoxCategory1 = new System.Windows.Forms.CheckedListBox();
            this.labelCategory1 = new System.Windows.Forms.Label();
            this.checkedListBoxCategory = new System.Windows.Forms.CheckedListBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NameClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCross = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.labelMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxClothing);
            this.splitContainer1.Panel1.Controls.Add(this.labelClothing);
            this.splitContainer1.Panel1.Controls.Add(this.labelSeparator);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox2);
            this.splitContainer1.Panel1.Controls.Add(this.labelCategory2);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxCategory1);
            this.splitContainer1.Panel1.Controls.Add(this.labelCategory1);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBoxCategory);
            this.splitContainer1.Panel1.Controls.Add(this.labelCategory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCross);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(889, 639);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkedListBoxMaterial
            // 
            this.checkedListBoxMaterial.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxMaterial.FormattingEnabled = true;
            this.checkedListBoxMaterial.Items.AddRange(new object[] {
            "Cotton",
            "Linen",
            "Valvet",
            "Synthetic",
            "Leather"});
            this.checkedListBoxMaterial.Location = new System.Drawing.Point(18, 510);
            this.checkedListBoxMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxMaterial.Name = "checkedListBoxMaterial";
            this.checkedListBoxMaterial.Size = new System.Drawing.Size(140, 64);
            this.checkedListBoxMaterial.TabIndex = 11;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterial.Location = new System.Drawing.Point(16, 488);
            this.labelMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(50, 12);
            this.labelMaterial.TabIndex = 10;
            this.labelMaterial.Text = "Material";
            // 
            // checkedListBoxClothing
            // 
            this.checkedListBoxClothing.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxClothing.FormattingEnabled = true;
            this.checkedListBoxClothing.Items.AddRange(new object[] {
            "Tops and Shirts",
            "T-Shirts",
            "Bottoms and Tights",
            "Jeans"});
            this.checkedListBoxClothing.Location = new System.Drawing.Point(18, 397);
            this.checkedListBoxClothing.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxClothing.Name = "checkedListBoxClothing";
            this.checkedListBoxClothing.Size = new System.Drawing.Size(140, 64);
            this.checkedListBoxClothing.TabIndex = 9;
            // 
            // labelClothing
            // 
            this.labelClothing.AutoSize = true;
            this.labelClothing.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClothing.Location = new System.Drawing.Point(16, 377);
            this.labelClothing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClothing.Name = "labelClothing";
            this.labelClothing.Size = new System.Drawing.Size(51, 12);
            this.labelClothing.TabIndex = 8;
            this.labelClothing.Text = "Clothing";
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.Location = new System.Drawing.Point(16, 346);
            this.labelSeparator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(130, 13);
            this.labelSeparator.TabIndex = 7;
            this.labelSeparator.Text = "-----------------------------------------";
            this.labelSeparator.Click += new System.EventHandler(this.labelSeparator_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Tops and Shirts",
            "T-Shirts",
            "Bottoms and Tights",
            "Jeans"});
            this.checkedListBox2.Location = new System.Drawing.Point(18, 261);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(140, 64);
            this.checkedListBox2.TabIndex = 6;
            // 
            // labelCategory2
            // 
            this.labelCategory2.AutoSize = true;
            this.labelCategory2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory2.Location = new System.Drawing.Point(16, 240);
            this.labelCategory2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory2.Name = "labelCategory2";
            this.labelCategory2.Size = new System.Drawing.Size(63, 12);
            this.labelCategory2.TabIndex = 5;
            this.labelCategory2.Text = "Category2";
            // 
            // checkedListBoxCategory1
            // 
            this.checkedListBoxCategory1.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCategory1.FormattingEnabled = true;
            this.checkedListBoxCategory1.Items.AddRange(new object[] {
            "Western",
            "Pakistani"});
            this.checkedListBoxCategory1.Location = new System.Drawing.Point(18, 174);
            this.checkedListBoxCategory1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxCategory1.Name = "checkedListBoxCategory1";
            this.checkedListBoxCategory1.Size = new System.Drawing.Size(140, 49);
            this.checkedListBoxCategory1.TabIndex = 4;
            // 
            // labelCategory1
            // 
            this.labelCategory1.AutoSize = true;
            this.labelCategory1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory1.Location = new System.Drawing.Point(16, 153);
            this.labelCategory1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory1.Name = "labelCategory1";
            this.labelCategory1.Size = new System.Drawing.Size(63, 12);
            this.labelCategory1.TabIndex = 3;
            this.labelCategory1.Text = "Category1";
            // 
            // checkedListBoxCategory
            // 
            this.checkedListBoxCategory.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxCategory.FormattingEnabled = true;
            this.checkedListBoxCategory.Items.AddRange(new object[] {
            "Men",
            "Women",
            "Kids",
            "All"});
            this.checkedListBoxCategory.Location = new System.Drawing.Point(18, 71);
            this.checkedListBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxCategory.Name = "checkedListBoxCategory";
            this.checkedListBoxCategory.Size = new System.Drawing.Size(140, 64);
            this.checkedListBoxCategory.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(16, 48);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(56, 12);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 497);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameClm,
            this.QtyClm,
            this.ColorClm,
            this.MaterialClm,
            this.PriceClm,
            this.DiscountClm});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(582, 497);
            this.dataGridView.TabIndex = 1;
            // 
            // NameClm
            // 
            this.NameClm.HeaderText = "Item Name";
            this.NameClm.MinimumWidth = 8;
            this.NameClm.Name = "NameClm";
            this.NameClm.ReadOnly = true;
            // 
            // QtyClm
            // 
            this.QtyClm.HeaderText = "Quantity";
            this.QtyClm.MinimumWidth = 8;
            this.QtyClm.Name = "QtyClm";
            this.QtyClm.ReadOnly = true;
            // 
            // ColorClm
            // 
            this.ColorClm.HeaderText = "Color";
            this.ColorClm.MinimumWidth = 8;
            this.ColorClm.Name = "ColorClm";
            this.ColorClm.ReadOnly = true;
            // 
            // MaterialClm
            // 
            this.MaterialClm.HeaderText = "Material";
            this.MaterialClm.MinimumWidth = 8;
            this.MaterialClm.Name = "MaterialClm";
            this.MaterialClm.ReadOnly = true;
            // 
            // PriceClm
            // 
            this.PriceClm.HeaderText = "Price";
            this.PriceClm.MinimumWidth = 8;
            this.PriceClm.Name = "PriceClm";
            this.PriceClm.ReadOnly = true;
            // 
            // DiscountClm
            // 
            this.DiscountClm.HeaderText = "Discount";
            this.DiscountClm.MinimumWidth = 8;
            this.DiscountClm.Name = "DiscountClm";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::ClothingFiesta.Properties.Resources.icons8_google_web_search_48;
            this.buttonSearch.Location = new System.Drawing.Point(585, 45);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(36, 36);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonCross
            // 
            this.buttonCross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCross.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCross.FlatAppearance.BorderSize = 0;
            this.buttonCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCross.Image = global::ClothingFiesta.Properties.Resources.Delete_32px;
            this.buttonCross.Location = new System.Drawing.Point(549, 52);
            this.buttonCross.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCross.Name = "buttonCross";
            this.buttonCross.Size = new System.Drawing.Size(18, 20);
            this.buttonCross.TabIndex = 1;
            this.buttonCross.UseVisualStyleBackColor = false;
            this.buttonCross.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(350, 49);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(220, 26);
            this.textBoxSearch.TabIndex = 0;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 639);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Items";
            this.Text = "Items";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label labelCategory2;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategory1;
        private System.Windows.Forms.Label labelCategory1;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.CheckedListBox checkedListBoxMaterial;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.CheckedListBox checkedListBoxClothing;
        private System.Windows.Forms.Label labelClothing;
        private System.Windows.Forms.Button buttonCross;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountClm;
    }
}