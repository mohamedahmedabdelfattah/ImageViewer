using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
        }

        private void producttxt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abouttxt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void developrtxt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
