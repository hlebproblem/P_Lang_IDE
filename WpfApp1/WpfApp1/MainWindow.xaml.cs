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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDraggable = false;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void VerticalRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggable)
            {
                Console.WriteLine("qwe");
            }
        }
        private void VerticalRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggable = true;
        }
        private void VerticalRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggable = false;
        }

        /*public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Key pressedKey = e.Key;
            Console.WriteLine(pressedKey.ToString());

        } */

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double currentWidth = e.NewSize.Width;
            double currentHeight = e.NewSize.Height - 5;

            codeArea.Height = currentHeight * 0.75;
            outputArea.Height = currentHeight * 0.25;
        }
    }
}
