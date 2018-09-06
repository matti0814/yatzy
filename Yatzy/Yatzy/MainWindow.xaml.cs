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


namespace Yatzy
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

            YatzyEngine Engine = new YatzyEngine();
            List <Dice> dicesThrown = new List<Dice>();           
            int result = Engine.totalScoreFromThrow(Engine.Kasta(6));
            txtBl1.Text = result.ToString();          
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
