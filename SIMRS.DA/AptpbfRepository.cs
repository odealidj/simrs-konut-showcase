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
    public class AptpbfRepository : IAptpbfRepository
    {
        private string sErrthrowClassName = "AptpbfRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptpbfRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptpbfRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptpbf obj)
        {
            throw new NotImplementedException();
        }

        public aptpbf Get(aptpbf obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptpbf> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptpbf>, string)> GetAllAsync()
        {
            #region query

            _sql = "SELECT * FROM aptpbf WHERE aptpbfsts = '1'";

            #endregion

            IEnumerable<aptpbf> list;

            try
            {
                list = await _context.db.QueryAsync<aptpbf>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<aptpbf>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptpbf, string)> GetAsync(aptpbf obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptpbf obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptpbf obj)
        {
            throw new NotImplementedException();
        }

        (int, string) IAptpbfRepository.Save(aptpbf obj)
        {
            int aptpbfid = -1;
            sErrthrowMethodName = "Save";

            try
            {


                DynamicParameters p = new DynamicParameters();
                p.Add("@aptpbfid", obj.aptpbfid);
                p.Add("@aptpbfnm", obj.aptpbfnm);

                _sql = @"p_Saveaptpbf"; // @"usp_registrasiInsert";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);


                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptpbfid, sErrResult);
        }

        string IAptpbfRepository.Delete(aptpbf obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptpbfid", obj.aptpbfid);

                _sql = @"[p_Deleteaptpbf]"; // @"usp_registrasiInsert";
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
