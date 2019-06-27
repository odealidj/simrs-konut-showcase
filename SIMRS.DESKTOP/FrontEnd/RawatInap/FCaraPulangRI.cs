using SIMRS.DESKTOP.Template.frm;
using SIMRS.Services.FrontEnd.RawatInap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMRS.DESKTOP.FrontEnd.RawatInap
{
    public class FCaraPulangRI : FCaraPulang
    {
        protected short pelayananmedikid = -1;
        protected short ruangrawatid = -1;
        protected short registrasiid = -1;
        protected short stsmasukkeluarruangrawatid = 0;

        protected string UpdateCaraPulang(short registrasiid, short stsmasukkeluarruangrawatid, byte carapulangid)
        {
            try
            {
                using (var service = new RawatInapServices())
                {
                    var result = service.UpdateCaraPulang(registrasiid, stsmasukkeluarruangrawatid, carapulangid);
                    if ((string.IsNullOrEmpty(result.Item1)) && (string.IsNullOrEmpty(result.Item2)))
                    {
                        //MetroFramework.MetroMessageBox.Show(this, result.Item1+"\n" + result.Item2, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return string.Empty;
                    }
                    else
                    {

                        return result.Item1 + "\n" + result.Item2;

                    }
                }
            }

            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ex.Message;
            }
        }

        public FCaraPulangRI() : base()
        {

        }

        public FCaraPulangRI(short pelayananmedikid, short ruangrawatid, short registrasiid) : base()
        {
            try
            {
                this.pelayananmedikid = pelayananmedikid;
                this.ruangrawatid = ruangrawatid;
                this.registrasiid = registrasiid;
                LoadCarapulangByPelayananmedikIdAsync(pelayananmedikid);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message +"\n"+this.Name+ "\nFCaraPulangRI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (carapulangLookUpEdit.EditValue==null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Silahkan pilih Cara pulang", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.carapulangLookUpEdit.Focus();
                    return;
                }

                var resultUpdateCaraPulang = UpdateCaraPulang(this.registrasiid,this.stsmasukkeluarruangrawatid,(byte) carapulangLookUpEdit.EditValue );

                if (string.IsNullOrEmpty(resultUpdateCaraPulang))
                {
                    //view Laporan
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    
                    MetroFramework.MetroMessageBox.Show(this, resultUpdateCaraPulang + "\n" + this.Name + "\nbtnOK_Click", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
