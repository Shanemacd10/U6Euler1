//U6Euler1
//Shane Macdonald
//program calculates the total of all multipuls of 3 and 5 under 1000
//june 19, 2018
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

namespace U6Euler1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int total;
        public MainWindow()
        {
            InitializeComponent();
            for( int i =1; i <=1000; i++)
            {
                if(i % 3 ==0)
                {
                    total += i;
                }
                else if(i%5==0)
                {
                    total += i;
                }
            }
            MessageBox.Show(total.ToString());
        }
    }
}
