using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_the_Button_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - button1.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - button1.ClientSize.Height;
            this.button1.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));
        }

        
    }
}
