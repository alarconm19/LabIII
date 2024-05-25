using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader F = new StreamReader(openFileDialog1.FileName))
                {
                    textBox1.Text = F.ReadToEnd();
                }
            }
            
        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            if ( saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter F = new StreamWriter(saveFileDialog1.FileName))
                {
                   F.WriteLine(textBox1.Text);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
