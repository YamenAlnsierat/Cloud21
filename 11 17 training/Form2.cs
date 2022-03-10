using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _11_17_training
{
    public partial class Form2 : Form
    {
        public string ButtonName
        {
            get
            {
                return textBoxButtonName.Text;
            }
            set
            {
                textBoxButtonName.Text = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
