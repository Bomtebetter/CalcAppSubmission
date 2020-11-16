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
                var result = Math.Sqrt(Convert.ToDouble(_CalcText.Text));
                _CalcText.Text = Convert.ToString(result);
            }

        }
        
        private void Button_Calc(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                double result = 0;
                if (_CalcText.Text.Contains('/'))
                {
                    var number1 = Convert.ToDouble(_CalcText.Text.Split('/')[0]);
                    var number2 = Convert.ToDouble(_CalcText.Text.Split('/')[1]);
                    result =  number1 / number2;
                }
                if (_CalcText.Text.Contains('*'))
                {
                    var number1 = Convert.ToDouble(_CalcText.Text.Split('*')[0]);
                    var number2 = Convert.ToDouble(_CalcText.Text.Split('*')[1]);
                    result = number1 * number2;
                }
                if (_CalcText.Text.Contains('+'))
                {
                    var number1 = Convert.ToDouble(_CalcText.Text.Split('+')[0]);
                    var number2 = Convert.ToDouble(_CalcText.Text.Split('+')[1]);
                    result = number1 + number2;
                }
                if (_CalcText.Text.Contains('-'))
                {
                    var number1 = Convert.ToDouble(_CalcText.Text.Split('-')[0]);
                    var number2 = Convert.ToDouble(_CalcText.Text.Split('-')[1]);
                    result = number1 - number2;
                }

                _CalcText.Text = Convert.ToString(result);
            }
        }

        private void Button_Del(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                if (_CalcText.Text.Length > 0)
                {
                    _CalcText.Text = _CalcText.Text.Substring(0, _CalcText.Text.Length - 1);
                }
                else
                {

                }
            }
            
        }

        
    }
}
