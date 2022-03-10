using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_08_WinFormsApp
{
    public partial class Form1 : Form
    {
        int WordsCount = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUpper_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = textBoxMessage.Text.ToUpper();
        }

        private void buttonLower_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = textBoxMessage.Text.ToLower();
        }

        private void buttonTextShifter_Click(object sender, EventArgs e)
        {
            var words = textBoxMessage.Text.Split();
            WordsCount++;
            if (WordsCount >= words.Length)
            {
                WordsCount = 0;
            }
            buttonTextShifter.Text = words[WordsCount];
        }
    }
}
