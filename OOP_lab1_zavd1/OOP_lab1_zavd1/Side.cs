using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1_zavd1
{
    internal class Side
    {
        /*private int length;
        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("The side may be positive");
                }
                else
                {
                    length = value;
                }
            }
        }
        private int width;
        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("The side may be positive");
                }
                else
                {
                    width = value;
                }
            }
        }*/
        int[] sides = new int[2];
        public Side(int length, int width)
        {
            sides[0] = length;
            sides[1] = width;
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return sides[0];
                else if (index == 1)
                    return sides[1];
                else
                    throw new IndexOutOfRangeException("Bad index");
            }
            set
            {
                if (index == 0)
                    sides[0] = value;
                else if (index == 1)
                    sides[1] = value;
                else
                    throw new IndexOutOfRangeException("Bad index");
                if (value <= 0)
                {
                    throw new Exception("The side may be positive");
                }
            }
        }
        public int Perimeter()
        {
            return checked(2 * (sides[0] + sides[1]));
        }

        public int Area()
        {
            return checked(sides[0] * sides[1]);
        }
    }
}
