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
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Draw(PictureBox pictureBox1)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, X, Y, 1, 1);
        }
    }
}
