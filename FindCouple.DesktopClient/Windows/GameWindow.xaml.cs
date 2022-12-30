using FindCouple.Models;
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
using System.Windows.Shapes;

namespace FindCouple.DesktopClient.Windows
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public Game Game;
        public int PixelsCellSize;
        public int FieldSize;
        public GameWindow(int fieldSize)
        {
            InitializeComponent();
            Game = new Game(fieldSize);
            FieldSize = fieldSize;
            PixelsCellSize = (int)(800 / fieldSize);
            DrawField();
        }

        public void DrawField()
        {
            for (var x = 0; x < FieldSize; x++)
            {
                for (var y = 0; y < FieldSize; y++)
                {
                    DrawCell(x, y);
                }
            }
        }

        public void DrawCell(int x, int y)
        {
            var bitmapImage = new BitmapImage();
            if (Game.Field.cells[x,y] == null)
            {
                bitmapImage = new BitmapImage(new Uri(@"/FindCouple.DesktopClient;component/images/empty.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                if (!Game.Field.cells[x, y].IsOpen && !Game.Field.cells[x, y].IsSolved)
                {
                    bitmapImage = new BitmapImage(new Uri(@"/FindCouple.DesktopClient;component/images/closed.jpg", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    bitmapImage = new BitmapImage(new Uri(GetUnitImage(Game.Field.cells[x, y].Unit), UriKind.RelativeOrAbsolute));
                }
            }
            System.Windows.Controls.Image image = new System.Windows.Controls.Image();
            image.Width = PixelsCellSize;
            image.Height = PixelsCellSize;
            image.Source = bitmapImage;
            Canvas.SetLeft(image, PixelsCellSize * (x));
            Canvas.SetTop(image, PixelsCellSize * (y));
            _field.Children.Add(image);
        }

        public string GetUnitImage(Unit unit)
        {
            return @"/FindCouple.DesktopClient;component/images/empty.jpg";
        }
    }
}
