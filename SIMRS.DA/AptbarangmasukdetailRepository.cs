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
    public class AptbarangmasukdetailRepository : IAptbarangmasukdetailRepository
    {
        private string sErrthrowClassName = "AptbarangmasukdetailRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptbarangmasukdetailRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptbarangmasukdetailRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(aptbarangmasukdetail obj)
        {
            throw new NotImplementedException();
        }

        public aptbarangmasukdetail Get(aptbarangmasukdetail obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptbarangmasukdetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptbarangmasukdetail>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptbarangmasukdetail>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_aptpembeliandetail>, string)> GetAll_v_aptpembeliandetailByAptbarangmasukIdAsync(short aptbarangmasukid)
        {
            #region query
           
                _sql = "SELECT * FROM v_aptpembeliandetail AS a \n"
                    + "WHERE a.aptbarangmasukid = @aptbarangmasukid";
            
            #endregion

            IEnumerable<v_aptpembeliandetail> list;

            try
            {
               
                    list = await _context.db.QueryAsync<v_aptpembeliandetail>(_sql, new { aptbarangmasukid = aptbarangmasukid }, commandType: CommandType.Text);
               
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembeliandetailByAptbarangmasukIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(aptbarangmasukdetail, string)> GetAsync(aptbarangmasukdetail obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptbarangmasukdetail obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptbarangmasukdetail obj)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_aptpembeliandetail>, string) GetAll_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid)
        {
            #region query

            _sql = "SELECT * FROM v_aptpembeliandetail AS a \n"
                + "WHERE a.aptbarangmasukid = @aptbarangmasukid";

            #endregion

            IEnumerable<v_aptpembeliandetail> list;

            try
            {

                list = _context.db.Query<v_aptpembeliandetail>(_sql, new { aptbarangmasukid = aptbarangmasukid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembeliandetailByAptbarangmasukId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptpembeliandetail>, string) GetAll_v_aptpembeliandetailByAptbarangmasukId(short aptbarangmasukid, string filter)
        {
            #region query

            _sql = "SELECT * FROM v_aptpembeliandetail AS a \n"
                + "WHERE a.aptbarangmasukid = @aptbarangmasukid AND a.aptbarangnm+a.aptdef1singkatan  LIKE @aptbarangnm";

            #endregion

            IEnumerable<v_aptpembeliandetail> list;

            try
            {

                list = _context.db.Query<v_aptpembeliandetail>(_sql, new { aptbarangmasukid = aptbarangmasukid, aptbarangnm  = string.Format("%{0}%",filter)}, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembeliandetailByAptbarangmasukId";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        string IAptbarangmasukdetailRepository.Save(aptbarangmasukdetail obj)
        {
            sErrResult = string.Empty;
             sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangmasukdetailid", obj.aptbarangmasukdetailid);
                p.Add("@aptbarangsatuanid", obj.aptbarangsatuanid);
                p.Add("@aptbarangmasukid", obj.aptbarangmasukid);
                p.Add("@kodebarangpbf", obj.kodebarangpbf);
                p.Add("@tglkadaluarsa", obj.tglkadaluarsa);
                p.Add("@nobatch", obj.nobatch);
                p.Add("@aptsatuankode", obj.aptsatuankode);
                p.Add("@qty", obj.qty);
                p.Add("@hargasatuanpot", obj.hargasatuanpot);
                p.Add("@hargasatuan", obj.hargasatuan);
                p.Add("@potonganpersen", obj.potonganpersen);
                p.Add("@jmlharga", obj.jmlharga);
                p.Add("@stskb", obj.stskb);
                p.Add("@aptstsbrgmasukdetailid", obj.aptstsbrgmasukdetailid);

                _sql = @"[p_Saveaptbarangmasukdetail]"; // @"usp_registrasiInsert";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
               
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.InnerException.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;

            }

            return sErrResult;
        }

        string IAptbarangmasukdetailRepository.Delete(aptbarangmasukdetail obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangmasukdetailid", obj.aptbarangmasukdetailid);
               
                _sql = @"[p_Deleteaptbarangmasukdetail]"; // @"usp_registrasiInsert";
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
    }
}
