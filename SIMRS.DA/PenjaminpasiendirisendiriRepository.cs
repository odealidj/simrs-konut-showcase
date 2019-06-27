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
    public class PenjaminpasiendirisendiriRepository : IPenjaminpasiendirisendiriRepository
    {
        private string sErrthrowClassName = "PenjaminpasiendirisendiriRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public PenjaminpasiendirisendiriRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public PenjaminpasiendirisendiriRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }


        public bool Delete(penjaminpasiendirisendiri obj)
        {
            throw new NotImplementedException();
        }

        public penjaminpasiendirisendiri Get(penjaminpasiendirisendiri obj)
        {
            #region query
            _sql = "SELECT * FROM penjaminpasiendirisendiri AS p \n"
                + "WHERE p.penjaminpasiendirisendiriid = @penjaminpasiendirisendiriid";
            #endregion

            penjaminpasiendirisendiri list;

            try
            {
                list = _context.db.QueryFirstOrDefault<penjaminpasiendirisendiri>(_sql, new { penjaminpasiendirisendiriid = obj.penjaminpasiendirisendiriid }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Get";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public IEnumerable<penjaminpasiendirisendiri> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<penjaminpasiendirisendiri>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<penjaminpasiendirisendiri>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(penjaminpasiendirisendiri, string)> GetAsync(penjaminpasiendirisendiri obj)
        {
            throw new NotImplementedException();
        }

        public int Save(penjaminpasiendirisendiri obj)
        {
            var result = -99;

            sErrthrowMethodName = "Save";

            try
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@penjaminpasiendirisendiriid", obj.penjaminpasiendirisendiriid);
                p.Add("@tgljaminan", obj.tgljaminan);
                p.Add("@identitasdiriid", obj.identitasdiriid);
                p.Add("@nomoridentitas", obj.nomoridentitas) ;
                p.Add("@nama", obj.nama);
                p.Add("@jkid", (obj.jkid == -1) ? null : obj.jkid);
                p.Add("@alamat", obj.alamat);
                p.Add("@propinsiid", (obj.propinsiid == -1) ? null : obj.propinsiid);
                p.Add("@kotakabid", (obj.kotakabid == -1) ? null : obj.kotakabid);
                p.Add("@kecid", (obj.kecid == -1) ? null : obj.kecid);
                p.Add("@keldesaid", (obj.keldesaid == -1) ? null : obj.keldesaid);
                p.Add("@rwid", (obj.rwid == -1) ? null : obj.rwid);
                p.Add("@rtid", (obj.rtid == -1) ? null : obj.rtid);
                p.Add("@notelp", obj.notelp);
                p.Add("@nohp", obj.nohp);
                p.Add("@created_date", DateTime.Now);
                p.Add("@updated_date", null);
                p.Add("@penjaminpasiendirisendirists", true);

                _sql = @"[p_Savepenjaminpasiendirisendiri]";
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

        public bool Update(penjaminpasiendirisendiri obj)
        {
            throw new NotImplementedException();
        }
    }
}
