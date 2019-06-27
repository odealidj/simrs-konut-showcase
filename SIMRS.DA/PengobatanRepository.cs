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
    public class PengobatanRepository : IPengobatanRepository
    {
        private string sErrthrowClassName = "PengobatanRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PengobatanRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PengobatanRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(pengobatan obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@pengobatanid", obj.pengobatanid);


                _sql = @"[p_Deletepengobatan]";
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

        public pengobatan Get(pengobatan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pengobatan> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<pengobatan>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<pengobatan>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(pengobatan, string)> GetAsync(pengobatan obj)
        {
            throw new NotImplementedException();
        }

        public int Save(pengobatan obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@pengobatanid", obj.pengobatanid);
                p.Add("@registrasiruangrawatid", obj.registrasiruangrawatid);
                p.Add("@tglperiksa", obj.tglperiksa);
                p.Add("@dokterid", (obj.dokterid == -1) ? null : obj.dokterid);
                p.Add("@perawatid", (obj.perawatid == -1) ? null : obj.perawatid);
                p.Add("@pengobatannm", obj.pengobatannm);
                p.Add("@ukuran", obj.ukuran);
                p.Add("@satuan", obj.satuan);
                p.Add("@aturanpakai", obj.aturanpakai);



                _sql = @"[p_Savepengobatan]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                p = null;
                p = new DynamicParameters();
                p.Add("@pengobatannm", obj.pengobatannm);

                _sql = @"[p_Savepengobatannama]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                p = null;
                p = new DynamicParameters();
                p.Add("@ukuran", obj.ukuran);

                _sql = @"[p_Savepengobatanukuran]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                p = null;
                p = new DynamicParameters();
                p.Add("@satuan", obj.satuan);

                _sql = @"[p_Savepengobatansatuan]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                p = null;
                p = new DynamicParameters();
                p.Add("@aturanpakai", obj.aturanpakai);

                _sql = @"[p_Savepengobatanaturanpakai]";
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

        public bool Update(pengobatan obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_pengobatan>, string)> GetAllv_pengobatanByRegistrasiruangrawatidAsync(short registrasiruangrawatid)
        {
            #region query


            _sql = "SELECT * FROM v_pengobatan AS a \n"
                    + "WHERE a.registrasiruangrawatid = @registrasiruangrawatid \n"
                    + "ORDER BY a.tglperiksa, a.registrasiruangrawatid DESC";


            #endregion

            IEnumerable<v_pengobatan> list;

            try
            {

                list = await _context.db.QueryAsync<v_pengobatan>(_sql, new { registrasiruangrawatid = registrasiruangrawatid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_pengobatanByRegistrasiruangrawatidAsync(short registrasiruangrawatid)";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<pengobatanaturanpakai>, string) GetAllPengobatanaturanpakai()
        {
            #region query


            _sql = "SELECT * FROM pengobatanaturanpakai AS p ORDER BY p.aturanpakai";


            #endregion

            IEnumerable<pengobatanaturanpakai> list;

            try
            {

                list = _context.db.Query<pengobatanaturanpakai>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPengobatanaturanpakai()";
                sErrResult =ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<pengobatannama>, string) GetAllPengobatannama()
        {
            #region query


            _sql = "SELECT * FROM pengobatannama AS p ORDER BY p.pengobatannm";


            #endregion

            IEnumerable<pengobatannama> list;

            try
            {

                list = _context.db.Query<pengobatannama>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPengobatannama()";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<pengobatansatuan>, string) GetAllPengobatansatuan()
        {
            #region query


            _sql = "SELECT * FROM pengobatansatuan AS p ORDER BY p.satuan";


            #endregion

            IEnumerable<pengobatansatuan> list;

            try
            {

                list = _context.db.Query<pengobatansatuan>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPengobatansatuan()";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<pengobatanukuran>, string) GetAllPengobatanukuran()
        {
            #region query


            _sql = "SELECT * FROM pengobatanukuran AS p ORDER BY p.ukuran";


            #endregion

            IEnumerable<pengobatanukuran> list;

            try
            {

                list = _context.db.Query<pengobatanukuran>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllPengobatanukuran()";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
