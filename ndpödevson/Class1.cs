using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpödevson
{
    public class Nesneler<nesne>
    {
        public int X;
        public int Y;
        public int Z;
        public int Cap;
        public int Yukseklik;
        public int Genislik;
        public int derinlik;
    }

    class Nokta<nesne> : Nesneler<nesne>
    {
        public Nokta()
        { 
        Random random = new Random(Guid.NewGuid().GetHashCode());
        X = random.Next(1,683);
        Y= random.Next(1, 420);
        Z = random.Next(1,683);
       }
    public void NoktaCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            graphics.DrawEllipse(pen, X, Y, 1, 1);

        }
    }

    class Dörtgen<nesne> : Nesneler<nesne>
    {
        public Dörtgen()
        {
        Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(50, 200);
            Y = random.Next(50, 200);
            Yukseklik = random.Next(50, 200);
            Genislik = random.Next(50, 200);
        }
        public void DörtgenCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Red);

            graphics.DrawRectangle(pen, X, Y, Genislik, Yukseklik);

        }

    }
    class Dörtgen2<nesne> : Nesneler<nesne>
    {
        public Dörtgen2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 200);
            Yukseklik = random.Next(50, 200);
            Genislik = random.Next(50, 200);
        }
        public void Dörtgen2Ciz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Red);

            graphics.DrawRectangle(pen, X, Y, Genislik, Yukseklik);

        }

    }
    class Dikdörtgen<nesne> : Nesneler<nesne>
    {
        public Dikdörtgen()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 200);
            Yukseklik = random.Next(20, 200);
            Genislik = random.Next(20, 200);
        }
        public void DikdörtgenCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            graphics.DrawRectangle(pen, X, Y, Genislik, Yukseklik);

        }

    }  
    class Dikdörtgen2<nesne> : Nesneler<nesne>
    {
        public Dikdörtgen2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 200);
            Yukseklik = random.Next(1, 200);
            Genislik = random.Next(1, 200);
        }
        public void Dikdörtgen2Ciz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            graphics.DrawRectangle(pen, X, Y, Genislik, Yukseklik);

        }

    }
    class Cember<nesne> : Nesneler<nesne>
    {
        public Cember()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(50, 300);
            Y = random.Next(50, 300);
            Cap = random.Next(1, 300);
        }
        public void CemberCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            graphics.DrawEllipse(pen, X, Y, Cap,Cap);

        }

    }
    class Cember2<nesne> : Nesneler<nesne>
    {
        public Cember2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 300);
            Y = random.Next(1, 300);
            Cap = random.Next(1, 300);
        }
        public void Cember2Ciz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Red);

            graphics.DrawEllipse(pen, X, Y, Cap, Cap);

        }

    }

    class Prizma<nesne> : Nesneler<nesne>
    {
        public Prizma()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 300);
            Y = random.Next(1,200);
            Z = random.Next(1, 200);
            Yukseklik = random.Next(1, 200);
            Genislik = random.Next(1, 200);
            derinlik = random.Next(1, 200);
        }
        public void PrizmaCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            //alt yuzey
            graphics.DrawRectangle(pen, X, Y, Genislik, Yukseklik);

            //üst yuzey
            graphics.DrawRectangle(pen, X + derinlik, Y + derinlik, Genislik, Yukseklik);

            //yan yüzeyler
            graphics.DrawLine(pen, X, Y, X + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X + Genislik, Y, X + Genislik + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X, Y + Yukseklik, X + derinlik, Y + Yukseklik + derinlik);
            graphics.DrawLine(pen, X + Genislik, Y + Yukseklik, X + Genislik + derinlik, Y + Yukseklik + derinlik);

        }

    }
    class Prizma2<nesne> : Nesneler<nesne>
    {
        public Prizma2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 100);
            Z = random.Next(1, 200);
            Yukseklik = random.Next(1,200);
            Genislik = random.Next(1, 200);
            derinlik = random.Next(1, 200);
        }
        public void Prizma2Ciz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Red);

            //alt yuzey
            graphics.DrawRectangle(pen, X, Y, Genislik, Yukseklik);

            //üst yuzey
            graphics.DrawRectangle(pen, X + derinlik, Y + derinlik, Genislik, Yukseklik);

            //yan yüzeyler
            graphics.DrawLine(pen, X, Y, X + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X + Genislik, Y, X + Genislik + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X, Y + Yukseklik, X + derinlik, Y + Yukseklik + derinlik);
            graphics.DrawLine(pen, X + Genislik, Y + Yukseklik, X + Genislik + derinlik, Y + Yukseklik + derinlik);

        }

    }
    class Küre<nesne> : Nesneler<nesne>
    {
        public Küre()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 200);
            Z = random.Next(1, 200);
            Cap = random.Next(1,200);
        }
        public void KüreCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            graphics.FillEllipse(Brushes.DarkGray,X ,Y  , Cap , Cap );

        }

    }
    class Küre2<nesne> : Nesneler<nesne>
    {
        public Küre2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 200);
            Z = random.Next(1, 200);
            Cap = random.Next(1, 200);
        }
        public void Küre2Ciz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            graphics.FillEllipse(Brushes.DarkGray, X, Y, Cap, Cap);

        }

    }
    class Silindir<nesne> : Nesneler<nesne>
    {
        public Silindir()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 200);
            Z = random.Next(1, 200);
            Cap = random.Next(1, 200);
            Yukseklik = random.Next(1, 300);
        }
        public void SilindirCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            graphics.DrawEllipse(pen, X , Y , Cap , Cap );

            graphics.DrawEllipse(pen, X , Y + Yukseklik , Cap , Cap );

            graphics.DrawLine(pen, X, Y + Cap / 2 , X , Y + Yukseklik + Cap/2);
            graphics.DrawLine(pen, X + Cap, Y + Cap/2, X + Cap, Y + Yukseklik + Cap/2);

        }

    }
    class Silindir2<nesne> : Nesneler<nesne>
    {
        public Silindir2()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(1, 200);
            Y = random.Next(1, 200);
            Z = random.Next(1, 200);
            Cap = random.Next(1,200);
            Yukseklik = random.Next(1, 170);
        }
        public void Silindir2Ciz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);


            graphics.DrawEllipse(pen, X, Y, Cap, Cap);

            graphics.DrawEllipse(pen, X, Y + Yukseklik, Cap, Cap);

            graphics.DrawLine(pen, X, Y + Cap / 2, X, Y + Yukseklik + Cap / 2);
            graphics.DrawLine(pen, X + Cap, Y + Cap / 2, X + Cap, Y + Yukseklik + Cap / 2);

        }

    }
    class Yuzey<nesne> : Nesneler<nesne>
    {
        public Yuzey()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            X = random.Next(60, 200);
            Y = random.Next(1, 200);
            Z = random.Next(1, 100);
            Yukseklik = random.Next(1, 200);
            Genislik = 1;
            derinlik = random.Next(1, 200);
        }
        public void YuzeyCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            //alt yuzey
            graphics.DrawRectangle(pen, X, Y, Genislik, Yukseklik);

            //üst yuzey
            graphics.DrawRectangle(pen, X + derinlik, Y + derinlik, Genislik, Yukseklik);

            //yan yüzeyler
            graphics.DrawLine(pen, X, Y, X + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X + Genislik, Y, X + Genislik + derinlik, Y + derinlik);
            graphics.DrawLine(pen, X, Y + Yukseklik, X + derinlik, Y + Yukseklik + derinlik);
            graphics.DrawLine(pen, X + Genislik, Y + Yukseklik , X  + Genislik + derinlik, Y  + Yukseklik + derinlik);

        }

    }




}
