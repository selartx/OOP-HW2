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
    public class Circle
    {
        Point m;
        int r;
        public Circle(Point m, int r)
        { M = m; R = r; }
        public int R { get => r; set => r = value; }
        public Point M { get => m; set => m = value; }
        public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            g.DrawEllipse(pen, M.X, M.Y, R, R);
        }
    }

}
