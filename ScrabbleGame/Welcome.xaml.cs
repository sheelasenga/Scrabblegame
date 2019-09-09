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
using System.Windows.Shapes;

namespace ScrabbleGame
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sw = new MainWindow();
            sw.Show();
            this.Close();

        }

        private void Abtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Fbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {string[] words = new string[] { "perfect", "country", "pumpkin", "freedom", "journey", "amazing" };
            Random r = new Random();
            // string rand = new string (words.ToString(). OrderBy(s => (r.Next(2)% 2 ) == 0).ToArray());
           
            MessageBox.Show(words[r.Next(0, words.Length)]);
            


        }
        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           // string words = wordlbl.rand;

        }
    }
}




