using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class Sharpness : MatrixFilter
    {
        public Sharpness()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            int counter = 0;
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (counter % 2 == 1)
                        kernel[i, j] = -1.0f;
                    if (counter % 2 == 0 && counter != 4)
                        kernel[i, j] = 0.0f;
                    if (counter % 2 == 0 && counter == 4)
                        kernel[i, j] = 5.0f;
                    counter++;
                }
            }
        }
    }
}
