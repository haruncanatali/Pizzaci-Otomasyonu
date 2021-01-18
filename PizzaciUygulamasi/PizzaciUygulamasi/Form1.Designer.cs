namespace PizzaciUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icecekCmbx = new System.Windows.Forms.ComboBox();
            this.PizzaBoyCmbx = new System.Windows.Forms.ComboBox();
            this.icecekSayi = new System.Windows.Forms.NumericUpDown();
            this.pizzaSayi = new System.Windows.Forms.NumericUpDown();
            this.adresTxt = new System.Windows.Forms.RichTextBox();
            this.TelefonTxt = new System.Windows.Forms.TextBox();
            this.adSoyadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ekstraListBox = new System.Windows.Forms.ListBox();
            this.PizzaBoyAdetListbox = new System.Windows.Forms.ListBox();
            this.icecekAdetListBox = new System.Windows.Forms.ListBox();
            this.ucretListBox = new System.Windows.Forms.ListBox();
            this.adresListBox = new System.Windows.Forms.ListBox();
            this.telefonListBOx = new System.Windows.Forms.ListBox();
            this.adSoyadListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.siparisiAlButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icecekSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSayi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.icecekCmbx);
            this.groupBox1.Controls.Add(this.PizzaBoyCmbx);
            this.groupBox1.Controls.Add(this.icecekSayi);
            this.groupBox1.Controls.Add(this.pizzaSayi);
            this.groupBox1.Controls.Add(this.adresTxt);
            this.groupBox1.Controls.Add(this.TelefonTxt);
            this.groupBox1.Controls.Add(this.adSoyadTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // icecekCmbx
            // 
            this.icecekCmbx.FormattingEnabled = true;
            this.icecekCmbx.Items.AddRange(new object[] {
            "Su",
            "Fanta",
            "Kola",
            "Sprite",
            "Ayran"});
            this.icecekCmbx.Location = new System.Drawing.Point(129, 120);
            this.icecekCmbx.Name = "icecekCmbx";
            this.icecekCmbx.Size = new System.Drawing.Size(100, 24);
            this.icecekCmbx.TabIndex = 4;
            // 
            // PizzaBoyCmbx
            // 
            this.PizzaBoyCmbx.FormattingEnabled = true;
            this.PizzaBoyCmbx.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.PizzaBoyCmbx.Location = new System.Drawing.Point(129, 93);
            this.PizzaBoyCmbx.Name = "PizzaBoyCmbx";
            this.PizzaBoyCmbx.Size = new System.Drawing.Size(100, 24);
            this.PizzaBoyCmbx.TabIndex = 4;
            // 
            // icecekSayi
            // 
            this.icecekSayi.Location = new System.Drawing.Point(275, 123);
            this.icecekSayi.Name = "icecekSayi";
            this.icecekSayi.Size = new System.Drawing.Size(39, 22);
            this.icecekSayi.TabIndex = 3;
            // 
            // pizzaSayi
            // 
            this.pizzaSayi.Location = new System.Drawing.Point(275, 93);
            this.pizzaSayi.Name = "pizzaSayi";
            this.pizzaSayi.Size = new System.Drawing.Size(39, 22);
            this.pizzaSayi.TabIndex = 3;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(334, 43);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(342, 102);
            this.adresTxt.TabIndex = 2;
            this.adresTxt.Text = "";
            // 
            // TelefonTxt
            // 
            this.TelefonTxt.Location = new System.Drawing.Point(129, 48);
            this.TelefonTxt.Name = "TelefonTxt";
            this.TelefonTxt.Size = new System.Drawing.Size(144, 22);
            this.TelefonTxt.TabIndex = 1;
            this.TelefonTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adSoyadTxt
            // 
            this.adSoyadTxt.Location = new System.Drawing.Point(129, 22);
            this.adSoyadTxt.Name = "adSoyadTxt";
            this.adSoyadTxt.Size = new System.Drawing.Size(144, 22);
            this.adSoyadTxt.TabIndex = 1;
            this.adSoyadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "İçecek :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pizza Boy :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Ve Soyadı :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.ekstraListBox);
            this.groupBox2.Controls.Add(this.PizzaBoyAdetListbox);
            this.groupBox2.Controls.Add(this.icecekAdetListBox);
            this.groupBox2.Controls.Add(this.ucretListBox);
            this.groupBox2.Controls.Add(this.adresListBox);
            this.groupBox2.Controls.Add(this.telefonListBOx);
            this.groupBox2.Controls.Add(this.adSoyadListBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1249, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparişler";
            // 
            // ekstraListBox
            // 
            this.ekstraListBox.FormattingEnabled = true;
            this.ekstraListBox.ItemHeight = 16;
            this.ekstraListBox.Location = new System.Drawing.Point(682, 52);
            this.ekstraListBox.Name = "ekstraListBox";
            this.ekstraListBox.Size = new System.Drawing.Size(243, 164);
            this.ekstraListBox.TabIndex = 1;
            // 
            // PizzaBoyAdetListbox
            // 
            this.PizzaBoyAdetListbox.FormattingEnabled = true;
            this.PizzaBoyAdetListbox.ItemHeight = 16;
            this.PizzaBoyAdetListbox.Location = new System.Drawing.Point(520, 52);
            this.PizzaBoyAdetListbox.Name = "PizzaBoyAdetListbox";
            this.PizzaBoyAdetListbox.Size = new System.Drawing.Size(156, 164);
            this.PizzaBoyAdetListbox.TabIndex = 1;
            // 
            // icecekAdetListBox
            // 
            this.icecekAdetListBox.FormattingEnabled = true;
            this.icecekAdetListBox.ItemHeight = 16;
            this.icecekAdetListBox.Location = new System.Drawing.Point(931, 52);
            this.icecekAdetListBox.Name = "icecekAdetListBox";
            this.icecekAdetListBox.Size = new System.Drawing.Size(186, 164);
            this.icecekAdetListBox.TabIndex = 1;
            // 
            // ucretListBox
            // 
            this.ucretListBox.FormattingEnabled = true;
            this.ucretListBox.ItemHeight = 16;
            this.ucretListBox.Location = new System.Drawing.Point(1123, 52);
            this.ucretListBox.Name = "ucretListBox";
            this.ucretListBox.Size = new System.Drawing.Size(120, 164);
            this.ucretListBox.TabIndex = 1;
            // 
            // adresListBox
            // 
            this.adresListBox.FormattingEnabled = true;
            this.adresListBox.ItemHeight = 16;
            this.adresListBox.Location = new System.Drawing.Point(325, 52);
            this.adresListBox.Name = "adresListBox";
            this.adresListBox.Size = new System.Drawing.Size(189, 164);
            this.adresListBox.TabIndex = 1;
            // 
            // telefonListBOx
            // 
            this.telefonListBOx.FormattingEnabled = true;
            this.telefonListBOx.ItemHeight = 16;
            this.telefonListBOx.Location = new System.Drawing.Point(181, 52);
            this.telefonListBOx.Name = "telefonListBOx";
            this.telefonListBOx.Size = new System.Drawing.Size(138, 164);
            this.telefonListBOx.TabIndex = 1;
            // 
            // adSoyadListBox
            // 
            this.adSoyadListBox.FormattingEnabled = true;
            this.adSoyadListBox.ItemHeight = 16;
            this.adSoyadListBox.Location = new System.Drawing.Point(9, 52);
            this.adSoyadListBox.Name = "adSoyadListBox";
            this.adSoyadListBox.Size = new System.Drawing.Size(166, 164);
            this.adSoyadListBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adı  Soyadı ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1156, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ücret :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(967, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "İçecek Ve Adet :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ekstra :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(541, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pizza Boy Ve Adet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(765, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstra";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(114, 68);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(71, 20);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Sebze";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.ekstraSec);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(114, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 20);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Peynir";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.ekstraSec);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Mantar";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.ekstraSec);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(114, 21);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(67, 20);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Kaşar";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.ekstraSec);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 20);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Sosis";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.ekstraSec);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Sucuk";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.ekstraSec);
            // 
            // siparisiAlButton
            // 
            this.siparisiAlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisiAlButton.Location = new System.Drawing.Point(770, 128);
            this.siparisiAlButton.Name = "siparisiAlButton";
            this.siparisiAlButton.Size = new System.Drawing.Size(87, 29);
            this.siparisiAlButton.TabIndex = 3;
            this.siparisiAlButton.Text = "Siparişi Al";
            this.siparisiAlButton.UseVisualStyleBackColor = true;
            this.siparisiAlButton.Click += new System.EventHandler(this.siparisiAlButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(770, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(859, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Siparişleri Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.siparisiAlButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Pizzacı Otomasyonu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icecekSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaSayi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox adresTxt;
        private System.Windows.Forms.TextBox adSoyadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown icecekSayi;
        private System.Windows.Forms.NumericUpDown pizzaSayi;
        private System.Windows.Forms.ListBox ekstraListBox;
        private System.Windows.Forms.ListBox PizzaBoyAdetListbox;
        private System.Windows.Forms.ListBox icecekAdetListBox;
        private System.Windows.Forms.ListBox ucretListBox;
        private System.Windows.Forms.ListBox adresListBox;
        private System.Windows.Forms.ListBox telefonListBOx;
        private System.Windows.Forms.ListBox adSoyadListBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button siparisiAlButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TelefonTxt;
        private System.Windows.Forms.ComboBox icecekCmbx;
        private System.Windows.Forms.ComboBox PizzaBoyCmbx;
    }
}

