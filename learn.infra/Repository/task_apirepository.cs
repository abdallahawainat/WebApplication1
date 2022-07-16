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
    public class task_apirepository : Itask_apirepository
    {
        private readonly IDBcontext dbContext;
        public task_apirepository(IDBcontext dbContext)
        {

            this.dbContext = dbContext;
        }
        public bool createinserttask(task_api task)
        {
            var parameter = new DynamicParameters();

            parameter.Add("title", task.tasktitle, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("descreption", task.taskdesc, dbType: DbType.String, direction: ParameterDirection.Input);

            dbContext.dbConnection.ExecuteAsync("task_package_api.createinserttask", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deletetask(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idoftask", id, dbType: System.Data.DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.dbConnection.ExecuteAsync("task_package_api.deletetask", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<task_api> getalltask()
        {
            IEnumerable<task_api> result = dbContext.dbConnection.Query<task_api>("task_package_api.getalltask", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public task_api getbyid(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idoftask", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<task_api> result = dbContext.dbConnection.Query<task_api>("task_package_api.getbyid", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
    }
}
