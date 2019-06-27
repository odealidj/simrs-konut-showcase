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

namespace SIMRS.DA.Expand
{
    public class KartuBPJSRepository : IKartuBPJSRepository
    {
        private string sErrthrowClassName = "KartuBPJSRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public KartuBPJSRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public KartuBPJSRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public async Task<(IEnumerable<kelas>, IEnumerable<jk>, IEnumerable<kec>, string)> GetAllKelasBPJSAndJKAndKecKartuBPJSAsync(short? kotakabid)
        {
            sErrResult = null;
            IEnumerable<kelas> listKelas;
            IEnumerable<jk> listJK;
            IEnumerable<kec> listKec;

            #region query

            if (kotakabid != null)
            {
                _sql = "SELECT k.* FROM kelasbpjs kjs INNER JOIN kelas AS k \n" +
                    "ON k.kelasid = kjs.kelasbpjsid; \n" +
                    "SELECT * FROM jk AS j; \n" +
                    "SELECT * FROM kec AS k WHERE k.kotakabid = @kotakabid AND k.kecsts = '1';";
            }
            #endregion

            try
            {
                using (var multi = await _context.db.QueryMultipleAsync(_sql, new { kotakabid = kotakabid }, commandType: CommandType.Text))
                {
                    listKelas = multi.Read<kelas>();
                    listJK = multi.Read<jk>();
                    listKec = multi.Read<kec>();
                }

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllKelasAndJKAndKecKartuBPJSAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                listKelas = null; listJK = null; listKec = null;
            }

            return (listKelas, listJK, listKec, sErrResult);
        }
    }
}
