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
    public class AptbarangsatuanRepository : IAptbarangsatuanRepository
    {
        private string sErrthrowClassName = "AptbarangsatuanRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptbarangsatuanRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptbarangsatuanRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(aptbarangsatuan obj)
        {
            throw new NotImplementedException();
        }

        public aptbarangsatuan Get(aptbarangsatuan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptbarangsatuan> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptbarangsatuan>, string)> GetAllAsync()
        {
            sErrResult = null;

            _sql = "SELECT *  FROM aptbarangsatuan AS a WHERE a.sts = '1'";


            IEnumerable<aptbarangsatuan> list;

            try
            {

                list = await _context.db.QueryAsync<aptbarangsatuan>(_sql, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<aptbarangsatuan>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptbarangsatuan, string)> GetAsync(aptbarangsatuan obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptbarangsatuan obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptbarangsatuan obj)
        {
            throw new NotImplementedException();
        }

        (int, string) IAptbarangsatuanRepository.Save(aptbarangsatuan obj)
        {
            var result = 0;
            int aptbarangsatuanid = -1;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangsatuanid", obj.aptbarangsatuanid, DbType.Int16, ParameterDirection.InputOutput);
                p.Add("@aptbarangid", obj.aptbarangid);
                p.Add("@aptpbfid", obj.aptpbfid);
                p.Add("@satuankecilkode", obj.satuankecilkode);
                p.Add("@jmlsatuankecil", obj.jmlsatuankecil);
                p.Add("@satuanbesarkode", obj.satuanbesarkode);
                p.Add("@jmlsatuanbesar", obj.jmlsatuanbesar);

                _sql = @"p_Saveaptbarangsatuan"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                aptbarangsatuanid = p.Get<short>("aptbarangsatuanid");

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptbarangsatuanid, sErrResult);
        }

        string IAptbarangsatuanRepository.Delete(aptbarangsatuan obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangsatuanid", obj.aptbarangsatuanid);

                _sql = @"[p_Deleteaptbarangsatuan]"; // @"usp_registrasiInsert";
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

        public async Task<(IEnumerable<v_aptbarangsatuan_pbf>, string)> GetAllByAptbarangidAsync(short aptbarangid)
        {
            sErrResult = null;

            _sql = "SELECT *  FROM v_aptbarangsatuan_pbf AS a WHERE  a.aptbarangid = @aptbarangid";


            IEnumerable<v_aptbarangsatuan_pbf> list;

            try
            {

                list = await _context.db.QueryAsync<v_aptbarangsatuan_pbf>(_sql, new { aptbarangid = aptbarangid }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByAptbarangidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<aptbarangsatuan>, string)> GetAllByIdAsync(short aptbarangsatuanid)
        {
            sErrResult = null;

            _sql = "SELECT *  FROM aptbarangsatuan AS a WHERE a.aptbarangsatuanid = @aptbarangsatuanid AND  a.sts = '1'";


            IEnumerable<aptbarangsatuan> list;

            try
            {

                list = await _context.db.QueryAsync<aptbarangsatuan>(_sql, new { aptbarangsatuanid = aptbarangsatuanid }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbarangsatuan_pbf>, string)> GetAll_v_aptbarangsatuanAsync()
        {
            sErrResult = null;

            _sql = "SELECT *  FROM v_aptbarangsatuan_pbf";


            IEnumerable<v_aptbarangsatuan_pbf> list;

            try
            {

                list = await _context.db.QueryAsync<v_aptbarangsatuan_pbf>(_sql, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarangsatuanAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        Task<(IEnumerable<v_aptbarangsatuan>, string)> IAptbarangsatuanRepository.GetAll_v_aptbarangsatuanAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_aptbarangsatuan_pbf>, string)> GetAll_v_aptbarangsatuan_pbfByPbfAsync(short pbfid)
        {
            sErrResult = null;

            _sql = "SELECT *  FROM v_aptbarangsatuan_pbf WHERE aptpbfid = @aptpbfid";


            IEnumerable<v_aptbarangsatuan_pbf> list;



            try
            {

                list = await _context.db.QueryAsync<v_aptbarangsatuan_pbf>(_sql, new { aptpbfid = pbfid }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarangsatuanAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }



       
    }
}
