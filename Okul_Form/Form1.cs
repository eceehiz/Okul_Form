using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OKULEntities db = new OKULEntities();

        private void btnOgrListele_Click(object sender, EventArgs e)
        {
            //dgvListe.DataSource = db.tblOgrenciler.ToList();    //sadece buda olsa çalışıyor

            OgrenciListele();

        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.tblNotlar.ToList()
                        select new
                        {
                            item.NotID,
                            item.tblOgrenciler.Adi,
                            item.tblOgrenciler.Soyadi,
                            item.tblDersler.DersAd,
                            //item.NotID,
                            //item.OgrenciID,
                            //item.DersID,
                            item.Sınav1,
                            item.Sınav2,
                            item.Sınav3,
                            item.Ortalama,
                            item.Durum
                        };
            dgvListe.DataSource = query.ToList();
            dgvListe.Columns[0].Visible = false;
        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            //dgvListe.DataSource = db.tblDersler.ToList();

            //2.yol
            var query = from i in db.tblDersler.ToList()
                        select new
                        {
                            i.DersID,
                            i.DersAd,
                            i.DersSaati
                        };
            dgvListe.DataSource = query.ToList();
        }

        private void OgrenciListele()
        {
            var query = from item in db.tblOgrenciler.ToList()
                        select new
                        {
                            item.OgrenciID,
                            item.Adi,
                            item.Soyadi

                        };
            dgvListe.DataSource = query.ToList();
            dgvListe.Columns[0].Visible = false;
        }
        private void DersListele()
        {
            var query = from item in db.tblDersler.ToList()
                        select new
                        {
                            item.DersID,
                            item.DersAd,
                            item.DersSaati

                        };
            dgvListe.DataSource = query.ToList();
            dgvListe.Columns[0].Visible = false;
        }
        private void NotListele()
        {
            var query = from item in db.tblNotlar.ToList()
                        select new
                        {
                            item.Sınav1,
                            item.Sınav2,
                            item.Sınav3

                        };
            dgvListe.DataSource = query.ToList();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (rbOgrenci.Checked)
            {
                tblOgrenciler t = new tblOgrenciler();
                t.Adi = txtOgrAd.Text;
                t.Soyadi = txtOgrSoyad.Text;
                db.tblOgrenciler.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci ekleme tamamlandı");
                OgrenciListele();
            }

            else if (rbDers.Checked)
            {
                tblDersler t = new tblDersler(); ;
                t.DersAd = txtDersAd.Text;
                t.DersSaati = (byte?)Convert.ToInt32(txtDersSaat.Text);
                db.tblDersler.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ders ekleme tamamlandı");
                DersListele();

            }

            else if (rbNot.Checked)
            {
                tblNotlar t = new tblNotlar();
                t.Sınav1 = Convert.ToInt16(txtSinav1.Text);
                db.tblNotlar.Add(t);
                db.SaveChanges();
                MessageBox.Show("Not ekleme tamamlandı");
                NotListele();

            }

        }

        private void rbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            gbxDersler.Enabled = false;
            gbxNotlar.Enabled = false;
            gbxOgrenciler.Enabled = true;
            OgrenciListele();
        }

        private void rbDers_CheckedChanged(object sender, EventArgs e)
        {
            gbxNotlar.Enabled = false;
            gbxOgrenciler.Enabled = false;
            gbxDersler.Enabled = true;
            DersListele();
        }

        private void rbNot_CheckedChanged(object sender, EventArgs e)
        {
            gbxOgrenciler.Enabled = false;
            gbxDersler.Enabled = false;
            gbxNotlar.Enabled = true;
            NotListele();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (rbOgrenci.Checked)
            {
                if (txtOgrId.Text == string.Empty)
                {
                    MessageBox.Show("ID alanını doldurunuz");
                }
                else
                {
                    int id = Convert.ToInt32(txtOgrId.Text);
                    var x = db.tblOgrenciler.Find(id);
                    db.tblOgrenciler.Remove(x);
                    db.SaveChanges();
                    MessageBox.Show("Öğrenci silindi");
                    OgrenciListele();
                }
            }

            else if (rbDers.Checked)
            {
                int id = Convert.ToInt32(txtDersId.Text);
                var x = db.tblDersler.Find(id);
                db.tblDersler.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Ders silindi");
                DersListele();

            }

            else
            {
                int id = Convert.ToInt32(txtSinav1.Text);
                var x = db.tblNotlar.Find(id);
                db.tblNotlar.Remove(x);
                db.SaveChanges();
                MessageBox.Show("Not silindi");
                NotListele();

            }


        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbOgrenci.Checked)
            {
                txtOgrId.Text = dgvListe.CurrentRow.Cells[0].Value.ToString();
                txtOgrAd.Text = dgvListe.CurrentRow.Cells[1].Value.ToString();
                txtOgrSoyad.Text = dgvListe.CurrentRow.Cells[2].Value.ToString();
            }

            else if (rbDers.Checked)
            {
                txtDersId.Text = dgvListe.CurrentRow.Cells[0].Value.ToString();
                txtDersAd.Text = dgvListe.CurrentRow.Cells[1].Value.ToString();
                txtDersSaat.Text = dgvListe.CurrentRow.Cells[2].Value.ToString();
            }

            else if (rbNot.Checked)
            {
                txtSinav1.Text = dgvListe.CurrentRow.Cells[0].Value.ToString();
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (rbOgrenci.Checked)
            {
                int id = Convert.ToInt32(txtOgrId.Text);
                var x = db.tblOgrenciler.Find(id);
                x.Adi = txtOgrAd.Text;
                x.Soyadi = txtOgrSoyad.Text;
                x.Fotograf = txtOgrFotograf.Text;
                db.SaveChanges();
                MessageBox.Show("Güncelleme tamamlandı");
                OgrenciListele();

            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (rbOgrenci.Checked)
            {
                dgvListe.DataSource = db.tblOgrenciler.Where(x => x.Adi == txtOgrAd.Text || x.Soyadi == txtOgrSoyad.Text).ToList();
            }

            else if (rbDers.Checked)
            {
                dgvListe.DataSource = db.tblDersler.Where(x => x.DersAd == txtDersAd.Text).ToList();
            }


        }

        private void txtOgrAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrAd.Text;
            var degerler = from s in db.tblOgrenciler
                           where s.Adi.Contains(aranan)
                           select s;
            dgvListe.DataSource = degerler.ToList();
        }

        private void btnTakdir_Click(object sender, EventArgs e)
        {
            var query = from item in db.tblNotlar
                        where item.Sınav1 > 65 & item.Sınav2 > 70
                        select new
                        {
                            item.tblOgrenciler.Adi,
                            item.tblOgrenciler.Soyadi,
                            item.Sınav1,
                            item.Sınav2,
                            item.Sınav3,
                            item.Ortalama,
                            item.Durum
                        };
            dgvListe.DataSource = query.ToList();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            dgvListe.DataSource = db.NotListesi(); //sqlde oluşturduğumuz prosedürü çağırıyoruz

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.tblNotlar
                        join d2 in db.tblOgrenciler
                        on d1.OgrenciID equals d2.OgrenciID
                        join d3 in db.tblDersler
                        on d1.DersID equals d3.DersID
                        select new  //kolonların başlıklarını yazıyoruz
                        {
                            Ogrenci = d2.Adi + " " + d2.Soyadi,
                            d3.DersAd,
                            Sınav1 = d1.Sınav1,
                            Sınav2 = d1.Sınav2,
                            Sınav3 = d1.Sınav3,
                            Ortalama = d1.Ortalama
                        };
            dgvListe.DataSource = sorgu.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (rbAdaGoreSirala.Checked)
            {
                List<tblOgrenciler> liste1 = db.tblOgrenciler.OrderBy(p => p.Adi).ToList();
                dgvListe.DataSource = liste1;
            }

            else if (rbAdaGoreSiralaTersten.Checked)
            {
                List<tblOgrenciler> liste2 = db.tblOgrenciler.OrderByDescending(p => p.Adi).ToList();
                dgvListe.DataSource = liste2;
            }

            else if (rbIlk3.Checked)
            {
                List<tblOgrenciler> liste3 = db.tblOgrenciler.OrderBy(p => p.Adi).Take(3).ToList();
                dgvListe.DataSource = liste3;
            }

            else if (rbIdyeGoreAra.Checked)
            {
                int arananId = int.Parse(txtOgrId.Text);
                List<tblOgrenciler> liste4 = db.tblOgrenciler.Where(p => p.OgrenciID == arananId).ToList();
                dgvListe.DataSource = liste4;
            }

            else if (rbAIleBaslayan.Checked)
            {
                List<tblOgrenciler> liste5 = db.tblOgrenciler.Where(p => p.Adi.StartsWith("a")).ToList();
                dgvListe.DataSource = liste5;
            }

            else if (rbAIleBiten.Checked)
            {
                List<tblOgrenciler> liste6 = db.tblOgrenciler.Where(p => p.Adi.EndsWith("a")).ToList();
                dgvListe.DataSource = liste6;
            }

            else if (rbKayitVarmi.Checked)
            {
                bool deger = db.tblOgrenciler.Any();
                MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (rbToplamKayit.Checked)
            {
                int toplam = db.tblOgrenciler.Count();
                MessageBox.Show(toplam.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (rbSinavToplam.Checked)
            {
                var toplam = db.tblNotlar.Sum(p => p.Sınav1);
                MessageBox.Show("Toplam" + toplam.ToString());
            }

            else if (rbOrtalama.Checked)
            {
                var ortalama = db.tblNotlar.Average(p => p.Sınav1);
                MessageBox.Show("Ortalama" + ortalama.ToString());
            }

            else if (rbEnYuksek.Checked)
            {
                var enYuksek = db.tblNotlar.Max(p => p.Sınav1);
                MessageBox.Show("En yüksek" + enYuksek.ToString());
            }

            else if (rbEnDusuk.Checked)
            {
                var enDusuk = db.tblNotlar.Max(p => p.Sınav1);
                MessageBox.Show("En düşük" + enDusuk.ToString());
            }

            else if (rbAdaGore.Checked)
            {
                string arananId = txtOgrId.Text;
                List<tblOgrenciler> liste7 = db.tblOgrenciler.Where(p => p.Adi==arananId).ToList();
                dgvListe.DataSource = liste7;
            }
                
        }
    }
}
