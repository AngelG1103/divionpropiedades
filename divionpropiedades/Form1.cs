using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divionpropiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            division DIVIDE = new division();
            DIVIDE.V1 = double.Parse(textBox1.Text);
            DIVIDE.V2 = double.Parse(textBox2.Text);

            textBox3.Text = DIVIDE.dividir().ToString();
        }
    }
}
