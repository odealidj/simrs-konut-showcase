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
    public class AptbrggudetailRepository : IAptbrggudetailRepository
    {

        private string sErrthrowClassName = "AptbrggudetailRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptbrggudetailRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptbrggudetailRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(aptbrggudetail obj)
        {
            throw new NotImplementedException();
        }

        public aptbrggudetail Get(aptbrggudetail obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptbrggudetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptbrggudetail>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptbrggudetail>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptbrggudetail, string)> GetAsync(aptbrggudetail obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptbrggudetail obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptbrggudetail obj)
        {
            throw new NotImplementedException();
        }

        
        (int, string) IAptbrggudetailRepository.Save(aptbrggudetail obj)
        {
            var result = 0;
            int aptbrgguid = -1;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbrggudetailid", obj.aptbrggudetailid);
                p.Add("@aptbrgguid", obj.aptbrgguid);
                p.Add("@hargaskecil", obj.hargaskecil);
                p.Add("@hargapph", obj.hargapph);
                p.Add("@harga35", obj.harga35);
                p.Add("@hargatoeslag", obj.hargatoeslag);
                p.Add("@hargajual", obj.hargajual);


                _sql = @"p_Saveaptbrggudetail"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptbrgguid, sErrResult);
        }

        

        

        string IAptbrggudetailRepository.Delete(aptbrggudetail obj)
        {
            throw new NotImplementedException();
        }

        public (int, string) Save(short aptbrggudetailid, short aptbrgguid, short aptbarangmasukid)
        {
            var result = 0;

            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbrggudetailid", aptbrggudetailid);
                p.Add("@aptbrgguid", aptbrgguid);
                p.Add("@aptbarangmasukid", aptbarangmasukid);
               
                _sql = @"p_Saveaptbrggudetail3"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (-1, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(short aptbrgguid)
        {
            #region query

            _sql = "SELECT * FROM v_aptbrggudetail WHERE aptbrgguid = @aptbrgguid";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbrggudetail>(_sql, new { aptbrgguid = aptbrgguid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptbrggudetailByAptbrgguidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(short aptbrgguid, string namabarang)
        {
            #region query

            _sql = "SELECT * FROM v_aptbrggudetail WHERE aptbrgguid = @aptbrgguid ";
            _sql = _sql + "AND aptbarangnm LIKE @namabarang ";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbrggudetail>(_sql, new { aptbrgguid = aptbrgguid,
                    namabarang = string.Format("%{0}%",namabarang) } , commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptbrggudetailByAptbrgguidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public string UpdateTarif(aptbrggudetail obj)
        {
            var result = 0;

            sErrthrowMethodName = "UpdateTarif";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbrggudetailid", obj.aptbrggudetailid );
                p.Add("@harga35", obj.harga35);
                p.Add("@hargatoeslag", obj.hargatoeslag);
                p.Add("@hargajual", obj.hargajual);


                _sql = @"p_Updateaptbrggudetail"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "UpdateTarif";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return sErrResult;
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync()
        {
            #region query

            _sql = "SELECT * FROM v_aptbrggudetail ORDER BY tglgu DESC, aptbarangnm ASC";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbrggudetail>(_sql,  commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptbrggudetailByAptbrgguidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(string tahun, string bulan)
        {
            #region query

            _sql = "SELECT * FROM v_aptbrggudetail WHERE tahun = @tahun AND bulan = @bulan  ORDER BY tglgu DESC, aptbarangnm ASC";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbrggudetail>(_sql, new { tahun= tahun, bulan= bulan }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptbrggudetailByAptbrgguidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_aptbrggudetail>, string)> GetAllv_aptbrggudetailByAptbrgguidAsync(string namabarang)
        {
            #region query

            _sql = "SELECT * FROM v_aptbrggudetail WHERE aptbarangnm LIKE @namabarang ORDER BY tglgu DESC, aptbarangnm ASC";
            //+ "ORDER BY aptbarangmasukdetailid ASC";

            #endregion

            IEnumerable<v_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbrggudetail>(_sql, new { namabarang = string.Format("%{0}%",namabarang) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptbrggudetailByAptbrgguidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
