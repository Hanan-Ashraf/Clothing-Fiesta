namespace ClothingFiesta
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.comboAccType = new System.Windows.Forms.ComboBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(258, 449);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 29);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.btn_Exit_MouseHover);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(182, 220);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(90, 18);
            this.label_Username.TabIndex = 9;
            this.label_Username.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(278, 218);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(151, 23);
            this.txt_Username.TabIndex = 10;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(182, 268);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(87, 18);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(278, 266);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(151, 23);
            this.txt_Password.TabIndex = 10;
            // 
            // comboAccType
            // 
            this.comboAccType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboAccType.FormattingEnabled = true;
            this.comboAccType.Items.AddRange(new object[] {
            "Admin",
            "Outlet"});
            this.comboAccType.Location = new System.Drawing.Point(233, 331);
            this.comboAccType.Name = "comboAccType";
            this.comboAccType.Size = new System.Drawing.Size(143, 20);
            this.comboAccType.TabIndex = 12;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Login.Location = new System.Drawing.Point(233, 378);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(143, 40);
            this.btn_Login.TabIndex = 13;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseLeave += new System.EventHandler(this.btn_Login_MouseLeave);
            this.btn_Login.MouseHover += new System.EventHandler(this.btn_Login_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(132, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clothing Fiesta Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClothingFiesta.Properties.Resources.ClothingFiesta;
            this.pictureBox1.Location = new System.Drawing.Point(171, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Account";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.comboAccType);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clothing Fiesta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ComboBox comboAccType;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

