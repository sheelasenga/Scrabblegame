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
        MainWindow sw = new MainWindow();
        public string currentword;
        private int wrongGuess = 0;
       // private string copyCurrent = "";
        
       // private int guessCount = 0;
        List<char> finalwords;
        List<int> index;
        int count = 0;
        int hasWord = 0;
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
            // string random = new string(words.ToString().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());
            int rnumber = rnd.Next(0, len);
            // display the generated scrabbled word in textbox
            while (true)
            {
                if (!(index.Contains(rnumber)))
                {
                    index.Add(rnumber);
                    finalwords.Add(wordChars[rnumber]);
                    count++;
                    if (count > 6)
                    {
                        break;
                    }
                }
                rnumber = rnd.Next(0, len);
            }
            sb1 = new StringBuilder();
            foreach (char ch in finalwords)
            {
                sb1.Append(ch.ToString());
            }

            wordtxt.Text = sb1.ToString();

            string real_words = words[rnd.Next(words.Length)];

            lengthTxt.Text = len.ToString();


            //hide the generated word using _
            for (int i = 0; i < wordChars.Length; i++)
            {
                WordLbl.Text += ("_ ");
            }
            wordbtn.IsEnabled = false;

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

    
        private void GuessClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            char charClicked = b.Content.ToString().ElementAt(0);
             b.IsEnabled = false;
            //  MessageBox.Show(charClicked.ToString());
         
            
            // button clicks 
            if (finalwords.Contains(charClicked))
            {
                MessageBox.Show("Correct Letter");

                // Add it to the _ _ _ _ 
            }

            char[] correctCharArray = new char[finalwords.Count];
            for (int k = 0; k < correctCharArray.Length; k++)
            {
                correctCharArray[k] = '_';

            }

            for (int i = 0; i < finalwords.Count; i++)
            {
                if (finalwords[i] == charClicked)
                {

                    MessageBox.Show("Correct letter at index " + i);
                    correctCharArray[i] = charClicked;
                }
            }

            // string charsStr = new string(correctCharArray);
            WordLbl.Text = new String(correctCharArray);
        
    
        {
         wrongGuess++;

        }
           
            if (wrongGuess == 8)
            {
                MessageBox.Show("wrong guess, You lost");
        
                sw.Show();
                this.Close();
              
            }
            else
            {
             if (words.Equals(finalwords))
              
              
                {
                    MessageBox.Show("You Win!");
                }

            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
      
            sw.Show();
            this.Close();
        }
    }
}

    





