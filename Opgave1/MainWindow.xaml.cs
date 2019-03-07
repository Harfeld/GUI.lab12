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

namespace Opgave1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Color _color = Colors.Black;

        public MainWindow()
        {
            InitializeComponent();
            MouseDown += Drawing_Start;
            KeyDown += ColorSelection;
            MouseMove += Position;
        }

        void Position(object sender, MouseEventArgs e)
        {
            var pos = e.GetPosition(_canvas);
            xPos.Text = pos.X.ToString();
            yPos.Text = pos.Y.ToString();
        }

        void Drawing_Start(object sender, MouseEventArgs e)
        {

        }

        void ColorSelection(object sender, KeyEventArgs e)
        {

            colorDisp.Fill = new SolidColorBrush(_color);
        }
    }
}
