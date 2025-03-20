using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class SobelFilter : MatrixFilter
    {
        public SobelFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (i == 1)
                        kernel[i, j] = 0;
                    if (i == 0)
                    {
                        if (j == 1)
                            kernel[i, j] = -2;
                        if (j != 1)
                            kernel[i, j] = -1;
                    }
                    if (i == 2)
                    {
                        if (j == 1)
                            kernel[i, j] = 2;
                        if (j != 1)
                            kernel[i, j] = 1;
                    }
                }
            }
        }
    }
}
