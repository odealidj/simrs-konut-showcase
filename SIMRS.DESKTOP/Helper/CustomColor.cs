using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DESKTOP.Helper
{
    public class CustomColor
    {
        public static Color PanelBackColor()
        {
            // Create a green color using the FromRgb static method.
            Color myArgbColor = new Color();
            myArgbColor = Color.FromArgb(0, 122, 204); 
            return myArgbColor;
        }

        public static Color IsBarangInGudang()
        {
            // Create a green color using the FromRgb static method.
           
            Color myArgbColor = new Color();
            //myArgbColor = Color.FromArgb(26, 188, 156);
            
            myArgbColor = Color.FromArgb(2, 125, 0);
            return myArgbColor;
        }

        public static Color IsBarangNotInGudang()
        {
            // Create a green color using the FromRgb static method.

            Color myArgbColor = new Color();
            //236, 68, 44
            myArgbColor = Color.FromArgb(236, 68, 44);
            //myArgbColor = Color.FromArgb(224, 79, 95);
            return myArgbColor;
        }

        public static Color IsBarangPending()
        {
            // Create a green color using the FromRgb static method.

            Color myArgbColor = new Color();
            //myArgbColor = Color.FromArgb(241, 196, 15);
            myArgbColor = Color.FromArgb(245, 255, 225);
            return myArgbColor;
        }

        public static Color IsWarningColor()
        {
            // Create a green color using the FromRgb static method.

            Color myArgbColor = new Color();
            //myArgbColor = Color.FromArgb(241, 196, 15);
            myArgbColor = Color.FromArgb(247, 148, 30);
            return myArgbColor;
        }

        public static Color IsDangerColor()
        {
            // Create a green color using the FromRgb static method.

            Color myArgbColor = new Color();
            //myArgbColor = Color.FromArgb(241, 196, 15);
            myArgbColor = Color.FromArgb(236, 68, 44);
            return myArgbColor;
        }
        public static Color IsSuccesColor()
        {
            // Create a green color using the FromRgb static method.

            Color myArgbColor = new Color();
            //myArgbColor = Color.FromArgb(241, 196, 15);
            myArgbColor = Color.FromArgb(50, 153, 50);
            return myArgbColor;
        }
    }
}
