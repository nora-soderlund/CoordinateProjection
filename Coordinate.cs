using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateProjection {
    public class Coordinate {
        public float Latitude;
        public float Longitude;

        public Coordinate() { }

        public Coordinate(float latitude, float longitude) {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
