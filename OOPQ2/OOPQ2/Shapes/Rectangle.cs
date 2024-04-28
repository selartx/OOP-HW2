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
    public class Rectangle
    {

        public Point M { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(Point p, int width, int height)
        {
            M = p;
            Width = width;
            Height = height;
        }
        public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Purple);
            g.DrawRectangle(pen, M.X, M.Y, Width, Height);
        }

    }
}
