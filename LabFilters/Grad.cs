using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class Grad : Filters
    {
        protected Bitmap ErosionImage;
        protected Bitmap DilationImage;

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            Filters Erosion = new Erosion();
            Filters Dilation = new Dilation();

            ErosionImage = Erosion.processImage(sourceImage, worker);
            DilationImage = Dilation.processImage(sourceImage, worker);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));

                if (worker.CancellationPending) { return null; }

                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color colorErosion = ErosionImage.GetPixel(x, y);
            Color colorDilation = DilationImage.GetPixel(x, y);

            return Color.FromArgb(
                        Clamp(colorDilation.R - colorErosion.R, 0, 255),
                        Clamp(colorDilation.G - colorErosion.G, 0, 255),
                        Clamp(colorDilation.B - colorErosion.B, 0, 255));
        }
    }
}
