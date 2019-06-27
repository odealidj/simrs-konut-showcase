using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using SIMRS.Model.view;

namespace SIMRS.DA
{
    public class AptstockopRepository : IAptstockopRepository
    {
        private string sErrthrowClassName = "AptstockopRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptstockopRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptstockopRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptstockop obj)
        {
            throw new NotImplementedException();
        }

        public aptstockop Get(aptstockop obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptstockop> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptstockop>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptstockop>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptstockop, string)> GetAsync(aptstockop obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptstockop obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptstockop obj)
        {
            throw new NotImplementedException();
        }

        (int, string) IAptstockopRepository.Save(aptstockop obj)
        {
            var result = 0;
            int aptstockopid = -1;
            sErrthrowMethodName = "Save";

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@aptstockopid", obj.aptstockopid, DbType.Int32, ParameterDirection.InputOutput);
                p.Add("@aptdepoid", obj.aptdepoid);
                p.Add("@aptstockopnm", obj.aptstockopnm);
                p.Add("@tglstockop", obj.tglstockop);
                p.Add("@jamstockop", obj.jamstockop);
                p.Add("@tahun", obj.tahun);
                p.Add("@bulan", obj.bulan);
                p.Add("@hari", obj.hari);


                _sql = @"p_Saveaptstockop"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                aptstockopid = p.Get<int>("aptstockopid");

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptstockopid, sErrResult);
        }

        string IAptstockopRepository.Delete(aptstockop obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptstockopid", obj.aptstockopid);

                _sql = @"[p_Deleteaptstockop]"; // @"usp_registrasiInsert";
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

        public async Task<(IEnumerable<v_aptbrggudetail_notin_stock>, string)> GetAll_v_aptbrggudetail_notin_stock()
        {
            #region query

            _sql = "SELECT * FROM v_aptbrggudetail_notin_stock ";
            _sql += "ORDER BY aptbarangnm,tglkadaluarsa ASC";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbrggudetail_notin_stock> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbrggudetail_notin_stock>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbrggudetail_notin_stock";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
