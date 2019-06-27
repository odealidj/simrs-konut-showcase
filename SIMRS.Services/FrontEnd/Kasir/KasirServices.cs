using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Kasir
{
    public class KasirServices : IDisposable
    {

        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public KasirServices()
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

        #endregion constructor

        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> Select50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize, short stsmasukkeluarid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.Get50v_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(pageIndex, pageSize, stsmasukkeluarid);
                }
            }
        }

        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> SelectAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(int pageIndex, int pageSize, short stsmasukkeluarid, string filter)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAsync(pageIndex, pageSize, stsmasukkeluarid, filter);
                }
            }
        }

        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> SelectAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync(int pageIndex, int pageSize, DateTime tglmasuk)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglMasukAsync(pageIndex, pageSize, tglmasuk);
                }
            }
        }

        public async Task<(IEnumerable<v_pelayananpasien_distinct_from_not_alamat>, string)> SelectAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglKeluarAsync(int pageIndex, int pageSize, DateTime tglkeluar)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllv_pelayananpasien_distinct_from_not_alamatByPageIndexAndTglKeluarAsync(pageIndex, pageSize, tglkeluar);
                }
            }

        }

        public async Task<(IEnumerable<v_pelayananpasien_ruangperawatan_from_not_alamat>, string)> SelectAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync(int registrasiid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllv_pelayananpasien_ruangperawatan_from_not_alamatByRegistrasiIdAsync(registrasiid);
                }
            }

        }

        public async Task<(IEnumerable<v_pelayananpasien_rincian_not_alamat>, string)> SelectAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync(int registrasiid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PelayananpasienRepository.GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiIdAsync(registrasiid);
                }
            }
        }

        public (IEnumerable<v_pelayananpasien_rincian_not_alamat>, string) SelectAllv_pelayananpasien_rincian_not_alamatByRegistrasiId(int registrasiid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PelayananpasienRepository.GetAllv_pelayananpasien_rincian_not_alamatByRegistrasiId(registrasiid);
                }
            }
        }

        public (string,string) InsertPelunasan(strukpelayanan _strukpelayanan, IList<pelayananpasienpelunasan> _listpelayananpasienpelunasan,
            IList<short> listtempattidurid,
            short registrasiid, short stsmasukkeluarid, DateTime tglkeluar, DateTime jamkeluar)
        {
            var errresult = (string.Empty, string.Empty);
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                   
                    uow.BeginTransaction();
                    var resultstrukpelayanan = uow.StrukpelayananRepository.Save(_strukpelayanan);
                    if (resultstrukpelayanan != -99)
                    {
                        var strukpelayananid = (short)resultstrukpelayanan;

                        var resultpelayananpasienpelunasan = uow.PelayananpasienpelunasanRepository.Save(_listpelayananpasienpelunasan, strukpelayananid);
                        if (resultpelayananpasienpelunasan != -99)
                        {
                            var resulttempattidur =  uow.TempattidurRepository.Updatetempattidurisi(listtempattidurid, 0);
                            if (resulttempattidur!=-99)
                            {
                                var resultupdatestsmasukkeluar = uow.RegistrasiRepository.UpdateStsmasukkeluaraAndTglKeluar(registrasiid, stsmasukkeluarid,tglkeluar,jamkeluar);
                                if (resultupdatestsmasukkeluar != 99)
                                {

                                }
                                else
                                {
                                    errresult = (string.Empty, "Proses update stsmasuk keluar tidak valid");
                                    return errresult;
                                }
                                
                            }
                            else
                            {
                                errresult = (string.Empty, "Proses update status tempat tidur tidak valid");
                                return errresult;
                            }
                        }
                        else
                        {
                            errresult = (string.Empty, "Proses simpan pelunasan tidak valid");
                            return errresult;

                        }
                    }
                    else
                    {

                        errresult =("Proses simpan struk tidak valid", "Proses simpan pelunasan tidak valid");
                        return errresult;
                    }
                    uow.Commit();

                    return errresult;
                }
            }
        }


    }
}
