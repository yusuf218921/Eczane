namespace Eczane
{
    partial class GirişEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişEkrani));
            this.textboxSifre = new System.Windows.Forms.TextBox();
            this.textboxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelGiriş = new System.Windows.Forms.Label();
            this.labelMesaj = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonGiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxSifre
            // 
            this.textboxSifre.Location = new System.Drawing.Point(380, 327);
            this.textboxSifre.Name = "textboxSifre";
            this.textboxSifre.Size = new System.Drawing.Size(152, 20);
            this.textboxSifre.TabIndex = 2;
            this.textboxSifre.UseSystemPasswordChar = true;
            // 
            // textboxKullaniciAdi
            // 
            this.textboxKullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textboxKullaniciAdi.Location = new System.Drawing.Point(380, 288);
            this.textboxKullaniciAdi.Name = "textboxKullaniciAdi";
            this.textboxKullaniciAdi.Size = new System.Drawing.Size(152, 20);
            this.textboxKullaniciAdi.TabIndex = 3;
            this.textboxKullaniciAdi.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(242, 288);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(107, 21);
            this.labelKullaniciAdi.TabIndex = 4;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            this.labelKullaniciAdi.Click += new System.EventHandler(this.label_username_Click);
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifre.ForeColor = System.Drawing.Color.White;
            this.labelSifre.Location = new System.Drawing.Point(298, 327);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(45, 21);
            this.labelSifre.TabIndex = 5;
            this.labelSifre.Text = "Şifre";
            // 
            // labelGiriş
            // 
            this.labelGiriş.AutoSize = true;
            this.labelGiriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelGiriş.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiriş.ForeColor = System.Drawing.Color.White;
            this.labelGiriş.Location = new System.Drawing.Point(387, 222);
            this.labelGiriş.Name = "labelGiriş";
            this.labelGiriş.Size = new System.Drawing.Size(81, 40);
            this.labelGiriş.TabIndex = 15;
            this.labelGiriş.Text = "Giriş";
            this.labelGiriş.Click += new System.EventHandler(this.label_welcome_Click);
            // 
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.BackColor = System.Drawing.Color.Transparent;
            this.labelMesaj.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMesaj.ForeColor = System.Drawing.Color.Red;
            this.labelMesaj.Location = new System.Drawing.Point(390, 173);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(0, 21);
            this.labelMesaj.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 251);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCikis
            // 
            this.buttonCikis.AutoSize = true;
            this.buttonCikis.BackColor = System.Drawing.Color.LightGray;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Location = new System.Drawing.Point(369, 363);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(79, 29);
            this.buttonCikis.TabIndex = 20;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGiriş
            // 
            this.buttonGiriş.AutoSize = true;
            this.buttonGiriş.BackColor = System.Drawing.Color.LightGray;
            this.buttonGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiriş.Location = new System.Drawing.Point(452, 363);
            this.buttonGiriş.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGiriş.Name = "buttonGiriş";
            this.buttonGiriş.Size = new System.Drawing.Size(90, 29);
            this.buttonGiriş.TabIndex = 22;
            this.buttonGiriş.Text = "GİRİŞ YAP";
            this.buttonGiriş.UseVisualStyleBackColor = false;
            this.buttonGiriş.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(293, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 51);
            this.label1.TabIndex = 23;
            this.label1.Text = "KANALİZE ECZANESİ\'NE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(293, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 51);
            this.label2.TabIndex = 24;
            this.label2.Text = "HOŞGELDİNİZ";
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(539, 329);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(55, 17);
            this.checkBoxSifreGoster.TabIndex = 25;
            this.checkBoxSifreGoster.Text = "göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // GirişEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.checkBoxSifreGoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGiriş);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMesaj);
            this.Controls.Add(this.labelGiriş);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Controls.Add(this.textboxKullaniciAdi);
            this.Controls.Add(this.textboxSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GirişEkrani";
            this.Text = "KANALİZE ECZANESİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxSifre;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textboxKullaniciAdi;
        private System.Windows.Forms.Label labelGiriş;
        private System.Windows.Forms.Label labelMesaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonGiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
    }
}

