using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayManipulation
{
    public partial class Form1 : Form
    {
        string[] slot = new string[50];
        int ne = 0,ni = 0;

        public Form1()
        {
            InitializeComponent();            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slot[ne++] = textBox1.Text;
            listBox1.Items.Add(slot[ni++]);                        
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            for (int i=0;i<listBox1.Items.Count;i++)
            {
                listBox1.SetSelected(i, true);
                MessageBox.Show($"The element of {listBox1.SelectedIndex} is {slot[i]}");                                
            }                                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            slot[listBox1.SelectedIndex] = textBox2.Text;
            listBox1.Items.RemoveAt(a);
            listBox1.Items.Insert(a, textBox2.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(a);
            slot[a] = slot[a + 1];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] a = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm','n', 'o', 'p', 'q', 'r', 's','t', 'u', 'v', 'w', 'x', 'y',
                'z', 'A', 'B', 'C','D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'y', 'Z' };
            
            foreach (char me in a)
            {
                if (textBox1.Text == me.ToString())
                {
                    textBox1.Clear();
                }
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = textBox3.Text;
        }
    }
}
