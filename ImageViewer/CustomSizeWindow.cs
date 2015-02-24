using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using openCV;

namespace ImageViewer
{
    public partial class CustomSizeWindow : Form
    {
        public int width, height;

        public CustomSizeWindow()
        {
            InitializeComponent();
        }

        public void customsizesubmit_Click(object sender, EventArgs e)
        {
            width = int.Parse(widthtxt.Text);
            height = int.Parse(heighttxt.Text);
            this.Close();
        }

        private void CustomSizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}