using SIMRS.DESKTOP.Template.frm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.Helper
{
    public class CommonFuncControl
    {


        public static void ClearControlInWindowsMetroForm(MetroFramework.Forms.MetroForm metroForm)
        {
            try
            {
                foreach (Control c in metroForm.Controls)
                {
                    if (c is MetroFramework.Controls.MetroTextBox)
                    {
                        (c as MetroFramework.Controls.MetroTextBox).Text = string.Empty;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).EditValue = DateTime.Now.Date;
                    }

                    if (c is DevExpress.XtraEditors.LookUpEdit)
                    {
                        (c as DevExpress.XtraEditors.LookUpEdit).EditValue = null;
                    }

                    if (c is DevExpress.XtraEditors.PictureEdit)
                    {
                        //(c as DevExpress.XtraEditors.PictureEdit).Image.Dispose();
                        (c as DevExpress.XtraEditors.PictureEdit).Image = null;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message + "\nClearControlInWindowsMetroForm()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearControlInWindowsFormPanel(ref Panel panel)
        {
            try
            {
                foreach (Control c in panel.Controls)
                {
                    if (c is MetroFramework.Controls.MetroTextBox)
                    {
                        c.Text = string.Empty;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).EditValue = DateTime.Now.Date;
                    }

                    if (c is DevExpress.XtraEditors.LookUpEdit)
                    {
                        (c as DevExpress.XtraEditors.LookUpEdit).EditValue = null;
                    }
                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).EditValue = DateTime.Now.Date;
                    }

                    if (c is DevExpress.XtraEditors.PictureEdit)
                    {
                        //(c as DevExpress.XtraEditors.PictureEdit).Image.Dispose();
                        (c as DevExpress.XtraEditors.PictureEdit).Image = null;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nClearControlInWindowsFormPanel()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearControlInWindowsFormGroupBox(ref GroupBox groupBox)
        {
            try
            {
                foreach (Control c in groupBox.Controls)
                {
                    if (c is MetroFramework.Controls.MetroTextBox)
                    {
                        (c as MetroFramework.Controls.MetroTextBox).Text = string.Empty;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).EditValue = DateTime.Now.Date;
                    }

                    if (c is DevExpress.XtraEditors.LookUpEdit)
                    {
                        (c as DevExpress.XtraEditors.LookUpEdit).EditValue = null;
                    }

                    if (c is DevExpress.XtraEditors.PictureEdit)
                    {
                        //(c as DevExpress.XtraEditors.PictureEdit).Image.Dispose();
                        (c as DevExpress.XtraEditors.PictureEdit).Image = null;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nClearControlInWindowsFormGroupBox()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearControlInMetroTabPage(ref MetroFramework.Controls.MetroTabPage metroTabPage)
        {
            try
            {
                foreach (Control c in metroTabPage.Controls)
                {

                    if (c is MetroFramework.Controls.MetroTextBox)
                    {
                        c.Text = string.Empty;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).EditValue = DateTime.Now.Date;
                    }

                    if (c is DevExpress.XtraEditors.LookUpEdit)
                    {
                        (c as DevExpress.XtraEditors.LookUpEdit).EditValue = null;
                    }

                    if (c is DevExpress.XtraEditors.PictureEdit)
                    {
                        //(c as DevExpress.XtraEditors.PictureEdit).Image.Dispose();
                        (c as DevExpress.XtraEditors.PictureEdit).Image = null;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nClearControlInMetroTabPage()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearDataSourceLookUpEdit(ref DevExpress.XtraEditors.LookUpEdit[] lookUpEdits)
        {
            foreach (DevExpress.XtraEditors.LookUpEdit l in lookUpEdits)
            {
                l.Properties.DataSource = null;
            }
        }

        public static void EnableControlInWindowsFormPanel(ref Panel panel, bool value)
        {
            try
            {
                foreach (Control c in panel.Controls)
                {
                    if (c is MetroFramework.Controls.MetroTextBox)
                    {
                        (c as MetroFramework.Controls.MetroTextBox).Enabled = value;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).Enabled = value;
                    }

                    if (c is DevExpress.XtraEditors.LookUpEdit)
                    {
                        (c as DevExpress.XtraEditors.LookUpEdit).Enabled = value;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nEnableControlInWindowsFormPanel()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ReadOnlyControlInWindowsFormPanel(ref Panel panel, bool value)
        {
            try
            {
                foreach (Control c in panel.Controls)
                {
                    if (c is MetroFramework.Controls.MetroTextBox)
                    {
                        (c as MetroFramework.Controls.MetroTextBox).ReadOnly = value;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).ReadOnly = value;
                    }

                    if (c is DevExpress.XtraEditors.LookUpEdit)
                    {
                        (c as DevExpress.XtraEditors.LookUpEdit).ReadOnly = value;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nReadOnlyControlInWindowsFormPanel()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ReadOnlyControlInWindowsFormGroupBox(ref GroupBox groupBox, bool value)
        {
            try
            {
                foreach (Control c in groupBox.Controls)
            {
                if (c is MetroFramework.Controls.MetroTextBox)
                {
                    (c as MetroFramework.Controls.MetroTextBox).ReadOnly = value;
                }

                if (c is DevExpress.XtraEditors.DateEdit)
                {
                    (c as DevExpress.XtraEditors.DateEdit).ReadOnly = value;
                }

                if (c is DevExpress.XtraEditors.LookUpEdit)
                {
                    (c as DevExpress.XtraEditors.LookUpEdit).ReadOnly = value;
                }

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nReadOnlyControlInWindowsFormGroupBox()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ReadOnlyControlInMetroForm(MetroFramework.Forms.MetroForm form , bool value)
        {
            try
            {
                foreach (Control c in form.Controls)
                {
                    if (c is MetroFramework.Controls.MetroTextBox)
                    {
                        (c as MetroFramework.Controls.MetroTextBox).ReadOnly = value;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).ReadOnly = value;
                    }

                    if (c is DevExpress.XtraEditors.LookUpEdit)
                    {
                        (c as DevExpress.XtraEditors.LookUpEdit).ReadOnly = value;
                    }

                    if (c is DevExpress.XtraEditors.DateEdit)
                    {
                        (c as DevExpress.XtraEditors.DateEdit).ReadOnly = value;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nReadOnlyControlInMetroForm()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ReadOnlyControlOnlyMetroTextBox(ref MetroFramework.Controls.MetroTextBox[] metroTextBoxes, bool value)
        {
            try
            {
                foreach (MetroFramework.Controls.MetroTextBox t in metroTextBoxes)
                {
                    (t as MetroFramework.Controls.MetroTextBox).ReadOnly = value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nReadOnlyControlOnlyMetroTextBox()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void CloseAllFormInPanel(ref Panel panel)
        {
            try
            {

                foreach (Form form in panel.Controls.OfType<Form>().ToArray())
                    form.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCloseAllFormInPanel()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
