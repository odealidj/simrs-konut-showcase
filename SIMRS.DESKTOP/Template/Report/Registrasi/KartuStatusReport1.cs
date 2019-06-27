using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using SIMRS.Model.view;
using System.Collections.Generic;

namespace SIMRS.DESKTOP.Template.Report.Registrasi
{
    public partial class KartuStatusReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        private IList<v_statuspenyakit> v_Statuspenyakits;
        public KartuStatusReport1()
        {
            InitializeComponent();
        }

        public KartuStatusReport1(string nocm, string namapasien, string umur, string pekerjaan, string alamat,  string penjamin,
            string ruanrawat,
            IList<v_statuspenyakit> v_Statuspenyakits)
        {
            InitializeComponent();
            this.pnocm.Value = nocm;this.pnamapasien.Value = namapasien;this.pumur.Value = umur;this.ppekerjaan.Value = pekerjaan;
            this.palamat.Value = alamat;this.ppenjamin.Value = penjamin;
            this.pruangrawat.Value = ruanrawat;
            this.v_Statuspenyakits = v_Statuspenyakits;
            bindingSource1.DataSource = this.v_Statuspenyakits;
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if(this.v_Statuspenyakits==null)
            {
                xrTableCell7.Visible = false;
            }
            else
            {
                if (this.v_Statuspenyakits.Count==0)
                {
                    xrTableCell7.Visible = false;
                }
                else
                {
                    xrTableCell7.Visible = true;
                }
            }
        }

        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.v_Statuspenyakits == null)
            {
                xrTableCell8.Visible = false;
            }
            else
            {
                if (this.v_Statuspenyakits.Count == 0)
                {
                    xrTableCell8.Visible = false;
                }
                else
                {
                    xrTableCell8.Visible = true;
                }
            }
        }

        private void xrTableCell9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.v_Statuspenyakits == null)
            {
                xrTableCell9.Visible = false;
            }
            else
            {
                if (this.v_Statuspenyakits.Count == 0)
                {
                    xrTableCell9.Visible = false;
                }
                else
                {
                    xrTableCell9.Visible = true;
                }
            }
        }

        private void xrTableCell10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.v_Statuspenyakits == null)
            {
                xrTableCell10.Visible = false;
            }
            else
            {
                if (this.v_Statuspenyakits.Count == 0)
                {
                    xrTableCell10.Visible = false;
                }
                else
                {
                    xrTableCell10.Visible = true;
                }
            }
        }

        private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.v_Statuspenyakits == null)
            {
                xrTableCell11.Visible = false;
            }
            else
            {
                if (this.v_Statuspenyakits.Count == 0)
                {
                    xrTableCell11.Visible = false;
                }
                else
                {
                    xrTableCell11.Visible = true;
                }
            }
        }

        private void xrTableCell12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.v_Statuspenyakits == null)
            {
                xrTableCell12.Visible = false;
            }
            else
            {
                if (this.v_Statuspenyakits.Count == 0)
                {
                    xrTableCell12.Visible = false;
                }
                else
                {
                    xrTableCell12.Visible = true;
                }
            }
        }
    }
}
