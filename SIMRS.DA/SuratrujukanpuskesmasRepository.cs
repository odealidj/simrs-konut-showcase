using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class SuratrujukanpuskesmasRepository : ISuratrujukanpuskesmasRepository
    {
        private string sErrthrowClassName = "SuratrujukanpuskesmasRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public SuratrujukanpuskesmasRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public SuratrujukanpuskesmasRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(suratrujukanpuskesmas obj)
        {
            throw new NotImplementedException();
        }

        public suratrujukanpuskesmas Get(suratrujukanpuskesmas obj)
        {
            #region query
            _sql = "SELECT * FROM suratrujukanpuskesmas AS s WHERE s.suratrujukanpuskesmasid = @suratrujukanpuskesmasid";
            #endregion

           suratrujukanpuskesmas list;

            try
            {
                list = _context.db.QueryFirstOrDefault<suratrujukanpuskesmas>(_sql, new { suratrujukanpuskesmasid = obj.suratrujukanpuskesmasid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Get";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public IEnumerable<suratrujukanpuskesmas> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<suratrujukanpuskesmas>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<suratrujukanpuskesmas>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<suratrujukanpuskesmas> GetAllSuratRujukanPuskesmasByPerujukId(short perujukid)
        {
            #region query
            _sql = "SELECT * FROM suratrujukanpuskesmas AS s WHERE s.perujukid = @perujukid AND s.suratrujukanpuskesmassts = '1';";
            #endregion

            IEnumerable<suratrujukanpuskesmas> list;

            try
            {
                list = _context.db.Query<suratrujukanpuskesmas>(_sql, new { perujukid = perujukid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public async Task<(IEnumerable<suratrujukanpuskesmas>, string)> GetAllSuratRujukanPuskesmasByPerujukIdAsync(short perujukid)
        {
            #region query
            _sql = "SELECT * FROM suratrujukanpuskesmas AS s WHERE s.perujukid = @perujukid AND s.suratrujukanpuskesmassts = '1';";
            #endregion

            IEnumerable<suratrujukanpuskesmas> list;

            try
            {
                list = await _context.db.QueryAsync<suratrujukanpuskesmas>(_sql, new { perujukid = perujukid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllSuratRujukanPuskesmasByPerujukIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public int Save(suratrujukanpuskesmas obj)
        {
            var result = -99;
            //short? suratrujukanpuskesmasid = -1;
          
            sErrthrowMethodName = "Save";

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@suratrujukanpuskesmasid", obj.suratrujukanpuskesmasid);
                p.Add("@suratrujukanpuskesmastgl", obj.suratrujukanpuskesmastgl);
                p.Add("@suratrujukanpuskesmasno", obj.suratrujukanpuskesmasno);
                p.Add("@puskesmasid", obj.puskesmasid);
                p.Add("@ruangrawatid", obj.ruangrawatid);
                p.Add("@icdxsubkategoriid", obj.icdxsubkategoriid);
                p.Add("@icdxpuskesmasid", (obj.icdxpuskesmasid == -1) ? null : obj.icdxpuskesmasid);
                p.Add("@suratrujukanpuskesmassts", obj.suratrujukanpuskesmassts);
                p.Add("@created_date", DateTime.Now);
                p.Add("@updated_date", obj.updated_date);
                p.Add("@suratrujukanpuskesmassts", obj.suratrujukanpuskesmassts);

                _sql = @"p_Savesuratrujukanpuskesmas"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                //suratrujukanpuskesmasid = p.Get<short>("suratrujukanpuskesmasid");
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                result = -99;
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                //suratrujukanpuskesmasid = null;
            }
            return (int)result;
        }

        public bool Update(suratrujukanpuskesmas obj)
        {
            throw new NotImplementedException();
        }

        public Task<(suratrujukanpuskesmas, string)> GetAsync(suratrujukanpuskesmas obj)
        {
            throw new NotImplementedException();
        }
    }
}
