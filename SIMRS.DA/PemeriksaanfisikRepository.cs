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
    public class PemeriksaanfisikRepository : IPemeriksaanfisikRepository
    {

        private string sErrthrowClassName = "PemeriksaanfisikRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PemeriksaanfisikRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PemeriksaanfisikRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(pemeriksaanfisik obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@pemeriksaanfisikid", obj.pemeriksaanfisikid);
                

                _sql = @"[p_Deletepemeriksaanfisik]";
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

        public pemeriksaanfisik Get(pemeriksaanfisik obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pemeriksaanfisik> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<pemeriksaanfisik>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<pemeriksaanfisik>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(pemeriksaanfisik, string)> GetAsync(pemeriksaanfisik obj)
        {
            throw new NotImplementedException();
        }

        public int Save(pemeriksaanfisik obj)
        {
            var result = -1;
            short? pemeriksaanfisikid = 0;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@pemeriksaanfisikid", obj.pemeriksaanfisikid, DbType.Int16, ParameterDirection.Output);
                p.Add("@tglperiksafisik", obj.tglperiksafisik);
                p.Add("@registrasiruangrawatid", obj.registrasiruangrawatid);
                p.Add("@perawatid", obj.perawatid);
                p.Add("@dokterid", obj.dokterid);
                p.Add("@tensi", obj.tensi);
                p.Add("@suhu", obj.suhu);
                p.Add("@beratbadan", obj.beratbadan);
                p.Add("@nadi", obj.nadi);
                p.Add("@respirasi", obj.respirasi);
                p.Add("@kesadaran", obj.kesadaran);
                p.Add("@kepala", obj.kepala);
                p.Add("@leher", obj.leher);
                p.Add("@dada", obj.dada);
                p.Add("@perut", obj.perut);
                p.Add("@punggung", obj.punggung);
                p.Add("@daerahgenetalis", obj.daerahgenetalis);
                p.Add("@extremitas_atas", obj.extremitas_atas);
                p.Add("@extremitas_bwh", obj.extremitas_bwh);
                p.Add("@terapi", obj.terapi);
                p.Add("@tinggibadan", obj.tinggibadan);
                p.Add("@lila", obj.lila);


                _sql = @"[p_Savepemeriksaanfisik]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                pemeriksaanfisikid = p.Get<short>("pemeriksaanfisikid");
                result = (int)pemeriksaanfisikid;
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -1;
            }

            return result;
        }

        public bool Update(pemeriksaanfisik obj)
        {
            throw new NotImplementedException();
        }

        public async  Task<(IEnumerable<pemeriksaanfisik>, string)> GetAllAsync(short pemeriksaanfisikid)
        {
            #region query

            
                _sql = "SELECT * FROM pemeriksaanfisik AS p \n"
                        +"WHERE p.pemeriksaanfisikid = @pemeriksaanfisikid";

           
            #endregion

            IEnumerable<pemeriksaanfisik> list;

            try
            {

                    list = await _context.db.QueryAsync<pemeriksaanfisik>(_sql, new { pemeriksaanfisikid = pemeriksaanfisikid }, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync(short pemeriksaanfisikid)";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_pemeriksaanfisik>, string)> GetAllv_pemeriksaanfisikAsync(short pemeriksaanfisikid)
        {
            #region query


            _sql = "SELECT * FROM v_pemeriksaanfisik AS p \n"
                    + "WHERE p.pemeriksaanfisikid = @pemeriksaanfisikid";


            #endregion

            IEnumerable<v_pemeriksaanfisik> list;

            try
            {

                list = await _context.db.QueryAsync<v_pemeriksaanfisik>(_sql, new { pemeriksaanfisikid = pemeriksaanfisikid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync(short pemeriksaanfisikid)";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_pemeriksaanfisik>, string)> GetAllv_pemeriksaanfisikByregistrasiruangrawatidAsync(short registrasiruangrawatid,DateTime tglperiksa)
        {
            #region query


            _sql = "SELECT * FROM v_pemeriksaanfisik AS p \n"
                    + "WHERE p.registrasiruangrawatid = @registrasiruangrawatid AND p.tglperiksafisik = @tglperiksafisik";


            #endregion

            IEnumerable<v_pemeriksaanfisik> list;

            try
            {

                list = await _context.db.QueryAsync<v_pemeriksaanfisik>(_sql, new { registrasiruangrawatid = registrasiruangrawatid, tglperiksafisik = tglperiksa.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync(short pemeriksaanfisikid)";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
