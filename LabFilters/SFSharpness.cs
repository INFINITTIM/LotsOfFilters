using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    internal class SFSharpness : MatrixFilter
    {
        public SFSharpness()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            int counter = 0;
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    if (counter == 4)
                        kernel[i, j] = 9.0f;
                    else
                        kernel[i, j] = -1.0f;
                    counter++;
                }
            }
        }
    }
}
