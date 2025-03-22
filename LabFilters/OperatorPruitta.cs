using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class OperatorPruitta : MatrixFilter
    {
        public OperatorPruitta()
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
                        kernel[i, j] = -1;
                    }
                    if (i == 2)
                    {
                        kernel[i, j] = 1;
                    }
                }
            }
        }
    }
}
