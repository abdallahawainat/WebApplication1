using learn.core.Data;
using learn.core.Repository;
using learn.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.infra.service
{
    public class task_apiservice : Itask_apiservice
    {
        private readonly Itask_apirepository repo;
        public task_apiservice(Itask_apirepository repo)
        {
            this.repo = repo;
        }
        public bool createinserttask(task_api task)
        {
            return repo.createinserttask(task);
        }

        public bool deletetask(int id)
        {
            return repo.deletetask(id);
        }

        public List<task_api> getalltask()
        {
            return repo.getalltask();
        }

        public task_api getbyid(int id)
        {
            return repo.getbyid(id);
        }
    }
}
