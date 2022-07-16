using learn.core.Data;
using learn.core.Repository;
using learn.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.infra.service
{
   public class emptaskservice : Iemptaskservice
    {
        private readonly Iemptaskrepository repo;
        public emptaskservice(Iemptaskrepository repo)
        {
            this.repo = repo;
        }
        public bool createinsertemployeetask(employee_task_api emptask)
        {
            return repo.createinsertemployeetask(emptask);
        }

        public bool deleteemployeetask(int? id)
        {
            return repo.deleteemployeetask(id);
        }

        public List<employee_task_api> getallemployeetask()
        {
            return repo.getallemployeetask();
        }

        public employee_task_api getbyid(int id)
        {
            return repo.getbyid(id);
        }
    }
}
