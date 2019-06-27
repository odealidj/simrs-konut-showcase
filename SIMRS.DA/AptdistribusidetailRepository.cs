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
    public class AptdistribusidetailRepository : IAptdistribusidetailRepository
    {
        private string sErrthrowClassName = "AptdistribusidetailRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptdistribusidetailRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptdistribusidetailRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptdistribusidetail obj)
        {
            throw new NotImplementedException();
        }

        public aptdistribusidetail Get(aptdistribusidetail obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptdistribusidetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptdistribusidetail>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptdistribusidetail>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_aptdistribusidetail>, string) GetAllv_aptdistribusidetailByAptdistribusiId(short aptdistribusiid)
        {
            #region query

            _sql = "SELECT * FROM v_aptdistribusidetail AS a \n"
                    + "WHERE a.aptdistribusiid = @aptdistribusiid \n"
                    +"ORDER BY a.tglkadaluarsa ASC";

            #endregion

            IEnumerable<v_aptdistribusidetail> list;

            try
            {

                list = _context.db.Query<v_aptdistribusidetail>(_sql, new { aptdistribusiid = aptdistribusiid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptdistribusidetailByAptdistribusiId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptdistribusidetail>, string) GetAllv_aptdistribusidetailByAptdistribusiId(short aptdistribusiid, string filter)
        {
            #region query

            _sql = "SELECT * FROM v_aptdistribusidetail AS a \n"
                    + "WHERE a.aptdistribusiid = @aptdistribusiid AND a.aptbarangnm + a.aptpbfnm + a.aptdef1singkatan + a.deponmtujuan LIKE @value\n"
                    + "ORDER BY a.tglkadaluarsa ASC";


            #endregion

            IEnumerable<v_aptdistribusidetail> list;

            try
            {

                list = _context.db.Query<v_aptdistribusidetail>(_sql, new { aptdistribusiid = aptdistribusiid, value = string.Format("%{0}%",filter)  }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_aptdistribusidetailByAptdistribusiId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(aptdistribusidetail, string)> GetAsync(aptdistribusidetail obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptdistribusidetail obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptdistribusidetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
