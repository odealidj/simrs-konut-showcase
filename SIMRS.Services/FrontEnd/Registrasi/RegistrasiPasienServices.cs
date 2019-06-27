using SIMRS.DA;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.Services.FrontEnd.Registrasi
{
    public class RegistrasiPasienServices : IDisposable
    {

        #region constructor

        protected IDapperContext context;
        protected IUnitOfWork uow;

        public RegistrasiPasienServices()
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

        public async Task<(IEnumerable<penjaminpasien>, string)> SelectAllPenjaminAsync()
        {

            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PenjaminRepository.GetAllAsync();
                }
            }
        }

        public IEnumerable<penjaminpasien> SelectAllPenjamin()
        {

            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PenjaminRepository.GetAll();
                }
            }
        }

        public async Task<(IEnumerable<keldesa>, string)> SelectKeldesaByKecIdAsync(short kecid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.KeldesaRepository.GetAllKeldesaByKecIdAsync(kecid);
                }
            }

        }

        public async Task<(IEnumerable<vrtrw>, string)> SelectRTRWByKeldesaidAsync(short keldesaid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RtRepository.GetAllVrtrwByKeldesaidAsync(keldesaid);
                }
            }

        }

        public (short, string, string) InsertRegistrasi(registrasi obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.RegistrasiRepository.Save(obj);
                    uow.Commit();
                    return data;
                }
            }
        }

        public int InsertRegistrasiRuangRawat(registrasiruangrawat obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.RegistrasiruangrawatRepository.Save(obj);
                    uow.Commit();
                    return data;
                }
            }
        }

        public int InsertRegistrasiRuangRawatRI(registrasiruangrawat objRegistrasiruangrawat, tempattidur objTempattidur)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    var data = uow.RegistrasiruangrawatRepository.Save(objRegistrasiruangrawat);
                    if (data ==-99)
                    {
                        return data;
                    }

                    var tt = uow.TempattidurRepository.Updatetempattidurisi(objTempattidur.tempattidurid, (short)objTempattidur.tempattidurisi);
                    if (tt==-99)
                    {
                        return tt;
                    }
                    uow.Commit();
                    return data;
                }
            }
        }


        ////public async Task<(IEnumerable<identitasdiri>, IEnumerable<jk>, IEnumerable<kec>, IEnumerable<pekerjaan>, string)> SelectIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiriAsync(short? kotakabid)
        ////{
        ////    using (context = new DapperContext())
        ////    {
                
        ////        using (uow = new UnitOfWork(context))
        ////        {
                    
        ////            return await uow.PenjamindirisendiriRepository.GetAllIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiriAsync(kotakabid);
                    
        ////        }
        ////    }
        ////}


        public (IEnumerable<identitasdiri>, IEnumerable<jk>, IEnumerable<kec>, IEnumerable<pekerjaan>, string) SelectIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(short? kotakabid)
        {
            using (context = new DapperContext())
            {

                using (uow = new UnitOfWork(context))
                {

                    return uow.PenjamindirisendiriRepository.GetAllIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(kotakabid);

                }
            }
        }


        public async Task<(IEnumerable<jk>, IEnumerable<goldarah>, IEnumerable<kec>, IEnumerable<stspernikahan>,
            IEnumerable<pendidikan>, IEnumerable<pekerjaan>, IEnumerable<agama>,
            IEnumerable<suku>, IEnumerable<sapaan>, IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>, string)>
            SelectJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(short? kotakabid, short? pelayananmedikid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {

                    return await uow.RegistrasipasienbaruRepository.GetAllJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(kotakabid, pelayananmedikid);


                }
            }
        }

        public async Task<(pelayananmedik, string)> SelectPelayananmedikByRuangrawatrujukanIdAsync(short ruangrawatid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RuangrawatrujukanRepository.GetPelayananmedikByRuangrawatrujukanIdAsync(ruangrawatid);

                }
            }
        }

        public IEnumerable<identitasdiri> SelectIdentitasdiri()
        {
            try
            {
                using (context = new DapperContext())
                {
                    using (uow = new UnitOfWork(context))
                    {
                        return uow.IdentitasdiriRepository.GetAll();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<(IEnumerable<hubkeluarga>, IEnumerable<identitasdiri>, IEnumerable<jk>, IEnumerable<kec>, string)> SelectHubkeluargaAndIdentitasdiriAndJKAndKecByKotakabIdKeluargaPasienAsync(short? kotakabid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.KeluargaPasienRepository.GetAllHubkeluargaAndIdentitasdiriAndJKAndKecByKotakabIdKeluargaPasienAsync(kotakabid.Value);
                }
            }
        }


        public IEnumerable<perujuk> SelectPerujuk()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PerujukRepository.GetAll();
                }
            }
        }

        public async Task<(IEnumerable<puskesmas>, string)> SelectPuskesmasByPerujukIdAsync(short perujukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PuskesmasRepository.GetAllPuskesmasByPerujukIdAsync(perujukid);
                }
            }
        }


        public async Task<(IEnumerable<icdxsubkategori>, string)> SelectIcdxsubkategoriEngByIcdxnameAsync(string icdxsubkategoriname)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxsubkategoriRepository.GetAllIcdxsubkategoriEngByIcdxnameAsync(icdxsubkategoriname);
                }
            }
        }

        public async Task<(IEnumerable<icdxsubkategori>, string)> SelectIcdxsubkategoriIndoByIcdxnameAsync(string icdxsubkategoriname)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxsubkategoriRepository.GetAllIcdxsubkategoriIndoByIcdxnameAsync(icdxsubkategoriname);
                }
            }
        }

        public async Task<(IEnumerable<icdxsubkategori>, string)> SelectIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxsubkategoriname)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxsubkategoriRepository.GetAllIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(pageIndex, pageSize, icdxsubkategoriname);
                }
            }
        }

        public (IEnumerable<icdxsubkategori>, short, string) SelectMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(int pageIndex, int pageSize, string icdxsubkategoriname)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.IcdxsubkategoriRepository.GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxname(pageIndex, pageSize, icdxsubkategoriname);
                }
            }
        }

        public async Task<(IEnumerable<icdxsubkategori>, short, string)> SelectMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxsubkategoriname)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxsubkategoriRepository.GetMultiIcdxsubkategoriIndoByPageIndexAndIcdxnameAsync(pageIndex, pageSize, icdxsubkategoriname);
                }
            }
        }


        public async Task<(IEnumerable<icdxsubkategori>, short, string)> SelectMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(int pageIndex, int pageSize, string icdxsubkategoriname)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxsubkategoriRepository.GetMultiIcdxsubkategoriEngByPageIndexAndIcdxnameAsync(pageIndex, pageSize, icdxsubkategoriname);
                }
            }
        }

        public async Task<(IEnumerable<puskesmas>, IEnumerable<ruangrawatrujukan>, IEnumerable<vicdxpuskesmas>, string)> SelectPuskesmasByPerujukIdAndGetAllRuangRawatRujukanAndVicdxpuskesmasAsync(short? puskesmasperujukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.SuratRujukanBPJSRepository.GetAllPuskesmasByPerujukIdAndGetAllRuangRawatRujukanAndVicdxpuskesmasAsync(puskesmasperujukid);
                }
            }
        }

        public async Task<(IEnumerable<kelas>, IEnumerable<jk>, IEnumerable<kec>, string)> SelectKelasBPJSAndJKAndKecKartuBPJSAsync(short? kotakabid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.KartuBPJSRepository.GetAllKelasBPJSAndJKAndKecKartuBPJSAsync(kotakabid.Value);
                }
            }
        }

        public async Task<(IEnumerable<ruangrawatrujukan>, string)> GetAllRuangRawatRujukanAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                { 
                    return await uow.RuangrawatrujukanRepository.GetAllAsync();
                }
            }
        }

        public async Task<(IEnumerable<ruangrawatrujukan>, string)> GetAllRuangRawatRujukanByNameAsync(string namaruangrawat)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RuangrawatrujukanRepository.GetAllRuangRawatRujukanByNameAsync(namaruangrawat);
                }
            }
        }

        public IEnumerable<perujuk> GetAllPerujuk()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PerujukRepository.GetAll();
                }
            }
        }

        public async Task<(IEnumerable<perujuk>, string)> GetAllPerujukAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PerujukRepository.GetAllAsync();
                }
            }
        }

        public async Task<(IEnumerable<puskesmas>, string)> GetAllPuskesmasByPerujukIdAsync(short perujukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.PuskesmasRepository.GetAllPuskesmasByPerujukIdAsync(perujukid);
                }
            }
        }

        public IEnumerable<puskesmas> GetAllPuskesmasByPerujukId(short perujukid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.PuskesmasRepository.GetAllPuskesmasByPerujukId(perujukid);
                }
            }
        }

        public async Task<(IEnumerable<icdxsubkategori>, string)> GetAllIcdxsubkategoriEngByIcdxnameAsync(string icdxsubkategoriname)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IcdxsubkategoriRepository.GetAllIcdxsubkategoriEngByIcdxnameAsync(icdxsubkategoriname);
                }
            }
        }

        public async Task<(IEnumerable<kec>, string)> GetAllKecByKotakabIdAsync(short? kotakabid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.KecRepository.GetAllKecByKotakabIdAsync(kotakabid);
                }
            }
        }

        public (jenistarif, string) FirstOrDefaultJenistarifByRuangrawatIdAndPenjaminId(short ruangrawatid, short penjaminid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.JenistarifRepository.GetJenistarifByRuangrawatIdAndPenjaminId( ruangrawatid,  penjaminid);
                }
            }
        }

        public async Task<(IEnumerable<ruangrawatrujukan>, string)> SelectRuangrawatrujukanAsync()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.RuangrawatrujukanRepository.GetAllAsync();
                }
            }
        }

        public (IEnumerable<ruangrawatrujukan>, string) SelectRuangrawatrujukan()
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.RuangrawatrujukanRepository.GetAll();
                }
            }
        }

        public async Task<(identitaspasienbpjs, string)> FirstOrDefaultIdentitaspasienbpjsAsync(identitaspasienbpjs obj)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return await uow.IdentitaspasienbpjsRepository.GetAsync(obj);
                }
            }
        }

        public (IEnumerable<v_statuspenyakit>, string) SelectAllv_statuspenyakitByNormAsync(string norm)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.RegistrasiruangrawatRepository.GetAllv_statuspenyakitByNormAsync(norm);
                }
            }
        }

        public stspasienbaru SelectStspasienbaruByRegistrasiId(short registrasiid)
        {
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.RegistrasiRepository.GetStspasienbaruByRegistrasiId(registrasiid);
                }
            }
        }

        public bool UpdateNoRM(string oldNoRM, string newNoRM)
        {
            var result = true;
            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    uow.BeginTransaction();
                    result = uow.IdentitaspasienRepository.UpdateNoRM(oldNoRM, newNoRM);
                    if (result ==false)
                    {
                        return result;
                    }
                    uow.Commit();
                    return result;
                }
            }
        }

        public bool IsNoRMIsExists(string norm)
        {

            using (context = new DapperContext())
            {
                using (uow = new UnitOfWork(context))
                {
                    return uow.IdentitaspasienRepository.IsNoRMIsExists(norm);
                }
            }
        }

    }
}
