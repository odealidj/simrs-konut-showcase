using SIMRS.DA.IRepository;
using SIMRS.DA.IRepository.IExpand;
using SIMRS.Model.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SIMRS.DA.Expand
{
	public class RLRepository : IRLRepository
	{
		private string sErrthrowClassName = "RLRepository";
		private string sErrthrowMethodName = "";
		private string sErrResult = null;
		//private int iRowsAffected = 0;

		//private IUnitOfWork _unitofwork;
		private IDapperContext _context;
		private IDbTransaction _transaction;
		private string _sql;

		public RLRepository(IDbTransaction transaction, IDapperContext context)
		{
			_transaction = transaction;
			_context = context;
		}

		public RLRepository(IDapperContext context)
		{
			//_transaction = transaction;
			_context = context;
			//_unitofwork = unitofwork;
		}
		public async Task<(IEnumerable<v_RL_51_Pengunjung>, string)> GetAllv_RL_51_PengunjungByThnAndBlnAsync(int thn, int bln)
		{
			#region query

			_sql = "select num = ROW_NUMBER() OVER(ORDER BY v.jeniskegiatanid ASC), \n"
				 +"v.thn, v.bln, v.jeniskegiatanid,v.jeniskegiatannm,v.jumlah \n"
				+ "from v_RL_51_Pengunjung AS v WHERE v.thn = @thn and v.bln = @bln";

			#endregion

			IEnumerable<v_RL_51_Pengunjung> list;

			try
			{
				list = await _context.db.QueryAsync<v_RL_51_Pengunjung>(_sql, new { thn = thn, bln = bln }, commandType: CommandType.Text);

			}
			catch (Exception ex)
			{
				sErrthrowMethodName = "GetAllv_RL_51_PengunjungByThnAndBlnAsync";
				sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
				list = null;
			}

			return (list, sErrResult);
		}

        public async Task<(IEnumerable<v_RL_54>, string)> GetAllv_RL_54ByThnAndBlnAsync(int thn, int bln)
        {
            #region query

            _sql = "SELECT TOP 10 * FROM v_rl_54 \n"
                + "WHERE thn = @thn AND bln = @bln \n"
                +"ORDER BY JmlKunjungan DESC";

            #endregion

            IEnumerable<v_RL_54> list;

            try
            {
                list = await _context.db.QueryAsync<v_RL_54>(_sql, new { thn = thn, bln = bln }, commandType: CommandType.Text);

            }
            catch (Exception ex)
            {
                sErrthrowMethodName = "GetAllv_RL_54ByThnAndBlnAsync";
                sErrResult = await Task.FromResult<string>(ex.Message + "\n" + sErrthrowClassName + "\n" + sErrthrowMethodName);
                list = null;
            }

            return (list, sErrResult);
        }
    }
}
