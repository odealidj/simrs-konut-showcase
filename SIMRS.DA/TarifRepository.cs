using SIMRS.DA.IRepository;
using SIMRS.Model;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SIMRS.DA
{
    public class TarifRepository : ITarifRepository
    {

        private string sErrthrowClassName = "TarifRepository";
        private string sErrthrowMethodName = "";
        private string sErrResult = null;
        //private int iRowsAffected = 0;

        //private IUnitOfWork _unitofwork;
        private IDapperContext _context;
        private IDbTransaction _transaction;
        private string _sql;

        public TarifRepository(IDbTransaction transaction, IDapperContext context)
        {
            _transaction = transaction;
            _context = context;
        }

        public TarifRepository(IDapperContext context)
        {
            //_transaction = transaction;
            _context = context;
            //_unitofwork = unitofwork;
        }

        public bool Delete(tarif obj)
        {
            throw new NotImplementedException();
        }

        public tarif Get(tarif obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tarif> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<(IEnumerable<tarif>, string)> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<tarif>> GetAllByPageIndex(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_tarif>, string)> GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan)
        {


            #region query

            if (string.IsNullOrEmpty(tindakan))
                _sql = "SELECT * FROM v_tarif AS t WHERE t.penjaminpasienid = @penjaminpasienid AND t.kelasid = @kelasid \n"
                        + "AND t.ruangrawatid = @ruangrawatid AND t.jenistarifid = @jenistarifid;";
            else
                _sql = "SELECT* FROM v_tarif AS t WHERE t.penjaminpasienid = @penjaminpasienid AND t.kelasid = @kelasid \n"
                    + "AND t.ruangrawatid = @ruangrawatid AND t.jenistarifid = @jenistarifid \n"
                    + "AND t.daftartindakannm LIKE @daftartindakannm;";
            #endregion

            IEnumerable<v_tarif> list = null;

            try
            {
                if (string.IsNullOrEmpty(tindakan))

                    list = await _context.db.QueryAsync<v_tarif>(_sql, new { penjaminpasienid=penjaminid, kelasid=kelasid, ruangrawatid=ruangrawatid, jenistarifid=jenistarifid }, commandType: CommandType.Text);

                else
                    list = await _context.db.QueryAsync<v_tarif>(_sql, new { penjaminpasienid = penjaminid, kelasid = kelasid, ruangrawatid = ruangrawatid, jenistarifid = jenistarifid, daftartindakannm = string.Format("%{0}%", tindakan) }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public Task<(tarif, string)> GetAsync(tarif obj)
        {
            throw new NotImplementedException();
        }

        public int Save(tarif obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(tarif obj)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<v_tarif>, string)> GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid)
        {
            #region query

           
                _sql = "SELECT top 50 * FROM v_tarif AS t WHERE t.penjaminpasienid = @penjaminpasienid AND t.kelasid = @kelasid \n"
                        + "AND t.ruangrawatid = @ruangrawatid AND t.jenistarifid = @jenistarifid;";
            #endregion

            IEnumerable<v_tarif> list = null;

            try
            {

                    list = await _context.db.QueryAsync<v_tarif>(_sql, new { penjaminpasienid = penjaminid, kelasid = kelasid, ruangrawatid = ruangrawatid, jenistarifid = jenistarifid }, commandType: CommandType.Text);
               
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakanAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_tarif>, string) GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid, string tindakan)
        {
            #region query

            if (string.IsNullOrEmpty(tindakan))
                _sql = "SELECT * FROM v_tarif AS t WHERE t.penjaminpasienid = @penjaminpasienid AND t.kelasid = @kelasid \n"
                        + "AND t.ruangrawatid = @ruangrawatid AND t.jenistarifid = @jenistarifid;";
            else
                _sql = "SELECT* FROM v_tarif AS t WHERE t.penjaminpasienid = @penjaminpasienid AND t.kelasid = @kelasid \n"
                    + "AND t.ruangrawatid = @ruangrawatid AND t.jenistarifid = @jenistarifid \n"
                    + "AND t.daftartindakannm LIKE @daftartindakannm;";
            #endregion

            IEnumerable<v_tarif> list = null;

            try
            {
                if (string.IsNullOrEmpty(tindakan))

                    list = _context.db.Query<v_tarif>(_sql, new { penjaminpasienid = penjaminid, kelasid = kelasid, ruangrawatid = ruangrawatid, jenistarifid = jenistarifid }, commandType: CommandType.Text);

                else
                    list = _context.db.Query<v_tarif>(_sql, new { penjaminpasienid = penjaminid, kelasid = kelasid, ruangrawatid = ruangrawatid, jenistarifid = jenistarifid, daftartindakannm = string.Format("%{0}%", tindakan) }, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllVtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_tarif>, string) GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan(short penjaminid, short kelasid, short ruangrawatid, short jenistarifid)
        {
            #region query


            _sql = "SELECT top 50 * FROM v_tarif AS t WHERE t.penjaminpasienid = @penjaminpasienid AND t.kelasid = @kelasid \n"
                    + "AND t.ruangrawatid = @ruangrawatid AND t.jenistarifid = @jenistarifid;";
            #endregion

            IEnumerable<v_tarif> list = null;

            try
            {

                list = _context.db.Query<v_tarif>(_sql, new { penjaminpasienid = penjaminid, kelasid = kelasid, ruangrawatid = ruangrawatid, jenistarifid = jenistarifid }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetTop50VtarifByPenjaminidAndKelasIdAndRuangRawatIdAndJenisTarifIdAndTindakan";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short kelasid, short ruangrawatid, string tindakan)
        {
            #region query

            if (string.IsNullOrEmpty(tindakan))
            {
                _sql = "SELECT ROW_NUMBER() OVER(ORDER BY daftartindakannm ASC) AS numrow, \n"
                    + "* FROM v_tarif_withaout_jenistarif_penjaminid \n"
                    + "WHERE kelasid = @kelasid AND ruangrawatid = @ruangrawatid;";
            }
            else
            {
                _sql = "SELECT ROW_NUMBER() OVER(ORDER BY daftartindakannm ASC) AS numrow, \n"
                    + "* FROM v_tarif_withaout_jenistarif_penjaminid \n"
                    + "WHERE kelasid = @kelasid AND ruangrawatid = @ruangrawatid AND daftartindakannm LIKE @daftartindakannm;";
            }
            #endregion

            IEnumerable<v_tarif_withaout_jenistarif_penjaminid> list = null;

            try
            {

                list = _context.db.Query<v_tarif_withaout_jenistarif_penjaminid>(_sql, new { kelasid = kelasid,ruangrawatid = ruangrawatid, daftartindakannm = string.Format("%{0}%",tindakan) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public bool Update(int daftartindakanid, short kelasid, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            var result = true;

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@daftartindakanid", daftartindakanid);
                p.Add("@kelasid", kelasid);
                p.Add("@biaya", harga);
                p.Add("@Jasasarana", jasasarana);
                p.Add("@Jasapelayanan", jasapelayanan);
                p.Add("@tarifsts",'1');

                _sql = @"[dbo].[p_Updatetarif_without_tarifid_jenistarifid]";
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

        public (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) GetAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan)
        {
            #region query

            if (string.IsNullOrEmpty(tindakan))
            {
                _sql = "SELECT \n"
                    +"ROW_NUMBER() OVER(ORDER BY a.daftartindakannm ASC) AS numrow, \n"
                    +"a.daftartindakanid,a.daftartindakannm,a.ruangrawatid,a.biaya,a.jasasarana,a.jasapelayanan \n"
                    +"FROM \n"
                    +"( \n"
                        +"SELECT \n"
                        +"DISTINCT \n"
                        +"t.daftartindakanid, t.daftartindakannm, t.ruangrawatid, t.biaya, t.jasasarana, t.jasapelayanan \n"
                        +"FROM[v_tarif_withaout_jenistarif_penjaminid] AS t \n"
                    +") a \n"
                    + "WHERE a.ruangrawatid = @ruangrawatid";
            }
            else
            {
                _sql = "SELECT \n"
                    + "ROW_NUMBER() OVER(ORDER BY a.daftartindakannm ASC) AS numrow, \n"
                    + "a.daftartindakanid,a.daftartindakannm,a.ruangrawatid,a.biaya,a.jasasarana,a.jasapelayanan \n"
                    + "FROM \n"
                    + "( \n"
                        + "SELECT \n"
                        + "DISTINCT \n"
                        + "t.daftartindakanid, t.daftartindakannm, t.ruangrawatid, t.biaya, t.jasasarana, t.jasapelayanan \n"
                        + "FROM[v_tarif_withaout_jenistarif_penjaminid] AS t \n"
                    + ") a \n"
                    + "WHERE a.ruangrawatid = @ruangrawatid AND a.daftartindakannm LIKE @daftartindakannm";
            }
            #endregion

            IEnumerable<v_tarif_withaout_jenistarif_penjaminid> list = null;

            try
            {

                list = _context.db.Query<v_tarif_withaout_jenistarif_penjaminid>(_sql, new { ruangrawatid = ruangrawatid, daftartindakannm = string.Format("%{0}%", tindakan) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_tarif_withaout_kelas_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }

        public bool Update(int daftartindakanid, decimal harga, decimal jasasarana, decimal jasapelayanan)
        {
            var result = true;

            try
            {

                DynamicParameters p = new DynamicParameters();
                p.Add("@daftartindakanid", daftartindakanid);
                p.Add("@biaya", harga);
                p.Add("@Jasasarana", jasasarana);
                p.Add("@Jasapelayanan", jasapelayanan);
                p.Add("@tarifsts", '1');
                               
                _sql = @"[dbo].[p_Updatetarif_without_kelas_tarifid_jenistarifid]";
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

        public (IEnumerable<v_tarif_withaout_jenistarif_penjaminid>, string) GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan(short ruangrawatid, string tindakan)
        {
            #region query

            if (string.IsNullOrEmpty(tindakan))
            {
                _sql = "SELECT ROW_NUMBER() OVER(ORDER BY daftartindakannm ASC) AS numrow, \n"
                    + "* FROM v_tarif_withaout_jenistarif_penjaminid \n"
                    + "WHERE ruangrawatid = @ruangrawatid;";
            }
            else
            {
                _sql = "SELECT ROW_NUMBER() OVER(ORDER BY daftartindakannm ASC) AS numrow, \n"
                    + "* FROM v_tarif_withaout_jenistarif_penjaminid \n"
                    + "WHERE ruangrawatid = @ruangrawatid AND daftartindakannm LIKE @daftartindakannm;";
            }
            #endregion

            IEnumerable<v_tarif_withaout_jenistarif_penjaminid> list = null;

            try
            {

                list = _context.db.Query<v_tarif_withaout_jenistarif_penjaminid>(_sql, new { ruangrawatid = ruangrawatid, daftartindakannm = string.Format("%{0}%", tindakan) }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_tarif_withaout_jenistarif_penjaminidByKelasIdAndRuangRawatIAndTindakan";
                sErrResult = ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName;
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
