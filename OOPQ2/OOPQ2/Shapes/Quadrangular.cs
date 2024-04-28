/****************************************************************************
**					        SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				        BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          Object Oriented Programming
**	
**				ÖDEV NUMARASI:OOPHW2
**				ÖĞRENCİ ADI:Selva Artunç
**				ÖĞRENCİ NUMARASI:Homework 2
**				DERS GRUBU:1/C
****************************************************************************/
namespace OOPQ2
{
    public class Quadrangular
    {
        public Point3D Center { get; set; } // Prizmanın merkezi
        public int Width { get; set; }    // Genişlik
        public int Height { get; set; }   // Yükseklik
        public int Depth { get; set; }    // Derinlik
        public Quadrangular(Point3D center, int width, int height, int depth)
        {
            Center = center;
            Width = width;
            Height = height;
            Depth = depth;
        }
        public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.HotPink);
            g.DrawRectangle(pen, Center.X, Center.Y, Width, Height); //bottom
            g.DrawRectangle(pen, Center.X + Depth, Center.Y + Depth, Width, Height);
            g.DrawLine(pen, Center.X, Center.Y, Center.X + Depth, Center.Y + Depth);
            g.DrawLine(pen, Center.X + Width, Center.Y, Center.X + Width + Depth, Center.Y + Depth);
            g.DrawLine(pen, Center.X, Center.Y + Height, Center.X + Depth, Center.Y + Depth + Height);
            g.DrawLine(pen, Center.X + Width, Center.Y + Height, Center.X + Width + Depth, Center.Y + Height + Depth);

        }
    }

}
