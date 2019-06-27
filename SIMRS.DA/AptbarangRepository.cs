using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class AptbarangRepository : IAptbarangRepository
    {

        private string sErrthrowClassName = "AptbarangRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptbarangRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptbarangRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(aptbarang obj)
        {
            throw new NotImplementedException();
        }

        public aptbarang Get(aptbarang obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptbarang> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptbarang>, string)> GetAllAsync()
        {
            sErrResult = null;

                _sql = "SELECT * FROM aptbarang AS a WHERE a.aptbarangsts = '1'";

            
            IEnumerable<aptbarang> list;

            try
            {
                
                list = await _context.db.QueryAsync<aptbarang>(_sql,  commandType: CommandType.Text);
               
               
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GGetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<aptbarang>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<v_aptbarang>, string)> GetAll_v_aptbarang_ByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_aptbarang>, string)> GetAll_v_aptbarang_ByPageIndex(int pageIndex, int pageSize, string filtered)
        {
            #region query
            if (string.IsNullOrEmpty(filtered))
            {
                _sql = "SELECT * FROM v_aptbarang AS a\n"
                    + "ORDER BY a.aptbarangnm ASC \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";

            }
            else
            {
                _sql = "SELECT * FROM v_aptbarang AS a\n"
                + "WHERE a.aptbarangnm LIKE @filter \n"
                + "ORDER BY a.aptbarangnm ASC \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";
            }
            #endregion

            IEnumerable<v_aptbarang> list;

            try
            {
                if (string.IsNullOrEmpty(filtered))
                {
                    list = await _context.db.QueryAsync<v_aptbarang>(_sql, new { pageIndex = pageIndex, pageSize =pageSize }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_aptbarang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, filter = string.Format("%{0}%", filtered) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarang_ByPageIndex";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbarang>, string)> GetAll_v_aptbarang_ByPageIndexAndAptdef1id(int pageIndex, int pageSize, string aptdef1id)
        {
            #region query

            _sql = "SELECT * FROM v_aptbarang AS a\n"
          + "WHERE a.aptdef1kode = @aptdef1kode  \n"
          + "ORDER BY a.aptbarangnm ASC \n"
          + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
          + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_aptbarang> list;

            try
            {
               
                
                    list = await _context.db.QueryAsync<v_aptbarang>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, aptdef1kode = string.Format("{0}", aptdef1id) }, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarang_ByPageIndexAndAptdef1id";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(aptbarang, string)> GetAsync(aptbarang obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptbarang obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptbarang obj)
        {
            throw new NotImplementedException();
        }

        (int, string) IAptbarangRepository.Save(aptbarang obj)
        {

            var result = 0;
            int aptbarangid = -1;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangid", obj.aptbarangid);
                p.Add("@aptdef1id", obj.aptdef1id);
                p.Add("@aptbarangnm", obj.aptbarangnm);

                _sql = @"p_Saveaptbarang"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptbarangid, sErrResult);
        }

        string IAptbarangRepository.Delete(aptbarang obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangid", obj.aptbarangid);

                _sql = @"[p_Deleteaptbarang]"; // @"usp_registrasiInsert";
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
