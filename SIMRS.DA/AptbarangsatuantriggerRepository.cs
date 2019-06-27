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
    public class AptbarangsatuantriggerRepository : IAptbarangsatuantriggerRepository
    {

        private string sErrthrowClassName = "AptbarangsatuantriggerRepository";
        private string sErrthrowMethodName = string.Empty;
        private string sErrResult = string.Empty;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql = string.Empty;

        public AptbarangsatuantriggerRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptbarangsatuantriggerRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public string Delete(aptbarangsatuantrigger obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangsatuantriggerid", obj.aptbarangsatuantriggerid);

                _sql = @"[p_Deleteaptbarangsatuantrigger]"; // @"usp_registrasiInsert";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Delete";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return sErrResult;
        }

        public aptbarangsatuantrigger Get(aptbarangsatuantrigger obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptbarangsatuantrigger> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<aptbarangsatuantrigger>, string)> GetAllAsync()
        {
            sErrResult = null;

            sErrthrowMethodName = "GetAllByAptbarangsatuanidAsync";

            _sql = "SELECT a.aptbarangsatuantriggerid,a.aptsatuankode,a.qty,a.stskb "
                      + "FROM aptbarangsatuantrigger AS a "
                      + "WHERE a.sts = '1'";


            IEnumerable<aptbarangsatuantrigger> list;

            try
            {

                list = await _context.db.QueryAsync<aptbarangsatuantrigger>(_sql,  commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByAptbarangsatuanidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<IEnumerable<aptbarangsatuantrigger>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(aptbarangsatuantrigger, string)> GetAsync(aptbarangsatuantrigger obj)
        {
            throw new NotImplementedException();
        }

        public (int, string) Save(aptbarangsatuantrigger obj)
        {

            var result = 0;
            int aptbarangsatuantriggerid = -1;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangsatuantriggerid", obj.aptbarangsatuantriggerid);
                p.Add("@aptbarangsatuanid", obj.aptbarangsatuanid);
                p.Add("@aptsatuankode", obj.aptsatuankode);
                p.Add("@qty", obj.qty);
                p.Add("@stskb", obj.stskb);

                _sql = @"p_Saveaptbarangsatuantrigger"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return (aptbarangsatuantriggerid, sErrResult);
        }

        public bool Update(aptbarangsatuantrigger obj)
        {
            throw new NotImplementedException();
        }

        bool IBaseRepository<aptbarangsatuantrigger>.Delete(aptbarangsatuantrigger obj)
        {
            throw new NotImplementedException();
        }

        int IBaseRepository<aptbarangsatuantrigger>.Save(aptbarangsatuantrigger obj)
        {
            throw new NotImplementedException();
        }

        public string DeleteByAptbarangsatuanId(short aptbarangsatuanId)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangsatuanid", aptbarangsatuanId);

                _sql = @"[p_DeleteaptbarangsatuantriggerByaptbarangsatuanid]"; // @"usp_registrasiInsert";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Delete";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return sErrResult;
        }

        public async Task<(IEnumerable<aptbarangsatuantrigger>, string)> GetAllByAptbarangsatuanidAsync(short Aptbarangsatuanid)
        {
            sErrResult = null;

            sErrthrowMethodName = "GetAllByAptbarangsatuanidAsync";

            _sql = "SELECT a.aptbarangsatuantriggerid,a.aptsatuankode,a.qty,a.stskb "
                      +"FROM aptbarangsatuantrigger AS a "
                      + "WHERE a.aptbarangsatuanid = @aptbarangsatuanid AND a.sts = '1'";


            IEnumerable<aptbarangsatuantrigger> list;

            try
            {

                list = await _context.db.QueryAsync<aptbarangsatuantrigger>(_sql, new { Aptbarangsatuanid = Aptbarangsatuanid }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByAptbarangsatuanidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<aptbarangsatuantrigger>, string) GetAllByAptbarangsatuanid(short Aptbarangsatuanid)
        {
            sErrResult = null;

            sErrthrowMethodName = "GetAllByAptbarangsatuanidAsync";

            _sql = "SELECT a.aptbarangsatuantriggerid,a.aptsatuankode,a.qty,a.stskb "
                      + "FROM aptbarangsatuantrigger AS a "
                      + "WHERE a.aptbarangsatuanid = @aptbarangsatuanid AND a.sts = '1'";


            IEnumerable<aptbarangsatuantrigger> list;

            try
            {

                list = _context.db.Query<aptbarangsatuantrigger>(_sql, new { Aptbarangsatuanid = Aptbarangsatuanid }, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByAptbarangsatuanidAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        (IEnumerable<aptbarangsatuantrigger>, string) IAptbarangsatuantriggerRepository.GetAll()
        {
            sErrResult = null;

            sErrthrowMethodName = "GetAll";

            _sql = "SELECT a.aptbarangsatuantriggerid,a.aptsatuankode,a.qty,a.stskb "
                      + "FROM aptbarangsatuantrigger AS a "
                      + "WHERE a.sts = '1'";


            IEnumerable<aptbarangsatuantrigger> list;

            try
            {

                list = _context.db.Query<aptbarangsatuantrigger>(_sql, commandType: CommandType.Text);


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByAptbarangsatuanidAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
