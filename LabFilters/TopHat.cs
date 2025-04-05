using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class TopHat : Filters
    {
        protected Bitmap closingImage;

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            Filters filter = new Closing();
            closingImage = filter.processImage(sourceImage, worker);

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
            Color color = sourceImage.GetPixel(x, y);
            Color color_closing = closingImage.GetPixel(x, y);

            return Color.FromArgb(
                        Clamp(color.R - color_closing.R, 0, 255),
                        Clamp(color.G - color_closing.G, 0, 255),
                        Clamp(color.B - color_closing.B, 0, 255));
        }
    }
}
