namespace KristofferStrube.Blazor.SVGEditor;

public class Box
{
    public double X { get; set; }

    public double Y { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

   public double CenterX { get => X + Width / 2.0; }
   public double CenterY { get => Y + Height / 2.0; }

	public Box Clone()
   {
       return new Box()
       {
           X = this.X,
           Y = this.Y,
           Width = this.Width,
           Height = this.Height
       };
	}
}
