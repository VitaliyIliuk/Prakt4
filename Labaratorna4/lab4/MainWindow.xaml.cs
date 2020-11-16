using PointLibrary;
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

namespace lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private byte r()
        {
            var rand = new Random();

            return (byte)(rand.Next()%200);
        }
        private void print_Click(object sender, RoutedEventArgs e)
        {
            ShapePoint[] shapePoints = new ShapePoint[20];
            for (int i = 0; i < 20; i++)
            {
                switch (r() % 5)
                {
                    case 0:
                        ShapePoint point = new MyPoint(r(), r());
                        shapePoints[i] = point;
                        break;
                    case 1:
                        ShapePoint Line = new MyLine(r(), r(), r(), r());
                        shapePoints[i] = Line;
                        break;
                    case 2:
                        ShapePoint quadrangle = new MyQuadrangle(r(), r(), r(), r());
                        shapePoints[i] = (quadrangle);
                        break;
                    case 3:
                        ShapePoint circle = new MyСircle(r(), r(), r(), r());
                        shapePoints[i] = (circle);
                        break;
                    case 4:
                        ShapePoint ellipse = new MyEllipse(r(), r(), r(), r(), r(), r());
                        shapePoints[i] = (ellipse);
                        break;
                    default:
                        ShapePoint ee = new MyQuadrangle(r(), r(), r(), r());
                        shapePoints[i] = (ee);
                        break;
                }

            }
            for (int i = 0; i < 20; i++)
                shapePoints[i].drow(grid1);
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            grid1.Children.Clear();
        }
    }
}
