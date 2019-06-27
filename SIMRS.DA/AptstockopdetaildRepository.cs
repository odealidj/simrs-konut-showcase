using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SIMRS.Model.view;

namespace SIMRS.DA
{
    public class AptstockopdetaildRepository : IAptstockopdetaildRepository
    {
        private string sErrthrowClassName = "AptstockopdetaildRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptstockopdetaildRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptstockopdetaildRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(aptstockopdetaild obj)
        {
            throw new NotImplementedException();
        }

        public aptstockopdetaild Get(aptstockopdetaild obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptstockopdetaild> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptstockopdetaild>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptstockopdetaild>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptstockopdetaild, string)> GetAsync(aptstockopdetaild obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptstockopdetaild obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptstockopdetaild obj)
        {
            throw new NotImplementedException();
        }

        (int, string) IAptstockopdetaildRepository.Save(aptstockopdetaild obj)
        {
            var result = 0;
            int aptstockopdetailid = -1;
            sErrthrowMethodName = "Save";

            try
            {
                
                DynamicParameters p = new DynamicParameters();
                p.Add("@aptstockopdetailid", obj.aptstockopdetailid);
                p.Add("@aptstockopid", obj.aptstockopid);
                p.Add("@aptbrggudetailid", obj.aptbrggudetailid);
                p.Add("@jmlstock", obj.jmlstock);
                
                _sql = @"[p_Saveaptstockopdetaild]"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptstockopdetailid, sErrResult);
        }

        string IAptstockopdetaildRepository.Delete(aptstockopdetaild obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptstockopdetailid", obj.aptstockopdetailid);

                _sql = @"[p_Deleteaptstockopdetaild]"; // @"usp_registrasiInsert";
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

        public async Task<(IEnumerable<v_aptstockkontrol>, string)> GetAll_v_aptstockkontrol()
        {
            #region query

            _sql = "  SELECT [aptbarangid],[aptbarangnm],[isonline],[tahunbulanexpire],[defenisisatuan] "
                    +",SUM([jmlstock]) AS[jmlstock],[satuankecil],[hargaskecil],[hargapph],[harga35],[hargatoeslag] "
                    + ",[hargajual],[stsisonline] "
                    + "FROM[dbo].[v_aptstockkontrol] "
                    +"GROUP BY[aptbarangid],[aptbarangnm],[isonline],[tahunbulanexpire],[defenisisatuan] "
                    +",[satuankecil],[hargaskecil],[hargapph],[harga35],[hargatoeslag] "
                    + ",[hargajual],[stsisonline] "
                    + "ORDER BY[aptbarangnm],[tahunbulanexpire] ASC";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptstockkontrol> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptstockkontrol>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptstockkontrol";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
