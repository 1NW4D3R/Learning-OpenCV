using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (*.bmp, *.png)| *.bmp;*.png";
            if(DialogResult.OK == ofd.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap ((Bitmap)this.picOriginal.Image);
            Method.ConvertToGray(copy);
            this.picResult.Image = copy;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Method.ConvertToNegative(copy);
            this.picResult.Image = copy;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if(DialogResult.OK == sfd.ShowDialog())
            {
                this.picResult.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Method.InvertEverySecondPixel(copy);
            this.picResult.Image = copy;
        }
    }
}
