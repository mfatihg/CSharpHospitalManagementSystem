﻿namespace Hastane_Proje
{
    partial class frm_bilgi_duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bilgi_duzenle));
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.mskYas = new System.Windows.Forms.MaskedTextBox();
            this.mskKilo = new System.Windows.Forms.MaskedTextBox();
            this.mskBoy = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mskAcilTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAcilKisi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIlaclar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbKanGrup = new System.Windows.Forms.ComboBox();
            this.txtTani = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlerji = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBilgiGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(101, 260);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(171, 33);
            this.btnBilgiGuncelle.TabIndex = 7;
            this.btnBilgiGuncelle.Text = "Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // mskYas
            // 
            this.mskYas.Location = new System.Drawing.Point(684, 28);
            this.mskYas.Mask = "000";
            this.mskYas.Name = "mskYas";
            this.mskYas.Size = new System.Drawing.Size(172, 32);
            this.mskYas.TabIndex = 12;
            this.mskYas.ValidatingType = typeof(int);
            // 
            // mskKilo
            // 
            this.mskKilo.Location = new System.Drawing.Point(684, 72);
            this.mskKilo.Mask = "000";
            this.mskKilo.Name = "mskKilo";
            this.mskKilo.Size = new System.Drawing.Size(172, 32);
            this.mskKilo.TabIndex = 13;
            this.mskKilo.ValidatingType = typeof(int);
            // 
            // mskBoy
            // 
            this.mskBoy.Location = new System.Drawing.Point(684, 114);
            this.mskBoy.Mask = "000";
            this.mskBoy.Name = "mskBoy";
            this.mskBoy.Size = new System.Drawing.Size(172, 32);
            this.mskBoy.TabIndex = 14;
            this.mskBoy.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(630, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 24);
            this.label13.TabIndex = 125;
            this.label13.Text = "Yaş:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(630, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 24);
            this.label11.TabIndex = 124;
            this.label11.Text = "Boy:";
            // 
            // mskAcilTelefon
            // 
            this.mskAcilTelefon.Location = new System.Drawing.Point(684, 207);
            this.mskAcilTelefon.Mask = "(999) 000-0000";
            this.mskAcilTelefon.Name = "mskAcilTelefon";
            this.mskAcilTelefon.Size = new System.Drawing.Size(172, 32);
            this.mskAcilTelefon.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(571, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 48);
            this.label15.TabIndex = 122;
            this.label15.Text = "Acil Durum \r\n             Tel:";
            // 
            // txtAcilKisi
            // 
            this.txtAcilKisi.Location = new System.Drawing.Point(684, 163);
            this.txtAcilKisi.Name = "txtAcilKisi";
            this.txtAcilKisi.Size = new System.Drawing.Size(172, 32);
            this.txtAcilKisi.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(571, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 48);
            this.label16.TabIndex = 121;
            this.label16.Text = "Acil Durum \r\n          Kişisi:";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(385, 28);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(175, 32);
            this.txtEPosta.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(300, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 24);
            this.label14.TabIndex = 119;
            this.label14.Text = "E-Posta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(630, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 117;
            this.label12.Text = "Kilo:";
            // 
            // txtIlaclar
            // 
            this.txtIlaclar.Location = new System.Drawing.Point(388, 208);
            this.txtIlaclar.Name = "txtIlaclar";
            this.txtIlaclar.Size = new System.Drawing.Size(172, 32);
            this.txtIlaclar.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 48);
            this.label10.TabIndex = 116;
            this.label10.Text = "Kullanılan \r\n      İlaçlar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 114;
            this.label9.Text = "Kan Grubu:";
            // 
            // cmbKanGrup
            // 
            this.cmbKanGrup.FormattingEnabled = true;
            this.cmbKanGrup.Items.AddRange(new object[] {
            "A Rh(+)\t",
            "A Rh(-)",
            "B Rh(+)",
            "B Rh(-)",
            "AB Rh(+)\t",
            "AB Rh(-)",
            "0 Rh(+)",
            "0 Rh(-)"});
            this.cmbKanGrup.Location = new System.Drawing.Point(385, 70);
            this.cmbKanGrup.Name = "cmbKanGrup";
            this.cmbKanGrup.Size = new System.Drawing.Size(175, 32);
            this.cmbKanGrup.TabIndex = 8;
            // 
            // txtTani
            // 
            this.txtTani.Location = new System.Drawing.Point(388, 161);
            this.txtTani.Name = "txtTani";
            this.txtTani.Size = new System.Drawing.Size(172, 32);
            this.txtTani.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 48);
            this.label5.TabIndex = 112;
            this.label5.Text = "Mevcut \r\nTanılar:";
            // 
            // txtAlerji
            // 
            this.txtAlerji.Location = new System.Drawing.Point(388, 114);
            this.txtAlerji.Name = "txtAlerji";
            this.txtAlerji.Size = new System.Drawing.Size(172, 32);
            this.txtAlerji.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 111;
            this.label8.Text = "Alerjiler:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 108;
            this.label7.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(95, 172);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(171, 32);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(95, 64);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(172, 32);
            this.txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 107;
            this.label1.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(95, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(172, 32);
            this.txtAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 106;
            this.label3.Text = "Ad:";
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(95, 100);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(172, 32);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 105;
            this.label6.Text = "T.C. No:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(95, 208);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(172, 32);
            this.txtSifre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 104;
            this.label4.Text = "Şifre:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(95, 136);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(172, 32);
            this.mskTel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 103;
            this.label2.Text = "Telefon:";
            // 
            // frm_bilgi_duzenle
            // 
            this.AcceptButton = this.btnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(897, 329);
            this.Controls.Add(this.mskYas);
            this.Controls.Add(this.mskKilo);
            this.Controls.Add(this.mskBoy);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskAcilTelefon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAcilKisi);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIlaclar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbKanGrup);
            this.Controls.Add(this.txtTani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlerji);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_bilgi_duzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgileri Düzenle";
            this.Load += new System.EventHandler(this.frm_bilgi_duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.MaskedTextBox mskYas;
        private System.Windows.Forms.MaskedTextBox mskKilo;
        private System.Windows.Forms.MaskedTextBox mskBoy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskAcilTelefon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAcilKisi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIlaclar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbKanGrup;
        private System.Windows.Forms.TextBox txtTani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlerji;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label2;
    }
}