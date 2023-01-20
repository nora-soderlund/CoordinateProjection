using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateProjection {
    public class CoordinateBounds {
        public float North;
        public float East;
        public float South;
        public float West;

        public CoordinateBounds() {}

        public CoordinateBounds(float north, float east, float south, float west) {
            North = north;
            East = east;
            South = south;
            West = west;
        }

        public CoordinateBounds(Coordinate start, Coordinate end) {
            North = start.Latitude;
            East = end.Longitude;
            South = end.Latitude;
            West = start.Longitude;
        }

        public Coordinate GetCoordinateOffset(Coordinate coordinate) {
            return new () {
                Latitude = North - coordinate.Latitude,
                Longitude = coordinate.Longitude - West
            };
        }

        public Coordinate GetCoordinateDifference() {
            return new () {
                Latitude = North - South,
                Longitude = East - West
            };
        }
    }
}
