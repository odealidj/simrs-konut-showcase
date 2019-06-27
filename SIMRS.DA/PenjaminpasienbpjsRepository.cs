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
    public class PenjaminpasienbpjsRepository : IPenjaminpasienbpjsRepository
    {
        private string sErrthrowClassName = "PenjaminpasienbpjsRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PenjaminpasienbpjsRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PenjaminpasienbpjsRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(penjaminpasienbpjs obj)
        {
            throw new NotImplementedException();
        }

        public penjaminpasienbpjs Get(penjaminpasienbpjs obj)
        {
            #region query
            _sql = "SELECT * FROM penjaminpasienbpjs AS p \n"
                    + "WHERE p.penjaminpasienbpjsid = @penjaminpasienbpjsid";
            #endregion

            penjaminpasienbpjs list;

            try
            {
                list = _context.db.QueryFirstOrDefault<penjaminpasienbpjs>(_sql, new { penjaminpasienbpjsid = obj.penjaminpasienbpjsid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Get";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public IEnumerable<penjaminpasienbpjs> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<penjaminpasienbpjs>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<penjaminpasienbpjs>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(penjaminpasienbpjs, string)> GetAsync(penjaminpasienbpjs obj)
        {
            throw new NotImplementedException();
        }

        public int Save(penjaminpasienbpjs obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@penjaminpasienbpjsid", obj.penjaminpasienbpjsid);
                p.Add("@nosep", obj.nosep);
                p.Add("@tglsep", obj.tglsep);
                p.Add("@ruangrawatid", (obj.ruangrawatid==-1)?null: obj.ruangrawatid);
                p.Add("@icdxsubkategoriid", (obj.icdxsubkategoriid == string.Empty)?null: obj.icdxsubkategoriid);
                p.Add("@icdxpuskesmasid", (obj.icdxpuskesmasid==-1)?null: obj.icdxpuskesmasid);
                p.Add("@diagnosaalt", obj.diagnosaalt);
                p.Add("@created_date", obj.created_date);
                p.Add("@updated_date", obj.updated_date);
                p.Add("@penjaminpasienbpjssts", obj.penjaminpasienbpjssts);

                _sql = @"[p_Savepenjaminpasienbpjs]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

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

        public bool Update(penjaminpasienbpjs obj)
        {
            throw new NotImplementedException();
        }
    }
}
