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
    public class AnamnesapasienRepository : IAnamnesapasienRepository
    {
        private string sErrthrowClassName = "AnamnesapasienRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AnamnesapasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AnamnesapasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(anamnesapasien obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {


                DynamicParameters p = new DynamicParameters();
                p.Add("@anamnesapasienid", obj.anamnesapasienid);
                

                _sql = @"[p_Deleteanamnesapasien]";
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

            if (result != -99)
                return true;
            else
                return false;

        }

        public anamnesapasien Get(anamnesapasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<anamnesapasien> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<anamnesapasien>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<anamnesapasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(anamnesapasien, string)> GetAsync(anamnesapasien obj)
        {
            throw new NotImplementedException();
        }

        public int Save(anamnesapasien obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {


                DynamicParameters p = new DynamicParameters();
                p.Add("@anamnesapasienid", obj.anamnesapasienid);
                p.Add("@registrasiruangrawatid", obj.registrasiruangrawatid);
                p.Add("@keluhanutama", obj.keluhanutama);
                p.Add("@keluhantambahan", obj.keluhantambahan);
                p.Add("@imunisasi", obj.imunisasi);
                p.Add("@tglperiksa", obj.tglperiksa);
                p.Add("@dokterid", (obj.dokterid == -1) ? null : obj.dokterid);
                p.Add("@perawatid", (obj.perawatid == -1) ? null : obj.perawatid);
                
               
                _sql = @"[p_Saveanamnesapasien]";
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

        public bool Update(anamnesapasien obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_anamnesapasien>, string)> GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid)
        {
            #region query


            _sql = "SELECT * FROM v_anamnesapasien AS a \n"
                    + "WHERE a.registrasiruangrawatid = @registrasiruangrawatid \n"
                    +"ORDER BY a.tglperiksa, a.registrasiruangrawatid DESC";


            #endregion

            IEnumerable<v_anamnesapasien> list;

            try
            {

                list = await _context.db.QueryAsync<v_anamnesapasien>(_sql, new { registrasiruangrawatid = registrasiruangrawatid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid)";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_anamnesapasien>, string)> GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid, DateTime tglperiksa)
        {
            #region query


            _sql = "SELECT * FROM v_anamnesapasien AS a \n"
                    + "WHERE a.registrasiruangrawatid = @registrasiruangrawatid and a.tglperiksa = @tglperiksa\n"
                    + "ORDER BY a.tglperiksa, a.registrasiruangrawatid DESC";


            #endregion

            IEnumerable<v_anamnesapasien> list;

            try
            {

                list = await _context.db.QueryAsync<v_anamnesapasien>(_sql, new { registrasiruangrawatid = registrasiruangrawatid, tglperiksa = tglperiksa.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_anamnesapasienByRegistrasiruangrawatidAsync(short registrasiruangrawatid)";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
