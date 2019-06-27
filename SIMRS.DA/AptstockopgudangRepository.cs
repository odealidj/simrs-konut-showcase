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
    public class AptstockopgudangRepository : IAptstockopgudangRepository
    {
        private string sErrthrowClassName = "AptstockopgudangRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptstockopgudangRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptstockopgudangRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(aptstockopgudang obj)
        {
            throw new NotImplementedException();
        }

        public aptstockopgudang Get(aptstockopgudang obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptstockopgudang> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptstockopgudang>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptstockopgudang>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptstockopgudang, string)> GetAsync(aptstockopgudang obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptstockopgudang obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptstockopgudang obj)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<v_aptstockopgudang>, string)> GetAll_v_aptstockopgudangByYearAndMonthAsync(short year, short month)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_aptstockopgudang>, string) GetAll_v_aptstockopgudangByYearAndMonth(short year, short month)
        {
            #region query

            _sql = "SELECT * FROM v_aptstockopgudang AS a \n"
                + "WHERE Year(a.tglmasukgudang) = @year AND MONTH(a.tglmasukgudang) = @month \n"
                    + "ORDER BY a.tglmasukgudang ASC; ";

            #endregion

            IEnumerable<v_aptstockopgudang> list;

            try
            {

                list = _context.db.Query<v_aptstockopgudang>(_sql, new { year =year, month= month } , commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelian";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptstockopgudang>, string) GetAll_v_aptstockopgudang()
        {
            #region query

            _sql = "SELECT * FROM v_aptstockopgudang AS a \n"
                    +"ORDER BY a.tglmasukgudang ASC; ";

            #endregion

            IEnumerable<v_aptstockopgudang> list;

            try
            {

                list = _context.db.Query<v_aptstockopgudang>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelian";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptstockopgudang>, string) GetAll_v_aptstockopgudangByYearAndMonthAndKet(string value)
        {
            #region query

            _sql = "SELECT * FROM v_aptstockopgudang AS a \n"
                + "WHERE a.tahunstock+a.bulanstock+a.ketgudang LIKE @value \n"
                    + "ORDER BY a.tglmasukgudang ASC; ";

            #endregion

            IEnumerable<v_aptstockopgudang> list;

            try
            {

                list = _context.db.Query<v_aptstockopgudang>(_sql, new { value = string.Format("%{0}%",value) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptstockopgudangByYearAndMonthAndKet";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
