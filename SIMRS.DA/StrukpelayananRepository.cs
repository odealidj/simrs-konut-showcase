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
    public class StrukpelayananRepository : IStrukpelayananRepository
    {
        private string sErrthrowClassName = "StrukpelayananRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public StrukpelayananRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public StrukpelayananRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(strukpelayanan obj)
        {
            var result = false;

            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@strukpelayananid", obj.strukpelayananid);
                
                _sql = @"[p_Deletestrukpelayanan]";
                _context.db.ExecuteScalar<int>(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                result = true;
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Delete";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = false;
            }

            return result;
        }

        public strukpelayanan Get(strukpelayanan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<strukpelayanan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<strukpelayanan>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<strukpelayanan>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(strukpelayanan, string)> GetAsync(strukpelayanan obj)
        {
            throw new NotImplementedException();
        }

        public int Save(strukpelayanan obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@strukpelayananid", obj.strukpelayananid);
                p.Add("@strukpelayanannostruk", obj.strukpelayanannostruk);
                p.Add("@strukpelayanantgl", obj.strukpelayanantgl);
                p.Add("@strukpelayananjam", obj.strukpelayananjam);
                p.Add("@strukpelayanannokw", obj.strukpelayanannokw);
                p.Add("@grandtotalbiaya", obj.grandtotalbiaya);
                p.Add("@grandtotalbayar", obj.grandtotalbayar);
                p.Add("@grandtotalpiutang", obj.grandtotalpiutang);
                p.Add("@grandtotalbebas", obj.grandtotalbebas);
                p.Add("@loginappid", (obj.loginappid == -1) ? null : obj.loginappid);
                p.Add("@created_date", DateTime.Now);
                p.Add("@updated_date", null);
                p.Add("@strukpelayanansts", true);

                _sql = @"[p_Savestrukpelayanan]";
                result = _context.db.ExecuteScalar<int>(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }

        public bool Update(strukpelayanan obj)
        {
            throw new NotImplementedException();
        }
    }
}
