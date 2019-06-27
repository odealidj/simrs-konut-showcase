using SIMRS.DA.IRepository;
using SIMRS.DA.IRepository.IExpand;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA.Expand
{
    public class SuratRujukanBPJSRepository : ISuratRujukanBPJSRepository
    {
        private string sErrthrowClassName = "SuratRujukanBPJSRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public SuratRujukanBPJSRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public SuratRujukanBPJSRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public async Task<(IEnumerable<puskesmas>, IEnumerable<ruangrawatrujukan>, IEnumerable<vicdxpuskesmas>, string)> GetAllPuskesmasByPerujukIdAndGetAllRuangRawatRujukanAndVicdxpuskesmasAsync(short? puskesmasperujukid)
        {

            IEnumerable<puskesmas> listPuskesmas;
            IEnumerable<ruangrawatrujukan> listRuangrawatrujukan;
            IEnumerable<vicdxpuskesmas> listVicdxpuskesmas;

            #region query

            if (puskesmasperujukid != null)
            {
                _sql = "SELECT * FROM puskesmas AS p WHERE p.perujukid = @perujukid AND  p.puskesmassts = '1'; \n" +
                    "SELECT * FROM ruangrawatrujukan AS r WHERE r.ruangrawatsts = '1'; \n" +
                    "SELECT * FROM vicdxpuskesmas AS v;";
            }
            #endregion

            try
            {
                    using (var multi = await _context.db.QueryMultipleAsync(_sql, new { perujukid = puskesmasperujukid } , commandType: CommandType.Text))
                    {
                        listPuskesmas = multi.ReadAsync<puskesmas>().Result;
                        listRuangrawatrujukan = multi.ReadAsync<ruangrawatrujukan>().Result;
                        listVicdxpuskesmas = multi.ReadAsync<vicdxpuskesmas>().Result;
                    }
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPuskesmasByPerujukIdAndGetAllRuangRawatRujukanAndVicdxpuskesmasAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                listPuskesmas = null; listRuangrawatrujukan = null; listVicdxpuskesmas = null;
            }

            return (listPuskesmas, listRuangrawatrujukan, listVicdxpuskesmas, sErrResult);
        }
    }
}
