# CoordinateProjection
An itsy-bitsy-teenie-weenie-tiny package to project coordinates into screen points where the map boundaries are already defined.

## Example

```csharp
public partial class MyForm : Form {
    private readonly CoordinateBounds staticMapBounds = new () {
        East = 153.32191748046876f,
        North = -33.50848555239759f,
        South = -35.27618036073599f,
        West = 147.96608251953126f
    };

    private List<Coordinate> Coordinates = new List<Coordinate>() {
        new (-33.86883898636453f, 151.20914864607147f), // Sydney
        new (-34.82777280506466f, 148.90830590294317f), // Yass
        new (-34.66920061357916f, 150.852685799046f), // Kiama
        new (-34.424845374813025f, 150.89311318548945f) // Wollongong
    };

    public MyForm() {
        InitializeComponent();

        ScreenProjection screenProjection = new(staticMap.Width, staticMap.Height, staticMapBounds);

        Image image = new Bitmap(staticMap.Width, staticMap.Height);

        using (var graphics = Graphics.FromImage(image)) {
            graphics.DrawImage(Resources.Resources.static_map, new Rectangle(0, 0, staticMap.Width, staticMap.Height));

            foreach (Coordinate coordinate in Coordinates) {
                ScreenPoint point = screenProjection.GetScreenPoint(coordinate);

                graphics.DrawImage(Resources.Resources.pin, new Rectangle(point.Left, point.Top - 20, 20, 20));
            }
        }

        staticMap.Image = image;
    }
}
```

![image](https://user-images.githubusercontent.com/78360666/213744975-d094deea-4690-45f5-b151-e193a717fbd7.png)
