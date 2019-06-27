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
using System.Data.Common;

namespace SIMRS.DA
{
    public class IdentitaspasienRepository : IIdentitaspasienRepository
    {
        private string sErrthrowClassName = "IdentitaspasienRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public IdentitaspasienRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public IdentitaspasienRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(identitaspasien obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<identitaspasien> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<identitaspasien>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            if (pageIndex < 0) pageIndex = 0;

            #region query
            _sql = "SELECT \n"
                   + "	nocm, \n"
                   + "	nama, \n"
                   + "	tanggallahir, \n"
                   + "	tempatlahir, \n"
                   + "	thn, \n"
                   + "	bulan, \n"
                   + "	hari, \n"
                   + "	jkid, \n"
                   + "	notelp, \n"
                   + "	nohp, \n"
                   + "	jknm, \n"
                   + "	alamatpasienid, \n"
                   + "	alamat, \n"
                   + "	kodepos, \n"
                   + "	kotakabid, \n"
                   + "	kecid, \n"
                   + "	keldesaid, \n"
                   + "	rwid, \n"
                   + "	rtid, \n"
                   + "	alamatpasiensts, \n"
                   + "	stspernikahanid, \n"
                   + "	pendidikanid, \n"
                   + "	pekerjaanid, \n"
                   + "	agamaid, \n"
                   + "	goldarahid, \n"
                   + "	sukuid, \n"
                   + "	negaraid \n"
                   + "FROM \n"
                   + "	[dbo].[v_identitaspasien_jk_alamatpasien] \n"
                   + "ORDER BY nocm DESC \n"
                   + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                   + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<identitaspasien> list;

            try
            {
                list = await _context.db.QueryAsync<identitaspasien>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllByPageIndex";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return list;
        }

