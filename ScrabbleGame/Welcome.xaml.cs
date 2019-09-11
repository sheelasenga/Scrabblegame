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
        private int guessCount = 0;
        List<char> finalwords;
        List<int> index;
        int count = 0;
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();

        public Welcome()
        {
            InitializeComponent();

            words = System.IO.File.ReadAllLines("Words.txt");
            finalwords = new List<char>();
            index = new List<int>();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow sw = new MainWindow();
            sw.Show();
            this.Close();
        }
        private void generateBtn(object sender, RoutedEventArgs e)
        {
            // random word generator
            Random rnd = new Random();
            string newword = words[rnd.Next(words.Length)];
            char[] wordChars = newword.ToCharArray();
            int len = wordChars.Length;
            string random = new string(words.ToString().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());
            int rnumber = rnd.Next(0, len);
            // display the generated word in textbox
            while (true)
            {
                if(!(index.Contains(rnumber)))
                {
                    index.Add(rnumber);
                    finalwords.Add(wordChars[rnumber]);
                    count++;
                    if(count > 6)
                    {
                        break;
                    }
                }
                rnumber = rnd.Next(0, len);
            }
            sb1 = new StringBuilder();
            foreach(char ch in finalwords)
            {
                sb1.Append(ch.ToString());
            }
                
            wordtxt.Text = sb1.ToString();

            string real_words = words[rnd.Next(words.Length)];

            //string rand_num = rnd.Next(0,words.Length);
            //wordtxt.Text = random;
            // MessageBox.Show(random);
            lengthTxt.Text = len.ToString();
            //guessleftTxt.Text = guessCount.ToString();
            //guessleftTxt.Text = " ";
            ////hide the generated word using _
            for (int i = 0; i < wordChars.Length; i++)
            {
                WordLbl.Text += ("_ ");
            }
            wordbtn.IsEnabled = false;

          
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
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
                guessCount--;
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
        private void GuessClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
           char charClicked = b.Content.ToString()[0];
            b.IsEnabled = false;
           

            //if (currentword.Contains(choice.Text))
            //   {
            //  char[] temp = copyCurrent.ToCharArray();
            //  char[] find = currentword.ToCharArray();
            // char guessChar = wordbtn.Content.ElementAt(0);
            // for (int index = 0; index < find.Length; index++)
            //  {
            //   if (find[index] == guessChar)
            //    {
            //      temp[index] = guessChar;
            //  }
            //   }

            wrongGuess++;
            if (wrongGuess > 7)
            {
                MessageBox.Show("wrong guess, You lost");
            }
            else
            {
                //    // MessageBox.Show("You won!");
            }


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}

    





