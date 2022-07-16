using Dapper;
using learn.core.Data;
using learn.core.domain;
using learn.core.Repository;
using System;
using learn.infra.domain;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace learn.infra.Repository
{
    public class dep_apirepository : Idep_apirepository
    {
        private readonly IDBcontext dbContext;
        public dep_apirepository(IDBcontext dbContext)
        {

            this.dbContext = dbContext;
        }
        public bool createinsertdep(dep_api dep)
        {
            var parameter = new DynamicParameters();
            
            parameter.Add("nameofdep", dep.depname, dbType: DbType.String, direction: ParameterDirection.Input);

           
            dbContext.dbConnection.ExecuteAsync("dep_package_api.createinsertdep", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool deletedep(int? id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("idofdep", id, dbType: System.Data.DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.dbConnection.ExecuteAsync("dep_package_api.deletedep", parameter, commandType: CommandType.StoredProcedure);
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<dep_api> getalldep()
        {
            IEnumerable<dep_api> result = dbContext.dbConnection.Query<dep_api>("dep_package_api.getalldep", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public dep_api getbyid(int id)
        {
           // var parameter = new DynamicParameters();
           // parameter.Add("(idofdep", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

           // IEnumerable<dep_api> result = dBContext.dbConnection.Query<dep_api>("dep_package_api.getbyid", parameter, commandType: CommandType.StoredProcedure);

            var parameter = new DynamicParameters();
            parameter.Add("idofdep", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<dep_api> result = dbContext.dbConnection.Query<dep_api>("dep_package_api.getbyid", parameter, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

      
    }
}
