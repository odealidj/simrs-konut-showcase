using SIMRS.DA.Expand;
using SIMRS.DA.Expand.RekamMedis;
using SIMRS.DA.IRepository;
using SIMRS.DA.IRepository.IExpand;
using SIMRS.DA.IRepository.IExpand.RekamMedis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA
{
    public class UnitOfWork : IUnitOfWork
    {

        #region IUnitOfWork

        private IDapperContext _context;
        private IDbTransaction _transaction;

        public UnitOfWork(IDapperContext context)
        {
            this._context = context;
        }

        public void BeginTransaction()
        {
            if (_transaction != null)
                throw new NullReferenceException("Not finished previous transaction");

            _transaction = _context.db.BeginTransaction();
        }

        public void Commit()
        {
            if (_transaction == null)
                throw new NullReferenceException("Tryed commit not opened transaction");

            _transaction.Commit();
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                try
                {

                }
                finally
                {
                    _transaction.Dispose();
                }
            }


            if (_context != null)
            {
                try
                {
                    
                }
                finally
                {
                    _context.Dispose();
                }
            }


            GC.SuppressFinalize(this);
        }



        #endregion IUnitOfWork

        #region deklarasi variabel

        private IInstalasipelayananRepository _instalasipelayananRepository;
        private IIdentitaspasienRepository _identitaspasienRepository;
        private IRegistrasiRepository _registrasiRepository;
        private ILoginappRepository _loginappRepository;
        private ILoginappdetailRepository _loginappdetailRepository;
        private ILoginmodulappRepository _loginmodulappRepository;
        private IPenjaminRepository _penjaminRepository;
        private IKelasRepository _kelasRepository;
        private IJkRepository _jkRepository;
        private IRuangrawatrujukanRepository _ruangrawatrujukanRepository;
        private IPerujukRepository _perujukRepository;
        private ISuratrujukanpuskesmasRepository _suratrujukanpuskesmasRepository;
        private IIcdxkategoriRepository _icdxkategoriRepository;
        private IPropinsiRepository _propinsiRepository;
        private IKotakabRepository _kotakabRepository;
        private IKecRepository _kecRepository;
        private IKeldesaRepository _keldesaRepository;
        private IRwRepository _rwRepository;
        private IRtRepository _rtRepository;
        private IIcdxsubkategoriRepository _icdxsubkategoriRepository;
        private IIcdxpuskesmasRepository _icdxpuskesmasRepository;
        private IHubkeluargaRepository _hubkeluargaRepository;
        private IIdentitasdiriRepository _identitasdiriRepository;
        private ISuratRujukanBPJSRepository _suratRujukanBPJSRepository;
        private IKartuBPJSRepository _kartuBPJSRepository;
        private IKeluargaPasienRepository _keluargaPasienRepository;
        private IAgamaRepository _agamaRepository;
        private IRegistrasipasienbaruRepository _registrasipasienbaruRepository;
        private IRegistrasiruangrawatRepository _registrasiruangrawatRepository;
        private IPenjamindirisendiriRepository _penjamindirisendiriRepository;
        private IPuskesmasRepository _puskesmasRepository;
        private IAlamatpasienRepository _alamatpasienRepository;
        private IListRegistrasiRepository _listRegistrasiRepository;
        private IRegistrasiPasienLamaRepository _registrasiPasienLamaRepository;
        private IPelayananmedikRepository _pelayananmedikRepository;
        private ITempattidurRepository _tempattidurRepository;
        private IRegistrasipenunjangRepository _registrasipenunjangRepository;
        private IRuangrawatRepository _ruangrawatRepository;
        private IPelayananpasienRepository _pelayananpasienRepository;
        private ITarifRepository _tarifRepository;
        private IJenistarifRepository _jenistarifRepository;
        private IDokterRepository _dokterRepository;
        private IPerawatRepository _perawatRepository;
        private IPenjaminpasiendirisendiriRepository _penjaminpasiendirisendiriRepository;
        private IPenjaminpasienkeluargaRepository _penjaminpasienkeluargaRepository;
        private IIdentitaspasienbpjsRepository _identitaspasienbpjsRepository;
        private IPenjaminpasienbpjsRepository _penjaminpasienbpjsRepository;
        private IIdentitasdiripasienRepository _identitasdiripasienRepository;
        private IJenisdiagnosaRepository _jenisdiagnosaRepository;
        private IIcdxpasienRepository _icdxpasienRepository;
        private IPemeriksaanfisikRepository _pemeriksaanfisikRepository;
        private IAnamnesapasienRepository _anamnesapasienRepository;
        private IPengobatanRepository _pengobatanRepository;
        private IPelayananpasienpelunasanRepository _pelayananpasienpelunasanRepository;
        private IStrukpelayananRepository _strukpelayananRepository;
        private ICarapulangRepository _carapulangRepository;

        #region rekammedis
        private IPengunjungRepository _pengunjungRepository;
        #endregion

        private IAptdepoRepository _aptdepoRepository;
        private IAptsatuanRepository _aptsatuanRepository;
        private IAptbarangRepository _aptbarangRepository;
        private IAptdef1brgRepository _aptdef1BrgRepository;
        private IAptpbfRepository _aptpbfRepository;
        private IAptbarangmasukRepository _aptbarangmasuk;
        private IAptbarangmasukdetailRepository _aptbarangmasukdetailRepository;
        private IAptstockopgudangRepository _aptstockopgudangRepository;
        private IAptstockopgudangdetailRepository _aptstockopgudangdetailRepository;
        private IAptdistribusiRepository _aptdistribusiRepository;
        private IAptdistribusidetailRepository _aptdistribusidetailRepository;
        private IRLRepository _rLRepository;
        private IAptbrgguRepository _aptbrgguRepository;
        private IAptbrggudetailRepository _aptbrggudetailRepository;
        private IAptbarangsatuanRepository _aptbarangsatuanRepository;
        private IAptbarangsatuantriggerRepository _aptbarangsatuantriggerRepository;
        private IAptstsbgrmasukdetailRepository _aptstsbgrmasukdetailRepository;
        private IAptstockopRepository _aptstockopRepository;
        private IAptstockopdetaildRepository _aptstockopdetaildRepository;

        #endregion


        #region implement rekam medis
        public IPengunjungRepository PengunjungRepository
        {
            get { return _pengunjungRepository ?? (_pengunjungRepository = new PengunjungRepository(_transaction, _context)); }

        }
        #endregion implement rekam medis

        public IAptstockopdetaildRepository AptstockopdetaildRepository
        {
            get { return _aptstockopdetaildRepository ?? (_aptstockopdetaildRepository = new AptstockopdetaildRepository(_transaction, _context)); }

        }
        public IAptstockopRepository AptstockopRepository
        {
            get { return _aptstockopRepository ?? (_aptstockopRepository = new AptstockopRepository(_transaction, _context)); }

        }

        public IAptstsbgrmasukdetailRepository AptstsbgrmasukdetailRepository
        {
            get { return _aptstsbgrmasukdetailRepository ?? (_aptstsbgrmasukdetailRepository = new AptstsbgrmasukdetailRepository(_transaction, _context)); }

        }

        public IAptbarangsatuantriggerRepository AptbarangsatuantriggerRepository 
        {
            get { return _aptbarangsatuantriggerRepository ?? (_aptbarangsatuantriggerRepository = new AptbarangsatuantriggerRepository(_transaction, _context)); }

        }


        public IAptbarangsatuanRepository AptbarangsatuanRepository
        {
            get { return _aptbarangsatuanRepository ?? (_aptbarangsatuanRepository = new AptbarangsatuanRepository(_transaction, _context)); }

        }

        public IAptbrggudetailRepository AptbrggudetailRepository 
        {
            get { return _aptbrggudetailRepository ?? (_aptbrggudetailRepository = new AptbrggudetailRepository(_transaction, _context)); }

        }

        public IAptbrgguRepository AptbrgguRepository
        {
            get { return _aptbrgguRepository ?? (_aptbrgguRepository = new AptbrgguRepository(_transaction, _context)); }

        }

        public IRLRepository RLRepository
        {
            get { return _rLRepository ?? (_rLRepository = new RLRepository(_transaction, _context)); }

        }

        public IAptdistribusidetailRepository AptdistribusidetailRepository 
        {
            get { return _aptdistribusidetailRepository ?? (_aptdistribusidetailRepository = new AptdistribusidetailRepository(_transaction, _context)); }

        }

        public IAptdistribusiRepository AptdistribusiRepository 
        {
            get { return _aptdistribusiRepository ?? (_aptdistribusiRepository = new AptdistribusiRepository(_transaction, _context)); }

        }

        public IAptstockopgudangdetailRepository AptstockopgudangdetailRepository 
        {
            get { return _aptstockopgudangdetailRepository ?? (_aptstockopgudangdetailRepository = new AptstockopgudangdetailRepository(_transaction, _context)); }

        }

        public IAptstockopgudangRepository AptstockopgudangRepository
        {
            get { return _aptstockopgudangRepository ?? (_aptstockopgudangRepository = new AptstockopgudangRepository(_transaction, _context)); }

        }

        public IAptbarangmasukdetailRepository AptbarangmasukdetailRepository 
        {
            get { return _aptbarangmasukdetailRepository ?? (_aptbarangmasukdetailRepository = new AptbarangmasukdetailRepository(_transaction, _context)); }

        }
        public IAptbarangmasukRepository AptbarangmasukRepository
        {
            get { return _aptbarangmasuk ?? (_aptbarangmasuk = new AptbarangmasukRepository(_transaction, _context)); }

        }

        public IAptpbfRepository AptpbfRepository 
        {
            get { return _aptpbfRepository ?? (_aptpbfRepository = new AptpbfRepository(_transaction, _context)); }

        }
    
        public IAptdef1brgRepository Aptdef1brgRepository
        {
            get { return _aptdef1BrgRepository ?? (_aptdef1BrgRepository = new Aptdef1brgRepository(_transaction, _context)); }

        }
        public IAptbarangRepository AptbarangRepository
        {
            get { return _aptbarangRepository ?? (_aptbarangRepository = new AptbarangRepository(_transaction, _context)); }

        }
        public IAptsatuanRepository AptsatuanRepository 
        {
            get { return _aptsatuanRepository ?? (_aptsatuanRepository = new AptsatuanRepository(_transaction, _context)); }

        }

        public IAptdepoRepository AptdepoRepository
        {
            get { return _aptdepoRepository ?? (_aptdepoRepository = new AptdepoRepository(_transaction, _context)); }

        }

        public ICarapulangRepository CarapulangRepository
        {
            get { return _carapulangRepository ?? (_carapulangRepository = new CarapulangRepository(_transaction, _context)); }

        }

        public IStrukpelayananRepository StrukpelayananRepository
        {
            get { return _strukpelayananRepository ?? (_strukpelayananRepository = new StrukpelayananRepository(_transaction, _context)); }

        }

        public IPelayananpasienpelunasanRepository PelayananpasienpelunasanRepository
        {
            get { return _pelayananpasienpelunasanRepository ?? (_pelayananpasienpelunasanRepository = new PelayananpasienpelunasanRepository(_transaction, _context)); }

        }

        public IPengobatanRepository PengobatanRepository
        {
            get { return _pengobatanRepository ?? (_pengobatanRepository = new PengobatanRepository(_transaction, _context)); }

        }


        public IAnamnesapasienRepository AnamnesapasienRepository
        {
            get { return _anamnesapasienRepository ?? (_anamnesapasienRepository = new AnamnesapasienRepository(_transaction, _context)); }

        }

        public IPemeriksaanfisikRepository PemeriksaanfisikRepository
        {
            get { return _pemeriksaanfisikRepository ?? (_pemeriksaanfisikRepository = new PemeriksaanfisikRepository(_transaction, _context)); }
            
        }

        public IInstalasipelayananRepository InstalasipelayananRepository
        {
            get { return _instalasipelayananRepository ?? (_instalasipelayananRepository = new InstalasipelayananRepository(_transaction, _context)); }
            // get { return _instalasipelayananRepository ?? (_instalasipelayananRepository = new InstalasipelayananRepository( _context)); }
            //get { return _instalasipelayananRepository ?? (_instalasipelayananRepository = new InstalasipelayananRepository(_context)); }
        }

        public IIdentitaspasienRepository IdentitaspasienRepository
        {
            get { return _identitaspasienRepository ?? (_identitaspasienRepository = new IdentitaspasienRepository(_transaction, _context)); }
        }

        public IRegistrasiRepository RegistrasiRepository
        {
            get { return _registrasiRepository ?? (_registrasiRepository = new RegistrasiRepository(_transaction, _context)); }
        }

        public ILoginappRepository LoginappRepository
        {
            get { return _loginappRepository ?? (_loginappRepository = new LoginappRepository(_transaction, _context)); }

        }

        public ILoginappdetailRepository LoginappdetailRepository
        {
            get { return _loginappdetailRepository ?? (_loginappdetailRepository = new LoginappdetailRepository(_transaction, _context)); }

        }

        public ILoginmodulappRepository LoginmodulappRepository
        {
            get { return _loginmodulappRepository ?? (_loginmodulappRepository = new LoginmodulappRepository(_transaction, _context)); }

        }

        public IPenjaminRepository PenjaminRepository
        {
            get { return _penjaminRepository ?? (_penjaminRepository = new PenjaminRepository(_transaction, _context)); }

        }

        public IKelasRepository KelasRepository
        {
            get { return _kelasRepository ?? (_kelasRepository = new KelasRepository(_transaction, _context)); }

        }

        public IJkRepository JkRepository
        {
            get { return _jkRepository ?? (_jkRepository = new JkRepository(_transaction, _context)); }

        }

        public IRuangrawatrujukanRepository RuangrawatrujukanRepository
        {
            get { return _ruangrawatrujukanRepository ?? (_ruangrawatrujukanRepository = new RuangrawatrujukanRepository(_transaction, _context)); }

        }

        public IPerujukRepository PerujukRepository
        {
            get { return _perujukRepository ?? (_perujukRepository = new PerujukRepository(_transaction, _context)); }

        }

        public ISuratrujukanpuskesmasRepository SuratrujukanpuskesmasRepository
        {
            get { return _suratrujukanpuskesmasRepository ?? (_suratrujukanpuskesmasRepository = new SuratrujukanpuskesmasRepository(_transaction, _context)); }

        }

        public IIcdxkategoriRepository IcdxkategoriRepository
        {
            get { return _icdxkategoriRepository ?? (_icdxkategoriRepository = new IcdxkategoriRepository(_transaction, _context)); }

        }

        public IPropinsiRepository PropinsiRepository
        {
            get { return _propinsiRepository ?? (_propinsiRepository = new PropinsiRepository(_transaction, _context)); }

        }

        public IKotakabRepository KotakabRepository
        {
            get { return _kotakabRepository ?? (_kotakabRepository = new KotakabRepository(_transaction, _context)); }

        }

        public IKecRepository KecRepository
        {
            get { return _kecRepository ?? (_kecRepository = new KecRepository(_transaction, _context)); }

        }

        public IKeldesaRepository KeldesaRepository
        {
            get { return _keldesaRepository ?? (_keldesaRepository = new KeldesaRepository(_transaction, _context)); }

        }

        public IRwRepository RwRepository
        {
            get { return _rwRepository ?? (_rwRepository = new RwRepository(_transaction, _context)); }

        }

        public IRtRepository RtRepository
        {
            get { return _rtRepository ?? (_rtRepository = new RtRepository(_transaction, _context)); }

        }

        public IIcdxsubkategoriRepository IcdxsubkategoriRepository
        {
            get { return _icdxsubkategoriRepository ?? (_icdxsubkategoriRepository = new IcdxsubkategoriRepository(_transaction, _context)); }

        }

        public IIcdxpuskesmasRepository IcdxpuskesmasRepository
        {
            get { return _icdxpuskesmasRepository ?? (_icdxpuskesmasRepository = new IcdxpuskesmasRepository(_transaction, _context)); }

        }

        public IHubkeluargaRepository HubkeluargaRepository
        {
            get { return _hubkeluargaRepository ?? (_hubkeluargaRepository = new HubkeluargaRepository(_transaction, _context)); }

        }

        public IIdentitasdiriRepository IdentitasdiriRepository
        {
            get { return _identitasdiriRepository ?? (_identitasdiriRepository = new IdentitasdiriRepository(_transaction, _context)); }

        }

        public ISuratRujukanBPJSRepository SuratRujukanBPJSRepository
        {
            get { return _suratRujukanBPJSRepository ?? (_suratRujukanBPJSRepository = new SuratRujukanBPJSRepository(_transaction, _context)); }

        }

        public IKartuBPJSRepository KartuBPJSRepository
        {
            get { return _kartuBPJSRepository ?? (_kartuBPJSRepository = new KartuBPJSRepository(_transaction, _context)); }

        }

        public IKeluargaPasienRepository KeluargaPasienRepository
        {
            get { return _keluargaPasienRepository ?? (_keluargaPasienRepository = new KeluargaPasienRepository(_transaction, _context)); }

        }

        public IAgamaRepository AgamaRepository
        {
            get { return _agamaRepository ?? (_agamaRepository = new AgamaRepository(_transaction, _context)); }

        }

        public IRegistrasipasienbaruRepository RegistrasipasienbaruRepository
        {
            get { return _registrasipasienbaruRepository ?? (_registrasipasienbaruRepository = new RegistrasipasienbaruRepository(_transaction, _context)); }

        }

        public IRegistrasiruangrawatRepository RegistrasiruangrawatRepository
        {
            get { return _registrasiruangrawatRepository ?? (_registrasiruangrawatRepository = new RegistrasiruangrawatRepository(_transaction, _context)); }

        }

        public IPenjamindirisendiriRepository PenjamindirisendiriRepository
        {
            get { return _penjamindirisendiriRepository ?? (_penjamindirisendiriRepository = new PenjamindirisendiriRepository(_transaction, _context)); }

        }

        public IPuskesmasRepository PuskesmasRepository
        {
            get { return _puskesmasRepository ?? (_puskesmasRepository = new PuskesmasRepository(_transaction, _context)); }

        }

        public IAlamatpasienRepository AlamatpasienRepository
        {
            get { return _alamatpasienRepository ?? (_alamatpasienRepository = new AlamatpasienRepository(_transaction, _context)); }

        }

        public IListRegistrasiRepository ListRegistrasiRepository
        {
            get { return _listRegistrasiRepository ?? (_listRegistrasiRepository = new ListRegistrasiRepository(_transaction, _context)); }

        }

        public IRegistrasiPasienLamaRepository RegistrasiPasienLamaRepository
        {
            get { return _registrasiPasienLamaRepository ?? (_registrasiPasienLamaRepository = new RegistrasiPasienLamaRepository(_transaction, _context)); }

        }

        public IPelayananmedikRepository PelayananmedikRepository
        {
            get { return _pelayananmedikRepository ?? (_pelayananmedikRepository = new PelayananmedikRepository(_transaction, _context)); }

        }

        public ITempattidurRepository TempattidurRepository
        {
            get { return _tempattidurRepository ?? (_tempattidurRepository = new TempattidurRepository(_transaction, _context)); }

        }

        public IRegistrasipenunjangRepository RegistrasipenunjangRepository
        {
            get { return _registrasipenunjangRepository ?? (_registrasipenunjangRepository = new RegistrasipenunjangRepository(_transaction, _context)); }

        }

        public IRuangrawatRepository RuangrawatRepository
        {
            get { return _ruangrawatRepository ?? (_ruangrawatRepository = new RuangrawatRepository(_transaction, _context)); }

        }

        public IPelayananpasienRepository PelayananpasienRepository
        {
            get { return _pelayananpasienRepository ?? (_pelayananpasienRepository = new PelayananpasienRepository(_transaction, _context)); }

        }

        public ITarifRepository TarifRepository
        {
            get { return _tarifRepository ?? (_tarifRepository = new TarifRepository(_transaction, _context)); }

        }

        public IJenistarifRepository JenistarifRepository
        {
            get { return _jenistarifRepository ?? (_jenistarifRepository = new JenistarifRepository(_transaction, _context)); }

        }

        public IDokterRepository DokterRepository
        {
            get { return _dokterRepository ?? (_dokterRepository = new DokterRepository(_transaction, _context)); }

        }

        public IPerawatRepository PerawatRepository
        {
            get { return _perawatRepository ?? (_perawatRepository = new PerawatRepository(_transaction, _context)); }

        }

        public IPenjaminpasiendirisendiriRepository PenjaminpasiendirisendiriRepository
        {
            get { return _penjaminpasiendirisendiriRepository ?? (_penjaminpasiendirisendiriRepository = new PenjaminpasiendirisendiriRepository(_transaction, _context)); }

        }

        public IPenjaminpasienkeluargaRepository PenjaminpasienkeluargaRepository
        {
            get { return _penjaminpasienkeluargaRepository ?? (_penjaminpasienkeluargaRepository = new PenjaminpasienkeluargaRepository(_transaction, _context)); }

        }

        public IIdentitaspasienbpjsRepository IdentitaspasienbpjsRepository
        {
            get { return _identitaspasienbpjsRepository ?? (_identitaspasienbpjsRepository = new IdentitaspasienbpjsRepository(_transaction, _context)); }

        }

        public IPenjaminpasienbpjsRepository PenjaminpasienbpjsRepository
        {
            get { return _penjaminpasienbpjsRepository ?? (_penjaminpasienbpjsRepository = new PenjaminpasienbpjsRepository(_transaction, _context)); }

        }

        public IIdentitasdiripasienRepository IdentitasdiripasienRepository
        {
            get { return _identitasdiripasienRepository ?? (_identitasdiripasienRepository = new IdentitasdiripasienRepository(_transaction, _context)); }

        }

        public IJenisdiagnosaRepository JenisdiagnosaRepository
        {
            get { return _jenisdiagnosaRepository ?? (_jenisdiagnosaRepository = new JenisdiagnosaRepository(_transaction, _context)); }
        }

        public IIcdxpasienRepository IcdxpasienRepository
        {
            get { return _icdxpasienRepository ?? (_icdxpasienRepository = new IcdxpasienRepository(_transaction, _context)); }
        }
    }
}
