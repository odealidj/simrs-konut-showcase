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
    public class AptdistribusiRepository : IAptdistribusiRepository
    {
        private string sErrthrowClassName = "AptdistribusiRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptdistribusiRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptdistribusiRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptdistribusi obj)
        {
            throw new NotImplementedException();
        }

        public aptdistribusi Get(aptdistribusi obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptdistribusi> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptdistribusi>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       
        public Task<(aptdistribusi, string)> GetAsync(aptdistribusi obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptdistribusi>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public int Save(aptdistribusi obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptdistribusi obj)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_aptdistribusi>, string) GetAllv_aptdistribusi()
        {
            #region query

            _sql = "SELECT  top 300 * FROM v_aptdistribusi AS a ";
            _sql += "ORDER BY a.aptdistribusiid DESC";

            #endregion

            IEnumerable<v_aptdistribusi> list = null;

            try
            {

                list = _context.db.Query<v_aptdistribusi>(_sql, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptdistribusi()";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptdistribusi>, string) GetAllv_aptdistribusi(string year, string month)
        {
            #region query

            _sql = "SELECT * FROM v_aptdistribusi AS a WHERE a.tahun = @tahun AND a.bulan = @bulan ";
            _sql += "ORDER BY a.aptdistribusiid DESC";

            #endregion

            IEnumerable<v_aptdistribusi> list = null;

            try
            {

                list = _context.db.Query<v_aptdistribusi>(_sql, new { tahun = year, bulan = month }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptdistribusi()";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }


        public (IEnumerable<v_aptdistribusi>, string) GetAllv_aptdistribusi(string depo)
        {
            #region query

            _sql = "SELECT * FROM v_aptdistribusi AS a WHERE a.depotujuannm LIKE @depotujuannm";
            _sql += "ORDER BY a.aptdistribusiid DESC";

            #endregion

            IEnumerable<v_aptdistribusi> list = null;

            try
            {

                list = _context.db.Query<v_aptdistribusi>(_sql, new { depotujuannm = string.Format("%{0}%", depo) }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptdistribusi()";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
