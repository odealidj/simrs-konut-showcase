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
    public class IdentitaspasienbpjsRepository : IIdentitaspasienbpjsRepository
    {
        private string sErrthrowClassName = "IdentitaspasienbpjsRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public IdentitaspasienbpjsRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IdentitaspasienbpjsRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(identitaspasienbpjs obj)
        {
            throw new NotImplementedException();
        }

        public identitaspasienbpjs Get(identitaspasienbpjs obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<identitaspasienbpjs> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<identitaspasienbpjs>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<identitaspasienbpjs>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(identitaspasienbpjs, string)> GetAsync(identitaspasienbpjs obj)
        {
            #region query

            _sql = "SELECT * FROM identitaspasienbpjs AS i WHERE i.nocm = @nocm";

            #endregion

            identitaspasienbpjs list;

            try
            {
                list = await _context.db.QueryFirstOrDefaultAsync<identitaspasienbpjs>(_sql,new { nocm = obj .nocm}, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public int Save(identitaspasienbpjs obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@nocm", obj.nocm);
                p.Add("@nopeserta", obj.nopeserta);
                p.Add("@namapeserta", obj.namapeserta);
                p.Add("@faskes", obj.faskes);
                p.Add("@kelasbpjsid", (obj.kelasbpjsid == -1) ? null : obj.kelasbpjsid);
                p.Add("@jkid", (obj.jkid == -1) ? null : obj.jkid);
                p.Add("@tempatlahir", obj.tempatlahir);
                p.Add("@tanggallahir", obj.tanggallahir);
                p.Add("@alamat", obj.alamat);
                p.Add("@kotakabid", (obj.kotakabid == -1) ? null : obj.kotakabid);
                p.Add("@kecid", (obj.kecid == -1) ? null : obj.kecid);
                p.Add("@keldesaid", (obj.keldesaid == -1) ? null : obj.keldesaid);
                p.Add("@rwid", (obj.rwid == -1) ? null : obj.rwid);
                p.Add("@rtid", (obj.rtid == -1) ? null : obj.rtid);
                p.Add("@created_date", obj.created_date);
                p.Add("@updated_date", obj.updated_date);
                p.Add("@identitaspasienbpjssts", obj.identitaspasienbpjssts);

                _sql = @"[p_Saveidentitaspasienbpjs]";
                result = _context.db.ExecuteScalar<int>(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = -99;
            }

            return result;
        }

        public bool Update(identitaspasienbpjs obj)
        {
            throw new NotImplementedException();
        }
    }
}
