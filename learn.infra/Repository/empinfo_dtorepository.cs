using Dapper;
using learn.core.domain;
using learn.core.DTO;
using learn.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace learn.infra.Repository
{
    public class empinfo_dtorepository : Iempinfo_dtorepository
    {
        private readonly IDBcontext dbContext;

        public empinfo_dtorepository(IDBcontext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<filterdate_dto> filterdate(filterdate_dto filterdate_Dto)
        {
           
            var parameter = new DynamicParameters();
            parameter.Add("startdate", filterdate_Dto.checkin, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("enddate", filterdate_Dto.checkout, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<filterdate_dto> result= dbContext.dbConnection.Query<filterdate_dto>("employee_info_package_api.filterdate", parameter, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public List<empindep_dto> getcountempindep()
        {
            IEnumerable<empindep_dto> result = dbContext.dbConnection.Query<empindep_dto>("employee_info_package_api.getcountempindep", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<counttaskemp> getcountemptask()
        {
            IEnumerable<counttaskemp> result = dbContext.dbConnection.Query<counttaskemp>("employee_info_package_api.getcountemptask", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<empinfo_dto> getempinfo()
        {
            IEnumerable<empinfo_dto> result = dbContext.dbConnection.Query<empinfo_dto>("employee_info_package_api.getempinfo", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<emptask_dto> getemptask()
        {
            IEnumerable<emptask_dto> result = dbContext.dbConnection.Query<emptask_dto>("employee_info_package_api.getemptask", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<empemail_dto> getnameandemail()
        {
            IEnumerable<empemail_dto> result = dbContext.dbConnection.Query<empemail_dto>("employee_info_package_api.getnameandemail", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<salinfo_dto> getsalinfo()
        {
            IEnumerable<salinfo_dto> result = dbContext.dbConnection.Query<salinfo_dto>("employee_info_package_api.getsalinfo", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
       
    }
}
