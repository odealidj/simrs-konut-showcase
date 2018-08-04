using SIMRS.DA.IRepository.IExpand;
using SIMRS.DA.IRepository.IExpand.RekamMedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository
{
    public interface IUnitOfWork : IDisposable
    {

        //INegaraRepository NegaraRepository { get; }
        IIdentitaspasienRepository IdentitaspasienRepository { get; }
        IInstalasipelayananRepository InstalasipelayananRepository { get; }
        IRegistrasiRepository RegistrasiRepository { get; }
        ILoginappRepository LoginappRepository { get; }
        
        ILoginappdetailRepository LoginappdetailRepository { get; }
        ILoginmodulappRepository LoginmodulappRepository { get; }
        IPenjaminRepository PenjaminRepository { get; }
        IKelasRepository KelasRepository { get; }
        IJkRepository JkRepository { get; }
        IRuangrawatrujukanRepository RuangrawatrujukanRepository { get; }
        IPerujukRepository PerujukRepository { get; }
        ISuratrujukanpuskesmasRepository SuratrujukanpuskesmasRepository { get; }
        IIcdxkategoriRepository IcdxkategoriRepository { get; }
        IPropinsiRepository PropinsiRepository { get; }
        IKotakabRepository KotakabRepository { get; }
        IKecRepository KecRepository { get; }
        IKeldesaRepository KeldesaRepository { get; }
        IRwRepository RwRepository { get; }
        IRtRepository RtRepository { get; }
        IIcdxsubkategoriRepository IcdxsubkategoriRepository { get; }
        IIcdxpuskesmasRepository IcdxpuskesmasRepository { get; }
        IIdentitasdiriRepository IdentitasdiriRepository { get; }
        IHubkeluargaRepository HubkeluargaRepository { get; }
        ISuratRujukanBPJSRepository SuratRujukanBPJSRepository { get; }
        IKartuBPJSRepository KartuBPJSRepository { get; }
        IKeluargaPasienRepository KeluargaPasienRepository { get; }
        IAgamaRepository AgamaRepository { get; }
        IRegistrasiruangrawatRepository RegistrasiruangrawatRepository { get; }
        IPenjamindirisendiriRepository PenjamindirisendiriRepository { get; }
        IRegistrasipasienbaruRepository RegistrasipasienbaruRepository { get; }
        IPuskesmasRepository PuskesmasRepository { get; }
        IAlamatpasienRepository AlamatpasienRepository { get; }
        IListRegistrasiRepository ListRegistrasiRepository { get; }
        IRegistrasiPasienLamaRepository RegistrasiPasienLamaRepository { get; }
        IPelayananmedikRepository PelayananmedikRepository { get; }
        ITempattidurRepository TempattidurRepository { get; }
        IRegistrasipenunjangRepository RegistrasipenunjangRepository { get; }
        IRuangrawatRepository RuangrawatRepository { get; }
        IPelayananpasienRepository PelayananpasienRepository { get; }
        ITarifRepository TarifRepository { get; }
        IJenistarifRepository JenistarifRepository { get; }
        IDokterRepository DokterRepository { get; }
        IPerawatRepository PerawatRepository { get; }
        IPenjaminpasiendirisendiriRepository PenjaminpasiendirisendiriRepository { get; }
        IPenjaminpasienkeluargaRepository PenjaminpasienkeluargaRepository { get; }
        IIdentitaspasienbpjsRepository IdentitaspasienbpjsRepository { get; }
        IPenjaminpasienbpjsRepository PenjaminpasienbpjsRepository { get; }
        IIdentitasdiripasienRepository IdentitasdiripasienRepository { get; }
        IJenisdiagnosaRepository JenisdiagnosaRepository { get; }
        IIcdxpasienRepository IcdxpasienRepository { get; }
        IPemeriksaanfisikRepository PemeriksaanfisikRepository { get; }
        IAnamnesapasienRepository AnamnesapasienRepository { get; }
        IPengobatanRepository PengobatanRepository { get; }
        IPelayananpasienpelunasanRepository PelayananpasienpelunasanRepository { get; }
        IStrukpelayananRepository StrukpelayananRepository { get; }
        ICarapulangRepository CarapulangRepository { get; }

        //rekam medis
        IPengunjungRepository PengunjungRepository { get; }


        IAptdepoRepository AptdepoRepository { get; }
        IAptsatuanRepository AptsatuanRepository { get; }
        IAptbarangRepository AptbarangRepository { get; }

        IAptdef1brgRepository Aptdef1brgRepository { get; }

        IAptpbfRepository AptpbfRepository { get; }

        IAptbarangmasukRepository AptbarangmasukRepository { get; }
        IAptbarangmasukdetailRepository AptbarangmasukdetailRepository { get; }

        IAptstockopgudangRepository AptstockopgudangRepository { get; }
        IAptstockopgudangdetailRepository AptstockopgudangdetailRepository { get; }

        IAptdistribusiRepository AptdistribusiRepository { get; }
        IAptdistribusidetailRepository  AptdistribusidetailRepository { get; }


        IAptbrgguRepository AptbrgguRepository { get; }

        IAptbrggudetailRepository AptbrggudetailRepository { get; }

        IAptbarangsatuanRepository AptbarangsatuanRepository { get; }


        IAptbarangsatuantriggerRepository AptbarangsatuantriggerRepository { get; }

        IRLRepository RLRepository { get; }

        IAptstsbgrmasukdetailRepository AptstsbgrmasukdetailRepository { get; }

        IAptstockopRepository AptstockopRepository { get; }
        IAptstockopdetaildRepository AptstockopdetaildRepository { get; }

        void BeginTransaction();

        void Commit();

    }
}
