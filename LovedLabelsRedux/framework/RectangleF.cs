namespace LovedLabels.Framework
{
    internal class RectangleF
    {
        public float X { get; }

        public float Y { get; }

        public float Width { get; }

        public float Height { get; }

        public RectangleF(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public bool Contains(float x, float y)
        {
            return
                x >= X
                && x < X + Width
                && y >= Y
                && y < Y + Height;
        }
    }
}