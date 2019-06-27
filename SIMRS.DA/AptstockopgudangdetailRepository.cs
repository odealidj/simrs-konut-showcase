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
    public class AptstockopgudangdetailRepository : IAptstockopgudangdetailRepository
    {
        private string sErrthrowClassName = "AptstockopgudangdetailRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptstockopgudangdetailRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptstockopgudangdetailRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(aptstockopgudangdetail obj)
        {
            throw new NotImplementedException();
        }

        public aptstockopgudangdetail Get(aptstockopgudangdetail obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptstockopgudangdetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptstockopgudangdetail>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptstockopgudangdetail>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptstockopgudangdetail, string)> GetAsync(aptstockopgudangdetail obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptstockopgudangdetail obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptstockopgudangdetail obj)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_aptstockopgudangdetail>, string) GetAll_v_aptstockopgudangdetailByAptstockopgudangId(short AptstockopgudangId)
        {
            #region query

            _sql = "SELECT * FROM v_aptstockopgudangdetail AS a \n"
                    + "WHERE a.aptstockopgudangid = @aptstockopgudangid \n"
                    +"ORDER BY a.tglkadaluarsa ASC";

            #endregion

            IEnumerable<v_aptstockopgudangdetail> list;

            try
            {

                list = _context.db.Query<v_aptstockopgudangdetail>(_sql, new { aptstockopgudangid = AptstockopgudangId }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembeliandetailByAptbarangmasukIdAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptstockopgudangdetail>, string) GetAll_v_aptstockopgudangdetailByAptstockopgudangId(short AptstockopgudangId, string filter)
        {
            #region query

            _sql = "SELECT * FROM v_aptpembeliandetail AS a \n"
                + "WHERE a.aptbarangmasukid = @aptbarangmasukid AND a.aptbarangnm+a.aptdef1singkatan LIKE @aptbarangnm \n"
                + "ORDER BY a.tglkadaluarsa ASC";

            #endregion

            IEnumerable<v_aptstockopgudangdetail> list;

            try
            {

                list = _context.db.Query<v_aptstockopgudangdetail>(_sql, new { aptbarangmasukid = AptstockopgudangId, aptbarangnm = string.Format("%{0}%",filter) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembeliandetailByAptbarangmasukIdAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
