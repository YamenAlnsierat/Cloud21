using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _11_17_training
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler ColorSelected;

        private Form1 form = null;
        public UserControl1()
        {
            InitializeComponent();
            AddComboBoxItem("Yamen");
        }

        public UserControl1(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // form.SetTextBox(comboBox1.Text);
           ColorSelected?.Invoke(this, EventArgs.Empty);
        }

        public void AddComboBoxItem(string text)
        {
            comboBox1.Items.Add(text);
        }
    }
}
