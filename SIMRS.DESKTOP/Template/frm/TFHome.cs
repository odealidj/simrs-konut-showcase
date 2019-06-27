using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Template.frm
{
    public partial class TFHome : Form
    {
        public TFHome()
        {
            InitializeComponent();

            imageSlider1.AnimationTime = 600;
            //Display images at the center of ImageSlider in their original size 
            imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            //... 
            //Slide to the next image 
            imageSlider1.SlideNext();
        }

        private void ImageSlider1_Click(object sender, EventArgs e)
        {

        }
    }
}
