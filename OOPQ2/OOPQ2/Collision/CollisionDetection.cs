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
    public static class CollisionDetection
    {
        public static bool PointRectangle(Point P1, Rectangle R1)
        {
            int x = P1.X;
            int y = P1.Y;
            int leftX = R1.M.X - R1.Width / 2; // Sol üst köşe x koordinatı
            int rightX = R1.M.X + R1.Width / 2; // Sağ üst köşe x koordinatı
            int topY = R1.M.Y - R1.Height / 2; // Sol üst köşe y koordinatı
            int bottomY = R1.M.Y + R1.Height / 2; // Sol alt köşe y koordinatı
            if (x >= leftX && x <= rightX && y >= topY && y <= bottomY)
            {
                // Nokta dikdörtgenin içinde veya sınırlarında
                return true;
            }
            else
            {
                // Nokta dikdörtgenin dışında
                return false;
            }
        }
        public static bool PointCircle(Point P1, Circle C)
        {
            double distance = Math.Sqrt(Math.Pow(P1.X - C.M.X, 2) + Math.Pow(P1.Y - C.M.Y, 2));
            if (distance <= C.R)
                return true;
            else
                return false;

        }
        public static bool RectangleRectangle(Rectangle R1, Rectangle R2)
        {
            int Xa = R1.M.X + R1.Width / 2;
            int Ya = R1.M.Y + R1.Height / 2;
            int Xb = R2.M.X + R2.Width / 2;
            int Yb = R2.M.Y + R2.Height / 2;
            if (Math.Abs(Xa - Xb) < (R1.Width / 2 + R2.Width / 2) && Math.Abs(Ya - Yb) < (R1.Height / 2 + R2.Height / 2))
                return true;
            else
                return false;
        }
        public static bool CircleCircle(Circle C1, Circle C2)
        {
            double distance = Math.Sqrt(Math.Pow(C1.M.X - C2.M.X, 2) + Math.Pow(C1.M.Y - C2.M.Y, 2));
            if (distance <= C1.R + C2.R)
                return true;
            else
                return false;
        }
        public static bool PointSphere(Point3D P1, Sphere S1)
        {
            double distance = Math.Sqrt(Math.Pow(P1.X - S1.M.X, 2) + Math.Pow(P1.Y - S1.M.Y, 2) + Math.Pow(P1.Z - S1.M.Z, 2));
            if (distance <= S1.R)
                return true;
            else
                return false;
        }
        public static bool PointQuadrangular(Point3D P1, Quadrangular Q1)
        {
            int x = P1.X;
            int y = P1.Y;
            int z = P1.Z;
            // Dikdörtgen prizmanın sınırlarını al
            int minX = Q1.Center.X - Q1.Width / 2;
            int minY = Q1.Center.Y - Q1.Height / 2;
            int minZ = Q1.Center.Z - Q1.Depth / 2;
            int maxX = Q1.Center.X + Q1.Width / 2;
            int maxY = Q1.Center.Y + Q1.Height / 2;
            int maxZ = Q1.Center.Z + Q1.Depth / 2;

            // Noktanın dikdörtgen prizmanın sınırları içinde olup olmadığını kontrol et
            if (x >= minX && x <= maxX && y >= minY && y <= maxY && z >= minZ && z <= maxZ)
            {
                // Nokta, dikdörtgen prizmanın içinde
                return true;
            }
            else
            {
                // Nokta, dikdörtgen prizmanın dışında
                return false;
            }
        }
        public static bool PointCylinder(Point3D P1, Cylinder C1)
        {
            // Noktanın silindirin eksenine dik düşen bir çizgi boyunca konumlandırılması
            double distanceToAxis = Math.Sqrt(Math.Pow(P1.X - C1.Center.X, 2) + Math.Pow(P1.Y - C1.Center.Y, 2));

            // Çizginin silindirin merkezinden geçtiğinin kontrolü
            if (distanceToAxis <= C1.Radius)
            {
                // Çizginin silindirin yüksekliği aralığında olup olmadığının kontrolü
                if (P1.Z >= C1.Center.Z - C1.Height / 2 && P1.Z <= C1.Center.Z + C1.Height / 2)
                {
                    return true; // Çarpışma gerçekleşti
                }
            }
            return false; // Çarpışma gerçekleşmedi
        }
        public static bool SphereSphere(Sphere S1, Sphere S2)
        {
            double distance = Math.Sqrt(Math.Pow(S1.M.X - S2.M.X, 2) + Math.Pow(S1.M.Y - S2.M.Y, 2) + Math.Pow(S1.M.Z - S2.M.Z, 2));
            if (distance <= S1.R + S2.R)
                return true;
            else
                return false;
        }
        public static bool CylinderCylinder(Cylinder C1, Cylinder C2)
        {  // Silindirlerin merkez noktaları arasındaki mesafe
            double distance = Math.Sqrt(Math.Pow(C1.Center.X - C2.Center.X, 2) +
                                        Math.Pow(C1.Center.Y - C2.Center.Y, 2) +
                                        Math.Pow(C1.Center.Z - C2.Center.Z, 2));

            // Silindirlerin yarıçaplarının toplamı
            double sumOfRadius = C1.Radius + C2.Radius;
            if (distance <= sumOfRadius && Math.Abs(C1.Height - C2.Height) < 0.001)
                return true;
            else
                return false;
        }
        public static bool SphereCylinder(Sphere S1, Cylinder C1)
        {  // Kürenin merkezi ile silindirin merkezi arasındaki mesafe
            double distance = Math.Sqrt(Math.Pow(S1.M.X - C1.Center.X, 2) +
                                        Math.Pow(S1.M.Y - C1.Center.Y, 2) +
                                        Math.Pow(S1.M.Z - C1.Center.Z, 2));

            // Kürenin yarıçapı ile silindirin yarıçapının toplamı
            double sumOfRadii = S1.R + C1.Radius;

            // Mesafe, yarıçapların toplamından küçük veya eşitse ve ayrıca kürenin merkezi silindirin yüksekliği
            // ile silindirin taban düzleminin arasındaysa çarpışma var.
            if (distance <= sumOfRadii && Math.Abs(S1.M.Z - C1.Center.Z) <= C1.Height / 2)
                return true;
            else
                return false;
        }
        public static bool SphereQuadrangular(Sphere S1, Quadrangular Q1)
        {
            double distanceX = Math.Abs(S1.M.X - Q1.Center.X);
            double distanceY = Math.Abs(S1.M.Y - Q1.Center.Y);
            double distanceZ = Math.Abs(S1.M.Z - Q1.Center.Z);

            // Kürenin x, y ve z eksenlerindeki mesafeleri sırasıyla hesaplanır
            double dx = Math.Max(distanceX - Q1.Width / 2, 0);
            double dy = Math.Max(distanceY - Q1.Height / 2, 0);
            double dz = Math.Max(distanceZ - Q1.Depth / 2, 0);

            // Kürenin merkezi ile dikdörtgen prizmanın içindeki en yakın nokta arasındaki mesafe
            double distanceSquared = dx * dx + dy * dy + dz * dz;

            // Kürenin yarıçapının karesi
            double radiusSquared = S1.R * S1.R;

            // Eğer kürenin merkezi, dikdörtgen prizmanın içindeki en yakın noktaya uzaklığı kürenin yarıçapından büyükse
            // küre dikdörtgen prizmayla çarpışmaz
            if (distanceSquared <= radiusSquared)
                return true;
            else return false;
        }
        public static bool QuadrangularQuadrangular(Quadrangular Q1, Quadrangular Q2)
        {
            double Q1MinX = Q1.Center.X - Q1.Width / 2;
            double Q1MaxX = Q1.Center.X + Q1.Width / 2;
            double Q1MinY = Q1.Center.Y - Q1.Height / 2;
            double Q1MaxY = Q1.Center.Y + Q1.Height / 2;
            double Q1MinZ = Q1.Center.Z - Q1.Depth / 2;
            double Q1MaxZ = Q1.Center.Z + Q1.Depth / 2;

            double Q2MinX = Q2.Center.X - Q2.Width / 2;
            double Q2MaxX = Q2.Center.X + Q2.Width / 2;
            double Q2MinY = Q2.Center.Y - Q2.Height / 2;
            double Q2MaxY = Q2.Center.Y + Q2.Height / 2;
            double Q2MinZ = Q2.Center.Z - Q2.Depth / 2;
            double Q2MaxZ = Q2.Center.Z + Q2.Depth / 2;

            // Çarpışma koşullarını kontrol edelim
            bool xOverlap = (Q1MinX <= Q2MaxX) && (Q1MaxX >= Q2MinX);
            bool yOverlap = (Q1MinY <= Q2MaxY) && (Q1MaxY >= Q2MinY);
            bool zOverlap = (Q1MinZ <= Q2MaxZ) && (Q1MaxZ >= Q2MinZ);

            // Eğer herhangi bir eksende çarpışma varsa, iki dikdörtgen prizma çarpışmıştır
            if (xOverlap && yOverlap && zOverlap)
                return true;
            else return false;
        }
        public static bool RectangleCircle(Rectangle R1, Circle C)
        {
            int dx = C.M.X - Math.Max(R1.M.X, Math.Min(R1.M.X, R1.Height));
            int dy = C.M.Y - Math.Max(R1.M.Y, Math.Min(R1.M.Y, R1.Width));
            if ((dx * dx + dy * dy) <= (C.R * C.R))
            {
                return true;
            }
            return false;
        }
        public static bool SurfaceCylinder(Surface S, Cylinder C)
        {
            double closestX = Math.Max(S.M.X, Math.Min(C.Center.X, S.M.X + S.Height));
            double closestY = Math.Max(S.M.Y, Math.Min(C.Center.Y, S.M.Y + S.Width));
            double closestZ = Math.Max(S.M.Z, Math.Min(C.Center.Z, S.M.Z + S.Depth));

            double distance = (double)Math.Sqrt(Math.Pow(C.Center.X - closestX, 2) + Math.Pow(C.Center.Y - closestY, 2));

            if (distance <= C.Radius && closestZ <= C.Center.Z + C.Height && closestZ >= C.Center.Z)

            {
                return true;
            }
            return false;
        }
        public static bool SurfaceSphere(Surface S, Sphere S1)
        {
            double closestX = Math.Max(S.M.X, Math.Min(S.M.X, S.M.X + S.Width));
            double closestY = Math.Max(S.M.Y, Math.Min(S.M.Y, S.M.Y + S.Height));
            double closestZ = Math.Max(S.M.Z, Math.Min(S.M.Z, S.M.Z + S.Depth));
            double distance = (double)Math.Sqrt(Math.Pow(S1.M.X - closestX, 2) + Math.Pow(S1.M.Y - closestY, 2) + Math.Pow(S1.M.X - closestZ, 2));

            if (distance <= S1.R)

            {
                return true;
            }
            return false;
        }
        public static bool SurfaceQuadrangular(Surface S, Quadrangular Q)
        {
            int closestX = Math.Max(S.M.X, Math.Min(Q.Center.X, S.M.X + S.Width));
            int closestY = Math.Max(S.M.Y, Math.Min(Q.Center.Y, S.M.Y + S.Height));
            int closestZ = Math.Max(S.M.Z, Math.Min(Q.Center.Z, S.M.Z + S.Depth));
            int distancex = closestX - Q.Center.X;
            int distancey = closestY - Q.Center.Y;
            int distancez = closestZ - Q.Center.Z;
            double distance = (double)Math.Sqrt(Math.Pow(distancex, 2) + Math.Pow(distancey, 2) + Math.Pow(distancez, 2));
            if (distance <= Q.Height || distance <= Q.Width || distance <= Q.Depth)
            {
                return true;
            }
            else return false;
        }
    }
}
