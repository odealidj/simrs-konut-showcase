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
    public class RtRepository : IRtRepository
    {
        private string sErrthrowClassName = "RtRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RtRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RtRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(rt obj)
        {
            throw new NotImplementedException();
        }

        public rt Get(rt obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<rt> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<rt>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<rt>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<rt>, string)> GetAllRtByRwIdAsync(short? rwid)
        {
            #region query
            _sql = "SELECT * FROM rt AS r WHERE r.rwid =@rwid AND r.rtsts = '1'";
            #endregion

            IEnumerable<rt> list;

            try
            {
                list = await _context.db.QueryAsync<rt>(_sql, new { rwid = rwid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllRtByRwIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(rt, string)> GetAsync(rt obj)
        {
            throw new NotImplementedException();
        }

        public int Save(rt obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(rt obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<vrtrw>, string)> GetAllVrtrwByKeldesaidAsync(short? keldesaid)
        {
            #region query
            _sql = "SELECT * FROM vrtrw WHERE keldesaid = @keldesaid";
            #endregion

            IEnumerable<vrtrw> list;

            try
            {
                list = await _context.db.QueryAsync<vrtrw>(_sql, new { keldesaid = keldesaid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVrtrwBykeldesaidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);

        }

        public async Task<(IEnumerable<vrtrw>, string)> GetAllVrtrwByKeldesaidAndRtrwNameAsync(short? keldesaid, string rtrwname)
        {
            #region query

            if (string.IsNullOrEmpty(rtrwname))
            {
                _sql = "SELECT rwid, rtid, rtrw FROM vrtrw AS v1 WHERE keldesaid = @keldesaid";
            }
            else
            {
                _sql = "SELECT rwid, rtid, rtrw FROM vrtrw AS v1 WHERE keldesaid = @keldesaid AND rtrw LIKE @rtrw";
            }
            
            #endregion

            IEnumerable<vrtrw> list;

            try
            {
                if (string.IsNullOrEmpty(rtrwname))
                {
                    list = await _context.db.QueryAsync<vrtrw>(_sql, new { keldesaid = keldesaid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<vrtrw>(_sql, new { keldesaid = keldesaid, rtrw =rtrwname}, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVrtrwByKeldesaidAndRtrwNameAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
