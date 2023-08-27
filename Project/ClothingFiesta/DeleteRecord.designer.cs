using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClothingFiesta
{
    partial class DeleteRecord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRecord));
            this.Category = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.DeleteRecodlbl = new System.Windows.Forms.Label();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridViewShowStock = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Category.Location = new System.Drawing.Point(67, 141);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(61, 14);
            this.Category.TabIndex = 0;
            this.Category.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCategory.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(70, 161);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(108, 22);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DeleteRecodlbl
            // 
            this.DeleteRecodlbl.AutoSize = true;
            this.DeleteRecodlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.DeleteRecodlbl.ForeColor = System.Drawing.Color.Tomato;
            this.DeleteRecodlbl.Location = new System.Drawing.Point(277, 47);
            this.DeleteRecodlbl.Name = "DeleteRecodlbl";
            this.DeleteRecodlbl.Size = new System.Drawing.Size(203, 32);
            this.DeleteRecodlbl.TabIndex = 0;
            this.DeleteRecodlbl.Text = "Delete Record";
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSubCategory.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(192, 161);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(132, 22);
            this.comboBoxSubCategory.TabIndex = 3;
            this.comboBoxSubCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lblSubCategory.Location = new System.Drawing.Point(189, 141);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(88, 14);
            this.lblSubCategory.TabIndex = 2;
            this.lblSubCategory.Text = "Sub-Category";
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItemType.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(338, 161);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(167, 22);
            this.comboBoxItemType.TabIndex = 5;
            this.comboBoxItemType.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.label1.Location = new System.Drawing.Point(335, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label2.Location = new System.Drawing.Point(11, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.Tomato;
            this.btnShow.Location = new System.Drawing.Point(634, 156);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 32);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show Item";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.MouseLeave += new System.EventHandler(this.btnShow_MouseLeave);
            this.btnShow.MouseHover += new System.EventHandler(this.btnShow_MouseHover);
            // 
            // dataGridViewShowStock
            // 
            this.dataGridViewShowStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowStock.Location = new System.Drawing.Point(14, 226);
            this.dataGridViewShowStock.Name = "dataGridViewShowStock";
            this.dataGridViewShowStock.RowHeadersWidth = 51;
            this.dataGridViewShowStock.RowTemplate.Height = 29;
            this.dataGridViewShowStock.Size = new System.Drawing.Size(712, 506);
            this.dataGridViewShowStock.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Tomato;
            this.btnDelete.Location = new System.Drawing.Point(613, 762);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 47);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.labelProductCode.Location = new System.Drawing.Point(516, 141);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(67, 14);
            this.labelProductCode.TabIndex = 4;
            this.labelProductCode.Text = "Item Code";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxItem.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(519, 161);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(108, 22);
            this.comboBoxItem.TabIndex = 1;
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 914);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewShowStock);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.labelProductCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSubCategory);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.DeleteRecodlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Category);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Record";
            this.Load += new System.EventHandler(this.DeleteRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Category;
        private ComboBox comboBoxCategory;
        private Label DeleteRecodlbl;
        private ComboBox comboBoxSubCategory;
        private Label lblSubCategory;
        private ComboBox comboBoxItemType;
        private Label label1;
        private Label label2;
        private Button btnShow;
        private DataGridView dataGridViewShowStock;
        private Button btnDelete;
        private Label labelProductCode;
        private ComboBox comboBoxItem;
    }
}