namespace ClothingFiesta
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Discount = new System.Windows.Forms.Button();
            this.btn_DeliverStock = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.flowLayoutPanel2);
            this.panelSideMenu.Controls.Add(this.panel5);
            this.panelSideMenu.Controls.Add(this.panel4);
            this.panelSideMenu.Controls.Add(this.panel3);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.MaximumSize = new System.Drawing.Size(226, 0);
            this.panelSideMenu.MinimumSize = new System.Drawing.Size(70, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(70, 639);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Discount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 75);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_DeliverStock);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 75);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 75);
            this.panel1.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelMenu);
            this.panelLogo.Controls.Add(this.MenuButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(70, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(68, 39);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(51, 18);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(70, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1045, 639);
            this.panelChildForm.TabIndex = 1;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_logout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 564);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 75);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_About);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 70);
            this.panel6.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btn_History);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 325);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(70, 152);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ClothingFiesta.Properties.Resources.Clothing_Final;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1045, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_History
            // 
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.FlatAppearance.BorderSize = 0;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_History.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_History.Image = global::ClothingFiesta.Properties.Resources.icons8_scroll_40;
            this.btn_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Location = new System.Drawing.Point(3, 3);
            this.btn_History.Name = "btn_History";
            this.btn_History.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_History.Size = new System.Drawing.Size(223, 70);
            this.btn_History.TabIndex = 0;
            this.btn_History.Text = "   Stock History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            this.btn_History.MouseLeave += new System.EventHandler(this.btn_History_MouseLeave);
            this.btn_History.MouseHover += new System.EventHandler(this.btn_History_MouseHover);
            // 
            // btn_About
            // 
            this.btn_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_About.Image = global::ClothingFiesta.Properties.Resources.icon_about_50;
            this.btn_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_About.Location = new System.Drawing.Point(0, 3);
            this.btn_About.Name = "btn_About";
            this.btn_About.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_About.Size = new System.Drawing.Size(226, 75);
            this.btn_About.TabIndex = 0;
            this.btn_About.Text = "   About";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            this.btn_About.MouseLeave += new System.EventHandler(this.btn_About_MouseLeave);
            this.btn_About.MouseHover += new System.EventHandler(this.btn_About_MouseHover);
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.Image = global::ClothingFiesta.Properties.Resources.icons8_logout_40;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(226, 75);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "    Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            this.btn_logout.MouseLeave += new System.EventHandler(this.btn_logout_MouseLeave);
            this.btn_logout.MouseHover += new System.EventHandler(this.btn_logout_MouseHover);
            // 
            // btn_Discount
            // 
            this.btn_Discount.FlatAppearance.BorderSize = 0;
            this.btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Discount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Discount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Discount.Image = global::ClothingFiesta.Properties.Resources.icons8_sale_price_tag_40;
            this.btn_Discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Discount.Location = new System.Drawing.Point(6, 0);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Discount.Size = new System.Drawing.Size(220, 75);
            this.btn_Discount.TabIndex = 0;
            this.btn_Discount.Text = "   Apply Discount";
            this.btn_Discount.UseVisualStyleBackColor = true;
            this.btn_Discount.Click += new System.EventHandler(this.btn_Discount_Click);
            this.btn_Discount.MouseLeave += new System.EventHandler(this.btn_Discount_MouseLeave);
            this.btn_Discount.MouseHover += new System.EventHandler(this.btn_Discount_MouseHover);
            // 
            // btn_DeliverStock
            // 
            this.btn_DeliverStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeliverStock.FlatAppearance.BorderSize = 0;
            this.btn_DeliverStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeliverStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeliverStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_DeliverStock.Image = global::ClothingFiesta.Properties.Resources.icon_stock_50;
            this.btn_DeliverStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeliverStock.Location = new System.Drawing.Point(0, 0);
            this.btn_DeliverStock.Name = "btn_DeliverStock";
            this.btn_DeliverStock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_DeliverStock.Size = new System.Drawing.Size(226, 75);
            this.btn_DeliverStock.TabIndex = 0;
            this.btn_DeliverStock.Text = "   Deliver Srock";
            this.btn_DeliverStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeliverStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeliverStock.UseVisualStyleBackColor = true;
            this.btn_DeliverStock.Click += new System.EventHandler(this.btn_DeliverStock_Click);
            this.btn_DeliverStock.MouseLeave += new System.EventHandler(this.btn_DeliverStock_MouseLeave);
            this.btn_DeliverStock.MouseHover += new System.EventHandler(this.btn_DeliverStock_MouseHover);
            // 
            // btnProducts
            // 
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = global::ClothingFiesta.Properties.Resources.icon_products_50;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(226, 75);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "   Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            this.btnProducts.MouseLeave += new System.EventHandler(this.btnProducts_MouseLeave);
            this.btnProducts.MouseHover += new System.EventHandler(this.btnProducts_MouseHover);
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.Location = new System.Drawing.Point(22, 35);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(29, 27);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 639);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_DeliverStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_Discount;

    }
}