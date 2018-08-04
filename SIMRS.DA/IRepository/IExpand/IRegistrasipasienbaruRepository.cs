using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA.IRepository.IExpand
{
    public interface IRegistrasipasienbaruRepository
    {
        Task<(IEnumerable<jk>, IEnumerable<goldarah>, IEnumerable<kec>, IEnumerable<stspernikahan>,
                IEnumerable<pendidikan>, IEnumerable<pekerjaan>, IEnumerable<agama>,
                IEnumerable<suku>, IEnumerable<sapaan>,IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>,string)> 
            GetAllJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(short? kotakabid,short? pelayananmedikid);

        //(short, string) Save (identitaspasien _identitaspasien, registrasi _registrasi, registrasiruangrawat _registrasiruangrawat);
    } 
}
