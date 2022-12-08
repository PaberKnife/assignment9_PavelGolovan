using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment9_PavelGolovan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostFrequentCharacter(string str)
        {
            List<char> characterList = new List<char>();
            int highest = 0;
            foreach (char ch in str)
            {
                int count = 0;
                int index = 0;
                while (index < str.Length)
                {
                    if (ch == str[index] && char.IsLetterOrDigit(ch) == true)
                    {
                        count++;
                    }
                    index++;
                }
                if (count > highest)
                {
                    highest = count;
                    characterList = new List<char>(ch);
                }
                else if (count == highest && characterList.Contains(ch) == false)
                {
                    characterList.Add(ch);
                }
            }
            if (characterList.Count == 1)
            {
                label2.Text = "The most frequent character is: " + string.Join(", ", characterList) + ".";
            }
            else
            {
                label2.Text = "The most frequent characters are: " + string.Join(", ", characterList) + ".";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToUpper();
            mostFrequentCharacter(str);
        }
    }
}