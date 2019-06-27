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
    public class RuangrawatrujukanRepository : IRuangrawatrujukanRepository
    {
        private string sErrthrowClassName = "RuangrawatrujukanRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RuangrawatrujukanRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RuangrawatrujukanRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(ruangrawatrujukan obj)
        {
            throw new NotImplementedException();
        }

        public ruangrawatrujukan Get(ruangrawatrujukan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ruangrawatrujukan> GetAll()
        {
            #region query
            _sql = "SELECT * FROM ruangrawatrujukan AS r WHERE r.ruangrawatsts = '1'";
            #endregion

            IEnumerable<ruangrawatrujukan> list = null;

            try
            {
                list = _context.db.Query<ruangrawatrujukan>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult =  ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public async Task<(IEnumerable<ruangrawatrujukan>, string)> GetAllAsync()
        {
            #region query
            _sql = "SELECT * FROM ruangrawatrujukan AS r WHERE r.ruangrawatsts = '1'";
            #endregion

            IEnumerable<ruangrawatrujukan> list = await Task.FromResult<IEnumerable<ruangrawatrujukan>>(null);

            try
            {
                list = await _context.db.QueryAsync<ruangrawatrujukan>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<ruangrawatrujukan>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(ruangrawatrujukan obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(ruangrawatrujukan obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<ruangrawatrujukan>, string)> GetAllRuangRawatRujukanByNameAsync(string namaruangrawat)
        {
            #region query
            _sql = "SELECT * FROM ruangrawatrujukan AS r\n "
                    + "WHERE r.ruangrawatnm LIKE @ruangrawatnm";
            #endregion

            IEnumerable<ruangrawatrujukan> list;

            try
            {
                list = await _context.db.QueryAsync<ruangrawatrujukan>(_sql, new { ruangrawatnm = string.Format("%{0}%", namaruangrawat) }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(ruangrawatrujukan, string)> GetAsync(ruangrawatrujukan obj)
        {
            throw new NotImplementedException();
        }

        public (pelayananmedik, string) GetPelayananmedikByRuangrawatrujukanId(short ruangrawatid)
        {
            #region query
            _sql = "SELECT p.* FROM ruangrawatrujukan AS r INNER JOIN pelayananmedik AS p \n" +
                    "ON p.pelayananmedikid = r.pelayananmedikid \n" +
                    "WHERE r.ruangrawatid = @ruangrawatid";
            #endregion

            pelayananmedik p;

            try
            {
                p = _context.db.QueryFirstOrDefault<pelayananmedik>(_sql, new { ruangrawatid = ruangrawatid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetPelayananmedikByRuangrawatrujukanIdAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                p = null;
            }

            return (p, sErrResult);
        }

        public async Task<(pelayananmedik, string)> GetPelayananmedikByRuangrawatrujukanIdAsync(short ruangrawatid)
        {
            #region query
            _sql = "SELECT p.* FROM ruangrawatrujukan AS r INNER JOIN pelayananmedik AS p \n" +
                    "ON p.pelayananmedikid = r.pelayananmedikid \n" +
                    "WHERE r.ruangrawatid = @ruangrawatid";
            #endregion

            pelayananmedik p;

            try
            {
                p = await _context.db.QueryFirstOrDefaultAsync<pelayananmedik>(_sql, new { ruangrawatid =ruangrawatid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetPelayananmedikByRuangrawatrujukanIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                p = null;
            }

            return (p, sErrResult);
        }

        (IEnumerable<ruangrawatrujukan>, string) IRuangrawatrujukanRepository.GetAll()
        {
            sErrResult = null;
            #region query
            _sql = "SELECT * FROM ruangrawatrujukan AS r WHERE r.ruangrawatsts = '1'";
            #endregion

            IEnumerable<ruangrawatrujukan> list = null;

            try
            {
                list = _context.db.Query<ruangrawatrujukan>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list,sErrResult);
        }
    }
}
