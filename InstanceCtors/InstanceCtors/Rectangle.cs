using System;
using System.Collections.Generic;
using System.Text;

namespace InstanceCtors
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, int width, int height)
            : this (topLeft, new Point(topLeft.X + width, topLeft.Y + height), width, height)
        {
        }

        public Rectangle(Point topLeft, Point bottomRight)
            : this (topLeft, bottomRight, Math.Abs(bottomRight.X - topLeft.X), Math.Abs(bottomRight.Y - topLeft.Y))
        {
        }

        private Rectangle(Point topLeft, Point bottomRight, int width, int height)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
            Width = width;
            Height = height;
        }

        public Point TopLeft { get; }

        public Point BottomRight { get; }

        public int Width { get; }

        public int Height { get; }

        public void Print(string label)
        {
            Console.WriteLine($"{label}: Top-Left-X={this.TopLeft.X}, Top-Left-Y={this.TopLeft.Y}");
            Console.WriteLine($"{label}: Bottom-Right-X={this.BottomRight.X}, Bottom-Right-Y={this.BottomRight.Y}");
            Console.WriteLine($"{label}: Width={this.Width}, Height={this.Height}");
        }
    }
}
