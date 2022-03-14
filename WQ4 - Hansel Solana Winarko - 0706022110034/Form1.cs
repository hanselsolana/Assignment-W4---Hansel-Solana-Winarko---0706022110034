using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WQ4___Hansel_Solana_Winarko___0706022110034
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public TextBox tb1;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2 = null;
            this.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static bool validate(char c)
        {
            int asci = Convert.ToInt32(c);
            if (asci >= 48 && asci <= 57|| asci == 13 || asci == 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            e.Handled = Validate(e.KeyChar);
        }
    }
}
