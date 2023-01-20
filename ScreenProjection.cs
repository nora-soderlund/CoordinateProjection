namespace CoordinateProjection {
    public class ScreenProjection {
        public static ScreenPoint GetScreenPointInBounds(int width, int height, CoordinateBounds coordinateBounds, Coordinate coordinate) {
            Coordinate staticMapDifference = coordinateBounds.GetCoordinateDifference();
            Coordinate sydneyOffset = coordinateBounds.GetCoordinateOffset(coordinate);

            float widthPerLongitude = width / staticMapDifference.Longitude;
            float heightPerLatitude = height / staticMapDifference.Latitude;

            int left = (int)(widthPerLongitude * sydneyOffset.Longitude);
            int top = (int)(heightPerLatitude * sydneyOffset.Latitude);

            return new ScreenPoint(left, top);
        }

        private int Width;
        private int Height;

        private CoordinateBounds CoordinateBounds;

        public ScreenProjection(int width, int height, CoordinateBounds coordinateBounds) {
            Width = width;
            Height = height;

            CoordinateBounds = coordinateBounds;
        }

        public ScreenPoint GetScreenPoint(Coordinate coordinate) {
            return GetScreenPointInBounds(Width, Height, CoordinateBounds, coordinate);
        }
    }
}
