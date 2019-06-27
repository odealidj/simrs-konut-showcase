using SIMRS.DA.IRepository;
using SIMRS.DA.IRepository.IExpand;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SIMRS.Model.view;

namespace SIMRS.DA.Expand
{
    public class RegistrasipasienbaruRepository : IRegistrasipasienbaruRepository
    {

        private string sErrthrowClassName = "RegistrasipasienbaruRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RegistrasipasienbaruRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RegistrasipasienbaruRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public async Task<(IEnumerable<jk>, IEnumerable<goldarah>, IEnumerable<kec>, IEnumerable<stspernikahan>, 
            IEnumerable<pendidikan>, IEnumerable<pekerjaan>, IEnumerable<agama>, 
            IEnumerable<suku>, IEnumerable<sapaan>, IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>, string)> 
            GetAllJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn(short? kotakabid,short? pelayananmedikid)
        {
            IEnumerable<jk> listJK;
            IEnumerable<goldarah> listGoldarah;
            IEnumerable<kec> listKec;
            IEnumerable<stspernikahan> listPernikahan;
            IEnumerable<pendidikan> listPendidikan;
            IEnumerable<pekerjaan> listPekerjaan;
            IEnumerable<agama> listAgama;
            IEnumerable<suku> listSuku;
            IEnumerable<sapaan> listSapaan;
            IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid> listVruangrawat_kelasruangrawatid_kamarid_tempattidurid;
            #region query

            if ( kotakabid !=null)
            {
                _sql = "SELECT * FROM jk AS j; \n" +
                    "SELECT * FROM goldarah AS g WHERE g.goldarahsts = '1'; \n" +
                    "SELECT * FROM kec AS k WHERE k.kotakabid = @kotakabid AND k.kecsts = '1'; \n" +
                    "SELECT * FROM stspernikahan AS s WHERE s.stspernikahansts= '1'; \n" +
                    "SELECT * FROM pendidikan AS p WHERE p.pendidikansts = '1'; \n" +
                    "SELECT * FROM pekerjaan AS p WHERE p.pekerjaansts = '1'; \n" +
                    "SELECT * FROM agama AS a WHERE a.agamasts = '1'; \n" +
                    "SELECT * FROM suku AS s WHERE s.sukusts = '1'; \n" +
                    "SELECT * FROM sapaan AS s WHERE s.sapaansts = '1';" +
                    "SELECT * FROM vruangrawat_kelasruangrawatid_kamarid_tempattidurid WHERE pelayananmedikid = @pelayananmedikid;";

            }
            #endregion

            try
            {
                using (var multi = await _context.db.QueryMultipleAsync(_sql, new { kotakabid = kotakabid, pelayananmedikid = pelayananmedikid }, commandType: CommandType.Text))
                {
                    listJK = multi.ReadAsync<jk>().Result;
                    listGoldarah = multi.ReadAsync<goldarah>().Result;
                    listKec = multi.ReadAsync<kec>().Result;
                    listPernikahan = multi.ReadAsync<stspernikahan>().Result;
                    listPendidikan = multi.ReadAsync<pendidikan>().Result; 
                    listPekerjaan = multi.ReadAsync<pekerjaan>().Result; 
                    listAgama = multi.ReadAsync<agama>().Result; 
                    listSuku = multi.ReadAsync<suku>().Result; 
                    listSapaan = multi.ReadAsync<sapaan>().Result; 
                    listVruangrawat_kelasruangrawatid_kamarid_tempattidurid = multi.ReadAsync<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>().Result;
                }

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllJKAndGolDarahAndKecByKotakabIdAndStsNikahAndPendiAndPekerAndAgamaAndSukuAsyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                listJK = null; listGoldarah = null; listKec = null; listPernikahan = null; listPendidikan = null;
                listPekerjaan = null; listAgama = null; listSuku = null; listSapaan = null;
                listVruangrawat_kelasruangrawatid_kamarid_tempattidurid = null;
            }

            return (listJK, listGoldarah, listKec, listPernikahan, listPendidikan, listPekerjaan,
                    listAgama, listSuku, listSapaan, listVruangrawat_kelasruangrawatid_kamarid_tempattidurid,sErrResult);
        }

    }
}
