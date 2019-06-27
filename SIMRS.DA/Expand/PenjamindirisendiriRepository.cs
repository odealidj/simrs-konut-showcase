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
    public class PenjamindirisendiriRepository : IPenjamindirisendiriRepository
    {
        private string sErrthrowClassName = "PenjamindirisendiriRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PenjamindirisendiriRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PenjamindirisendiriRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public async Task<(IEnumerable<identitasdiri>, IEnumerable<jk>, IEnumerable<kec>, IEnumerable<pekerjaan>, string)> GetAllIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiriAsync(short? kotakabid)
        {

            IEnumerable<identitasdiri> listIdentitasdiri;
            IEnumerable<jk> listJK;
            IEnumerable<kec> listKec;
            IEnumerable<pekerjaan> listPekerjaan;

            #region query

            if (kotakabid != null)
            {
                _sql =
                    "SELECT i.identitasdiriid, i.identitasdirinm FROM identitasdiri AS i WHERE i.identitasdirists = '1'; \n" +
                    "SELECT * FROM jk AS j; \n" +
                    "SELECT * FROM kec AS k WHERE k.kotakabid = @kotakabid AND k.kecsts = '1'; \n" +
                    "SELECT * FROM pekerjaan AS p WHERE p.pekerjaansts = '1';";
            }
            #endregion

            try
            {
                using (var multi = await _context.db.QueryMultipleAsync(_sql, new { kotakabid = kotakabid }, commandType: CommandType.Text))
                {
                    
                    listIdentitasdiri = multi.ReadAsync<identitasdiri>().Result;
                    listJK = multi.ReadAsync<jk>().Result;
                    listKec = multi.ReadAsync<kec>().Result;
                    listPekerjaan = multi.ReadAsync<pekerjaan>().Result;
                }

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiriAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                listPekerjaan = null; listIdentitasdiri = null; listJK = null; listKec = null;
            }

            return (listIdentitasdiri, listJK, listKec, listPekerjaan,sErrResult);
        }

        public (IEnumerable<identitasdiri>, IEnumerable<jk>, IEnumerable<kec>, IEnumerable<pekerjaan>, string) GetAllIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri(short? kotakabid)
        {
            IEnumerable<identitasdiri> listIdentitasdiri;
            IEnumerable<jk> listJK;
            IEnumerable<kec> listKec;
            IEnumerable<pekerjaan> listPekerjaan;

            #region query

            if (kotakabid != null)
            {
                _sql =
                    "SELECT i.identitasdiriid, i.identitasdirinm FROM identitasdiri AS i WHERE i.identitasdirists = '1'; \n" +
                    "SELECT * FROM jk AS j; \n" +
                    "SELECT * FROM kec AS k WHERE k.kotakabid = @kotakabid AND k.kecsts = '1'; \n" +
                    "SELECT * FROM pekerjaan AS p WHERE p.pekerjaansts = '1';";
            }
            #endregion

            try
            {
                using (var multi = _context.db.QueryMultiple(_sql, new { kotakabid = kotakabid }, commandType: CommandType.Text))
                {

                    listIdentitasdiri = multi.Read<identitasdiri>();
                    listJK = multi.Read<jk>();
                    listKec = multi.Read<kec>();
                    listPekerjaan = multi.Read<pekerjaan>();
                }

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllIdentitasdiriAndJKAndKecByKotakabIdAndPekerjaanDiriSendiri";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                listPekerjaan = null; listIdentitasdiri = null; listJK = null; listKec = null;
            }

            return (listIdentitasdiri, listJK, listKec, listPekerjaan, sErrResult);
        }
    }
}
