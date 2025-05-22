using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Figuras
{
    internal class Star2
    {
        private float mSize;
        private float mAngle = 0;  // Ángulo de rotación en grados
        private float mTranslateX = 0;  // Desplazamiento horizontal
        private float mTranslateY = 0;  // Desplazamiento vertical
        private const float SF = 40f;
        private const float MOVE_STEP = 5f;

        public Star2(float size = 5.0f)
        {
            mSize = size;
        }

        public void Rotate(float degrees)
        {
            // Actualizar el ángulo de rotación
            mAngle += degrees;

            if (mAngle >= 360)
                mAngle -= 360;
            else if (mAngle < 0)
                mAngle += 360;
        }

        public void MoveUp()
        {
            mTranslateY -= MOVE_STEP;
        }

        public void MoveDown()
        {
            mTranslateY += MOVE_STEP;
        }

        public void MoveLeft()
        {
            mTranslateX -= MOVE_STEP;
        }

        public void MoveRight()
        {
            mTranslateX += MOVE_STEP;
        }

        public void PlotShape(PaintEventArgs e, PictureBox picCanvas)
        {
            Graphics graphics = e.Graphics;
            Matrix originalMatrix = graphics.Transform.Clone();

            float scaledSize = mSize * SF;

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            graphics.TranslateTransform(centerX + mTranslateX, centerY + mTranslateY);
            graphics.RotateTransform(mAngle);

            PointF[] starPoints = CalculateStarPoints(scaledSize);

            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                graphics.DrawPolygon(pen, starPoints);

                PointF center = new PointF(0, 0);
                for (int i = 0; i < starPoints.Length; i++)
                {
                    graphics.DrawLine(pen, center, starPoints[i]);
                }
            }

            graphics.Transform = originalMatrix;
        }

        private PointF[] CalculateStarPoints(float size)
        {
            PointF[] points = new PointF[10];
            float angleStep = 360.0f / 5;
            float outerRadius = size / 2;
            float innerRadius = outerRadius * 0.382f;

            for (int i = 0; i < 5; i++)
            {
                // Convertir ángulos a radianes
                double outerAngle = (i * angleStep - 90) * Math.PI / 180; // -90 para que la primera punta esté arriba
                double innerAngle = ((i * angleStep + angleStep / 2) - 90) * Math.PI / 180;

                // Calcular punta exterior
                float x1 = (float)(outerRadius * Math.Cos(outerAngle));
                float y1 = (float)(outerRadius * Math.Sin(outerAngle));

                // Calcular punta interior
                float x2 = (float)(innerRadius * Math.Cos(innerAngle));
                float y2 = (float)(innerRadius * Math.Sin(innerAngle));

                // Intercalar puntas exteriores e interiores
                points[i * 2] = new PointF(x1, y1); // Punta exterior
                points[i * 2 + 1] = new PointF(x2, y2); // Punta interior
            }

            return points;
        }
    }
}