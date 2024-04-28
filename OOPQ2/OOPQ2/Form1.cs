/****************************************************************************
**					        SAKARYA ÜNÝVERSÝTESÝ
**			         BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				        BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				          Object Oriented Programming
**	
**				ÖDEV NUMARASI:OOPHW2
**				ÖÐRENCÝ ADI:Selva Artunç
**				ÖÐRENCÝ NUMARASI:Homework 2
**				DERS GRUBU:1/C
****************************************************************************/

namespace OOPQ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Point-Rectangle");//0
            comboBox1.Items.Add("Point-Circle");//1
            comboBox1.Items.Add("Rectangle-Rectangle");//2
            comboBox1.Items.Add("Rectangle-Circle");//3
            comboBox1.Items.Add("Circle-Circle");//4
            comboBox1.Items.Add("Point-Sphere");//5
            comboBox1.Items.Add("Point-Quadrangular");//6
            comboBox1.Items.Add("Point-Cylinder");//7
            comboBox1.Items.Add("Cylinder-Cylinder");//8
            comboBox1.Items.Add("Sphere-Sphere");//9
            comboBox1.Items.Add("Sphere-Cylinder");//10
            comboBox1.Items.Add("Surface-Sphere");//11
            comboBox1.Items.Add("Surface-Quadrangular");//12
            comboBox1.Items.Add("Surface-Cylinder");//13
            comboBox1.Items.Add("Sphere-Quadrangular");//14
            comboBox1.Items.Add("Quadrangular-Quadrangular");//15

        }
        public void Detect_Click(object sender, EventArgs e)
        { 
            if (comboBox1.SelectedIndex == 0)
            {
                int point1X = Convert.ToInt32(PointX.Text);
                int point1Y = Convert.ToInt32(PointY.Text);
                int point1Z = Convert.ToInt32(PointZ.Text);
                int rect1X = Convert.ToInt32(Rectangle1X.Text);
                int rect1Y = Convert.ToInt32(Rectangle1Y.Text);
                int rect1Width = Convert.ToInt32(Rectangle1W.Text);
                int rect1Height = Convert.ToInt32(Rectangle1H.Text);
                Point point = new Point(point1X, point1Y);
                Rectangle Rectangle1 = new Rectangle(new Point(rect1X, rect1Y), rect1Width, rect1Height);

                if (CollisionDetection.PointRectangle(point, Rectangle1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else if (point1Z != 0)
                {
                    MessageBox.Show("Nokta, dikdörtgen  düzlemi dýþýnda olduðu için çarpýþma gerçekleþmedi.");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                int point1X = Convert.ToInt32(PointX.Text);
                int point1Y = Convert.ToInt32(PointY.Text);
                int point1Z = Convert.ToInt32(PointZ.Text);
                Point point = new Point(point1X, point1Y);
                int circle1X = Convert.ToInt32(Circle1X.Text);
                int circle1Y = Convert.ToInt32(Circle1Y.Text);
                int circle1R = Convert.ToInt32(CircleR.Text);
                Circle Circle1 = new Circle(new Point(circle1X, circle1Y), circle1R);
                if (CollisionDetection.PointCircle(point, Circle1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else if (point1Z != 0)
                {
                    MessageBox.Show("Nokta, dikdörtgen  çember dýþýnda olduðu için çarpýþma gerçekleþmedi.");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int rect1X = Convert.ToInt32(Rectangle1X.Text);
                int rect1Y = Convert.ToInt32(Rectangle1Y.Text);
                int rect1Width = Convert.ToInt32(Rectangle1W.Text);
                int rect1Height = Convert.ToInt32(Rectangle1H.Text);
                Rectangle Rectangle1 = new Rectangle(new Point(rect1X, rect1Y), rect1Width, rect1Height);
                int rectY2 = Convert.ToInt32(Rectangle2Y.Text);
                int recX2 = Convert.ToInt32(Rectangle2X.Text);
                int recw2 = Convert.ToInt32(Rectangle2W.Text);
                int rech2 = Convert.ToInt32(Rectangle2H.Text);
                Rectangle Rectangle2 = new Rectangle(new Point(recX2, rectY2), recw2, rech2);
                if (CollisionDetection.RectangleRectangle(Rectangle1, Rectangle2))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int rect1X = Convert.ToInt32(Rectangle1X.Text);
                int rect1Y = Convert.ToInt32(Rectangle1Y.Text);
                int rect1Width = Convert.ToInt32(Rectangle1W.Text);
                int rect1Height = Convert.ToInt32(Rectangle1H.Text);
                Rectangle Rectangle1 = new Rectangle(new Point(rect1X, rect1Y), rect1Width, rect1Height);
                int circle1X = Convert.ToInt32(Circle1X.Text);
                int circle1Y = Convert.ToInt32(Circle1Y.Text);
                int circle1R = Convert.ToInt32(CircleR.Text);
                Circle Circle1 = new Circle(new Point(circle1X, circle1Y), circle1R);
                if (CollisionDetection.RectangleCircle(Rectangle1, Circle1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                int circle1X = Convert.ToInt32(Circle1X.Text);
                int circle1Y = Convert.ToInt32(Circle1Y.Text);
                int circle1R = Convert.ToInt32(CircleR.Text);
                Circle Circle1 = new Circle(new Point(circle1X, circle1Y), circle1R);
                int circleX2 = Convert.ToInt32(Circle2X.Text);
                int circleY2 = Convert.ToInt32(Circle2Y.Text);
                int circle2R = Convert.ToInt32(Circle2R.Text);
                Circle Circle2 = new Circle(new Point(circleX2, circleY2), circle2R);
                if (CollisionDetection.CircleCircle(Circle1, Circle2))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                int point1X = Convert.ToInt32(PointX.Text);
                int point1Y = Convert.ToInt32(PointY.Text);
                int point1Z = Convert.ToInt32(PointZ.Text);
                Point3D point3D = new Point3D(point1X, point1Y, point1Z);
                int sphere1X = Convert.ToInt32(Sphere1X.Text);
                int sphere1Y = Convert.ToInt32(Sphere1Y.Text);
                int sphere1Z = Convert.ToInt32(Sphere1Z.Text);
                int sphere1R = Convert.ToInt32(Sphere1R.Text);
                Sphere Sphere1 = new Sphere(new Point3D(sphere1X, sphere1Y, sphere1Z), sphere1R);
                if (CollisionDetection.PointSphere(point3D, Sphere1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                int point1X = Convert.ToInt32(PointX.Text);
                int point1Y = Convert.ToInt32(PointY.Text);
                int point1Z = Convert.ToInt32(PointZ.Text);
                Point3D point3D = new Point3D(point1X, point1Y, point1Z);
                int quadrangular1X = Convert.ToInt32(Quadrangular1X.Text);
                int quadrangular1Y = Convert.ToInt32(Quadrangular1Y.Text);
                int quadrangular1Z = Convert.ToInt32(Quadrangular1Z.Text);
                int quadrangular1W = Convert.ToInt32(Quadrangular1W.Text);
                int quadrangular1H = Convert.ToInt32(Quadrangular1H.Text);
                int quadrangular1D = Convert.ToInt32(Quadrangular1D.Text);
                Quadrangular quadrangular1 = new Quadrangular(new Point3D(quadrangular1X, quadrangular1Y, quadrangular1Z), quadrangular1W, quadrangular1H, quadrangular1D);
                if (CollisionDetection.PointQuadrangular(point3D, quadrangular1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }

            }
            else if (comboBox1.SelectedIndex == 7)
            {
                int point1X = Convert.ToInt32(PointX.Text);
                int point1Y = Convert.ToInt32(PointY.Text);
                int point1Z = Convert.ToInt32(PointZ.Text);
                Point3D point3D = new Point3D(point1X, point1Y, point1Z);

                int cylinder1X = Convert.ToInt32(Cylinder1X.Text);
                int cylinder1Y = Convert.ToInt32(Cylinder1Y.Text);
                int cylinder1Z = Convert.ToInt32(Cylinder1Z.Text);
                int cylinder1R = Convert.ToInt32(Cylinder1R.Text);
                int cylinder1H = Convert.ToInt32(Cylinder1H.Text);
                Cylinder cylinder1 = new Cylinder(new Point3D(cylinder1X, cylinder1Y, cylinder1Z), cylinder1R, cylinder1H);

                if (CollisionDetection.PointCylinder(point3D, cylinder1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }

            }
            else if (comboBox1.SelectedIndex == 8)
            {
                int cylinder1X = Convert.ToInt32(Cylinder1X.Text);
                int cylinder1Y = Convert.ToInt32(Cylinder1Y.Text);
                int cylinder1Z = Convert.ToInt32(Cylinder1Z.Text);
                int cylinder1R = Convert.ToInt32(Cylinder1R.Text);
                int cylinder1H = Convert.ToInt32(Cylinder1H.Text);
                Cylinder cylinder1 = new Cylinder(new Point3D(cylinder1X, cylinder1Y, cylinder1Z), cylinder1R, cylinder1H);
                int cylinder2X = Convert.ToInt32(Cylinder2X.Text);
                int cylinder2Y = Convert.ToInt32(Cylinder2Y.Text);
                int cylinder2Z = Convert.ToInt32(Cylinder2Z.Text);
                int cylinder2R = Convert.ToInt32(Cylinder2R.Text);
                int cylinder2H = Convert.ToInt32(Cylinder2H.Text);
                Cylinder cylinder2 = new Cylinder(new Point3D(cylinder2X, cylinder2Y, cylinder2Z), cylinder2R, cylinder2H);
                if (CollisionDetection.CylinderCylinder(cylinder1, cylinder2))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }

            }
            else if (comboBox1.SelectedIndex == 9)
            {
                int sphere1X = Convert.ToInt32(Sphere1X.Text);
                int sphere1Y = Convert.ToInt32(Sphere1Y.Text);
                int sphere1Z = Convert.ToInt32(Sphere1Z.Text);
                int sphere1R = Convert.ToInt32(Sphere1R.Text);
                Sphere Sphere1 = new Sphere(new Point3D(sphere1X, sphere1Y, sphere1Z), sphere1R);
                int sphere2X = Convert.ToInt32(Sphere2X.Text);
                int sphere2Y = Convert.ToInt32(Sphere2Y.Text);
                int sphere2Z = Convert.ToInt32(Sphere2Z.Text);
                int sphere2R = Convert.ToInt32(Sphere2R.Text);
                Sphere Sphere2 = new Sphere(new Point3D(sphere2X, sphere2Y, sphere2Z), sphere2R);

                if (CollisionDetection.SphereSphere(Sphere1, Sphere2))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }

            }
            else if (comboBox1.SelectedIndex == 10)
            {
                int sphere1X = Convert.ToInt32(Sphere1X.Text);
                int sphere1Y = Convert.ToInt32(Sphere1Y.Text);
                int sphere1Z = Convert.ToInt32(Sphere1Z.Text);
                int sphere1R = Convert.ToInt32(Sphere1R.Text);
                Sphere Sphere1 = new Sphere(new Point3D(sphere1X, sphere1Y, sphere1Z), sphere1R);
                int cylinder1X = Convert.ToInt32(Cylinder1X.Text);
                int cylinder1Y = Convert.ToInt32(Cylinder1Y.Text);
                int cylinder1Z = Convert.ToInt32(Cylinder1Z.Text);
                int cylinder1R = Convert.ToInt32(Cylinder1R.Text);
                int cylinder1H = Convert.ToInt32(Cylinder1H.Text);
                Cylinder cylinder1 = new Cylinder(new Point3D(cylinder1X, cylinder1Y, cylinder1Z), cylinder1R, cylinder1H);

                if (CollisionDetection.SphereCylinder(Sphere1, cylinder1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                int sphere1X = Convert.ToInt32(Sphere1X.Text);
                int sphere1Y = Convert.ToInt32(Sphere1Y.Text);
                int sphere1Z = Convert.ToInt32(Sphere1Z.Text);
                int sphere1R = Convert.ToInt32(Sphere1R.Text);
                Sphere Sphere1 = new Sphere(new Point3D(sphere1X, sphere1Y, sphere1Z), sphere1R);
                int surfaceX = Convert.ToInt32(SurfaceX.Text);
                int surfaceY = Convert.ToInt32(SurfaceY.Text);
                int surfaceZ = Convert.ToInt32(SurfaceX.Text);
                int surfaceW = Convert.ToInt32(SurfaceW.Text);
                int surfaceH = Convert.ToInt32(SurfaceH.Text);
                int surfaceD = Convert.ToInt32(SurfaceD.Text);

                Surface surface = new Surface(new Point3D(surfaceX, surfaceY, surfaceZ), surfaceW, surfaceH);
                if (CollisionDetection.SurfaceSphere(surface, Sphere1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }

            }
            else if (comboBox1.SelectedIndex == 12)
            {
                int surfaceX = Convert.ToInt32(SurfaceX.Text);
                int surfaceY = Convert.ToInt32(SurfaceY.Text);
                int surfaceZ = Convert.ToInt32(SurfaceX.Text);
                int surfaceW = Convert.ToInt32(SurfaceW.Text);
                int surfaceH = Convert.ToInt32(SurfaceH.Text);
                int surfaceD = Convert.ToInt32(SurfaceD.Text);

                Surface surface = new Surface(new Point3D(surfaceX, surfaceY, surfaceZ), surfaceW, surfaceH);
                int quadrangular1X = Convert.ToInt32(Quadrangular1X.Text);
                int quadrangular1Y = Convert.ToInt32(Quadrangular1Y.Text);
                int quadrangular1Z = Convert.ToInt32(Quadrangular1Z.Text);
                int quadrangular1W = Convert.ToInt32(Quadrangular1W.Text);
                int quadrangular1H = Convert.ToInt32(Quadrangular1H.Text);
                int quadrangular1D = Convert.ToInt32(Quadrangular1D.Text);
                Quadrangular quadrangular1 = new Quadrangular(new Point3D(quadrangular1X, quadrangular1Y, quadrangular1Z), quadrangular1W, quadrangular1H, quadrangular1D);
                if (CollisionDetection.SurfaceQuadrangular(surface, quadrangular1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                int cylinder1X = Convert.ToInt32(Cylinder1X.Text);
                int cylinder1Y = Convert.ToInt32(Cylinder1Y.Text);
                int cylinder1Z = Convert.ToInt32(Cylinder1Z.Text);
                int cylinder1R = Convert.ToInt32(Cylinder1R.Text);
                int cylinder1H = Convert.ToInt32(Cylinder1H.Text);
                Cylinder cylinder1 = new Cylinder(new Point3D(cylinder1X, cylinder1Y, cylinder1Z), cylinder1R, cylinder1H);
                int surfaceX = Convert.ToInt32(SurfaceX.Text);
                int surfaceY = Convert.ToInt32(SurfaceY.Text);
                int surfaceZ = Convert.ToInt32(SurfaceX.Text);
                int surfaceW = Convert.ToInt32(SurfaceW.Text);
                int surfaceH = Convert.ToInt32(SurfaceH.Text);
                int surfaceD = Convert.ToInt32(SurfaceD.Text);

                Surface surface = new Surface(new Point3D(surfaceX, surfaceY, surfaceZ), surfaceW, surfaceH);
                if (CollisionDetection.SurfaceCylinder(surface, cylinder1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                int sphere1X = Convert.ToInt32(Sphere1X.Text);
                int sphere1Y = Convert.ToInt32(Sphere1Y.Text);
                int sphere1Z = Convert.ToInt32(Sphere1Z.Text);
                int sphere1R = Convert.ToInt32(Sphere1R.Text);
                Sphere Sphere1 = new Sphere(new Point3D(sphere1X, sphere1Y, sphere1Z), sphere1R);
                int quadrangular1X = Convert.ToInt32(Quadrangular1X.Text);
                int quadrangular1Y = Convert.ToInt32(Quadrangular1Y.Text);
                int quadrangular1Z = Convert.ToInt32(Quadrangular1Z.Text);
                int quadrangular1W = Convert.ToInt32(Quadrangular1W.Text);
                int quadrangular1H = Convert.ToInt32(Quadrangular1H.Text);
                int quadrangular1D = Convert.ToInt32(Quadrangular1D.Text);
                Quadrangular quadrangular1 = new Quadrangular(new Point3D(quadrangular1X, quadrangular1Y, quadrangular1Z), quadrangular1W, quadrangular1H, quadrangular1D);
                
                if (CollisionDetection.SphereQuadrangular(Sphere1, quadrangular1))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                int quadrangular1X = Convert.ToInt32(Quadrangular1X.Text);
                int quadrangular1Y = Convert.ToInt32(Quadrangular1Y.Text);
                int quadrangular1Z = Convert.ToInt32(Quadrangular1Z.Text);
                int quadrangular1W = Convert.ToInt32(Quadrangular1W.Text);
                int quadrangular1H = Convert.ToInt32(Quadrangular1H.Text);
                int quadrangular1D = Convert.ToInt32(Quadrangular1D.Text);
                Quadrangular quadrangular1 = new Quadrangular(new Point3D(quadrangular1X, quadrangular1Y, quadrangular1Z), quadrangular1W, quadrangular1H, quadrangular1D);
                int quadrangular2X = Convert.ToInt32(Quadrangular2X.Text);
                int quadrangular2Y = Convert.ToInt32(Quadrangular2Y.Text);
                int quadrangular2Z = Convert.ToInt32(Quadrangular2Z.Text);
                int quadrangular2W = Convert.ToInt32(Quadrangular2W.Text);
                int quadrangular2H = Convert.ToInt32(Quadrangular2H.Text);
                int quadrangular2D = Convert.ToInt32(Quadrangular2D.Text);
                Quadrangular quadrangular2 = new Quadrangular(new Point3D(quadrangular2X, quadrangular2Y, quadrangular2Z), quadrangular2W, quadrangular2H, quadrangular2D);
                if (CollisionDetection.QuadrangularQuadrangular(quadrangular1, quadrangular2))
                {
                    MessageBox.Show("Çarpýþma gerçekleþti!");
                }
                else
                {
                    MessageBox.Show("Çarpýþma gerçekleþmedi.");
                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            Point p = new Point(r.Next(1, 300), r.Next(1, 300));
            Point3D p3 = new Point3D(r.Next(1, 300), r.Next(1, 300), r.Next(1, 300));
            Rectangle rectangle = new Rectangle(new Point(r.Next(1, 300), r.Next(1, 300)), r.Next(1, 200), r.Next(1, 200));
            Circle circle = new Circle(new Point(r.Next(1, 300), r.Next(1, 300)), r.Next(1, 200));
            Sphere sphere = new Sphere(new Point3D(r.Next(1, 300), r.Next(1, 300), r.Next(1, 300)), r.Next(1, 300));
            Quadrangular quadrangular = new Quadrangular(new Point3D(r.Next(1, 300), r.Next(1, 300), r.Next(1, 300)), r.Next(1, 300), r.Next(1, 300), r.Next(1, 300));
            Cylinder cylinder = new Cylinder(new Point3D(r.Next(1, 300), r.Next(1, 300), r.Next(1, 300)), r.Next(1, 300), r.Next(1, 300));
            Surface surface = new Surface(new Point3D(r.Next(1, 300), r.Next(0, 300), r.Next(1, 300)), r.Next(1, 300), r.Next(1, 300));
            if (radioButton1.Checked) { p.Draw(pictureBox1); }
            else if (radioButton2.Checked) { p3.Draw(pictureBox1); }
            else if (radioButton3.Checked) { rectangle.Draw(pictureBox1); }
            else if (radioButton4.Checked) { circle.Draw(pictureBox1); }
            else if (radioButton5.Checked) { sphere.Draw(pictureBox1); }
            else if (radioButton6.Checked) { quadrangular.Draw(pictureBox1); }
            else if (radioButton7.Checked) { cylinder.Draw(pictureBox1); }
            else if (radioButton8.Checked) { surface.Draw(pictureBox1); }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

    }
}
