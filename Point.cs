using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFivePrototypes
{
    class Point(int x = 0, int y = 0)
    {
        public int XCord { get; set; } = x;
        public int YCord { get; set; } = y;
    }
}
