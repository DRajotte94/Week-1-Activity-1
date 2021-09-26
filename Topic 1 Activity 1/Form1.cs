using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_1_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When clicking the submit button the text from the text boxes will be displayed in the greeting label at the bottom
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // English
            {
                greetingLabel.Text = "Hello, " + fNameBox.Text + " " + lNameBox.Text + "!";
            }
            else if (radioButton2.Checked) // Spanish
            {
                greetingLabel.Text = "Hola, " + fNameBox.Text + " " + lNameBox.Text + "!";
            }
            else if (radioButton3.Checked) // French
            {
                greetingLabel.Text = "Bonjour, " + fNameBox.Text + " " + lNameBox.Text + "!";
            }
        }
    }
}
