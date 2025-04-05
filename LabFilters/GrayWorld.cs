using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class GrayWorld : Filters
    {
        private float avgR, avgG, avgB, avgGray;

        public override Bitmap processImage(Bitmap sourceImage, System.ComponentModel.BackgroundWorker worker)
        {
            long sumR = 0, sumG = 0, sumB = 0;
            int pixelCount = sourceImage.Width * sourceImage.Height;

            for (int x = 0; x < sourceImage.Width; x++)
            {
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    sumR += color.R;
                    sumG += color.G;
                    sumB += color.B;
                }
            }

            avgR = sumR / pixelCount;
            avgG = sumG / pixelCount;
            avgB = sumB / pixelCount;

            avgGray = (avgR + avgG + avgB) / 3.0f;

            return base.processImage(sourceImage, worker);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color color = sourceImage.GetPixel(x, y);

            float coefR = avgGray / Math.Max(avgR, 1);
            float coefG = avgGray / Math.Max(avgG, 1);
            float coefB = avgGray / Math.Max(avgB, 1);

            int r = Clamp((int)(color.R * coefR), 0, 255);
            int g = Clamp((int)(color.G * coefG), 0, 255);
            int b = Clamp((int)(color.B * coefB), 0, 255);

            return Color.FromArgb(r, g, b);
        }
    }
}
