using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_17_training
{
    public partial class Form1 : Form
    {
        public void SetTextBox(string text)
        {
            textBox1.Text = text;
        }
        public Form1()
        {

            InitializeComponent();
            //GenereteButtons();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(textBox1.Text);

            var userControl = new UserControl1(this);
            userControl.Dock = DockStyle.Fill;
            //userControl.ColorSelected += user;

            var tapCount = tabControl1.TabPages.Count;
            var activePage = tabControl1.TabPages[tapCount - 1];
            activePage.Controls.Add(userControl);

            userControl.AddComboBoxItem(textBox1.Text);
            tabControl1.SelectedTab = activePage;
        }


        public void GenereteButtons()
        {
            const int width = 10;
            const int height = 10;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var mybutton = new Button()
                    {
                        Location = new Point(5 + 50 + x * 170, 5 + 50 + y * 50),
                        Name = "b" + (y * width + x),
                        Size = new Size(150, 46),
                        TabIndex = (y * width + x),
                        Text = "b" + (y * width + x),
                        UseVisualStyleBackColor = true
                    };
                    Controls.Add(mybutton);
                    mybutton.Click += Mybutton_Click;
                }
            }
        }

        private void Mybutton_Click(object sender, EventArgs e)
        {
            using (var editForm = new Form2())
            {
                editForm.ButtonName = (sender as Button).Text;

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    (sender as Button).Text = editForm.ButtonName;
                }
            }
        }


    }
}
