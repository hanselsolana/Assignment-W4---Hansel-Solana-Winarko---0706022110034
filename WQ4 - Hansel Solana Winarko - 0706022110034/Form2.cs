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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label lab1;
        
        public Form2()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.tb1.Text = "set by form2";
        }
    }
}
