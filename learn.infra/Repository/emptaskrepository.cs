using Dapper;
using learn.core.Data;
using learn.core.domain;
using learn.core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace learn.infra.Repository
{
    public class emptaskrepository : Iemptaskrepository
    {
        private readonly IDBcontext dbContext;
        public emptaskrepository(IDBcontext dbContext)
        {

            this.dbContext = dbContext;
        }
        public bool createinsertemployeetask(employee_task_api emptask)
        {
            var parameter = new DynamicParameters();

            parameter.Add("emp", emptask.empid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("task", emptask.taskid, dbType: DbType.Int32, direction: ParameterDirection.Input);

            dbContext.dbConnection.ExecuteAsync("employee_task_package_api.createinsertemployeetask", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deleteemployeetask(int? id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("nid ", id, dbType: System.Data.DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.dbConnection.ExecuteAsync("employee_task_package_api.deleteemployeetask", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<employee_task_api> getallemployeetask()
        {
            IEnumerable<employee_task_api> result = dbContext.dbConnection.Query<employee_task_api>("employee_task_package_api.getallemployeetask", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public employee_task_api getbyid(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("nid ", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<employee_task_api> result = dbContext.dbConnection.Query<employee_task_api>("employee_task_package_api.getbyid", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
    }
}
