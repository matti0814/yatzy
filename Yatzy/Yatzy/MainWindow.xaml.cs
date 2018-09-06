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

        

        public List<Dice> Kasta (int amount)
        {
            
            Random side = new Random();
            List<Dice> diceList = new List<Dice>();           
            for (int i = 0; i < amount; i++)

            {               
                diceList.Add(new Dice());               
            }
            foreach (var item in diceList)
            {
                item.Side = side.Next(1, 7);
            }
            return diceList;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kasta(6);           
        }
    }
}
