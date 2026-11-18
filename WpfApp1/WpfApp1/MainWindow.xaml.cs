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
        private bool isVRSDraggable = false;
        private double codePart = 0.75f;

        private double currentWindowWidth = 800;
        private double currentWindowHeight = 450;

        public MainWindow()
        {
            InitializeComponent();

        }
        private void Mouse_Moved(object sender, MouseEventArgs e)
        {
            Point currentPos = e.GetPosition(this);
            if (isVRSDraggable)
            {
                codePart = 1 - (currentWindowHeight - currentPos.Y) / currentWindowHeight;
                if (codePart > 0.95d) codePart = 0.95d;
                if (codePart < 0.05d) codePart = 0.05d;
                codeArea.Height = currentWindowHeight * codePart;
                outputArea.Height = currentWindowHeight * 1 - codePart;
                /*switch (codePart) 
                {
                    case > 0.95d:
                        codePart = 0.95d; break;
                    case < 0.05d:
                        codePart = 0.05d; break;
                    default: break;
                } */

            }
        }
        private void VerticalRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            verticalStretchRectangle.CaptureMouse();
            isVRSDraggable = true;
        }
        private void VerticalRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            verticalStretchRectangle.ReleaseMouseCapture();
            isVRSDraggable = false;
        }

        /*public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Key pressedKey = e.Key;
            Console.WriteLine(pressedKey.ToString());

        } */

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            currentWindowWidth = e.NewSize.Width;
            currentWindowHeight = e.NewSize.Height - 10;

            codeArea.Height = currentWindowHeight * codePart;
            outputArea.Height = currentWindowHeight * 1-codePart;
        }
    }
}
