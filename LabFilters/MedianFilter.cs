﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class MedianFilter : Filters
    {
        private int radius;
        public MedianFilter(int radius = 3)
        {
            this.radius = radius;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            List<int> r = new List<int>();
            List<int> g = new List<int>();
            List<int> b = new List<int>();

            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    int newX = Clamp(x + i, 0, sourceImage.Width - 1);
                    int newY = Clamp(y + j, 0, sourceImage.Height - 1);
                    Color color = sourceImage.GetPixel(newX, newY);

                    r.Add(color.R);
                    g.Add(color.G);
                    b.Add(color.B);
                }
            }

            r.Sort();
            g.Sort();
            b.Sort();

            int medianIndex = r.Count / 2;

            return Color.FromArgb(r[medianIndex], g[medianIndex], b[medianIndex]);
        }
    }
}

