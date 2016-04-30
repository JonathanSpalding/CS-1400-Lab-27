using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab27
{
    class Box
    {

        private int height;
        private int width;
        private int depth;

        public static int Length { get; internal set; }

        public Box(int p1, int p2, int p3)
        {
            height = p1;
            width = p2;
            depth = p3;
        }
        public int GetVolume()
        {
            return (height * width * depth);
        }
    }
}
