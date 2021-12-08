using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace HanoiB
{
    class Disk
    {
        public Disk disk;
        public int Width;
        public readonly int Height;
        public readonly Brush Color;
        public int X;
        public int Y;
        public Disk(int x, int y, int width, int height, Brush color)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Color = color;
            disk = disk;
        }
        public void MoveTo(Tower tower)
        {
            tower.Disks.Push(this.disk);
        }
    }
}
