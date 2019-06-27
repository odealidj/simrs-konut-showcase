using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SIMRS.DA
{
    public class AptdepoRepository : IAptdepoRepository
    {
        private string sErrthrowClassName = "AptdepoRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptdepoRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptdepoRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptdepo obj)
        {
            throw new NotImplementedException();
        }

        public aptdepo Get(aptdepo obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptdepo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptdepo>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptdepo>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptdepo, string)> GetAsync(aptdepo obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptdepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptdepo obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptdepo>, string)> GetAllAsync(string filtered)
        {
            #region query
            if (string.IsNullOrEmpty(filtered))
            {
                _sql = "SELECT* FROM aptdepo AS a \n"
                    + "WHERE a.aptdepoid <> 57 and a.sts = '1'";
            }
            else
            {
                _sql = "SELECT* FROM aptdepo AS a \n"
                    + "WHERE a.aptdepoid <> 57  And a.aptdepoid + a.aptdeponm LIKE @filtered AND a.sts = '1'";
            }
            #endregion

            IEnumerable<aptdepo> list;

            try
            {
                if (string.IsNullOrEmpty(filtered))
                {
                    list = await _context.db.QueryAsync<aptdepo>(_sql, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<aptdepo>(_sql, new { filtered = string.Format("%{0}%", filtered) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        (int, string) IAptdepoRepository.Save(aptdepo obj)
        {

            int aptdepoid = -1;
            sErrthrowMethodName = "Save";

            try
            {


                DynamicParameters p = new DynamicParameters();
                p.Add("@aptdepoid", obj.aptdepoid);
                p.Add("@aptdeponm", obj.aptdeponm);

                _sql = @"p_Saveaptdepo"; // @"usp_registrasiInsert";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);


                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptdepoid, sErrResult);
        }

        string IAptdepoRepository.Delete(aptdepo obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptdepoid", obj.aptdepoid);

                _sql = @"[p_Deleteaptdepo]"; // @"usp_registrasiInsert";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Delete";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return sErrResult;
        }
    }
}
