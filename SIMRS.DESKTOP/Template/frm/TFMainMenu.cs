using DevExpress.XtraEditors;
using SIMRS.DESKTOP.FrontEnd;
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
    public partial class TFMainMenu : Form
    {
        private bool mouseDown = false;
        protected bool HiddenSlidePanel = false;
        protected int mouseX = 0, mouseY = 0, defaultWidthPanelSlide = 210, defaultWidthPanelSlideHide = 50;

        protected Color defaultBackGroundColorPanelSide;

        TFToolTip tFtooltip = null;

        public TFMainMenu()
        {
            InitializeComponent();

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            defaultBackGroundColorPanelSide = this.pnlSlide.BackColor;
            defaultControlShowPanelSlide();
            lblTgl.Text = DateTime.Now.ToLongDateString();
            lbljam.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
            lbljam.Size = new Size() { Width = 65, Height = 27 };

            this.mlblTitleHeader.Text = Helper.Modul.modulname;

            this.lblUserName.Text = Helper.LoginAppDetail.loginappdetailnm;

        }

        protected void defaultControlHiddenPanelSlide()
        {
            HiddenSlidePanel = true;
            this.picUserHide.Visible = true;
            this.picUserShow.Visible = false;
            lblUserName.Visible = false;
            mlblLeftTitle.FontSize = MetroFramework.MetroLabelSize.Small;

        }

        protected void defaultControlShowPanelSlide()
        {
            HiddenSlidePanel = false;
            this.picUserHide.Visible = false;
            this.picUserShow.Visible = true;
            lblUserName.Visible = true;
            mlblLeftTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
        }


        private void btnResize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            bool isKeluar = false;
            try
            {

                using (FDialogExit f = new FDialogExit("Apakah akan keluar dari aplikasi"))
                {

                    f.StartPosition = FormStartPosition.Manual;
                    f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - f.Width,
                        this.pnlHeader.Height);

                    //create an overlay form
                    XtraForm overlayForm = new XtraForm();
                    overlayForm.StartPosition = this.StartPosition; // FormStartPosition.CenterScreen; //this.StartPosition;
                    overlayForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    overlayForm.FormBorderEffect = FormBorderEffect.Glow;
                    overlayForm.Opacity = .80d;
                    overlayForm.BackColor = Color.Black;
                    overlayForm.Size = Screen.PrimaryScreen.WorkingArea.Size;// base.Size; //(this as FListRegistrasiRI).Activate.Size; //mainmenu.Size;// this.Size;
                    overlayForm.Location = Screen.PrimaryScreen.WorkingArea.Location; //base.Location;// FMainMenuRI.ActiveForm.Location; //mainmenu.Location;// this.Location;
                                                                                      //overlayForm.Size = this.Size;
                                                                                      //overlayForm.Location =  this.Location;

                    overlayForm.ShowInTaskbar = false;
                    overlayForm.Show();

                    //Show the dialog
                    f.Owner = overlayForm;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        isKeluar = true;

                    }
                    //LoadDataThnPenangananBySKToLooUpEdit(skLookUpEdit.EditValue?.ToString());
                    //tahunLookUpEdit.ItemIndex = 0;

                    //Get rid of the overlay form
                    overlayForm.Dispose();
                    f.Dispose();

                    if (isKeluar)
                    {

                        this.DialogResult = DialogResult.OK;
                        //this.Close();

                    }


                }

            }
            catch
            {
                Application.Exit();
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbljam.Text = DateTime.Now.ToLongTimeString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MlblTitleHeader_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            tFtooltip = new TFToolTip("Exit");

            tFtooltip.StartPosition = FormStartPosition.Manual;
            //f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (f.Width+this.btnLogout.Left)  ,
            //    this.pnlHeader.Height);

            tFtooltip.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - tFtooltip.Width,
                this.pnlHeader.Height);
            tFtooltip.Show();
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            if (tFtooltip != null)
            {
                tFtooltip.Close();
            }
        }

        private void BtnResize_MouseHover(object sender, EventArgs e)
        {
            tFtooltip = new TFToolTip("Resize");

            tFtooltip.StartPosition = FormStartPosition.Manual;
            //f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (f.Width+this.btnLogout.Left)  ,
            //    this.pnlHeader.Height);

            tFtooltip.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - tFtooltip.Width,
                this.pnlHeader.Height);
            tFtooltip.Show();
        }

        private void BtnResize_MouseLeave(object sender, EventArgs e)
        {
            if (tFtooltip != null)
            {
                tFtooltip.Close();
            }
        }

        private void BtnMinimize_MouseHover(object sender, EventArgs e)
        {
            tFtooltip = new TFToolTip("Minimize");

            tFtooltip.StartPosition = FormStartPosition.Manual;
            //f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (f.Width+this.btnLogout.Left)  ,
            //    this.pnlHeader.Height);

            tFtooltip.Location = new Point(this.btnMinimize.Left - tFtooltip.Width,
                this.pnlHeader.Height);
            tFtooltip.Show();
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            if (tFtooltip != null)
            {
                tFtooltip.Close();
            }
        }

        private void BtnLogout_MouseHover(object sender, EventArgs e)
        {
            tFtooltip = new TFToolTip("Logout ..");

            tFtooltip.StartPosition = FormStartPosition.Manual;
            //f.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (f.Width+this.btnLogout.Left)  ,
            //    this.pnlHeader.Height);

            tFtooltip.Location = new Point(this.btnLogout.Left - tFtooltip.Width,
                this.pnlHeader.Height);
            tFtooltip.Show();
        }

        private void BtnLogout_MouseLeave(object sender, EventArgs e)
        {
            if (tFtooltip != null)
            {
                tFtooltip.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VisiblePanelGroup();

            if (HiddenSlidePanel)
            {
                //lblIconTitle.Visible = false;
                //picIconFoto.Visible = false;

                pnlSlide.Width = pnlSlide.Width + 40;
                pnlLeftHeader.Width = pnlSlide.Width;
                if (pnlSlide.Width >= defaultWidthPanelSlide)
                {
                    defaultControlShowPanelSlide();

                    timer1.Stop();
                    this.Refresh();
                }

            }
            else
            {
                pnlSlide.Width = pnlSlide.Width - 40;
                pnlLeftHeader.Width = pnlSlide.Width;
                if (pnlSlide.Width <= defaultWidthPanelSlideHide)
                {

                    defaultControlHiddenPanelSlide();
                    //DefaultMenuButtonHeight();
                    //DefaultMenuButtonImage();

                    timer1.Stop();
                    this.Refresh();
                }
            }
        }

        private void VisiblePanelGroup()
        {
            foreach (Control p in pnlSlide.Controls)
            {
                if (p.GetType() == typeof(Panel))
                {

                    p.Visible = true;

                }
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 400; // This way we have the mouse closer to the middle of the window
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}
