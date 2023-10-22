using Spectre.Console;
using H.World.Models;
using Object = H.World.Models.Object;

namespace H.World.Console;

public static class CanvasExtensions
{
    public static void DrawPlanetarySystem(
        this Canvas canvas,
        PlanetarySystem planetarySystem)
    {
        canvas.DrawSpace();

        foreach (var @object in planetarySystem.Objects)
        {
            canvas.DrawObject(@object);
        }
    }
    
    private static void DrawSpace(this Canvas canvas)
    {
        for(var x = 0; x < canvas.Width; x++)
        {
            for(var y = 0; y < canvas.Height; y++)
            {
                canvas.SetPixel(x, y, Color.White);
            }
        }
    }
    
    private static void DrawObject(this Canvas canvas, Object @object)
    {
        var x = @object.X.ToInt();
        var y = @object.Y.ToInt();

        canvas.SafeDrawPixel(x, y, @object.Color);
        if (@object.Radius > 1.5)
        {
            canvas.SafeDrawPixel(x - 1, y, @object.Color);
            canvas.SafeDrawPixel(x + 1, y, @object.Color);
            canvas.SafeDrawPixel(x, y - 1, @object.Color);
            canvas.SafeDrawPixel(x, y + 1, @object.Color);
        }
    }
    
    private static void SafeDrawPixel(this Canvas canvas, int x, int y, Color color)
    {
        if (x >= 0 && x < canvas.Width &&
            y >= 0 && y < canvas.Height)
        {
            canvas.SetPixel(x, y, color);
        }
    }
    
    private static int ToInt(this double value)
    {
        return (int)Math.Round(value);
    }
}