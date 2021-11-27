using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            handleTextBoxText();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                handleTextBoxText();
            }
        }

        private void handleTextBoxText()
        {
            if (this.textBox1.Text.Length > 0)
            {
                this.richTextBox1.AppendText(this.textBox1.Text);
                this.richTextBox1.AppendText("\n");
                this.textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("TextBox must not be empty");
            }
        }
    }
}
