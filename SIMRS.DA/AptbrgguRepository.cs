using Dapper;
using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS.DA
{
    public class AptbrgguRepository : IAptbrgguRepository
    {

        private string sErrthrowClassName = "AptbrgguRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptbrgguRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptbrgguRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptbrggu obj)
        {
            throw new NotImplementedException();
        }

        public aptbrggu Get(aptbrggu obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptbrggu> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptbrggu>, string)> GetAllAsync()
        {
            #region query

            _sql = "SELECT * FROM aptbrggu AS a ORDER BY a.aptgudangid DESC";

            #endregion

            IEnumerable<aptbrggu> list;

            try
            {
                list = await _context.db.QueryAsync<aptbrggu>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<aptbrggu>, string)> GetAllAsync(string tahun, string bulan)
        {
            #region query

            _sql = "SELECT * FROM aptbrggu AS a WHERE a.tahun = @tahun AND a.bulan = @bulan ORDER BY a.aptgudangid DESC";

            #endregion

            IEnumerable<aptbrggu> list;

            try
            {
                list = await _context.db.QueryAsync<aptbrggu>(_sql, new { tahun = tahun, bulan = bulan }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<aptbrggu>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptbrggu, string)> GetAsync(aptbrggu obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptbrggu obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptbrggu obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_aptbarangmasuk_pbf_aptbrggu>, string)> GetAll_v_aptbarangmasuk_pbf_aptbrggu(short aptbrgguid)
        {
            #region query

            _sql = "SELECT * FROM v_aptbarangmasuk_pbf_aptbrggu WHERE aptbrgguid = @aptbrgguid \n"
                    + "ORDER BY aptbarangmasukid ASC";

            #endregion

            IEnumerable<v_aptbarangmasuk_pbf_aptbrggu> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbarangmasuk_pbf_aptbrggu>(_sql, new { aptbrgguid= aptbrgguid}, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarangmasuk_pbf_aptbrggu";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbarangmasukdetail_aptbrggudetail>, string)> GetAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbrgguid, short aptbarangmasukid)
        {
            #region query

            _sql = "SELECT * FROM v_aptbarangmasukdetail_aptbrggudetail \n"
                + "WHERE aptbrgguid = @aptbrgguid AND aptbarangmasukid = @aptbarangmasukid \n"
                + "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbarangmasukdetail_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbarangmasukdetail_aptbrggudetail>(_sql, new { aptbrgguid = aptbrgguid, aptbarangmasukid= aptbarangmasukid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarangmasukdetail_aptbrggudetail";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbarangmasukdetail_aptbrggudetail>, string)> GetAll_v_aptbarangmasukdetail_aptbrggudetail(short aptbarangmasukdetailid)
        {
            #region query

            _sql = "SELECT * FROM v_aptbarangmasukdetail_aptbrggudetail \n"
                + "WHERE aptbarangmasukdetailid = @aptbarangmasukdetailid ";
                //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbarangmasukdetail_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbarangmasukdetail_aptbrggudetail>(_sql, new { aptbarangmasukdetailid = aptbarangmasukdetailid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarangmasukdetail_aptbrggudetail";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(v_aptgenerateharga, string)> GetAll_v_aptgenerateharga(short aptbarangmasukdetailid)
        {
            #region query

            _sql = "SELECT * FROM v_aptgenerateharga WHERE aptbarangmasukdetailid =@aptbarangmasukdetailid  ";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            v_aptgenerateharga list;

            try
            {
                list = await _context.db.QueryFirstOrDefaultAsync<v_aptgenerateharga>(_sql, new { aptbarangmasukdetailid = aptbarangmasukdetailid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptgenerateharga";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        (int, string) IAptbrgguRepository.Save(aptbrggu obj)
        {
            var result = 0;
            int aptbrgguid = -1;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbrgguid", obj.aptbrgguid, DbType.Int32, ParameterDirection.InputOutput);
                p.Add("@aptgudangid", obj.aptgudangid);
                p.Add("@loginid", obj.loginid);
                p.Add("@tglgu", obj.tglgu);
                p.Add("@jamgu", obj.jamgu);
                p.Add("@tahun", obj.tahun);
                p.Add("@bulan", obj.bulan);
                p.Add("@ket", obj.ket);
                
                _sql = @"p_Saveaptbrggu"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                aptbrgguid = p.Get<int>("aptbrgguid");

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptbrgguid, sErrResult);
        }

        string IAptbrgguRepository.Delete(aptbrggu obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbrgguid", obj.aptbrgguid);

                _sql = @"[p_Deleteaptbrggu]"; // @"usp_registrasiInsert";
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

        public string SaveAptbrggudetail(short aptbrggudetailid, short aptbrgguid, short aptbarangmasukid)
        {
            var result = 0;
            sErrthrowMethodName = "SaveAptbrggudetail";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbrggudetailid", aptbrggudetailid);
                p.Add("@aptbrgguid", aptbrgguid);
                p.Add("@aptbarangmasukid", aptbarangmasukid);
                
                _sql = @"p_Saveaptbrggudetail2"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                

            }
            catch (Exception ex)
            {
                //sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return sErrResult;
        }
    }
}
