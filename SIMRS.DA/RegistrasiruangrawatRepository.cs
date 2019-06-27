using SIMRS.DA.IRepository;
using SIMRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using SIMRS.Model.view;

namespace SIMRS.DA
{
    public class RegistrasiruangrawatRepository : IRegistrasiruangrawatRepository
    {
        private string sErrthrowClassName = "RegistrasiruangrawatRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public RegistrasiruangrawatRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public RegistrasiruangrawatRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(registrasiruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public registrasiruangrawat Get(registrasiruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<registrasiruangrawat> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<registrasiruangrawat>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<registrasiruangrawat>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<(registrasiruangrawat, string)> GetAsync(registrasiruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public int Save(registrasiruangrawat obj)
        {
            var result = -99;
            
            sErrthrowMethodName = "Save";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasiruangrawatid", obj.registrasiruangrawatid);
                p.Add("@registrasiid", obj.registrasiid);
                p.Add("@tglmasukruangan", obj.tglmasukruangan);
                p.Add("@jammasukruangan", obj.jammasukruangan);
                p.Add("@kelasid", (obj.kelasid == -1) ? null : obj.kelasid);
                p.Add("@ruangrawatid", (obj.ruangrawatid == -1) ? null : obj.ruangrawatid);
                p.Add("@kamarid", (obj.kamarid == -1) ? null : obj.kamarid);
                p.Add("@tempattidurid", (obj.tempattidurid == -1) ? null : obj.tempattidurid);
                p.Add("@loginappid", (obj.loginappid == -1) ? null : obj.loginappid);
                p.Add("@registrasiruangrawatsts", obj.registrasiruangrawatsts);

                _sql = @"[p_Saveregistrasiruangrawat]";
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

        public bool Update(registrasiruangrawat obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid)
        {
            #region query

            _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
               + "WHERE r.pelayananmedikid = @pelayananmedikid  \n"
               + "ORDER BY r.registrasiid DESC \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {


                list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid  \n"
                   + "ORDER BY r.registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                   + "ORDER BY r.registrasiid DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawatrjrd>, string)> GetAllVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short? stsregistrasiid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT * FROM v_registrasiruangrawatrjrd AS r  \n"
                    + "ORDER BY r.registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "SELECT* FROM v_registrasiruangrawatrjrd AS r  \n"
                   + "WHERE r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                   + "ORDER BY r.registrasiid DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_registrasiruangrawatrjrd> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawatrjrd>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawatrjrd>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiruangrawatrjrdByPageIndexAndFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid  \n"
                   + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
                   + "ORDER BY r.registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid " 
                   + " AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid \n"
                   + "AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                   + "ORDER BY r.registrasiid DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid =stsmasukkeluarruangrawatid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndTglMasukAndFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, short ruangrawatid, DateTime tglmasuk, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid  \n"
                   + "ORDER BY r.registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                   + "ORDER BY r.registrasiid DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndTglMasukAndFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public bool UpdateStsMasukKeluarRuangRawat(short registrasiruangrawatid, short stsmasukkeluarruangrawatid,
            DateTime tglkeluarruangan, DateTime jamkeluarruangan)
        {
            var result = false;

            sErrthrowMethodName = "UpdateStsMasukKeluarRuangRawat";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasiruangrawatid", registrasiruangrawatid);
                p.Add("@stsmasukkeluarruangrawatid", stsmasukkeluarruangrawatid);
                p.Add("@tglkeluarruangan", tglkeluarruangan);
                p.Add("@jamkeluarruangan", jamkeluarruangan);

                _sql = @"[p_Updatestsmasukkeluarregistrasiruangrawat]";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                result = true;
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = false;
            }

            return result;
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short? stsregistrasiid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value, DateTime tglmasuk)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid  \n"
                   + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
                   + "AND r.tglmasuk = @tglmasuk \n"
                   + "ORDER BY r.registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            else
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid "
                   + " AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid \n"
                   + "AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                   + "AND r.tglmasuk = @tglmasuk \n"
                   + "ORDER BY r.registrasiid DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid, tglmasuk = tglmasuk.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid, value = string.Format("%{0}%", value), tglmasuk = tglmasuk.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_statuspenyakit>, string) GetAllv_statuspenyakitByNormAsync(string norm)
        {
            #region query

            
                _sql = "select distinct * from  v_statuspenyakit WHERE nocm = @nocm ORDER BY jammasuk DESC";
            

            #endregion

            IEnumerable<v_statuspenyakit> list;

            try
            {

                
                    list = _context.db.Query<v_statuspenyakit>(_sql, new { nocm = norm }, commandType: CommandType.Text);
                
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_statuspenyakitByNormAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllv_registrasiruangrawatByRegistrasiidAsync(short registrasiid)
        {
            #region query

            _sql = "SELECT distinct r.nocm,r.nama,r.kelasnm,r.tanggallahir,r.thn,r.bulan,r.hari,r.stsmasukkeluarid,r.registrasiid,r.registrasiruangrawatid, \n"
                +"r.tglmasukruangan,r.ruangrawatid,r.ruangrawatnm,r.kelasid,r.kelasuraian \n"
                +"FROM v_registrasiruangrawat AS r \n"
                + "WHERE r.registrasiid = @registrasiid";

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {


                list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { registrasiid= registrasiid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public bool UpdateStsMasukKeluarRuangRawatByRegistrasiid(short registrasiid,short stsmasukkeluarruangrawatid)
        {
            var result = false;

            sErrthrowMethodName = "UpdateStsMasukKeluarRuangRawatByRegistrasiid";

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@registrasiid", registrasiid);
                p.Add("@stsmasukkeluarruangrawatid", stsmasukkeluarruangrawatid);
                
                _sql = @"[p_UpdatestsmasukkeluarruangrawatByRegistrasiid]";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                result = true;
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "UpdateStsMasukKeluarRuangRawatByRegistrasiid";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                result = false;
            }

            return result;
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid,
              short stsmasukkeluarruangrawatid, string value, DateTime tglmasuk)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                    _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                       + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid  \n"
                       + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
                       + "AND r.tglmasuk = @tglmasuk \n"
                       + "ORDER BY r.registrasiid  DESC \n"
                        + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                        + "FETCH NEXT @pageSize ROWS ONLY";
             
            }

            else
            {

                
                    _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid "
                   + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
                   + "AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                   + "AND r.tglmasuk = @tglmasuk \n"
                   + "ORDER BY r.registrasiid DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";
               
            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid,  tglmasuk = tglmasuk.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid, value = string.Format("%{0}%", value), tglmasuk = tglmasuk.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid  \n"
                   + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
                   + "ORDER BY r.registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            }

            else
            {


                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
               + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid "
               + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
               + "AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
               + "ORDER BY r.registrasiid DESC \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";

            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid, value = string.Format("%{0}%", value)}, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(IEnumerable<v_registrasiruangrawat>, string)> GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync(int pageIndex, int pageSize, short pelayananmedikid, short ruangrawatid, short stsmasukkeluarruangrawatid, string value, DateTime tglkeluarruangan)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                   + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid  \n"
                   + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
                   + "AND r.tglkeluarruangan = @tglkeluarruangan \n"
                   + "ORDER BY r.registrasiid  DESC \n"
                    + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                    + "FETCH NEXT @pageSize ROWS ONLY";

            }

            else
            {


                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
               + "WHERE r.pelayananmedikid = @pelayananmedikid AND r.ruangrawatid = @ruangrawatid "
               + "AND r.stsmasukkeluarruangrawatid = @stsmasukkeluarruangrawatid  \n"
               + "AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
               + "AND r.tglkeluarruangan = @tglkeluarruangan \n"
               + "ORDER BY r.registrasiid DESC \n"
                + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                + "FETCH NEXT @pageSize ROWS ONLY";

            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid, tglkeluarruangan = tglkeluarruangan.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);
                }
                else
                {
                    list = await _context.db.QueryAsync<v_registrasiruangrawat>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, pelayananmedikid = pelayananmedikid, ruangrawatid = ruangrawatid, stsmasukkeluarruangrawatid = stsmasukkeluarruangrawatid, tglkeluarruangan = string.Format("%{0}%", value), tglmasuk = tglkeluarruangan.ToString("yyyy-MM-dd") }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPageIndexAndPelayananmedikIdAndRuangRawatIdAndAndStsMasukKeluarRuangrawatIdFilterByNocmNoregNamaTglKeluarRuanganAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_registrasiruangrawat>, string) GetAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNama(short pelayananmedikid, DateTime tglmasuk, short stsmasukkeluar, string value)
        {
            #region query

            if (string.IsNullOrEmpty(value))
            {
                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                        + "WHERE r.pelayananmedikid = @pelayananmedikid \n"
                        + "AND r.tglmasuk = @tglmasuk \n"
                        + "AND r.stsmasukkeluarid = @stsmasukkeluarid \n"
                        + "ORDER BY r.registrasiid";

            }

            else
            {

                _sql = "SELECT* FROM v_registrasiruangrawat AS r  \n"
                        + "WHERE r.pelayananmedikid = @pelayananmedikid \n"
                        + "AND r.tglmasuk = @tglmasuk \n"
                        + "AND r.stsmasukkeluarid = @stsmasukkeluarid \n"
                        + "AND r.nocm+r.noregistrasi+r.nama LIKE @value \n"
                        + "ORDER BY r.registrasiid";

            }

            #endregion

            IEnumerable<v_registrasiruangrawat> list;

            try
            {

                if (string.IsNullOrEmpty(value))
                {
                    list = _context.db.Query<v_registrasiruangrawat>(_sql, new { pelayananmedikid = pelayananmedikid, tglmasuk = tglmasuk.ToString("yyyy-MM-dd"), stsmasukkeluarid =stsmasukkeluar }, commandType: CommandType.Text);
                }
                else
                {
                    list = _context.db.Query<v_registrasiruangrawat>(_sql, new { pelayananmedikid = pelayananmedikid, tglmasuk = tglmasuk.ToString("yyyy-MM-dd"), stsmasukkeluarid = stsmasukkeluar, value =string.Format("%{0}%",value) }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVregistrasiByPelayananmedikIdAndTglMasukAndStsmasukkeluarAndFilterByNocmNoregNamaAsync";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }


    }
}
