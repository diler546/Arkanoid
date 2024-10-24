using System.Drawing;

namespace Arkanoid.Contracts
{
    /// <summary>
    /// Представляет блок в игре с его положением, размерами и цветом.
    /// </summary>
    public class Block
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsDestroyed { get; set; }
        public Color Color { get; set; }
    }
}
