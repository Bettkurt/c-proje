using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            dortgen.DörtgenCiz(panel1 );
            nokta.NoktaCiz(panel1);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Nokta<int> nokta = new Nokta<int>();
            Cember<int> cember = new Cember<int>();

            
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

            dortgen.DörtgenCiz(panel1);
            dortgen2.Dörtgen2Ciz(panel1);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Dörtgen<int> dortgen = new Dörtgen<int>();
            Cember<int> cember = new Cember<int>();

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

            kure.KüreCiz(panel1);
            silindir.SilindirCiz(panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Refresh();

            List<Nesneler<int>> nesneler = new List<Nesneler<int>>();
            Yuzey<int> yuzey = new Yuzey<int>();
            Küre<int> kure = new Küre<int>();

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

            prizma.PrizmaCiz(panel1);
            prizma2.Prizma2Ciz(panel1);
        }
    }
}
