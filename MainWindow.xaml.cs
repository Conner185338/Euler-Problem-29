/*
 * Conner Warboys
 * Project Euler Problem 29
 * May 12th, 2019
 * ICS3U
*/
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

namespace _185338DistinctPowers
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
       
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            List<double> set = new List<double>();
            double Terms = 0;
            double sum = 0;
            for (int a = 2; a <= 100; a++)
            {
                for(int b = 2; b <= 100; b++)
                {
                    sum = Math.Pow(a, b);

                    if (!set.Contains(sum))
                    {
                        set.Add(sum);
                        Terms += 1;
                    }
                }
                lblOuput.Content = Terms;
            }
        }
    }
}
