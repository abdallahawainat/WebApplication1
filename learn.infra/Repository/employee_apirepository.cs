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
    public class employee_apirepository : Iemployee_apirepository
    {
        private readonly IDBcontext dbContext;

        public employee_apirepository(IDBcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool createinsertemployee(employee_api emp)
        {
            
                var parameter = new DynamicParameters();

                parameter.Add("firstname", emp.fname, dbType: DbType.String, direction: ParameterDirection.Input);
                parameter.Add("lastname", emp.lname, dbType: DbType.String, direction: ParameterDirection.Input);
                parameter.Add("sal", emp.salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
                parameter.Add("mail", emp.email, dbType: DbType.String, direction: ParameterDirection.Input);
                parameter.Add("dep", emp.depid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("startdate", emp.checkin, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            parameter.Add("enddate", emp.checkout, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            dbContext.dbConnection.ExecuteAsync("employee_package_api.createinsertemployee", parameter, commandType: CommandType.StoredProcedure);
                return true;
            
           
        }

        public bool deleteemployee(int? id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idofemployee", id, dbType: System.Data.DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.dbConnection.ExecuteAsync("employee_package_api.deleteemployee", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<employee_api> getallemployee()
        {
            IEnumerable<employee_api> result = dbContext.dbConnection.Query<employee_api>("employee_package_api.getallemployee", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public employee_api getbyid(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idofemployee", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<employee_api> result = dbContext.dbConnection.Query<employee_api>("employee_package_api.getbyid", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
    }
}
