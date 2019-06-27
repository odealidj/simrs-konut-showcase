using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using SIMRS.Model.view;

namespace SIMRS.DESKTOP.Template.Report.Kasir
{
    public partial class RincianTransaksiPasienRpt : DevExpress.XtraReports.UI.XtraReport
    {
        private IList<v_pelunasan> v_Pelunasans;
        public RincianTransaksiPasienRpt()
        {
            InitializeComponent();
        }

        public RincianTransaksiPasienRpt(IList<v_pelunasan> v_Pelunasans)
        {
            InitializeComponent();
            this.v_Pelunasans = v_Pelunasans;
        }

    }
}
