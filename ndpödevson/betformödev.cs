/****************************************************************************
**                                       SAKARYA ÜNİVERSİTESİ
**                               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                      PROGRAMLAMAYA GİRİŞİ DERSİ
**
**                                           ÖDEV NUMARASI…...:1
**                                           ÖĞRENCİ ADI...............: BETÜL KURT
**                                           ÖĞRENCİ NUMARASI.:G221210054
**                                           DERS GRUBU…………:B
                                             YOUTUBE LİNKİ… …:
    ****************************************************************************/







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpödevson 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Nokta<int> nokta = new Nokta<int>();
            Dörtgen<int> dortgen = new Dörtgen<int>();

            textBox1.Text = ("Noktanın verileri  (x, y)       : (" + nokta.X + ", " + nokta.Y + ")");
            textBox2.Text = ("Dörtgenin verileri (x, y, h, d) : (" + dortgen.X + ", " + dortgen.Y + ", " + dortgen.Yukseklik + ", " + dortgen.Genislik + ")");

            if (nokta.X >= dortgen.X && nokta.X <= dortgen.X + dortgen.Genislik &&
                nokta.Y >= dortgen.Y && nokta.Y <= dortgen.Y + dortgen.Yukseklik)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Nokta ve Dörtgen çarpışıyor.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Nokta ve Dörtgen çarpışmıyor. ");
            }


            dortgen.DörtgenCiz(panel1 );
            nokta.NoktaCiz(panel1);
        }
        
       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Nokta<int> nokta = new Nokta<int>();
            Cember<int> cember = new Cember<int>();

            int yaricap = cember.Cap / 2;
            int merkezX = cember.X + yaricap;
            int merkezY = cember.Y + yaricap;

            textBox1.Text = ("Noktanın verileri  (x, y)       : (" + nokta.X + ", " + nokta.Y + ")");
            textBox2.Text = ("Çemberin verileri  (x, y, r)    : (" + merkezX + ", " + merkezY + "," + yaricap + ")");

            //if (uzaklikKaresi < yaricapKaresi)
            if (Math.Sqrt((nokta.X - merkezX) * (nokta.X - merkezX) + (nokta.Y - merkezY) * (nokta.Y - merkezY)) == yaricap)
            //çemberin içi boş olduğu için saadece = dedik
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Nokta ve Çember çarpışıyor. ");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Nokta ve Çember çarpışmıyor. ");
            }
            nokta.NoktaCiz(panel1);
            cember.CemberCiz(panel1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Dörtgen<int> dortgen = new Dörtgen<int>();
            Dörtgen2<int> dortgen2 = new Dörtgen2<int>();


            textBox1.Text = ("1. Dörtgenin verileri (x, y, h, d) : (" + dortgen.X + ", " + dortgen.Y + ", " + dortgen.Yukseklik + ", " + dortgen.Genislik + ")");
            textBox2.Text = ("2. Dörtgenin verileri (x, y, h, d) : (" + dortgen2.X + ", " + dortgen2.Y + ", " + dortgen2.Yukseklik + ", " + dortgen2.Genislik + ")");

            if (Math.Abs((dortgen.X + dortgen.Genislik / 2) - (dortgen2.X + dortgen2.Genislik / 2)) < dortgen.Genislik / 2 + dortgen2.Genislik / 2 &&
                Math.Abs((dortgen.Y + dortgen.Yukseklik / 2) - (dortgen2.Y + dortgen2.Yukseklik / 2)) < dortgen.Yukseklik / 2 + dortgen2.Yukseklik / 2)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Dörtgen ve Dörtgen çarpışıyor. ");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Dörtgen ve Dörtgen çarpışmıyor.");
            }


            dortgen.DörtgenCiz(panel1);
            dortgen2.Dörtgen2Ciz(panel1);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Dörtgen<int> dortgen = new Dörtgen<int>();
            Cember<int> cember = new Cember<int>();

            int yaricap = cember.Cap / 2;
            int merkezX = cember.X + yaricap;
            int merkezY = cember.Y + yaricap;

            textBox1.Text = ("Dörtgenin verileri (x, y, h, d) : (" + dortgen.X + ", " + dortgen.Y + ", " + dortgen.Yukseklik + ", " + dortgen.Genislik + ")");
            textBox2.Text = ("Çemberin verileri  (x, y, r)    : (" + merkezX + ", " + merkezY + "," + yaricap + ")");

            if (Math.Abs((dortgen.X + dortgen.Genislik / 2) - merkezX) < dortgen.Genislik / 2 + yaricap &&
                Math.Abs(merkezY - (dortgen.Y + dortgen.Yukseklik / 2)) < dortgen.Yukseklik / 2 + yaricap)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Dörtgen ve Çember çarpışıyor. ");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Dörtgen ve Çember çarpışmıyor.");
            }


            dortgen.DörtgenCiz(panel1);
            cember.CemberCiz(panel1);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Cember<int> cember = new Cember<int>();
            Cember2<int> cember2 = new Cember2<int>();

            int yaricap = cember.Cap / 2;
            int merkezX = cember.X + yaricap;
            int merkezY = cember.Y + yaricap;

            int yaricap2 = cember2.Cap / 2;
            int merkez2X = cember2.X + yaricap2;
            int merkez2Y = cember2.Y + yaricap2;

            textBox1.Text = ("1. Çemberin verileri  (x, y, r)    : (" + merkezX + ", " + merkezY + "," + yaricap + ")");
            textBox2.Text = ("2. Çemberin verileri  (x, y, r)    : (" + merkez2X + ", " + merkez2Y + "," + yaricap2 + ")");

            if (Math.Sqrt(Math.Abs((merkezX - merkez2X) * (merkezX - merkez2X) + (merkezY - merkez2Y) * (merkezY - merkez2Y))) < yaricap + yaricap2)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Çember ve Çember çarpıştı. ");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Çember ve Çember çarpışmadı");
            }


            cember.CemberCiz(panel1);
            cember2.Cember2Ciz(panel1);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh(); 

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Nokta<int> nokta = new Nokta<int>();
            Küre<int> kure = new Küre<int>();

            int yaricap = kure.Cap / 2;
            int merkezX = kure.X + yaricap;
            int merkezY = kure.Y + yaricap;
            int merkezZ = kure.Z + yaricap;

            double mesafe = Math.Sqrt(Math.Pow(nokta.X - kure.X, 2) + Math.Pow(nokta.Y - kure.Y, 2) + Math.Pow(nokta.Z - kure.Z, 2));

            textBox1.Text = ("Noktanın verileri  (x, y, z)       : (" + nokta.X + ", " + nokta.Y + ", " + nokta.Z + ")");
            textBox2.Text = ("Kürenin verileri   (x, y, z, r)    : (" + merkezX + ", " + merkezY + ", " + merkezZ + ", " + yaricap + ")");

            //if (uzaklikKaresi < yaricapKaresi)
            if (Math.Sqrt((nokta.X - merkezX) * (nokta.X - merkezX) + (nokta.Y - merkezY) * (nokta.Y - merkezY)) == yaricap)
            //çemberin içi boş olduğu için saadece = dedik
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Nokta ve Çember çarpışıyor. ");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Nokta ve Çember çarpışmıyor. ");
            }


            nokta.NoktaCiz(panel1);
            kure.KüreCiz(panel1);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Nokta<int> nokta = new Nokta<int>();
            Prizma<int> prizma = new Prizma<int>();


            int merkezX = prizma.X + prizma.Genislik / 2;
            int merkezY = prizma.Y + prizma.Yukseklik / 2;
            int merkezZ = prizma.Z + prizma.derinlik / 2;

            textBox1.Text = ("Noktanın verileri  (x, y, z)          : (" + nokta.X + ", " + nokta.Y + ", " + nokta.Z + ")");
            textBox2.Text = ("Prizmanın verileri (x, y, z, h, d, u) : (" + merkezX + ", " + merkezY + ", " + merkezZ + ", " + prizma.Yukseklik + ", " + prizma.Genislik + ", " + prizma.derinlik + ")");

            if (nokta.X >= prizma.X && nokta.X <= prizma.X + prizma.Genislik &&
            nokta.Y >= prizma.Y && nokta.Y <= prizma.Y + prizma.Yukseklik &&
            nokta.X >= prizma.X + prizma.derinlik && nokta.X <= prizma.X + prizma.derinlik + prizma.Genislik &&
            nokta.Y >= prizma.Y + prizma.derinlik && nokta.Y <= prizma.Y + prizma.derinlik + prizma.Yukseklik)
            {
                textBox3.BackColor = Color.Black;
                textBox3.Text = ("Nokta ve Prizma çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Nokta ve Prizma çarpışmadı.");
            }

            nokta.NoktaCiz(panel1);
            prizma.PrizmaCiz(panel1);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Nokta<int> nokta = new Nokta<int>();
            Silindir<int> silindir = new Silindir<int>();


            int merkezX = silindir.X + silindir.Genislik / 2 + silindir.Cap / 2;
            int merkezY = silindir.Y + silindir.Yukseklik / 2 + silindir.Cap / 2;
            int merkezZ = silindir.Z + silindir.derinlik / 2;
            int yaricap = silindir.Cap / 2;
            int ikiUcArası = silindir.Yukseklik + silindir.Cap / 2;

            int projeksiyon = nokta.Z - merkezZ;
            //noktanın silindir üzerindeki iz düşümü

            int nokMerkezMesafeKaresi = (nokta.X - merkezX) * (nokta.X - merkezX) + (nokta.Y - merkezY) * (nokta.Y - merkezY);
            int yaricapKaresi = yaricap * yaricap;

            textBox1.Text = ("Noktanın verileri   (x, y, z)          : (" + nokta.X + ", " + nokta.Y + nokta.Z + ")");
            textBox2.Text = ("Silindirin verileri (x, y, z, h, r)    : (" + merkezX + ", " + merkezY + ", " + merkezZ + ", " + silindir.Yukseklik + ", " + yaricap + ")");

            if (nokMerkezMesafeKaresi <= yaricapKaresi && projeksiyon >= 0 && projeksiyon <= ikiUcArası)
            {
                textBox3.BackColor = Color.Black;
                textBox3.Text = ("Nokta ve Silindir çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Nokta ve Silindir carpışmadı.");
            }

            nokta.NoktaCiz(panel1);
            silindir.SilindirCiz(panel1);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Silindir<int> silindir = new Silindir<int>();
            Silindir2<int> silindir2 = new Silindir2<int>();


            int merkezX = silindir.X + silindir.Genislik / 2 + silindir.Cap / 2;
            int merkezY = silindir.Y + silindir.Yukseklik / 2 + silindir.Cap / 2;
            int merkezZ = silindir.Z + silindir.derinlik / 2;
            int yaricap = silindir.Cap / 2;
            int ikiUcArası = silindir.Yukseklik + silindir.Cap / 2;

            int merkez2X = silindir2.X + silindir2.Genislik / 2 + silindir2.Cap / 2;
            int merkez2Y = silindir2.Y + silindir2.Yukseklik / 2 + silindir2.Cap / 2;
            int merkez2Z = silindir2.Z + silindir2.derinlik / 2;
            int yaricap2 = silindir2.Cap / 2;
            int ikiUcArası2 = silindir2.Yukseklik + silindir2.Cap / 2;

            int MerkezlerArasiUzaklikKare = (merkezX - merkez2X) * (merkezX - merkez2X) + (merkezY - merkez2Y) * (merkezY - merkez2Y);
            int MaxMesafeKaresi = (yaricap + yaricap2) * (yaricap + yaricap2);

            textBox1.Text = ("1. Silindirin verileri (x, y, z, h, r)    : (" + merkezX + ", " + merkezY + ", " + merkezZ + ", " + ikiUcArası + ", " + yaricap + ")");
            textBox2.Text = ("2. Silindirin verileri (x, y, z, h, r)    : (" + merkez2X + ", " + merkez2Y + ", " + merkez2Z + ", " + ikiUcArası2 + ", " + yaricap2 + ")");

            if (MerkezlerArasiUzaklikKare <= MaxMesafeKaresi)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Silindir ve Silindir çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Silindir ve Silindir çarpıştı.");
            }

            silindir.SilindirCiz(panel1);
            silindir2.Silindir2Ciz(panel1);

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Küre<int> kure = new Küre<int>();
            Küre2<int> kure2 = new Küre2<int>();


            int yaricap = kure.Cap / 2;
            int merkezX = kure.X + yaricap;
            int merkezY = kure.Y + yaricap;

            int yaricap2 = kure2.Cap / 2;
            int merkezX2 = kure2.X + yaricap2;
            int merkezY2 = kure2.Y + yaricap2;

            textBox1.Text = ("Kürenin verileri   (x, y, z, r)    : (" + merkezX + ", " + merkezY + ", " + kure.Z + ", " + yaricap + ")");
            textBox2.Text = ("Kürenin verileri   (x, y, z, r)    : (" + merkezX2 + ", " + merkezY2 + ", " + kure2.Z + ", " + yaricap2 + ")");

            if (Math.Sqrt(Math.Abs((merkezX - merkezX2) * (merkezX - merkezX2) + (merkezY - merkezY2) * (merkezY - merkezY2))) < yaricap + yaricap2)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Küre ve Küre çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Küre ve Küre çarpışmadı.");
            }


            kure.KüreCiz(panel1);
            kure2.Küre2Ciz(panel1);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Küre<int> kure = new Küre<int>();
            Silindir<int> silindir = new Silindir<int>();


            int yaricap = kure.Cap / 2;
            int merkezX = kure.X + yaricap;
            int merkezY = kure.Y + yaricap;

            int merkezXS = silindir.X + silindir.Genislik / 2 + silindir.Cap / 2;
            int merkezYS = silindir.Y + silindir.Yukseklik / 2 + silindir.Cap / 2;
            int merkezZS = silindir.Z + silindir.derinlik / 2;
            int yaricapS = silindir.Cap / 2;
            int ikiUcArası = silindir.Yukseklik + silindir.Cap / 2;

            textBox1.Text = ("Kürenin verileri    (x, y, z, r)       : (" + merkezX + ", " + merkezY + ", " + kure.Z + ", " + yaricap + ")");
            textBox2.Text = ("Silindirin verileri (x, y, z, h, r)  : (" + merkezXS + ", " + merkezYS + ", " + merkezZS + ", " + silindir.Yukseklik + ", " + yaricapS + ")");

            int dikeymesafekaresi = (merkezY - ikiUcArası / 2) * (merkezY - ikiUcArası / 2);
            int yatayMesafeKare = (merkezX - merkezXS) * (merkezX - merkezXS);
            int MaxUzaklikKaresi = (yaricap + yaricapS) * (yaricap + yaricapS);
            int silindiryaricapKare = yaricapS * yaricapS;

            if (dikeymesafekaresi <= MaxUzaklikKaresi && yatayMesafeKare <= silindiryaricapKare)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Küre ve Silindir çarpıştı. ");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Küre ve Silindir çarpışmadı.");
            }

            kure.KüreCiz(panel1);
            silindir.SilindirCiz(panel1);
        }

        
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Yuzey<int> yuzey = new Yuzey<int>();
            Küre<int> kure = new Küre<int>();

            int yaricap = kure.Cap / 2;
            int merkezX = kure.X + yaricap;
            int merkezY = kure.Y + yaricap;

            int YmerkezX = yuzey.X + yuzey.Genislik / 2;
            int YmerkezY = yuzey.Y + yuzey.Yukseklik / 2;
            int YmerkezZ = yuzey.Z + yuzey.derinlik / 2;

            int dikeyMesafeKare = (merkezY - yuzey.Yukseklik / 2) * (merkezY - yuzey.Yukseklik / 2);
            int yatayMesafeKare = (merkezX - YmerkezX) * (merkezX - YmerkezX);
            int maxMesafeKaresi = (yaricap + yuzey.Genislik / 2) * (yaricap + yuzey.Genislik / 2);
            int YuzeyGenislikKare = (yuzey.Genislik / 2) * (yuzey.Genislik / 2);

            textBox1.Text = ("Yüzeyin verileri   (x, y, z, h, d, u) : (" + YmerkezX + ", " + YmerkezY + ", " + YmerkezZ + ", " + yuzey.Yukseklik + ", " + yuzey.Genislik + ", " + yuzey.derinlik + ")");
            textBox2.Text = ("Kürenin verileri   (x, y, z, r)    : (" + merkezX + ", " + merkezY + ", " + kure.Z + ", " + yaricap + ")");

            if (dikeyMesafeKare <= maxMesafeKaresi && yatayMesafeKare <= YuzeyGenislikKare)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Yüzey ve Küre çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Yüzey ve Küre çarpışmadı.");
            }

            yuzey.YuzeyCiz(panel1);
            kure.KüreCiz(panel1);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Yuzey<int> yuzey = new Yuzey<int>();
            Prizma<int> prizma = new Prizma<int>();


            int YmerkezX = yuzey.X + yuzey.Genislik / 2;
            int YmerkezY = yuzey.Y + yuzey.Yukseklik / 2;
            int YmerkezZ = yuzey.Z + yuzey.derinlik / 2;

            int merkezX = prizma.X + prizma.Genislik / 2;
            int merkezY = prizma.Y + prizma.Yukseklik / 2;
            int merkezZ = prizma.Z + prizma.derinlik / 2;

            int MaxZMesafe = (YmerkezY + yuzey.derinlik / 2) + (merkezY + prizma.derinlik / 2);
            int MaxyatayMesafe = (merkezX + prizma.Genislik / 2) + (YmerkezX + yuzey.Genislik / 2);
            int MaxDikeymesafe = (YmerkezY + yuzey.Yukseklik / 2) + (merkezZ + prizma.Yukseklik / 2);

            int dikeyMesafe = (prizma.Yukseklik / 2 - yuzey.Yukseklik / 2);
            int yatayMesafe = (prizma.Genislik / 2 - yuzey.derinlik / 2) + (yuzey.derinlik / 2 - prizma.derinlik / 2);

            textBox1.Text = ("Yüzeyin verileri   (x, y, z, h, d, u) : (" + YmerkezX + ", " + YmerkezY + ", " + YmerkezZ + ", " + yuzey.Yukseklik + ", " + yuzey.Genislik + ", " + yuzey.derinlik + ")");
            textBox2.Text = ("Prizmanın verileri (x, y, z, h, d, u) : (" + merkezX + ", " + merkezY + ", " + merkezZ + ", " + prizma.Yukseklik + ", " + prizma.Genislik + ", " + prizma.derinlik + ")");

            if (dikeyMesafe <= MaxDikeymesafe && yatayMesafe <= MaxyatayMesafe && yatayMesafe <= MaxZMesafe)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Yüzey ve Prizma çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Yüzey ve Prizma çarpışmadı.");
            }


            yuzey.YuzeyCiz(panel1);
            prizma.PrizmaCiz(panel1);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Yuzey<int> yuzey = new Yuzey<int>();
            Silindir<int> silindir = new Silindir<int>();

            int YmerkezX = yuzey.X + yuzey.Genislik / 2;
            int YmerkezY = yuzey.Y + yuzey.Yukseklik / 2;
            int YmerkezZ = yuzey.Z + yuzey.derinlik / 2;

            int merkezXS = silindir.X + silindir.Genislik / 2 + silindir.Cap / 2;
            int merkezYS = silindir.Y + silindir.Yukseklik / 2 + silindir.Cap / 2;
            int merkezZS = silindir.Z + silindir.derinlik / 2;
            int yaricapS = silindir.Cap / 2;
            int ikiUcArası = silindir.Yukseklik + silindir.Cap / 2;

            int xUzakligi = merkezXS - YmerkezX;
            int yUzakligi = merkezYS - YmerkezY;
            int zUzakligi = merkezZS - YmerkezZ;

            textBox1.Text = ("Yüzeyin verileri    (x, y, z, h, d, u) : (" + YmerkezX + ", " + YmerkezY + ", " + YmerkezZ + ", " + yuzey.Yukseklik + ", " + yuzey.Genislik + ", " + yuzey.derinlik + ")");
            textBox2.Text = ("Silindirin verileri (x, y, z, h, r)    : (" + merkezXS + ", " + merkezYS + ", " + merkezZS + ", " + silindir.Yukseklik + ", " + yaricapS + ")");


            yuzey.YuzeyCiz(panel1);
            silindir.SilindirCiz(panel1);

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh(); 

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Küre<int> kure = new Küre<int>();
            Prizma<int> prizma = new Prizma<int>();

            int yaricap = kure.Cap / 2;
            int merkezX = kure.X + yaricap;
            int merkezY = kure.Y + yaricap;

            int merkezXP = prizma.X + prizma.Genislik / 2;
            int merkezYP = prizma.Y + prizma.Yukseklik / 2;
            int merkezZP = prizma.Z + prizma.derinlik / 2;

            int dikeyMesafeKare = (merkezY - prizma.Yukseklik / 2) * (merkezY - prizma.Yukseklik / 2);
            int yatayMesafeKare = (merkezX - merkezXP) * (merkezX - merkezXP);
            int maxMesafeKaresi = (yaricap + prizma.Genislik / 2) * (yaricap + prizma.Genislik / 2);
            int YuzeyGenislikKare = (prizma.Genislik / 2) * (prizma.Genislik / 2);

            textBox1.Text = ("Kürenin verileri   (x, y, z, r)       : (" + merkezX + ", " + merkezY + ", " + kure.Z + ", " + yaricap + ")");
            textBox2.Text =("Prizmanın verileri (x, y, z, h, d, u) : (" + merkezXP + ", " + merkezYP + ", " + merkezZP + ", " + prizma.Yukseklik + ", " + prizma.Genislik + ", " + prizma.derinlik + ")");

            if (dikeyMesafeKare <= maxMesafeKaresi && yatayMesafeKare <= YuzeyGenislikKare)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Prizma ve Küre çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Prizma ve Küre çarpışmadı.");
            }


            kure.KüreCiz(panel1);
            prizma.PrizmaCiz(panel1);

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Prizma<int> prizma = new Prizma<int>();
            Prizma2<int> prizma2 = new Prizma2<int>();


            int merkezXP = prizma.X + prizma.Genislik / 2;
            int merkezYP = prizma.Y + prizma.Yukseklik / 2;
            int merkezZP = prizma.Z + prizma.derinlik / 2;

            int merkezXP2 = prizma2.X + prizma2.Genislik / 2;
            int merkezYP2 = prizma2.Y + prizma2.Yukseklik / 2;
            int merkezZP2 = prizma2.Z + prizma2.derinlik / 2;

            int MaxZMesafe = (merkezXP + prizma.derinlik / 2) + (merkezYP2 + prizma2.derinlik / 2);
            int MaxyatayMesafe = (merkezXP2 + prizma2.Genislik / 2) + (merkezXP + prizma.Genislik / 2);
            int MaxDikeymesafe = (merkezYP + prizma.Yukseklik / 2) + (merkezZP2 + prizma2.Yukseklik / 2);

            int dikeyMesafe = (prizma2.Yukseklik / 2 - prizma.Yukseklik / 2);
            int yatayMesafe = (prizma2.Genislik / 2 - prizma.derinlik / 2) + (prizma.derinlik / 2 - prizma2.derinlik / 2);

            textBox1.Text = ("1. Prizmanın verileri (x, y, z, h, d, u) : (" + merkezXP + ", " + merkezYP + ", " + merkezZP + ", " + prizma.Yukseklik + ", " + prizma.Genislik + ", " + prizma.derinlik + ")");
            textBox2.Text = ("2. Prizmanın verileri (x, y, z, h, d, u) : (" + merkezXP2 + ", " + merkezYP2 + ", " + merkezZP2 + ", " + prizma2.Yukseklik + ", " + prizma2.Genislik + ", " + prizma2.derinlik + ")");

            if (dikeyMesafe <= MaxDikeymesafe && yatayMesafe <= MaxyatayMesafe && yatayMesafe <= MaxZMesafe)
            {
                textBox3.BackColor = Color.Green;
                textBox3.Text = ("Prizma ve Prizma çarpıştı.");
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.Text = ("Prizma ve Prizma çarpışmadı.");
            }


            prizma.PrizmaCiz(panel1);
            prizma2.Prizma2Ciz(panel1);
        }
    }
}
