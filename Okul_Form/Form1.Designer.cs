
namespace Okul_Form
{
    partial class Form1
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
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.rbEnDusuk = new System.Windows.Forms.RadioButton();
            this.rbEnYuksek = new System.Windows.Forms.RadioButton();
            this.rbOrtalama = new System.Windows.Forms.RadioButton();
            this.rbSinavToplam = new System.Windows.Forms.RadioButton();
            this.rbToplamKayit = new System.Windows.Forms.RadioButton();
            this.rbKayitVarmi = new System.Windows.Forms.RadioButton();
            this.rbAIleBiten = new System.Windows.Forms.RadioButton();
            this.rbAIleBaslayan = new System.Windows.Forms.RadioButton();
            this.rbIdyeGoreAra = new System.Windows.Forms.RadioButton();
            this.rbIlk3 = new System.Windows.Forms.RadioButton();
            this.rbAdaGoreSiralaTersten = new System.Windows.Forms.RadioButton();
            this.rbAdaGoreSirala = new System.Windows.Forms.RadioButton();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.btnDersListesi = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnOgrListele = new System.Windows.Forms.Button();
            this.gbxNotlar = new System.Windows.Forms.GroupBox();
            this.btnSinavGuncelle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSinav1 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblSinav2 = new System.Windows.Forms.Label();
            this.lblSinav3 = new System.Windows.Forms.Label();
            this.gbxDersler = new System.Windows.Forms.GroupBox();
            this.txtDersSaat = new System.Windows.Forms.TextBox();
            this.lblDersSaat = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.lblDersId = new System.Windows.Forms.Label();
            this.gbxOgrenciler = new System.Windows.Forms.GroupBox();
            this.txtOgrFotograf = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrId = new System.Windows.Forms.TextBox();
            this.lblOgrFotograf = new System.Windows.Forms.Label();
            this.lblOgrId = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.rbOgrenci = new System.Windows.Forms.RadioButton();
            this.gbxSec = new System.Windows.Forms.GroupBox();
            this.rbNot = new System.Windows.Forms.RadioButton();
            this.rbDers = new System.Windows.Forms.RadioButton();
            this.btnTakdir = new System.Windows.Forms.Button();
            this.rbAdaGore = new System.Windows.Forms.RadioButton();
            this.gbxNotlar.SuspendLayout();
            this.gbxDersler.SuspendLayout();
            this.gbxOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.gbxSec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(783, 607);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(109, 30);
            this.btnLinqEntity.TabIndex = 51;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // rbEnDusuk
            // 
            this.rbEnDusuk.AutoSize = true;
            this.rbEnDusuk.Location = new System.Drawing.Point(933, 345);
            this.rbEnDusuk.Name = "rbEnDusuk";
            this.rbEnDusuk.Size = new System.Drawing.Size(88, 21);
            this.rbEnDusuk.TabIndex = 50;
            this.rbEnDusuk.TabStop = true;
            this.rbEnDusuk.Text = "En düşük";
            this.rbEnDusuk.UseVisualStyleBackColor = true;
            // 
            // rbEnYuksek
            // 
            this.rbEnYuksek.AutoSize = true;
            this.rbEnYuksek.Location = new System.Drawing.Point(934, 318);
            this.rbEnYuksek.Name = "rbEnYuksek";
            this.rbEnYuksek.Size = new System.Drawing.Size(94, 21);
            this.rbEnYuksek.TabIndex = 49;
            this.rbEnYuksek.TabStop = true;
            this.rbEnYuksek.Text = "En yüksek";
            this.rbEnYuksek.UseVisualStyleBackColor = true;
            // 
            // rbOrtalama
            // 
            this.rbOrtalama.AutoSize = true;
            this.rbOrtalama.Location = new System.Drawing.Point(934, 291);
            this.rbOrtalama.Name = "rbOrtalama";
            this.rbOrtalama.Size = new System.Drawing.Size(87, 21);
            this.rbOrtalama.TabIndex = 48;
            this.rbOrtalama.TabStop = true;
            this.rbOrtalama.Text = "Ortalama";
            this.rbOrtalama.UseVisualStyleBackColor = true;
            // 
            // rbSinavToplam
            // 
            this.rbSinavToplam.AutoSize = true;
            this.rbSinavToplam.Location = new System.Drawing.Point(934, 262);
            this.rbSinavToplam.Name = "rbSinavToplam";
            this.rbSinavToplam.Size = new System.Drawing.Size(110, 21);
            this.rbSinavToplam.TabIndex = 47;
            this.rbSinavToplam.TabStop = true;
            this.rbSinavToplam.Text = "Sınav toplam";
            this.rbSinavToplam.UseVisualStyleBackColor = true;
            // 
            // rbToplamKayit
            // 
            this.rbToplamKayit.AutoSize = true;
            this.rbToplamKayit.Location = new System.Drawing.Point(934, 235);
            this.rbToplamKayit.Name = "rbToplamKayit";
            this.rbToplamKayit.Size = new System.Drawing.Size(109, 21);
            this.rbToplamKayit.TabIndex = 46;
            this.rbToplamKayit.TabStop = true;
            this.rbToplamKayit.Text = "Toplam kayıt";
            this.rbToplamKayit.UseVisualStyleBackColor = true;
            // 
            // rbKayitVarmi
            // 
            this.rbKayitVarmi.AutoSize = true;
            this.rbKayitVarmi.Location = new System.Drawing.Point(934, 209);
            this.rbKayitVarmi.Name = "rbKayitVarmi";
            this.rbKayitVarmi.Size = new System.Drawing.Size(102, 21);
            this.rbKayitVarmi.TabIndex = 45;
            this.rbKayitVarmi.TabStop = true;
            this.rbKayitVarmi.Text = "Kayıt var mı";
            this.rbKayitVarmi.UseVisualStyleBackColor = true;
            // 
            // rbAIleBiten
            // 
            this.rbAIleBiten.AutoSize = true;
            this.rbAIleBiten.Location = new System.Drawing.Point(934, 182);
            this.rbAIleBiten.Name = "rbAIleBiten";
            this.rbAIleBiten.Size = new System.Drawing.Size(91, 21);
            this.rbAIleBiten.TabIndex = 44;
            this.rbAIleBiten.TabStop = true;
            this.rbAIleBiten.Text = "A ile biten";
            this.rbAIleBiten.UseVisualStyleBackColor = true;
            // 
            // rbAIleBaslayan
            // 
            this.rbAIleBaslayan.AutoSize = true;
            this.rbAIleBaslayan.Location = new System.Drawing.Point(934, 155);
            this.rbAIleBaslayan.Name = "rbAIleBaslayan";
            this.rbAIleBaslayan.Size = new System.Drawing.Size(117, 21);
            this.rbAIleBaslayan.TabIndex = 43;
            this.rbAIleBaslayan.TabStop = true;
            this.rbAIleBaslayan.Text = "A ile başlayan";
            this.rbAIleBaslayan.UseVisualStyleBackColor = true;
            // 
            // rbIdyeGoreAra
            // 
            this.rbIdyeGoreAra.AutoSize = true;
            this.rbIdyeGoreAra.Location = new System.Drawing.Point(934, 128);
            this.rbIdyeGoreAra.Name = "rbIdyeGoreAra";
            this.rbIdyeGoreAra.Size = new System.Drawing.Size(119, 21);
            this.rbIdyeGoreAra.TabIndex = 42;
            this.rbIdyeGoreAra.TabStop = true;
            this.rbIdyeGoreAra.Text = "ID ye göre ara";
            this.rbIdyeGoreAra.UseVisualStyleBackColor = true;
            // 
            // rbIlk3
            // 
            this.rbIlk3.AutoSize = true;
            this.rbIlk3.Location = new System.Drawing.Point(934, 101);
            this.rbIlk3.Name = "rbIlk3";
            this.rbIlk3.Size = new System.Drawing.Size(54, 21);
            this.rbIlk3.TabIndex = 41;
            this.rbIlk3.TabStop = true;
            this.rbIlk3.Text = "İlk 3";
            this.rbIlk3.UseVisualStyleBackColor = true;
            // 
            // rbAdaGoreSiralaTersten
            // 
            this.rbAdaGoreSiralaTersten.AutoSize = true;
            this.rbAdaGoreSiralaTersten.Location = new System.Drawing.Point(934, 74);
            this.rbAdaGoreSiralaTersten.Name = "rbAdaGoreSiralaTersten";
            this.rbAdaGoreSiralaTersten.Size = new System.Drawing.Size(173, 21);
            this.rbAdaGoreSiralaTersten.TabIndex = 40;
            this.rbAdaGoreSiralaTersten.TabStop = true;
            this.rbAdaGoreSiralaTersten.Text = "Ada göre sırala tersten";
            this.rbAdaGoreSiralaTersten.UseVisualStyleBackColor = true;
            // 
            // rbAdaGoreSirala
            // 
            this.rbAdaGoreSirala.AutoSize = true;
            this.rbAdaGoreSirala.Location = new System.Drawing.Point(934, 47);
            this.rbAdaGoreSirala.Name = "rbAdaGoreSirala";
            this.rbAdaGoreSirala.Size = new System.Drawing.Size(125, 21);
            this.rbAdaGoreSirala.TabIndex = 39;
            this.rbAdaGoreSirala.TabStop = true;
            this.rbAdaGoreSirala.Text = "Ada göre sırala";
            this.rbAdaGoreSirala.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(783, 571);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(115, 30);
            this.btnJoin.TabIndex = 38;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(783, 534);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(115, 30);
            this.btnProcedure.TabIndex = 37;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.Location = new System.Drawing.Point(783, 455);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(115, 30);
            this.btnNotListesi.TabIndex = 36;
            this.btnNotListesi.Text = "Not Listesi";
            this.btnNotListesi.UseVisualStyleBackColor = true;
            this.btnNotListesi.Click += new System.EventHandler(this.btnNotListesi_Click);
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.Location = new System.Drawing.Point(783, 419);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(115, 30);
            this.btnDersListesi.TabIndex = 35;
            this.btnDersListesi.Text = "Ders Listesi";
            this.btnDersListesi.UseVisualStyleBackColor = true;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(783, 376);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(115, 30);
            this.btnBul.TabIndex = 34;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(783, 337);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 31);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(783, 295);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 31);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(783, 253);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 31);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnOgrListele
            // 
            this.btnOgrListele.Location = new System.Drawing.Point(783, 209);
            this.btnOgrListele.Name = "btnOgrListele";
            this.btnOgrListele.Size = new System.Drawing.Size(115, 32);
            this.btnOgrListele.TabIndex = 30;
            this.btnOgrListele.Text = "Öğrenci Listele";
            this.btnOgrListele.UseVisualStyleBackColor = true;
            this.btnOgrListele.Click += new System.EventHandler(this.btnOgrListele_Click);
            // 
            // gbxNotlar
            // 
            this.gbxNotlar.Controls.Add(this.btnSinavGuncelle);
            this.gbxNotlar.Controls.Add(this.btnHesapla);
            this.gbxNotlar.Controls.Add(this.txtDurum);
            this.gbxNotlar.Controls.Add(this.txtOrtalama);
            this.gbxNotlar.Controls.Add(this.txtSinav3);
            this.gbxNotlar.Controls.Add(this.txtSinav2);
            this.gbxNotlar.Controls.Add(this.txtSinav1);
            this.gbxNotlar.Controls.Add(this.lblDurum);
            this.gbxNotlar.Controls.Add(this.lblSinav1);
            this.gbxNotlar.Controls.Add(this.lblOrtalama);
            this.gbxNotlar.Controls.Add(this.lblSinav2);
            this.gbxNotlar.Controls.Add(this.lblSinav3);
            this.gbxNotlar.Location = new System.Drawing.Point(276, 235);
            this.gbxNotlar.Name = "gbxNotlar";
            this.gbxNotlar.Size = new System.Drawing.Size(251, 366);
            this.gbxNotlar.TabIndex = 29;
            this.gbxNotlar.TabStop = false;
            this.gbxNotlar.Text = "Notlar";
            // 
            // btnSinavGuncelle
            // 
            this.btnSinavGuncelle.Location = new System.Drawing.Point(159, 283);
            this.btnSinavGuncelle.Name = "btnSinavGuncelle";
            this.btnSinavGuncelle.Size = new System.Drawing.Size(75, 61);
            this.btnSinavGuncelle.TabIndex = 15;
            this.btnSinavGuncelle.Text = "Sınav Not Güncelle";
            this.btnSinavGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(31, 283);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 62);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(146, 208);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 22);
            this.txtDurum.TabIndex = 13;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(146, 169);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 22);
            this.txtOrtalama.TabIndex = 12;
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(146, 124);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(100, 22);
            this.txtSinav3.TabIndex = 11;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(146, 80);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(100, 22);
            this.txtSinav2.TabIndex = 10;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(146, 34);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(100, 22);
            this.txtSinav1.TabIndex = 9;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(27, 208);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(50, 17);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.Text = "Durum";
            // 
            // lblSinav1
            // 
            this.lblSinav1.AutoSize = true;
            this.lblSinav1.Location = new System.Drawing.Point(27, 40);
            this.lblSinav1.Name = "lblSinav1";
            this.lblSinav1.Size = new System.Drawing.Size(51, 17);
            this.lblSinav1.TabIndex = 4;
            this.lblSinav1.Text = "Sınav1";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(27, 162);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(66, 17);
            this.lblOrtalama.TabIndex = 7;
            this.lblOrtalama.Text = "Ortalama";
            // 
            // lblSinav2
            // 
            this.lblSinav2.AutoSize = true;
            this.lblSinav2.Location = new System.Drawing.Point(27, 80);
            this.lblSinav2.Name = "lblSinav2";
            this.lblSinav2.Size = new System.Drawing.Size(51, 17);
            this.lblSinav2.TabIndex = 5;
            this.lblSinav2.Text = "Sınav2";
            // 
            // lblSinav3
            // 
            this.lblSinav3.AutoSize = true;
            this.lblSinav3.Location = new System.Drawing.Point(27, 124);
            this.lblSinav3.Name = "lblSinav3";
            this.lblSinav3.Size = new System.Drawing.Size(51, 17);
            this.lblSinav3.TabIndex = 6;
            this.lblSinav3.Text = "Sınav3";
            // 
            // gbxDersler
            // 
            this.gbxDersler.Controls.Add(this.txtDersSaat);
            this.gbxDersler.Controls.Add(this.lblDersSaat);
            this.gbxDersler.Controls.Add(this.txtDersAd);
            this.gbxDersler.Controls.Add(this.txtDersId);
            this.gbxDersler.Controls.Add(this.lblDersAd);
            this.gbxDersler.Controls.Add(this.lblDersId);
            this.gbxDersler.Location = new System.Drawing.Point(37, 443);
            this.gbxDersler.Name = "gbxDersler";
            this.gbxDersler.Size = new System.Drawing.Size(219, 158);
            this.gbxDersler.TabIndex = 28;
            this.gbxDersler.TabStop = false;
            this.gbxDersler.Text = "Dersler";
            // 
            // txtDersSaat
            // 
            this.txtDersSaat.Location = new System.Drawing.Point(100, 122);
            this.txtDersSaat.Name = "txtDersSaat";
            this.txtDersSaat.Size = new System.Drawing.Size(100, 22);
            this.txtDersSaat.TabIndex = 5;
            // 
            // lblDersSaat
            // 
            this.lblDersSaat.AutoSize = true;
            this.lblDersSaat.Location = new System.Drawing.Point(10, 125);
            this.lblDersSaat.Name = "lblDersSaat";
            this.lblDersSaat.Size = new System.Drawing.Size(74, 17);
            this.lblDersSaat.TabIndex = 4;
            this.lblDersSaat.Text = "Ders Saati";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(100, 81);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(100, 22);
            this.txtDersAd.TabIndex = 3;
            // 
            // txtDersId
            // 
            this.txtDersId.Location = new System.Drawing.Point(100, 35);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.Size = new System.Drawing.Size(100, 22);
            this.txtDersId.TabIndex = 2;
            // 
            // lblDersAd
            // 
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Location = new System.Drawing.Point(10, 81);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(25, 17);
            this.lblDersAd.TabIndex = 1;
            this.lblDersAd.Text = "Ad";
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Location = new System.Drawing.Point(10, 38);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(21, 17);
            this.lblDersId.TabIndex = 0;
            this.lblDersId.Text = "ID";
            // 
            // gbxOgrenciler
            // 
            this.gbxOgrenciler.Controls.Add(this.txtOgrFotograf);
            this.gbxOgrenciler.Controls.Add(this.txtOgrSoyad);
            this.gbxOgrenciler.Controls.Add(this.txtOgrAd);
            this.gbxOgrenciler.Controls.Add(this.txtOgrId);
            this.gbxOgrenciler.Controls.Add(this.lblOgrFotograf);
            this.gbxOgrenciler.Controls.Add(this.lblOgrId);
            this.gbxOgrenciler.Controls.Add(this.lblOgrSoyad);
            this.gbxOgrenciler.Controls.Add(this.lblOgrAd);
            this.gbxOgrenciler.Location = new System.Drawing.Point(37, 224);
            this.gbxOgrenciler.Name = "gbxOgrenciler";
            this.gbxOgrenciler.Size = new System.Drawing.Size(219, 203);
            this.gbxOgrenciler.TabIndex = 27;
            this.gbxOgrenciler.TabStop = false;
            this.gbxOgrenciler.Text = "Öğrenciler";
            // 
            // txtOgrFotograf
            // 
            this.txtOgrFotograf.Location = new System.Drawing.Point(100, 147);
            this.txtOgrFotograf.Name = "txtOgrFotograf";
            this.txtOgrFotograf.Size = new System.Drawing.Size(100, 22);
            this.txtOgrFotograf.TabIndex = 11;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(100, 107);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtOgrSoyad.TabIndex = 10;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(100, 65);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(100, 22);
            this.txtOgrAd.TabIndex = 9;
            this.txtOgrAd.TextChanged += new System.EventHandler(this.txtOgrAd_TextChanged);
            // 
            // txtOgrId
            // 
            this.txtOgrId.Location = new System.Drawing.Point(100, 29);
            this.txtOgrId.Name = "txtOgrId";
            this.txtOgrId.Size = new System.Drawing.Size(100, 22);
            this.txtOgrId.TabIndex = 8;
            // 
            // lblOgrFotograf
            // 
            this.lblOgrFotograf.AutoSize = true;
            this.lblOgrFotograf.Location = new System.Drawing.Point(6, 152);
            this.lblOgrFotograf.Name = "lblOgrFotograf";
            this.lblOgrFotograf.Size = new System.Drawing.Size(61, 17);
            this.lblOgrFotograf.TabIndex = 7;
            this.lblOgrFotograf.Text = "Fotoğraf";
            // 
            // lblOgrId
            // 
            this.lblOgrId.AutoSize = true;
            this.lblOgrId.Location = new System.Drawing.Point(6, 34);
            this.lblOgrId.Name = "lblOgrId";
            this.lblOgrId.Size = new System.Drawing.Size(21, 17);
            this.lblOgrId.TabIndex = 4;
            this.lblOgrId.Text = "ID";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Location = new System.Drawing.Point(0, 112);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(48, 17);
            this.lblOgrSoyad.TabIndex = 6;
            this.lblOgrSoyad.Text = "Soyad";
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Location = new System.Drawing.Point(6, 71);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(25, 17);
            this.lblOgrAd.TabIndex = 5;
            this.lblOgrAd.Text = "Ad";
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(37, 31);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 51;
            this.dgvListe.RowTemplate.Height = 24;
            this.dgvListe.Size = new System.Drawing.Size(861, 168);
            this.dgvListe.TabIndex = 26;
            this.dgvListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellClick);
            // 
            // rbOgrenci
            // 
            this.rbOgrenci.AutoSize = true;
            this.rbOgrenci.Location = new System.Drawing.Point(21, 30);
            this.rbOgrenci.Name = "rbOgrenci";
            this.rbOgrenci.Size = new System.Drawing.Size(95, 21);
            this.rbOgrenci.TabIndex = 52;
            this.rbOgrenci.TabStop = true;
            this.rbOgrenci.Text = "Öğrenciler";
            this.rbOgrenci.UseVisualStyleBackColor = true;
            this.rbOgrenci.CheckedChanged += new System.EventHandler(this.rbOgrenci_CheckedChanged);
            // 
            // gbxSec
            // 
            this.gbxSec.Controls.Add(this.rbNot);
            this.gbxSec.Controls.Add(this.rbDers);
            this.gbxSec.Controls.Add(this.rbOgrenci);
            this.gbxSec.Location = new System.Drawing.Point(533, 239);
            this.gbxSec.Name = "gbxSec";
            this.gbxSec.Size = new System.Drawing.Size(200, 181);
            this.gbxSec.TabIndex = 53;
            this.gbxSec.TabStop = false;
            this.gbxSec.Text = "Seçim";
            // 
            // rbNot
            // 
            this.rbNot.AutoSize = true;
            this.rbNot.Location = new System.Drawing.Point(21, 108);
            this.rbNot.Name = "rbNot";
            this.rbNot.Size = new System.Drawing.Size(67, 21);
            this.rbNot.TabIndex = 54;
            this.rbNot.TabStop = true;
            this.rbNot.Text = "Notlar";
            this.rbNot.UseVisualStyleBackColor = true;
            this.rbNot.CheckedChanged += new System.EventHandler(this.rbNot_CheckedChanged);
            // 
            // rbDers
            // 
            this.rbDers.AutoSize = true;
            this.rbDers.Location = new System.Drawing.Point(21, 71);
            this.rbDers.Name = "rbDers";
            this.rbDers.Size = new System.Drawing.Size(75, 21);
            this.rbDers.TabIndex = 53;
            this.rbDers.TabStop = true;
            this.rbDers.Text = "Dersler";
            this.rbDers.UseVisualStyleBackColor = true;
            this.rbDers.CheckedChanged += new System.EventHandler(this.rbDers_CheckedChanged);
            // 
            // btnTakdir
            // 
            this.btnTakdir.Location = new System.Drawing.Point(783, 491);
            this.btnTakdir.Name = "btnTakdir";
            this.btnTakdir.Size = new System.Drawing.Size(115, 32);
            this.btnTakdir.TabIndex = 54;
            this.btnTakdir.Text = "Takdir";
            this.btnTakdir.UseVisualStyleBackColor = true;
            this.btnTakdir.Click += new System.EventHandler(this.btnTakdir_Click);
            // 
            // rbAdaGore
            // 
            this.rbAdaGore.AutoSize = true;
            this.rbAdaGore.Location = new System.Drawing.Point(934, 376);
            this.rbAdaGore.Name = "rbAdaGore";
            this.rbAdaGore.Size = new System.Drawing.Size(87, 21);
            this.rbAdaGore.TabIndex = 55;
            this.rbAdaGore.TabStop = true;
            this.rbAdaGore.Text = "Ada göre";
            this.rbAdaGore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 665);
            this.Controls.Add(this.rbAdaGore);
            this.Controls.Add(this.btnTakdir);
            this.Controls.Add(this.gbxSec);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.rbEnDusuk);
            this.Controls.Add(this.rbEnYuksek);
            this.Controls.Add(this.rbOrtalama);
            this.Controls.Add(this.rbSinavToplam);
            this.Controls.Add(this.rbToplamKayit);
            this.Controls.Add(this.rbKayitVarmi);
            this.Controls.Add(this.rbAIleBiten);
            this.Controls.Add(this.rbAIleBaslayan);
            this.Controls.Add(this.rbIdyeGoreAra);
            this.Controls.Add(this.rbIlk3);
            this.Controls.Add(this.rbAdaGoreSiralaTersten);
            this.Controls.Add(this.rbAdaGoreSirala);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnNotListesi);
            this.Controls.Add(this.btnDersListesi);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnOgrListele);
            this.Controls.Add(this.gbxNotlar);
            this.Controls.Add(this.gbxDersler);
            this.Controls.Add(this.gbxOgrenciler);
            this.Controls.Add(this.dgvListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxNotlar.ResumeLayout(false);
            this.gbxNotlar.PerformLayout();
            this.gbxDersler.ResumeLayout(false);
            this.gbxDersler.PerformLayout();
            this.gbxOgrenciler.ResumeLayout(false);
            this.gbxOgrenciler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.gbxSec.ResumeLayout(false);
            this.gbxSec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton rbEnDusuk;
        private System.Windows.Forms.RadioButton rbEnYuksek;
        private System.Windows.Forms.RadioButton rbOrtalama;
        private System.Windows.Forms.RadioButton rbSinavToplam;
        private System.Windows.Forms.RadioButton rbToplamKayit;
        private System.Windows.Forms.RadioButton rbKayitVarmi;
        private System.Windows.Forms.RadioButton rbAIleBiten;
        private System.Windows.Forms.RadioButton rbAIleBaslayan;
        private System.Windows.Forms.RadioButton rbIdyeGoreAra;
        private System.Windows.Forms.RadioButton rbIlk3;
        private System.Windows.Forms.RadioButton rbAdaGoreSiralaTersten;
        private System.Windows.Forms.RadioButton rbAdaGoreSirala;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.Button btnDersListesi;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnOgrListele;
        private System.Windows.Forms.GroupBox gbxNotlar;
        private System.Windows.Forms.Button btnSinavGuncelle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSinav1;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblSinav2;
        private System.Windows.Forms.Label lblSinav3;
        private System.Windows.Forms.GroupBox gbxDersler;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label lblDersAd;
        private System.Windows.Forms.Label lblDersId;
        private System.Windows.Forms.GroupBox gbxOgrenciler;
        private System.Windows.Forms.TextBox txtOgrFotograf;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrId;
        private System.Windows.Forms.Label lblOgrFotograf;
        private System.Windows.Forms.Label lblOgrId;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.RadioButton rbOgrenci;
        private System.Windows.Forms.GroupBox gbxSec;
        private System.Windows.Forms.RadioButton rbNot;
        private System.Windows.Forms.RadioButton rbDers;
        private System.Windows.Forms.TextBox txtDersSaat;
        private System.Windows.Forms.Label lblDersSaat;
        private System.Windows.Forms.Button btnTakdir;
        private System.Windows.Forms.RadioButton rbAdaGore;
    }
}

