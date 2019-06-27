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
    public class CarapulangRepository : ICarapulangRepository
    {
        private string sErrthrowClassName = "CarapulangRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public CarapulangRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public CarapulangRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(carapulang obj)
        {
            throw new NotImplementedException();
        }

        public carapulang Get(carapulang obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<carapulang> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<carapulang>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<carapulang>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<carapulang>, string)> GetAllByPelayananmedikIdAsync(short pelayananmedikid)
        {
            #region query

            _sql = "SELECT * FROM carapulang AS c WHERE c.pelayananmedikid = @pelayananmedikid And c.carapulangsts = '1'";

            #endregion

            IEnumerable<carapulang> list = null;

            try
            {

                list = await _context.db.QueryAsync<carapulang>(_sql, new { pelayananmedikid  = pelayananmedikid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByPelayananmedikIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(carapulang, string)> GetAsync(carapulang obj)
        {
            throw new NotImplementedException();
        }

        public int Save(carapulang obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(carapulang obj)
        {
            throw new NotImplementedException();
        }
    }
}
