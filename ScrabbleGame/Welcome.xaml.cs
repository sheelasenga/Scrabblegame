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
        string[] words;
        public string currentword;
        public Welcome()
        {
            InitializeComponent();

            words = System.IO.File.ReadAllLines("Words.txt");
           
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
        {
           
            // string[] words = { "perfect", "country", "pumpkin", "freedom", "journey", "amazing" , "good"};
            
           Random rnd = new Random();
            string newword = words[rnd.Next(words.Length)];
            char[] wordChars = newword.ToCharArray();
            int len = wordChars.Length;
            string random = new string(words.ToString().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());

            // display the generated word in textbox
            wordtxt.Text = words[rnd.Next(words.Length)];
           //wordtxt.Text = words[random.Next(0,words.Count)];
            lengthTxt.Text = len.ToString();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //   string[] words = { "perfect", "country", "pumpkin", "freedom", "journey", "amazing", "good" };
            //Random rnd = new Random();
            //string newword = words[rnd.Next(words.Length)];
            

          
           


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }
        private void setWord(int length)
        {
            for (int i = 0; i < length; i++)
            {
                wordtxt.AppendText("_ ");
            }
        }
        private void AddButtons()

            {
            for (int i = (int) 'A'; i <= (int)'Z'; i++)
            {
                Button b = new Button();
                b.DataContext = ((char)i).ToString();
               
            }
            }
        }
    }





