using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        levenshtein dataset;
        public Form1()
        {
            InitializeComponent();
            Array.Sort(item);
            foreach (string i in item)
            {
                listBox1.Items.Add(i);
            }
            dataset = new levenshtein(item);
        }
        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                mouse.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                mouse.LeftClick();
                keyboard.send(label1.Text);
                keyboard.send("~");
                keyboard.send("~");
                Thread.Sleep(100);
                keyboard.SwitchToThisWindow(keyboard.FindWindow(null, "Form1"),true);
                textBox3.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label1.Text = dataset.compute(textBox3.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                mouse.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            }
            catch (Exception)
            {
                
            }
            
        }
    }
}
