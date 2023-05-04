namespace Eczane
{
    partial class HastaKayitEkrani
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
            this.textboxTC = new System.Windows.Forms.TextBox();
            this.textboxAd = new System.Windows.Forms.TextBox();
            this.textboxSoyad = new System.Windows.Forms.TextBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelHastaAd = new System.Windows.Forms.Label();
            this.labelHastaSoyad = new System.Windows.Forms.Label();
            this.labelDogumTarih = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.labelHastaKayıt = new System.Windows.Forms.Label();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonHastaKayit = new System.Windows.Forms.Button();
            this.dateTimePickerDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.labelBaşarılı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxTC
            // 
            this.textboxTC.Location = new System.Drawing.Point(260, 143);
            this.textboxTC.MaxLength = 11;
            this.textboxTC.Name = "textboxTC";
            this.textboxTC.Size = new System.Drawing.Size(251, 20);
            this.textboxTC.TabIndex = 1;
            // 
            // textboxAd
            // 
            this.textboxAd.Location = new System.Drawing.Point(260, 187);
            this.textboxAd.MaxLength = 50;
            this.textboxAd.Name = "textboxAd";
            this.textboxAd.Size = new System.Drawing.Size(251, 20);
            this.textboxAd.TabIndex = 2;
            this.textboxAd.UseSystemPasswordChar = true;
            // 
            // textboxSoyad
            // 
            this.textboxSoyad.Location = new System.Drawing.Point(260, 234);
            this.textboxSoyad.MaxLength = 50;
            this.textboxSoyad.Name = "textboxSoyad";
            this.textboxSoyad.Size = new System.Drawing.Size(251, 20);
            this.textboxSoyad.TabIndex = 3;
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelTC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTC.ForeColor = System.Drawing.Color.White;
            this.labelTC.Location = new System.Drawing.Point(226, 143);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(28, 21);
            this.labelTC.TabIndex = 6;
            this.labelTC.Text = "TC";
            // 
            // labelHastaAd
            // 
            this.labelHastaAd.AutoSize = true;
            this.labelHastaAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelHastaAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHastaAd.ForeColor = System.Drawing.Color.White;
            this.labelHastaAd.Location = new System.Drawing.Point(146, 187);
            this.labelHastaAd.Name = "labelHastaAd";
            this.labelHastaAd.Size = new System.Drawing.Size(108, 21);
            this.labelHastaAd.TabIndex = 7;
            this.labelHastaAd.Text = "Hastanın Adı";
            // 
            // labelHastaSoyad
            // 
            this.labelHastaSoyad.AutoSize = true;
            this.labelHastaSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelHastaSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHastaSoyad.ForeColor = System.Drawing.Color.White;
            this.labelHastaSoyad.Location = new System.Drawing.Point(192, 234);
            this.labelHastaSoyad.Name = "labelHastaSoyad";
            this.labelHastaSoyad.Size = new System.Drawing.Size(62, 21);
            this.labelHastaSoyad.TabIndex = 10;
            this.labelHastaSoyad.Text = "Soyadı";
            // 
            // labelDogumTarih
            // 
            this.labelDogumTarih.AutoSize = true;
            this.labelDogumTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelDogumTarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDogumTarih.ForeColor = System.Drawing.Color.White;
            this.labelDogumTarih.Location = new System.Drawing.Point(140, 279);
            this.labelDogumTarih.Name = "labelDogumTarih";
            this.labelDogumTarih.Size = new System.Drawing.Size(114, 21);
            this.labelDogumTarih.TabIndex = 11;
            this.labelDogumTarih.Text = "Dogum Tarihi";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.BackColor = System.Drawing.Color.Transparent;
            this.label_message.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_message.ForeColor = System.Drawing.Color.Red;
            this.label_message.Location = new System.Drawing.Point(130, 354);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 21);
            this.label_message.TabIndex = 27;
            // 
            // labelHastaKayıt
            // 
            this.labelHastaKayıt.AutoSize = true;
            this.labelHastaKayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.labelHastaKayıt.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHastaKayıt.ForeColor = System.Drawing.Color.White;
            this.labelHastaKayıt.Location = new System.Drawing.Point(302, 9);
            this.labelHastaKayıt.Name = "labelHastaKayıt";
            this.labelHastaKayıt.Size = new System.Drawing.Size(192, 37);
            this.labelHastaKayıt.TabIndex = 28;
            this.labelHastaKayıt.Text = "HASTA KAYDI";
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackColor = System.Drawing.Color.LightGray;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGeri.Location = new System.Drawing.Point(260, 305);
            this.buttonGeri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(69, 29);
            this.buttonGeri.TabIndex = 29;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = false;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonHastaKayit
            // 
            this.buttonHastaKayit.BackColor = System.Drawing.Color.LightGray;
            this.buttonHastaKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHastaKayit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHastaKayit.Location = new System.Drawing.Point(387, 305);
            this.buttonHastaKayit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHastaKayit.Name = "buttonHastaKayit";
            this.buttonHastaKayit.Size = new System.Drawing.Size(124, 29);
            this.buttonHastaKayit.TabIndex = 30;
            this.buttonHastaKayit.Text = "KAYIT OLUŞTUR";
            this.buttonHastaKayit.UseVisualStyleBackColor = false;
            this.buttonHastaKayit.Click += new System.EventHandler(this.buttonHastaKayit_Click);
            // 
            // dateTimePickerDogumTarih
            // 
            this.dateTimePickerDogumTarih.Location = new System.Drawing.Point(260, 279);
            this.dateTimePickerDogumTarih.MaxDate = new System.DateTime(2023, 5, 4, 0, 0, 0, 0);
            this.dateTimePickerDogumTarih.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDogumTarih.Name = "dateTimePickerDogumTarih";
            this.dateTimePickerDogumTarih.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerDogumTarih.TabIndex = 31;
            this.dateTimePickerDogumTarih.Value = new System.DateTime(2023, 5, 4, 0, 0, 0, 0);
            // 
            // labelBaşarılı
            // 
            this.labelBaşarılı.AutoSize = true;
            this.labelBaşarılı.Location = new System.Drawing.Point(257, 95);
            this.labelBaşarılı.Name = "labelBaşarılı";
            this.labelBaşarılı.Size = new System.Drawing.Size(0, 13);
            this.labelBaşarılı.TabIndex = 32;
            // 
            // HastaKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.labelBaşarılı);
            this.Controls.Add(this.dateTimePickerDogumTarih);
            this.Controls.Add(this.buttonHastaKayit);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.labelHastaKayıt);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.labelDogumTarih);
            this.Controls.Add(this.labelHastaSoyad);
            this.Controls.Add(this.labelHastaAd);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.textboxSoyad);
            this.Controls.Add(this.textboxAd);
            this.Controls.Add(this.textboxTC);
            this.Name = "HastaKayitEkrani";
            this.Text = "KAYIT OL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxTC;
        private System.Windows.Forms.TextBox textboxAd;
        private System.Windows.Forms.TextBox textboxSoyad;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelHastaAd;
        private System.Windows.Forms.Label labelHastaSoyad;
        private System.Windows.Forms.Label labelDogumTarih;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label labelHastaKayıt;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonHastaKayit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarih;
        private System.Windows.Forms.Label labelBaşarılı;
    }
}