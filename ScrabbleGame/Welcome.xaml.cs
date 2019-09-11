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
        private int wrongGuess = 0;
        private string copyCurrent = "";

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

        private void generateBtn(object sender, RoutedEventArgs e)
        {
           // string[] words = { "perfect", "country", "pumpkin", "freedom", "journey", "amazing" , "good"};
            
            // random word generator
           Random rnd = new Random();
            string newword = words[rnd.Next(words.Length)];
            char[] wordChars = newword.ToCharArray();
            int len = wordChars.Length;
           string random = new string(words.ToString().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());

            // display the generated word in textbox
            wordtxt.Text = words[rnd.Next(words.Length)];
            // wordtxt.Text = words[random.Next(0,words.Count)];
            //wordtxt.Text = random;
           // MessageBox.Show(random);
            lengthTxt.Text = len.ToString();

            //hide the generated word using _
            for (int i = 0; i < wordChars.Length; i++)
            {
              WordLbl.Text += ("_ ");
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //   string[] words = { "perfect", "country", "pumpkin", "freedom", "journey", "amazing", "good" };
            //Random rnd = new Random();
            //string newword = words[rnd.Next(words.Length)];
            
        }

        private void Wordchoice()
        {
            wrongGuess = 0;
            int guessIndex = (new Random()).Next(words.Length);
            currentword = words[guessIndex];
            copyCurrent = "";
            for (int index = 0; index < currentword.Length; index++)
            {
                copyCurrent += "_";
            }
            displayword();
        }
        private void displayword()
        {
           
            for (int index = 0; index < currentword.Length; index++)
            {
                WordLbl.Text += copyCurrent.Substring(index, 1);
                WordLbl.Text += " ";
                
            }
        }
        private void GuessClick(object sender, RoutedEventArgs e)
        {
            wrongGuess++;
            if (wrongGuess > 7)
            {
                MessageBox.Show("wrong guess, You lost");
            }
            else
            {
                // MessageBox.Show("You won!");
            }

            Button choice = sender as Button;

            if (currentword.Equals(choice.Content))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = currentword.ToCharArray();
            }



        }

        private void Bbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }





