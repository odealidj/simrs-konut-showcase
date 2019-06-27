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
    public class AptsatuanRepository : IAptsatuanRepository
    {
        private string sErrthrowClassName = "AptsatuanRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptsatuanRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptsatuanRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptsatuan obj)
        {
            throw new NotImplementedException();
        }

        public aptsatuan Get(aptsatuan obj)
        {
            #region query

            _sql = "SELECT * FROM aptsatuan AS a WHERE a.aptsatuankode = @aptsatuankode and a.aptsatuansts = 1";


            #endregion

            aptsatuan list;

            try
            {
                
                list = _context.db.QueryFirstOrDefault<aptsatuan>(_sql, new { aptsatuankode = obj.aptsatuankode  }, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public IEnumerable<aptsatuan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptsatuan>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptsatuan>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptsatuan, string)> GetAsync(aptsatuan obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptsatuan obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptsatuan obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptsatuan>, string)> GetAllAsync(string filtered)
        {
            #region query
            if (string.IsNullOrEmpty(filtered))
            {
                _sql = "SELECT a.aptsatuankode FROM aptsatuan AS a \n"
                    + "WHERE a.aptsatuansts = '1' \n"
                    +"ORDER BY a.aptsatuankode";
            }
            else
            {
                _sql = "SELECT a.aptsatuankode FROM aptsatuan AS a \n"
                    + "WHERE a.aptsatuankode LIKE @filtered AND a.aptsatuansts = '1' \n"
                    +"ORDER BY a.aptsatuankode";
            }
            #endregion

            IEnumerable<aptsatuan> list;

            try
            {
                if (string.IsNullOrEmpty(filtered))
                {
                    list = await _context.db.QueryAsync<aptsatuan>(_sql, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<aptsatuan>(_sql, new { filtered = string.Format("%{0}%", filtered) }, commandType: CommandType.Text);
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

        public async Task<(IEnumerable<aptsatuan>, string)> GetAllNotInKodeAsync(string aptsatuankode)
        {
           
            _sql = "SELECT * FROM aptsatuan AS a \n"
                    + "WHERE a.aptsatuankode <> @aptsatuankode AND a.aptsatuansts = '1' \n"
                    + "ORDER BY a.aptsatuankode";
            
            IEnumerable<aptsatuan> list;

            try
            {
               
                
                    list = await _context.db.QueryAsync<aptsatuan>(_sql, new { aptsatuankode = aptsatuankode }, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllNotInKodeAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        (int, string) IAptsatuanRepository.Save(aptsatuan obj, string newaptsatuankode)
        {
            int aptsatuanid = -1;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptsatuankode", obj.aptsatuankode);
                p.Add("@newaptsatuankode", newaptsatuankode);

                _sql = @"[p_Saveaptsatuan]"; // @"usp_registrasiInsert";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);


                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptsatuanid, sErrResult);
        }

        string IAptsatuanRepository.Delete(aptsatuan obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptsatuankode", obj.aptsatuankode);

                _sql = @"[p_Deleteaptsatuan]"; // @"usp_registrasiInsert";
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
