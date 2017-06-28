using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bakhsh_Paziri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           try
            {
                listBox1.Items.Clear();
                for (int i = 1; i <= Convert.ToInt64(textBox1.Text); i++)
                {
                    if (Convert.ToInt64(textBox1.Text) % i == 0) listBox1.Items.Add(i.ToString());
                    label4.Text = listBox1.Items.Count.ToString();
                }
            }
            catch { }
        }
    }
}
