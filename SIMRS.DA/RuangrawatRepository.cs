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
    public class RuangrawatRepository : IRuangrawatRepository
    {
        private string sErrthrowClassName = "RuangrawatRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RuangrawatRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RuangrawatRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(ruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public ruangrawat Get(ruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ruangrawat> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<ruangrawat>, string)> GetAllAsync()
        {
            #region query
            _sql = "SELECT * FROM ruangrawat AS r where  r.ruangrawatsts = '1'";
            #endregion

            IEnumerable<ruangrawat> list;

            try
            {
                list = await _context.db.QueryAsync<ruangrawat>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllasyn";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<ruangrawat>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(ruangrawat, string)> GetAsync(ruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public int Save(ruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(ruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<ruangrawat>, string)> GetAllByPelayananmedikIdAsync(short pelayananmedikid)
        {
            #region query
            _sql = "SELECT * FROM ruangrawat AS r WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatsts = '1'";
            #endregion

            IEnumerable<ruangrawat> list;

            try
            {
                list = await _context.db.QueryAsync<ruangrawat>(_sql, new { pelayananmedikid = pelayananmedikid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByPelayananmedikIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>, string) GetAllvruangrawat_kelasruangrawatid_kamarid_tempattidurid(short pelayananmedikid)
        {
            #region query


            _sql = "SELECT * FROM vruangrawat_kelasruangrawatid_kamarid_tempattidurid WHERE pelayananmedikid = @pelayananmedikid;";


            #endregion

            IEnumerable<vruangrawat_kelasruangrawatid_kamarid_tempattidurid> list;

            try
            {
                list = _context.db.Query<vruangrawat_kelasruangrawatid_kamarid_tempattidurid>(_sql, new { pelayananmedikid = pelayananmedikid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllvruangrawat_kelasruangrawatid_kamarid_tempattidurid";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
