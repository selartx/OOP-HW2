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
    public class Surface
    {
        Point3D m; int width; int height; int depth;
        public Surface(Point3D m, int width, int height)
        { M = m; Width = width; Height = height; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Height { get; set; }
        public Point3D M { get; set; }
        public void Draw(PictureBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, M.X, M.Y, Width, Height);
            g.DrawRectangle(pen, M.X + Depth, M.Y + Depth, Width, Height);
            g.DrawLine(pen, M.X, M.Y, M.X + Depth, M.Y + Depth);
            g.DrawLine(pen, M.X + Width, M.Y, M.X + Depth + Width, M.Y + Depth);
            g.DrawLine(pen, M.X, M.Y + Height, M.X + Depth, M.Y + Depth + Height);
            g.DrawLine(pen, M.X + Width, M.Y + Height, M.X + Width + Depth, M.Y + Depth + Height);
        }
    }
}
