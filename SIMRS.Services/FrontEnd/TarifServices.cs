using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd
{
    public class TarifServices : IDisposable
    {
        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public TarifServices()
        {
            //context = new DapperContext();
            //uow = new UnitOfWork(context);
        }

        public void Dispose()
        {
            if (uow != null)
            {
                try
                {
                }
                finally
                {
                    uow.Dispose();
                }
            }
            if (context != null)
            {
                try
                {
                }
                finally
                {
                    context.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }

        #endregion

        public async Task<(IEnumerable<v_tarif>, string)> SelectVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.TarifRepository.GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(penjaminid, kelasid, ruangrawatid, jenistarifid, tindakan);
                }
            }
        }

        public async Task<(IEnumerable<v_tarif>, string)> SelectTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.TarifRepository.GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(penjaminid, kelasid, ruangrawatid, jenistarifid);
                }
            }
        }

        public (IEnumerable<v_tarif>, string) SelectVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.TarifRepository.GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(penjaminid, kelasid, ruangrawatid, jenistarifid, tindakan);
                }
            }
        }

        public (IEnumerable<v_tarif>, string) SelectTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.TarifRepository.GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(penjaminid, kelasid, ruangrawatid, jenistarifid);
                }
            }
        }

        public (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) SelectAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short kelasid, short ruangrawatid, string tindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.TarifRepository.GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(kelasid, ruangrawatid, tindakan);
                }
            }
        }

        public (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) SelectAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.TarifRepository.GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(ruangrawatid, tindakan);
                }
            }
        }

        public bool Update(int daftartindakanid, short kelasid, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.TarifRepository.Update(daftartindakanid, kelasid, harga, jasasarana, jasapelayanan); 
                }
            }
        }

        public (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) SelectAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.TarifRepository.GetAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(ruangrawatid, tindakan);
                }
            }
        }

        public bool Update(int daftartindakanid, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.TarifRepository.Update(daftartindakanid, harga, jasasarana, jasapelayanan);
                }
            }
        }
    }
}
