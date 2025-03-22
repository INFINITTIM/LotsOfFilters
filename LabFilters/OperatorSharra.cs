using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class OperatorSharra : MatrixFilter
    {
        public OperatorSharra()
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
                            kernel[i, j] = 10;
                        if (j != 1)
                            kernel[i, j] = 3;
                    }
                    if (i == 2)
                    {
                        if (j == 1)
                            kernel[i, j] = -10;
                        if (j != 1)
                            kernel[i, j] = -3;
                    }
                }
            }
        }
    }
}
