using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFilters
{
    class MorphologyFilter : MatrixFilter
    {
        protected bool[,] structuringElement;
        protected int elementSize;

        //с заданным структурным элементом
        public MorphologyFilter(bool[,] element)
        {
            structuringElement = element;
            elementSize = element.GetLength(0) / 2;
        }

        //по умолчанию (крест)
        public MorphologyFilter() : this(GetStructuringElement(3, "cross")) { }

        //другая фигура
        public static bool[,] GetStructuringElement(int size, string type = "cross")
        {
            bool[,] element = new bool[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (type == "square")
                        element[i, j] = true;
                    else if (type == "cross")
                        element[i, j] = (i == size / 2 || j == size / 2);
                }
            }
            return element;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return Color.Black;
        }
    }
}
