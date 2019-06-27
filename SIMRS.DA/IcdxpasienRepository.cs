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
    public class IcdxpasienRepository : IIcdxpasienRepository
    {
        private string sErrthrowClassName = "IcdxpasienRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public IcdxpasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IcdxpasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(icdxpasien obj)
        {
            var result = false;

            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@icdxpasienid", obj.icdxpasienid);
                
                _sql = @"[p_Deleteicdxpasien]";
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

        public icdxpasien Get(icdxpasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<icdxpasien> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<icdxpasien>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<icdxpasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(icdxpasien, string)> GetAsync(icdxpasien obj)
        {
            throw new NotImplementedException();
        }

        public int Save(icdxpasien obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@icdxpasienid", obj.icdxpasienid);
                p.Add("@icdxsubkategoriid", obj.icdxsubkategoriid);
                p.Add("@registrasiruangrawatid", obj.registrasiruangrawatid);
                p.Add("@icdxpasientgl", obj.icdxpasientgl);
                p.Add("@jenisdiagnosaid", (obj.jenisdiagnosaid == -1) ? null : obj.jenisdiagnosaid);
                p.Add("@dokterid", (obj.dokterid == -1) ? null : obj.dokterid);
                p.Add("@loginappid", (obj.loginappid==-1)?null: obj.loginappid);
                p.Add("@created_date", obj.created_date);
                p.Add("@updated_date", obj.updated_date);
                p.Add("@icdxpasiensts", obj.icdxpasiensts);

                _sql = @"[p_Saveicdxpasien]";
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

        public bool Update(icdxpasien obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_icdxpasienpoli>, string)> GetAllVicdxpasienpoliAsync(short registrasiruangrawatid)
        {
            #region query

            _sql = "SELECT* FROM v_icdxpasienpoli WHERE registrasiruangrawatid = @registrasiruangrawatid \n"
                + "ORDER BY icdxpasienid ASC";

            #endregion

            IEnumerable<v_icdxpasienpoli> list = null;

            try
            {

                list = await _context.db.QueryAsync<v_icdxpasienpoli>(_sql, new { registrasiruangrawatid = registrasiruangrawatid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVicdxpasienpoliAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
