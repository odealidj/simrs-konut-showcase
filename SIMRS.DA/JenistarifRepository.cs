using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA
{
    public class JenistarifRepository : IJenistarifRepository
    {
        private string sErrthrowClassName = "JenistarifRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public JenistarifRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public JenistarifRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(jenistarif obj)
        {
            throw new NotImplementedException();
        }

        public jenistarif Get(jenistarif obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<jenistarif> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<jenistarif>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<jenistarif>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_jenistarifpenjamin>, string)> GetAllVjenistarifpenjaminByPenjaminIdAsync(short penjaminid)
        {
            #region query

                _sql = "SELECT * FROM v_jenistarifpenjamin WHERE penjaminpasienid = @penjaminpasienid ORDER BY jenistarifid ASC";

            #endregion

            IEnumerable<v_jenistarifpenjamin> list = null;

            try
            {

                list = await _context.db.QueryAsync<v_jenistarifpenjamin>(_sql, new { penjaminpasienid = penjaminid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVjenistarifpenjaminByPenjaminIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(jenistarif, string)> GetAsync(jenistarif obj)
        {
            throw new NotImplementedException();
        }

        public int Save(jenistarif obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(jenistarif obj)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_jenistarifpenjamin>, string) GetAllVjenistarifpenjaminByPenjaminId(short penjaminid)
        {
            #region query

            _sql = "SELECT * FROM v_jenistarifpenjamin WHERE penjaminpasienid = @penjaminpasienid ORDER BY jenistarifid ASC";

            #endregion

            IEnumerable<v_jenistarifpenjamin> list = null;

            try
            {

                list = _context.db.Query<v_jenistarifpenjamin>(_sql, new { penjaminpasienid = penjaminid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVjenistarifpenjaminByPenjaminIdAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (jenistarif, string) GetJenistarifByRuangrawatIdAndPenjaminId(short ruangrawatid, short penjaminid)
        {
            #region query

            _sql = "SELECT TOP 1 j.* FROM ruangrawat AS r \n"
                + "INNER JOIN ruangrawatjenistarif AS r2 ON r2.ruangrawatid = r.ruangrawatid \n"
                + "INNER JOIN jenistarif AS j ON j.jenistarifid = r2.jenistarifid \n"
                + "INNER JOIN jenistarifpenjaminpasien AS j2 ON j2.jenistarifid = j.jenistarifid \n"
                + "WHERE r.ruangrawatid = @ruangrawatid AND j2.penjaminpasienid = @penjaminpasienid AND r.ruangrawatsts = '1' AND r2.sts = '1' \n"
                + "AND j.jenistarifsts = '1' AND j2.sts = '1'";


            #endregion

            jenistarif list = null;

            try
            {

                list = _context.db.QueryFirstOrDefault<jenistarif>(_sql, new { ruangrawatid = ruangrawatid, penjaminpasienid = penjaminid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetJenistarifByRuangrawatIdAndPenjaminId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
