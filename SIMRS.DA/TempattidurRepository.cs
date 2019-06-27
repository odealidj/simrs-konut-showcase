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
    public class TempattidurRepository : ITempattidurRepository
    {
        private string sErrthrowClassName = "TempattidurRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public TempattidurRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public TempattidurRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(tempattidur obj)
        {
            throw new NotImplementedException();
        }

        public tempattidur Get(tempattidur obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tempattidur> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<tempattidur>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<tempattidur>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(tempattidur, string)> GetAsync(tempattidur obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_jmltempattidurbasekelasrawatinap>, string)> GetVjmltempattidurbasekelasrawatinapAsync()
        {
            #region query
            _sql = "SELECT * FROM v_jmltempattidurbasekelasrawatinap";
            #endregion

            IEnumerable<v_jmltempattidurbasekelasrawatinap> list;

            try
            {
                list = await _context.db.QueryAsync<v_jmltempattidurbasekelasrawatinap>(_sql, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetVjmltempattidurbasekelasrawatinap";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public int Save(tempattidur obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(tempattidur obj)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<v_listtempattidurrawatinap>, string)> GetVlisttempattidurrawatinapAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_listtempattidurrawatinap>, string)> GetVlisttempattidurrawatinapByKelasidAsync(short kelasid)
        {
            #region query
            _sql = "SELECT * FROM v_listtempattidurrawatinap WHERE kelasid = @kelasid";
            #endregion

            IEnumerable<v_listtempattidurrawatinap> list;

            try
            {
                list = await _context.db.QueryAsync<v_listtempattidurrawatinap>(_sql, new { kelasid= kelasid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetVlisttempattidurrawatinapByKelasidAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public int Updatetempattidurisi(short tempattidurid, short tempattidurisi)
        {
            var result = -99;

            sErrthrowMethodName = "Updatetempattidurisi";

            try
            {


                DynamicParameters p = new DynamicParameters();
                p.Add("@tempattidurid", tempattidurid);
                p.Add("@tempattidurisi", tempattidurisi);
                

                _sql = @"[p_Updatetempattidurisi]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Updatetempattidurisi";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }

        public int Updatetempattidurisi(IList<short> tempattidurid, short tempattidurisi)
        {
            var result = -99;

            sErrthrowMethodName = "Updatetempattidurisi";

            try
            {
                DynamicParameters p = null;
                foreach (var item in tempattidurid)
                {
                    p = new DynamicParameters();
                    p.Add("@tempattidurid", item);
                    p.Add("@tempattidurisi", tempattidurisi);


                    _sql = @"[p_Updatetempattidurisi]";
                    result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                }

               
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Updatetempattidurisi";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }
    }
}
