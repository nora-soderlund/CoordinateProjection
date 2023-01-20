using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateProjection {
    public class ScreenPoint {
        public int Left;
        public int Top;

        public ScreenPoint() { }

        public ScreenPoint(int left, int top) {
            Left = left;
            Top = top;
        }
    }
}
