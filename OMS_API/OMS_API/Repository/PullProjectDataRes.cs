using Dapper;
using OfficeOnline.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OMS_API.Repository
{
    public class PullProjectDataRes
    {
        public IEnumerable<PullProjectDataRes> GetAllData(int ProjectID, int SourceID , DateTime DateFrom, DateTime DateEnd)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@ProjectID", ProjectID, DbType.Int32);
                param.Add("@SourceID", SourceID, DbType.Int32);
                if (DateFrom != DateTime.MinValue || DateEnd != DateTime.MinValue)
                {
                    param.Add("@DateFrom", DateFrom, DbType.DateTime);
                    param.Add("@DateEnd", DateEnd, DbType.DateTime);
                }
                var enumResult = DapperHelper.Query<PullProjectDataRes>("oms_PullProjectData", "admin", param);
                return enumResult;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
