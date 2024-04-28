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
    public class Cylinder
    {
        public Point3D Center { get; set; }
        public int Radius { get; set; }
        public int Height { get; set; }

        public Cylinder(Point3D center, int radius, int height)
        {
            Center = center;
            Radius = radius;
            Height = height;
        }
        public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Orange);
            g.DrawEllipse(pen, Center.X, Center.Y, Radius, Radius);
            g.DrawEllipse(pen, Center.X, Center.Y + Height, Radius, Radius);
            g.DrawLine(pen, Center.X, Center.Y + (Radius / 2), Center.X, Center.Y + Height + (Radius / 2));
            g.DrawLine(pen, Center.X + Radius, Center.Y + (Radius / 2), Center.X + Radius, Center.Y + Height + (Radius / 2));
        }
    }


}
