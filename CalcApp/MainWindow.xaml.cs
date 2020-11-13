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

namespace CalcApp
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(e.Source is Button button)
            {
                _CalcText.Text += button.Content;
            }

            
        }

        private void Button_Rot(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
              //  _CalcText.Text == Math.Sqrt(_CalcText);
            }

        }

        private void Button_Calc(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
             // _CalcText.Text = _CalcText.Text.;
            }
        }

        private void Button_Del(object sender, RoutedEventArgs e)
        {
            _CalcText.Text = _CalcText.Text.Substring(0, _CalcText.Text.Length - 1);
        }
    }
}
