using System.Security.Cryptography;
using System.Text;

namespace Pig_Latin_chap_8_pro_7_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void formatSentence(ref string str)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Get the input from the user
            string input = sentencetb.Text.Trim();
           
            //string variable to hold the first letter of each word
            string ch1 = " ";
            //string variable to hold the rest of the word after removing the first letter of the word
            string ch2 = "";
            //string variable to store the word after inserting the 1st letter and AY
            string ch3 = "";

            //Get the tokens from the string
            string[] tokens = input.Split(' ');

            //empty input entered by user
            input = String.Empty;

            //iterate trough the string array
            foreach(string s in tokens)
            {
                //get the first letter of each word in the string
                ch1 = s.Substring(0, 1);
                //get the remaining letters of the word after 
                ch2 = s.Substring(1, s.Length - 1);
                //insert the first letter and AY at the end of each word
                ch3 = ch2.Insert(ch2.Length, ch1) + "AY";

                //Accumulator to edit and add each word to the string input
                input += ch3 + ' ';
                

            }
            //displays the edited sentence in the label
            sentenceConvertedlbl.Text = input.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
