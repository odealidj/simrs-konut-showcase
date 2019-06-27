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
    public class AptbarangmasukRepository : IAptbarangmasukRepository
    {

        private string sErrthrowClassName = "AptbarangmasukRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public AptbarangmasukRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public AptbarangmasukRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }
        public bool Delete(aptbarangmasuk obj)
        {
            throw new NotImplementedException();
        }

        public aptbarangmasuk Get(aptbarangmasuk obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<aptbarangmasuk> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<aptbarangmasuk>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<aptbarangmasuk>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_aptpembelian>, string)> GetAll_v_aptpembelianByYearAndMonthAsync(short year, short month)
        {
            #region query

            _sql = "SELECT * FROM v_aptpembelian AS a \n"
                + "WHERE Year(a.tglmasuk) = @year AND MONTH(a.tglmasuk) = @month \n"
                + "ORDER BY a.tglmasuk ASC;";


            #endregion

            IEnumerable<v_aptpembelian> list;

            try
            {

                list = await _context.db.QueryAsync<v_aptpembelian>(_sql, new { year = year, month = month }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelianByYearAndMonthAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(aptbarangmasuk, string)> GetAsync(aptbarangmasuk obj)
        {
            throw new NotImplementedException();
        }

        public int Save(aptbarangmasuk obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(aptbarangmasuk obj)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByYearAndMonth(short year, short month)
        {
            #region query

            _sql = "SELECT * FROM v_aptpembelian AS a \n"
                + "WHERE  Year(a.tglmasuk) = @year AND MONTH(a.tglmasuk) = @month \n"
                + "ORDER BY a.tglmasuk ASC;";


            #endregion

            IEnumerable<v_aptpembelian> list;

            try
            {

                list = _context.db.Query<v_aptpembelian>(_sql, new { year = year, month = month }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelianByYearAndMonth";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelian()
        {
            #region query

            _sql = "SELECT * FROM v_aptpembelian AS a \n"
                + "ORDER BY a.tglmasuk DESC;";


            #endregion

            IEnumerable<v_aptpembelian> list;

            try
            {

                list = _context.db.Query<v_aptpembelian>(_sql,  commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelian";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByYearAndMonth(string value)
        {
            #region query

            _sql = "SELECT * FROM v_aptpembelian AS a \n"
                + "WHERE a.tahunbeli+a.bulanbeli LIKE @value \n"
                + "ORDER BY a.tglmasuk ASC;";


            #endregion

            IEnumerable<v_aptpembelian> list;

            try
            {

                list = _context.db.Query<v_aptpembelian>(_sql, new { value = string.Format("%{0}%", value) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelian";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByKeterangan(string value)
        {
            #region query

            _sql = "SELECT * FROM v_aptpembelian AS a \n"
                + "WHERE a.ket LIKE @ket \n"
                + "ORDER BY a.tglmasuk ASC;";


            #endregion

            IEnumerable<v_aptpembelian> list;

            try
            {

                list = _context.db.Query<v_aptpembelian>(_sql, new { ket = string.Format("%{0}%", value) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelian";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        (int, string) IAptbarangmasukRepository.Save(aptbarangmasuk obj)
        {
            var result = 0;
            int aptbarangmasukid = -1;
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangmasukid", obj.aptbarangmasukid, DbType.Int32, ParameterDirection.InputOutput);
                p.Add("@aptpbfid", obj.aptpbfid);
                p.Add("@tglmasuk", obj.tglmasuk);
                p.Add("@jammasuk", obj.jammasuk);
                p.Add("@tahun", obj.tahun);
                p.Add("@bulan", obj.bulan);
                p.Add("@nobeli", obj.nobeli);
                p.Add("@dpp", obj.dpp);
                p.Add("@ppn", obj.ppn);
                p.Add("@biayakirim", obj.biayakirim);
                p.Add("@materai", obj.materai);
                p.Add("@total", obj.total);
                p.Add("@nppn", obj.nppn);

                _sql = @"p_Saveaptbarangmasuk"; // @"usp_registrasiInsert";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                aptbarangmasukid = p.Get<int>("aptbarangmasukid");
               
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
               
            }

            return (aptbarangmasukid, sErrResult);
        }

        public Task<(IEnumerable<v_aptpembelian>, string)> GetAll_v_aptpembelianByYearAndMonthAsync(string year, string month)
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelianByYearAndMonth(string year, string month)
        {
            throw new NotImplementedException();
        }

        string IAptbarangmasukRepository.Delete(aptbarangmasuk obj)
        {
            sErrResult = string.Empty;
            sErrthrowMethodName = "Delete";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@aptbarangmasukid", obj.aptbarangmasukid);

                _sql = @"[p_Deleteaptbarangmasuk]"; // @"usp_registrasiInsert";
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

        public async Task<(IEnumerable<v_aptbarangmasuk_pbf_notin_aptbrggudetail>, string)> GetAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail()
        {
            #region query

            _sql = "SELECT * FROM v_aptbarangmasuk_pbf_notin_aptbrggudetail \n"
                +"ORDER BY aptbarangmasukid DESC";
            

            #endregion

            IEnumerable< v_aptbarangmasuk_pbf_notin_aptbrggudetail> list;

            try
            {
                list = await _context.db.QueryAsync<v_aptbarangmasuk_pbf_notin_aptbrggudetail>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptbarangmasuk_pbf_notin_aptbrggudetail";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelian_notin__aptbrggudetail()
        {
            #region query

            _sql = "SELECT * FROM v_aptpembelian_notin__aptbrggudetail AS a \n"
                + "ORDER BY a.tglmasuk DESC;";


            #endregion

            IEnumerable<v_aptpembelian> list;

            try
            {

                list = _context.db.Query<v_aptpembelian>(_sql, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelian_notin__aptbrggudetail";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_aptpembelian>, string) GetAll_v_aptpembelian(string tahun, string bulan, string search)
        {
            #region query

            if ((!string.IsNullOrEmpty(tahun)) && (!string.IsNullOrEmpty(bulan)))
            {
                if (!string.IsNullOrEmpty(search))
                {
                    _sql = "SELECT * FROM v_aptpembelian AS a ";
                    _sql += "WHERE a.tahunbeli = @tahun AND a.bulanbeli = @bulan ";
                    _sql += "AND CONCAT(a.aptpbfnm, a.nobeli) LIKE @search ";
                    _sql += "ORDER BY a.tglmasuk DESC; ";
                }
                else
                {
                    _sql = "SELECT * FROM v_aptpembelian AS a ";
                    _sql += "WHERE a.tahunbeli = @tahun AND a.bulanbeli = @bulan ";
                    _sql += "ORDER BY a.tglmasuk DESC; ";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(search))
                {
                    _sql = "SELECT * FROM v_aptpembelian AS a ";
                    _sql += "WHERE CONCAT(a.aptpbfnm, a.nobeli) LIKE @search ";
                    _sql += "ORDER BY a.tglmasuk DESC; ";
                }
                else
                {
                    _sql = "SELECT * FROM v_aptpembelian AS a ";
                    _sql += "ORDER BY a.tglmasuk DESC; ";
                }
            }


            #endregion

            

            IEnumerable<v_aptpembelian> list;

            try
            {
                if ((!string.IsNullOrEmpty(tahun)) && (!string.IsNullOrEmpty(bulan)))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        list = _context.db.Query<v_aptpembelian>(_sql, new { tahun= tahun, bulan = bulan, search= string.Format("%{0}%", search) }, commandType: CommandType.Text);
                    }
                    else
                    {
                        list = _context.db.Query<v_aptpembelian>(_sql, new { tahun = tahun, bulan = bulan }, commandType: CommandType.Text);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        list = _context.db.Query<v_aptpembelian>(_sql, new { search = string.Format("%{0}%", search) }, commandType: CommandType.Text);
                    }
                    else
                    {
                        list = _context.db.Query<v_aptpembelian>(_sql, commandType: CommandType.Text);
                    }
                }

                        
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAll_v_aptpembelian";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
