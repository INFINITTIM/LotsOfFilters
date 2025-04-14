using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class RandomFilter : Filters
    {
        private Filters[] sectorFilters;
        private Random random;

        public RandomFilter()
        {
            random = new Random();
            sectorFilters = new Filters[4]; 

            Filters[] allFilters = new Filters[]
            {
                new InvertFilter(),
                new BlurFilter(),
                new GaussianFilter(),
                new GrayScaleFilter(),
                new Sepia(),
                new Brightness(),
                new SobelFilter(),
                new Sharpness(),
                new Embossing(),
                new MedianFilter(),
                new MotionBlur(),
                new SFSharpness(),
                new OperatorSharra(),
                new OperatorPruitta(),
                new PerfectReflector(),
                new Glass(),
                new Left(),
                new Right(),
                new RotateRight(),
                new RotateLeft(),
                new WavesG(),
                new WavesV(),
                new LuminousEdges(),
                new DilationFilter(),
                new Erosion(),
                new Opening(),
                new Line(),
                new GrayWorld(),
                new Closing(),
                new TopHat()
            };

            for (int i = 0; i < 4; i++)
            {
                sectorFilters[i] = allFilters[random.Next(allFilters.Length)];
            }
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int centerX = sourceImage.Width / 2;
            int centerY = sourceImage.Height / 2;

            double dx = x - centerX;
            double dy = y - centerY;

            int sector;

            if (dy < dx && dy < -dx)
            {
                sector = 0;
            }
            else if (dy < dx && dy >= -dx)
            {
                sector = 1;
            }
            else if (dy >= dx && dy >= -dx)
            {
                sector = 2;
            }
            else
            {
                sector = 3;
            }

            return sectorFilters[sector].ApplyFilterToPixel(sourceImage, x, y);
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int x = 0; x < sourceImage.Width; x++)
            {
                worker.ReportProgress((int)((float)x / sourceImage.Width * 100));
                if (worker.CancellationPending) return null;

                for (int y = 0; y < sourceImage.Height; y++)
                {
                    resultImage.SetPixel(x, y, calculateNewPixelColor(sourceImage, x, y));
                }
            }
            return resultImage;
        }
    }
}
