using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_17_MultiForms
{
    public partial class Form1 : Form
    {
        private int buttonCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;

            var mybutton = new Button()
            {
                Location = new System.Drawing.Point(325, 12 + 50 + buttonCount),
                Name = "b" + buttonCount,
                Size = new System.Drawing.Size(150, 46),
                TabIndex = 0,
                Text = "b" + buttonCount,
                UseVisualStyleBackColor = true
            };

            mybutton.Click += new System.EventHandler(this.button1_Click);
            Controls.Add(mybutton);

            buttonCount++;
        }
    }
}
