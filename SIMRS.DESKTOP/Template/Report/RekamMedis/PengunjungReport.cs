using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using SIMRS.Model.view;

namespace SIMRS.DESKTOP.Template.Report.RekamMedis
{
    public partial class PengunjungReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PengunjungReport()
        {
            InitializeComponent();
        }

        public PengunjungReport(IList<v_registrasiruangrawat> v_Registrasiruangrawats)
        {
            InitializeComponent();
            this.bindingSource2.DataSource = v_Registrasiruangrawats;
            if (v_Registrasiruangrawats.Count > 0)
            {
                this.ppelayananmediknm.Value = string.Format("REGISTRASI PENDAFTARAN {0}", v_Registrasiruangrawats[0].pelayananmediknm.ToUpper());
                //this.ppelayananmediknm.Visible = true;
            }
        }

        private void xrTableCell17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
