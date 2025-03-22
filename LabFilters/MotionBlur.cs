using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class MotionBlur  : MatrixFilter
    {
        public MotionBlur()
        {
            int sizeX = 5;
            int sizeY = 5;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (i == j)
                    {
                        kernel[i, j] = 1.0f / (float)(sizeX);
                    }
                }
            }
        }
    }
}
