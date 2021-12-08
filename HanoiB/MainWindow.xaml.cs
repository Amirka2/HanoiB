using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HanoiB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*static string text = "";*/
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Tower[] towers = Logic.CreateLogic();
            Draw(towers);

            /*const int Height = 100;
            SolutionHanoibns(K, 'A', 'B', 'C');
            TextBlock1.Text = text;
            DrawTowers(80, 250, Height);
            Line[] disks = DrawDisks(80, 250);
            MoveDisks(disks);*/
        }
        
        private void Draw(Tower[] towers)
        {
            foreach(var tower in towers)
            {
                DrawTower(tower);
                DrawDisks(tower.Disks);
            }
        }
        private void DrawTower(Tower tower)
        {
            DrawLine(tower.X, tower.Y);
            DrawLine(tower.X, tower.Y, tower.Height);
        }
        private void DrawDisks(Stack<Disk> disks)
        {
            if (disks != null)
            {
                foreach (var disk in disks)
                {
                    DrawDisk(disk);
                }
            }
        }
        private void DrawDisk(Disk disk)
        {
            Line l = new Line();
            l.Stroke = disk.Color;
            l.StrokeThickness = 10;
            l.X1 = disk.X;
            l.Y1 = disk.Y;
            l.X2 = disk.X + disk.Width;
            l.Y2 = disk.Y;
            Canvas1.Children.Add(l);
        }
        private void DrawLine(int x, int y)
        {
            Line towerLine = new Line();
            towerLine.Stroke = Brushes.Black;
            towerLine.StrokeThickness = 10;
            towerLine.X1 = x;
            towerLine.Y1 = y;
            towerLine.X2 = x + 100;
            towerLine.Y2 = y;
            Canvas1.Children.Add(towerLine);
        }
        private void DrawLine(int x, int y, int height)
        {
            Line towerLine = new Line();
            towerLine.Stroke = Brushes.Black;
            towerLine.StrokeThickness = 5;
            towerLine.X1 = x + 50;
            towerLine.Y1 = y;
            towerLine.X2 = x + 50;
            towerLine.Y2 = y - height;
            Canvas1.Children.Add(towerLine);
        }




        /*private static void SolutionHanoibns(int k, char a, char b, char c)
        {
            if (k == 1) 
                text += $"\nПереложить диск из {a} в {b}";
            else
            {
                SolutionHanoibns(k - 1, a, c, b);
                text += $"\nПереложить диск из {a} в {b}";
                SolutionHanoibns(k - 1, c, b, a);
            }
        }
        private void MoveDisks(int k, Line[] disks)
        {
            if (k == 1) MoveDiskAnimation(disks, );
            else
            {
                MoveDisks(k - 1, disks);
                MoveDiskAnimation(disks[0], disks[1]);
                MoveDisks(k - 1, disks);
            }
        }
        private void MoveDiskAnimation()
        {

        }
        private void DrawTowers(int x, int y ,int height)
        {
            DrawTower(x, y, height);
            DrawTower(x + 150, y, height);
            DrawTower(x + 300, y, height);
        }
        private Line[] DrawDisks(int x, int y)
        {
            Line[] disks = new Line[K];
            for(int i = 0; i < K; i++)
            {
                disks[i] = DrawDisk(x, y, i);
            }
            return disks;
        }
        private Line DrawDisk(int x, int y, int index)
        {
            Line towerLine = new Line();
            towerLine.Stroke = GetRNDColor();
            towerLine.StrokeThickness = 10;
            towerLine.X1 = x + index * 10;
            towerLine.Y1 = y - index * 10 - 10;
            towerLine.X2 = x + 100 - index * 10;
            towerLine.Y2 = y - index * 10 - 10;
            Canvas1.Children.Add(towerLine);
            return towerLine;
        }
        private void DrawLine(int x, int y)
        {
            Line towerLine = new Line();
            towerLine.Stroke = Brushes.Black;
            towerLine.StrokeThickness = 10;
            towerLine.X1 = x;
            towerLine.Y1 = y;
            towerLine.X2 = x + 100;
            towerLine.Y2 = y;
            Canvas1.Children.Add(towerLine);
        }
        private void DrawLine(int x, int y, int height)
        {
            Line towerLine = new Line();
            towerLine.Stroke = Brushes.Black;
            towerLine.StrokeThickness = 5;
            towerLine.X1 = x + 50;
            towerLine.Y1 = y;
            towerLine.X2 = x + 50;
            towerLine.Y2 = y - height;
            Canvas1.Children.Add(towerLine);
        }
        private void DrawTower(int x, int y, int height)
        {
            DrawLine(x, y);
            DrawLine(x, y, height);
        }
        private Brush GetRNDColor()
        {
            Brush color;
            var rnd = new Random();
            var x = rnd.Next(0, 4);
            switch (x)
            {
                case 0: color = Brushes.Green; break;
                case 1: color = Brushes.Red; break;
                case 2: color = Brushes.Blue; break;
                case 3: color = Brushes.Yellow; break;
                case 4: color = Brushes.Pink; break;
                default: color = Brushes.Violet; break;
            }
            return color;
        }
        */
    }
}
