using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Helper
{
    public class CustomMessageBox
    {
        public static DialogResult MessageWarning(string msg, object owner)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public static DialogResult MessageWarning(string msg, string caption, object owner)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public static DialogResult MessageInfo(string msg, object owner)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static DialogResult MessageInfo(string msg, string caption, object owner)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static DialogResult MessageQuestion(string msg, object owner)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        public static DialogResult MessageQuestion(string msg, string caption, object owner)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        public static DialogResult MessageError(string msg, object obj)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(obj);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static DialogResult MessageError(string msg, string caption, object obj)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(obj);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public static DialogResult MessageError(string msg, string methodname, string classname = "", object owner = null)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            string mesg = string.Empty;
            if (!string.IsNullOrEmpty(classname))
            {
                mesg = string.Format("{0}\n{1}\n{2}", msg, methodname, classname);
            }
            else
            {
                mesg = string.Format("{0}\n{1}", msg, methodname);
            }
            return XtraMessageBox.Show(lookAndFeelError, mesg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static DialogResult MessageError(string msg, string caption, string methodname, string classname, object owner)
        {
            //configuring the UserLookAndFeel  
            UserLookAndFeel lookAndFeelError = new UserLookAndFeel(owner);
            lookAndFeelError.SkinName = "The Bezier";
            lookAndFeelError.Style = LookAndFeelStyle.Skin;
            lookAndFeelError.UseDefaultLookAndFeel = false;

            // force Message Boxes to use the "MyCustomSkin" 
            XtraMessageBox.AllowCustomLookAndFeel = true;

            // pass the UserLookAndFeel as a Parameter in the show method 
            return XtraMessageBox.Show(lookAndFeelError, string.Format("{0}\n{1}\n{2}", msg, methodname, classname), caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
