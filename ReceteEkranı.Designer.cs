using System.Windows.Forms;

namespace Eczane
{
    partial class ReceteEkranı
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
            this.labelKullanici = new System.Windows.Forms.Label();
            this.labelRecete = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.buttonRecete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHastaEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Location = new System.Drawing.Point(12, 9);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(52, 13);
            this.labelKullanici.TabIndex = 0;
            this.labelKullanici.Text = "Kullanıcı :";
            // 
            // labelRecete
            // 
            this.labelRecete.AutoSize = true;
            this.labelRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRecete.Location = new System.Drawing.Point(193, 9);
            this.labelRecete.Name = "labelRecete";
            this.labelRecete.Size = new System.Drawing.Size(412, 31);
            this.labelRecete.TabIndex = 1;
            this.labelRecete.Text = "RECETE OLUŞTURMA EKRANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC";
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(132, 131);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTC.TabIndex = 3;
            // 
            // buttonRecete
            // 
            this.buttonRecete.Location = new System.Drawing.Point(199, 197);
            this.buttonRecete.Name = "buttonRecete";
            this.buttonRecete.Size = new System.Drawing.Size(121, 23);
            this.buttonRecete.TabIndex = 4;
            this.buttonRecete.Text = "Receteyi Yaz";
            this.buttonRecete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "İLAC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Bulunamadı";
            // 
            // buttonHastaEkle
            // 
            this.buttonHastaEkle.Location = new System.Drawing.Point(337, 129);
            this.buttonHastaEkle.Name = "buttonHastaEkle";
            this.buttonHastaEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonHastaEkle.TabIndex = 8;
            this.buttonHastaEkle.Text = "Hastayı Ekle";
            this.buttonHastaEkle.UseVisualStyleBackColor = true;
            this.buttonHastaEkle.Click += new System.EventHandler(this.buttonHastaEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // ReceteEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonHastaEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRecete);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRecete);
            this.Controls.Add(this.labelKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceteEkranı";
            this.Text = "İLAÇ SATIN ALMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage page_makeReservation;
        private Label labelKullanici;
        private Label labelRecete;
        private Label label2;
        private TextBox textBoxTC;
        private Button buttonRecete;
        private Label label1;
        private Label label3;
        private Button buttonHastaEkle;
        private ComboBox comboBox1;
    }
}