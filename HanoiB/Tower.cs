using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace HanoiB
{
    class Tower
    {
        const int K = 3;
        public Stack<Disk> Disks { get; set; }
        public readonly int X, Y;
        public int Height = 100;
        public readonly int DisksX, DisksY;
        public Tower(int x, int y, Stack<Disk> disks)
        {
            this.Disks = disks;
            this.X = x;
            this.Y = y;
            DisksX = x + 5;
            DisksY = y - 10;
        }
        public Tower(int x, int y)
        {
            this.X = x;
            this.Y = y;
            DisksX = x + 5;
            DisksY = y - 10;
        }
        public void CreateDisks()
        {
            Stack<Disk> disks = new Stack<Disk>();
            Disk[] diskArr = new Disk[K];
            for (int i = 0; i < K; i++)
            {
                var x = DisksX + 5 * i;
                var y = DisksY - 10 * i;
                var width = 100 - 10 * i;
                var height = 10;
                diskArr[i] = new Disk(x, y, width, height, Brushes.Green);
                disks.Push(diskArr[i]);
            }
            this.Disks = disks;
        }
    }
}
