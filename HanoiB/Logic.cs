using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace HanoiB
{
    class Logic
    {
        const int K = 3;
        public static Tower[] CreateLogic()
        {
            int x = 0, y = 150;                             // левая точка основания левой башни
            Tower[] towers = CreateTowers(x, y);
            towers[0].CreateDisks();
            return towers;
        }
        
        private static Tower[] CreateTowers(int x, int y)
        {
            Tower[] towers = new Tower[3];
            towers[0] = new Tower(x, y);
            towers[1] = new Tower(x + 150, y);
            towers[2] = new Tower(x + 300, y);
            return towers;
        }
    }
}
