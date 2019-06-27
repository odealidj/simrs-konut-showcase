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
    public class KeluargaPasienRepository : IKeluargaPasienRepository
    {
        private string sErrthrowClassName = "KeluargaPasienRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public KeluargaPasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public KeluargaPasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public async Task<(IEnumerable<hubkeluarga>, IEnumerable<identitasdiri>, IEnumerable<jk>, IEnumerable<kec>, string)> GetAllHubkeluargaAndIdentitasdiriAndJKAndKecByKotakabIdKeluargaPasienAsync(short? kotakabid)
        {
            IEnumerable<hubkeluarga> listHubkeluarga;
            IEnumerable<identitasdiri> listIdentitasdiri;
            IEnumerable<jk> listJK;
            IEnumerable<kec> listKec;

            #region query

            if (kotakabid != null)
            {
                _sql = "SELECT h.hubkeluargaid,h.hubkeluarganm FROM hubkeluarga AS h WHERE h.hubkeluargasts = '1'; \n" +
                    "SELECT i.identitasdiriid, i.identitasdirinm FROM identitasdiri AS i WHERE i.identitasdirists = '1'; \n" +
                    "SELECT * FROM jk AS j; \n" +
                    "SELECT * FROM kec AS k WHERE k.kotakabid = @kotakabid AND k.kecsts = '1';";
            }
            #endregion

            try
            {
                using (var multi = await _context.db.QueryMultipleAsync(_sql, new { kotakabid = kotakabid }, commandType: CommandType.Text))
                {
                    listHubkeluarga = multi.ReadAsync<hubkeluarga>().Result;
                    listIdentitasdiri = multi.ReadAsync<identitasdiri>().Result;
                    listJK = multi.ReadAsync<jk>().Result;
                    listKec = multi.ReadAsync<kec>().Result;
                }

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllHubkeluargaAndIdentitasdiriAndJKAndKecByKotakabIdKeluargaPasienAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                listHubkeluarga = null; listIdentitasdiri = null; listJK = null; listKec = null;
            }

            return (listHubkeluarga, listIdentitasdiri, listJK, listKec, sErrResult);
        }
    }
}
