using DevExpress.XtraEditors;
using SIMRS.DESKTOP.Template.frm;
using SIMRS.Model;
using SIMRS.Services.FrontEnd.Registrasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RegistrasiRJ
{
    public class FListICDXRJ : FListSix
    {
        private const int maxPageSize = 100;
        public int? PageNumber { get; set; }

        protected int pageIndex = 1;
        private int totalPage = 0;
        private int _pageSize = 50;
        protected int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value < maxPageSize) ? value : maxPageSize;
            }
        }

        public icdxsubkategori icdxsubkategoriSelected { get; set; }
        


        #region private method control

        protected async void LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageindex, int pagesize, string icdxname)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(pageindex, pagesize, icdxname);
                    if (result.Item3 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gridControl2.DataSource = result.Item1;
                        dataNavigator2.DataSource = gridControl2.DataSource;

                       
                        this.totalPage = (int)Math.Ceiling(result.Item2 / (double)PageSize);
                        //MessageBox.Show(this.totalPage.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected async void LoadMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(int pageindex, int pagesize, string icdxname)
        {
            try
            {
                using (var service = new RegistrasiPasienServices())
                {
                    var result = await service.SelectMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(pageindex, pagesize, icdxname);
                    if (result.Item3 != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, result.Item3, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        gridControl1.DataSource = result.Item1;
                        dataNavigator1.DataSource = gridControl2.DataSource;
                        this.totalPage = (int)Math.Ceiling(result.Item2 / (double)PageSize);
                        //MessageBox.Show(this.totalPage.ToString());
                    }
                }
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion
        public FListICDXRJ():base()
        {
            this.pageIndex = 1;

            bOK.Visible = false;
            bCancel.Text = "OK";

            LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, string.Empty);
            LoadMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, string.Empty);


        }

        protected override void FListSix_Load(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFListSix_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void FListSix_Shown(object sender, EventArgs e)
        {
            try
            {

                gridView1.Columns[1].Visible = false;
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[5].Visible = false;
                gridView1.Columns[6].Visible = false;

                gridView1.Columns[0].Caption = "KODE";
                gridView1.Columns[2].Caption = "SUBKATEGORI ICD X";

                gridView1.Columns[0].OptionsColumn.AllowEdit = false;
                gridView1.Columns[2].OptionsColumn.AllowEdit = false;
                gridView1.Columns[0].OptionsColumn.FixedWidth = true;

                gridView1.Columns[0].Width = 65;

                gridView2.Columns[1].Visible = false;
                gridView2.Columns[2].Visible = false;
                gridView2.Columns[3].Visible = false;
                gridView2.Columns[5].Visible = false;
                gridView2.Columns[6].Visible = false;

                gridView2.Columns[0].Caption = "KODE";
                gridView2.Columns[4].Caption = "SUBKATEGORI ICD X";

                gridView2.Columns[0].OptionsColumn.AllowEdit = false;
                gridView2.Columns[4].OptionsColumn.AllowEdit = false;
                gridView2.Columns[0].OptionsColumn.FixedWidth = true;

                gridView2.Columns[0].Width = 65;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\nFListSix_Load", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {


                icdxsubkategoriSelected = gridView1.GetRow(e.FocusedRowHandle) as icdxsubkategori;
                if (icdxsubkategoriSelected != null)
                {
                    if (passData != null)
                    {
                        passData(icdxsubkategoriSelected.icdxsubkategoriid, icdxsubkategoriSelected.icdxsubkategorinmeng);
                    }
                }
                else
                {
                    passData(string.Empty, string.Empty);
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message+ "\ngridView1_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //if (passData != null)
            //{
              //  passData(icdxsubkategoriSelected.icdxsubkategoriid, icdxsubkategoriSelected.icdxsubkategorinmeng);
                this.Close();
            //}
        }

        protected override void gridView2_DoubleClick(object sender, EventArgs e)
        {
            //if (passData != null)
            //{
              //  passData(icdxsubkategoriSelected.icdxsubkategoriid, icdxsubkategoriSelected.icdxsubkategorinmindo);
                this.Close();
            //}
        }

        protected override void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                icdxsubkategoriSelected = gridView2.GetRow(e.FocusedRowHandle) as icdxsubkategori;
                if (icdxsubkategoriSelected != null)
                {
                    if (passData != null)
                    {
                        passData(icdxsubkategoriSelected.icdxsubkategoriid, icdxsubkategoriSelected.icdxsubkategorinmindo);
                    }
                }
                else
                {
                    passData(string.Empty, string.Empty);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ngridView2_FocusedRowChanged()", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void caridataMTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.pageIndex = 1;
                if (metroTabControl1.SelectedIndex == 0)
                {
                    LoadMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, caridataMTxt.Text);
                    
                }
                else
                {
                    LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, caridataMTxt.Text);
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ncaridataMTxt_TextChanged", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void dataNavigator1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == NavigatorButtonType.Custom)
                {

                    switch (int.Parse(e.Button.Tag.ToString()))
                    {
                        case 0:
                            this.pageIndex = 1;
                            break;
                        case 1:
                            this.pageIndex--;
                            if (this.pageIndex < 1) this.pageIndex = 1;
                            break;
                        case 6:
                            this.pageIndex++;
                            if (this.pageIndex > this.totalPage) this.pageIndex = this.totalPage;
                            break;
                        case 7:
                            this.pageIndex = this.totalPage;
                            break;
                    }
                    //LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);

                    LoadMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, caridataMTxt.Text);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndataNavigator1_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void dataNavigator2_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.ButtonType == NavigatorButtonType.Custom)
                {

                    switch (int.Parse(e.Button.Tag.ToString()))
                    {
                        case 0:
                            this.pageIndex = 1;
                            break;
                        case 1:
                            this.pageIndex--;
                            if (this.pageIndex < 1) this.pageIndex = 1;
                            break;
                        case 6:
                            this.pageIndex++;
                            if (this.pageIndex > this.totalPage) this.pageIndex = this.totalPage;
                            break;
                        case 7:
                            this.pageIndex = this.totalPage;
                            break;
                    }
                    //LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(this.pageIndex, this.PageSize, DiagnosaAwalSrtRujukanBPJS.Text);

                    LoadMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(this.pageIndex, this.PageSize, caridataMTxt.Text);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + "\ndataNavigator1_ButtonClick", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected override void bOK_Click(object sender, EventArgs e)
        {

        }

        protected override void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
