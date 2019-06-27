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
    public class PelayananmedikRepository : IPelayananmedikRepository
    {
        private string sErrthrowClassName = "PelayananmedikRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PelayananmedikRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PelayananmedikRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(pelayananmedik obj)
        {
            throw new NotImplementedException();
        }

        public pelayananmedik Get(pelayananmedik obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pelayananmedik> GetAll()
        {
            #region query

            _sql = "SELECT * FROM pelayananmedik AS p WHERE p.pelayananmediksts = '1'";

            #endregion

            IEnumerable<pelayananmedik> list = null;

            try
            {

                list = _context.db.Query<pelayananmedik>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public Task<(IEnumerable<pelayananmedik>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<pelayananmedik>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(pelayananmedik, string)> GetAsync(pelayananmedik obj)
        {
            throw new NotImplementedException();
        }

        public int Save(pelayananmedik obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(pelayananmedik obj)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<pelayananmedik>,string) GetAllByModulappkode(string modulappkode)
        {
            throw new NotImplementedException();
        }

        public async Task<(pelayananmedik, string)> GetAllPelayananmedikByModulappkodeAsync(string modulappkode)
        {
            #region query

            if (!string.IsNullOrEmpty(modulappkode))
            {
                _sql = "SELECT p.pelayananmedikid,p.pelayananmediknm \n" +
                        "FROM modulapp AS m INNER JOIN pelayananmedik AS p ON p.pelayananmedikid = m.pelayananmedikid \n" +
                        "WHERE m.modulappkode = @modulappkode AND m.modulappsts = '1' AND p.pelayananmediksts = '1'";
            }

            #endregion

            pelayananmedik list;

            try
            {
                //if (!string.IsNullOrEmpty(modulappkode))
                //{
                list =  await _context.db.QueryFirstOrDefaultAsync<pelayananmedik>(_sql, new { modulappkode = string.Format("{0}", modulappkode) }, commandType: CommandType.Text);
                //}
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPelayananmedikByModulappkodeAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (pelayananmedik, string) GetAllPelayananmedikByModulappkode(string modulappkode)
        {
            #region query

            if (!string.IsNullOrEmpty(modulappkode))
            {
                _sql = "SELECT p.pelayananmedikid,p.pelayananmediknm \n" +
                        "FROM modulapp AS m INNER JOIN pelayananmedik AS p ON p.pelayananmedikid = m.pelayananmedikid \n" +
                        "WHERE m.modulappkode = @modulappkode AND m.modulappsts = '1' AND p.pelayananmediksts = '1'";
            }

            #endregion

            pelayananmedik list;

            try
            {
                //if (!string.IsNullOrEmpty(modulappkode))
                //{
                list = _context.db.QueryFirstOrDefault<pelayananmedik>(_sql, new { modulappkode = string.Format("{0}", modulappkode) }, commandType: CommandType.Text);
                //}
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPelayananmedikByModulappkodeAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