        public async Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>,string)> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAsync(int pageIndex, int pageSize)
        {
            
            #region query
            _sql = "SELECT \n"
                   + "	nocm, \n"
                   + "	nama, \n"
                   + "	tanggallahir, \n"
                   + "	tempatlahir, \n"
                   + "	thn, \n"
                   + "	bulan, \n"
                   + "	hari, \n"
                   + "	jkid, \n"
                   + "	notelp, \n"
                   + "	nohp, \n"
                   + "	jknm, \n"
                   + "	alamatpasienid, \n"
                   + "	alamat, \n"
                   + "	kodepos, \n"
                   + "	kotakabid, \n"
                   + "	kecid, \n"
                   + "	keldesaid, \n"
                   + "	rwid, \n"
                   + "	rtid, \n"
                   + "	alamatpasiensts, \n"
                   + "	stspernikahanid, \n"
                   + "	pendidikanid, \n"
                   + "	pekerjaanid, \n"
                   + "	agamaid, \n"
                   + "	goldarahid, \n"
                   + "	sukuid, \n"
                   + "	negaraid \n"
                   + "FROM \n"
                   + "	[dbo].[v_identitaspasien_jk_alamatpasien] \n"
                   + "ORDER BY nocm DESC \n"
                   + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                   + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_identitaspasien_jk_alamatpasien> list;

            try
            {
                list = await _context.db.QueryAsync<v_identitaspasien_jk_alamatpasien>(_sql, new { pageIndex = pageIndex, pageSize = pageSize }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_identitaspasien_jk_alamatpasienByPageIndex";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public int Save(identitaspasien obj)
        {
            var result = 0;

            try
            {
        
                DynamicParameters p = new DynamicParameters();
                p.Add("nocm", obj.nocm,DbType.String,ParameterDirection.InputOutput);
                p.Add("sapaanid", obj.sapaanid);
                p.Add("nama", obj.nama);
                p.Add("tanggallahir", obj.tanggallahir);
                p.Add("thn", obj.thn);
                p.Add("bulan", obj.bulan);
                p.Add("hari", obj.hari);
                p.Add("jkid", obj.jkid);
                p.Add("stspernikahanid", obj.stspernikahanid);
                p.Add("pendidikanid", obj.pendidikanid);
                p.Add("pekerjaanid", obj.pekerjaanid);
                p.Add("agamaid", obj.agamaid);
                p.Add("notelp", obj.notelp);
                p.Add("nohp", obj.nohp);
                p.Add("goldarahid", obj.goldarahid);
                p.Add("sukuid", obj.sukuid);
                p.Add("negaraid", obj.negaraid);
                p.Add("identitaspasiensts", obj.identitaspasiensts);

                _sql = @"[dbo].[usp_identitaspasienInsert]";
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool Update(identitaspasien obj)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<v_identitaspasien_jk_alamatpasien>> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndNoCmAsync(int pageIndex, int pageSize, string nocm)
        {
            #region query
            _sql = "SELECT \n"
                   + "	nocm, \n"
                   + "	nama, \n"
                   + "	tanggallahir, \n"
                   + "	tempatlahir, \n"
                   + "	thn, \n"
                   + "	bulan, \n"
                   + "	hari, \n"
                   + "	jkid, \n"
                   + "	notelp, \n"
                   + "	nohp, \n"
                   + "	jknm, \n"
                   + "	alamatpasienid, \n"
                   + "	alamat, \n"
                   + "	kodepos, \n"
                   + "	kotakabid, \n"
                   + "	kecid, \n"
                   + "	keldesaid, \n"
                   + "	rwid, \n"
                   + "	rtid, \n"
                   + "	alamatpasiensts, \n"
                   + "	stspernikahanid, \n"
                   + "	pendidikanid, \n"
                   + "	pekerjaanid, \n"
                   + "	agamaid, \n"
                   + "	goldarahid, \n"
                   + "	sukuid, \n"
                   + "	negaraid \n"
                   + "FROM \n"
                   + "	[dbo].[v_identitaspasien_jk_alamatpasien] \n"
                   + "Where nocm like @nocm \n"
                   + "ORDER BY nocm DESC \n"
                   + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                   + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_identitaspasien_jk_alamatpasien> list;


            try
            {
                list = await _context.db.QueryAsync<v_identitaspasien_jk_alamatpasien>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, nocm = string.Format("{0}%",nocm)  }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndNoCm";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return list;
        }

        public async Task<IEnumerable<v_identitaspasien_jk_alamatpasien>> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndNamaAsync(int pageIndex, int pageSize, string nama)
        {
            #region query
            _sql = "SELECT \n"
                   + "	nocm, \n"
                   + "	nama, \n"
                   + "	tanggallahir, \n"
                   + "	tempatlahir, \n"
                   + "	thn, \n"
                   + "	bulan, \n"
                   + "	hari, \n"
                   + "	jkid, \n"
                   + "	notelp, \n"
                   + "	nohp, \n"
                   + "	jknm, \n"
                   + "	alamatpasienid, \n"
                   + "	alamat, \n"
                   + "	kodepos, \n"
                   + "	kotakabid, \n"
                   + "	kecid, \n"
                   + "	keldesaid, \n"
                   + "	rwid, \n"
                   + "	rtid, \n"
                   + "	alamatpasiensts, \n"
                   + "	stspernikahanid, \n"
                   + "	pendidikanid, \n"
                   + "	pekerjaanid, \n"
                   + "	agamaid, \n"
                   + "	goldarahid, \n"
                   + "	sukuid, \n"
                   + "	negaraid \n"
                   + "FROM \n"
                   + "	[dbo].[v_identitaspasien_jk_alamatpasien] \n"
                   + "Where nama like @nama \n"
                   + "ORDER BY nocm DESC \n"
                   + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                   + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_identitaspasien_jk_alamatpasien> list;


            try
            {
                list = await _context.db.QueryAsync<v_identitaspasien_jk_alamatpasien>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, nama = string.Format("%{0}%", nama) }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndNama";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return list;
        }

        public identitaspasien Get(identitaspasien obj)
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<identitaspasien>,string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(identitaspasien, string)> GetAsync(identitaspasien obj)
        {
            #region query
            _sql = "SELECT * FROM identitaspasien AS i WHERE i.nocm = @nocm";
            #endregion

            identitaspasien list;

            try
            {
                list = await _context.db.QueryFirstOrDefaultAsync<identitaspasien>(_sql, new { nocm = obj.nocm }  , commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        (string, string) IIdentitaspasienRepository.Save(identitaspasien obj)
        {
            var result = 0;
            var nocm = string.Empty;

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("nocm", obj.nocm,DbType.String,ParameterDirection.InputOutput);
                p.Add("sapaanid", (obj.sapaanid==-1)?null: obj.sapaanid);
                p.Add("nama", obj.nama);
                p.Add("tempatlahir", obj.tempatlahir);
                p.Add("tanggallahir", obj.tanggallahir);
                p.Add("thn", obj.thn);
                p.Add("bulan", obj.bulan);
                p.Add("hari", obj.hari);
                p.Add("jkid", (obj.jkid==-1)?null: obj.jkid);
                p.Add("stspernikahanid", (obj.stspernikahanid==-1)?null: obj.stspernikahanid);
                p.Add("pendidikanid", (obj.pendidikanid==-1)?null: obj.pendidikanid);
                p.Add("pekerjaanid", (obj.pekerjaanid==-1)?null: obj.pekerjaanid);
                p.Add("agamaid", (obj.agamaid==-1)?null: obj.agamaid);
                p.Add("notelp", obj.notelp);
                p.Add("nohp", obj.nohp);
                p.Add("goldarahid", (obj.goldarahid==-1)? null: obj.goldarahid);
                p.Add("sukuid", (obj.sukuid==-1)?null: obj.sukuid);
                p.Add("negaraid", (obj.negaraid==-1)? null:obj.negaraid);
                p.Add("identitaspasiensts", obj.identitaspasiensts);

                _sql = @"p_Saveidentitaspasien"; //  "usp_identitaspasienInsert";

                
                result = _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);
                nocm = p.Get<string>("nocm");
                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "Save";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                nocm = string.Empty;
            }

            return (nocm,sErrResult);
        }

        public async Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>,string)> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync(int pageIndex, int pageSize, string value)
        {
            #region query
            _sql = "SELECT \n"
                   + "	nocm, \n"
                   + "	nama, \n"
                   + "	tanggallahir, \n"
                   + "	tempatlahir, \n"
                   + "	thn, \n"
                   + "	bulan, \n"
                   + "	hari, \n"
                   + "	jkid, \n"
                   + "	notelp, \n"
                   + "	nohp, \n"
                   + "	jknm, \n"
                   + "	alamatpasienid, \n"
                   + "	alamat, \n"
                   + "	kodepos, \n"
                   + "	kotakabid, \n"
                   + "	kecid, \n"
                   + "	keldesaid, \n"
                   + "	rwid, \n"
                   + "	rtid, \n"
                   + "	alamatpasiensts, \n"
                   + "	stspernikahanid, \n"
                   + "	pendidikanid, \n"
                   + "	pekerjaanid, \n"
                   + "	agamaid, \n"
                   + "	goldarahid, \n"
                   + "	sukuid, \n"
                   + "	negaraid \n"
                   + "FROM \n"
                   + "	[dbo].[v_identitaspasien_jk_alamatpasien] \n"
                   + "Where nocm+nama like @value \n"
                   + "ORDER BY nocm DESC \n"
                   + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                   + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_identitaspasien_jk_alamatpasien> list;


            try
            {
                list = await _context.db.QueryAsync<v_identitaspasien_jk_alamatpasien>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, value = string.Format("%{0}%", value) }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByNocmNamaAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async  Task<(IEnumerable<v_identitaspasien_jk_alamatpasien>, string)> GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync(int pageIndex, int pageSize, string value)
        {
            #region query
            _sql = "SELECT \n"
                   + "	nocm, \n"
                   + "	nama, \n"
                   + "	tanggallahir, \n"
                   + "	tempatlahir, \n"
                   + "	thn, \n"
                   + "	bulan, \n"
                   + "	hari, \n"
                   + "	jkid, \n"
                   + "	notelp, \n"
                   + "	nohp, \n"
                   + "	jknm, \n"
                   + "	alamatpasienid, \n"
                   + "	alamat, \n"
                   + "	kodepos, \n"
                   + "	kotakabid, \n"
                   + "	kecid, \n"
                   + "	keldesaid, \n"
                   + "	rwid, \n"
                   + "	rtid, \n"
                   + "	alamatpasiensts, \n"
                   + "	stspernikahanid, \n"
                   + "	pendidikanid, \n"
                   + "	pekerjaanid, \n"
                   + "	agamaid, \n"
                   + "	goldarahid, \n"
                   + "	sukuid, \n"
                   + "	negaraid \n"
                   + "FROM \n"
                   + "	[dbo].[v_identitaspasien_jk_alamatpasien] \n"
                   + "Where tanggallahir = @value \n"
                   + "ORDER BY nocm DESC \n"
                   + "OFFSET (@pageIndex-1)*@pageSize ROWS \n"
                   + "FETCH NEXT @pageSize ROWS ONLY";
            #endregion

            IEnumerable<v_identitaspasien_jk_alamatpasien> list;

            try
            {
                list = await _context.db.QueryAsync<v_identitaspasien_jk_alamatpasien>(_sql, new { pageIndex = pageIndex, pageSize = pageSize, value = value }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_identitaspasien_jk_alamatpasienByPageIndexAndFilterByTglLahirAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(v_identitaspasien_for_listidentitaspasien, string)> GetVidentitaspasien_for_listidentitaspasienByNoCMAsync(string nocm)
        {
            #region query

            if (!string.IsNullOrEmpty(nocm))
            {
                _sql = "SELECT * FROM v_identitaspasien_for_listregistrasi AS ifl WHERE ifl.nocm = @nocm";
            }

            #endregion

            v_identitaspasien_for_listidentitaspasien list = null;

            try
            {

                if (!string.IsNullOrEmpty(nocm))
                {
                    list = await _context.db.QueryFirstOrDefaultAsync<v_identitaspasien_for_listidentitaspasien>(_sql, new { nocm = nocm }, commandType: CommandType.Text);
                }


            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetVidentitaspasien_for_listidentitaspasienByNoCMAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public async Task<(identitaspasien, string)> GetIdentitasPasienByNocmAsync(string nocm)
        {
            #region query
            _sql = "SELECT * FROM identitaspasien AS i WHERE i.nocm = @nocm";
            #endregion

            identitaspasien list;

            try
            {
                list = await _context.db.QueryFirstOrDefaultAsync<identitaspasien>(_sql, new { nocm = nocm }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetIdentitasPasienByNocmAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public bool UpdateNoRM(string oldNoRM, string newNoRM)
        {
            var result = true;

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@oldnocm", oldNoRM);
                p.Add("@newnocm", newNoRM);
                
                _sql = @"[dbo].[p_UpdateNoRM]";
                _context.db.Execute(_sql, p, _transaction, commandType: CommandType.StoredProcedure);

                //if (result > 0)
                //    obj.CategoryID = _context.GetLastId();
            }
            catch (Exception ex)
            {
                result = false;
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool IsNoRMIsExists(string norm)
        {
            var result = false;

            
                _sql = "SELECT 1 FROM identitaspasien AS i WHERE i.nocm = @nocm";

                try
                {
                    var data = _context.db.QuerySingleOrDefault(_sql, new { nocm = norm }, commandType: CommandType.Text);
                    if (data!=null)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                result = true;
                sErrthrowMethodName = "IsNoRMIsExists";
                    sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                    
                }

            return result;
        }
    }
}
