using learn.core.Data;
using learn.core.Repository;
using learn.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.infra.service
{
    public class dep_apiservice : Idep_apiservice

    {
        private readonly Idep_apirepository repo;
        public dep_apiservice(Idep_apirepository repo)
        {
            this.repo = repo;
        }
        public bool createinsertdep(dep_api dep)
        {
            return repo.createinsertdep(dep);
        }

        public bool deletedep(int? id)
        {
            return repo.deletedep(id);
        }

        public List<dep_api> getalldep()
        {
            return repo.getalldep();
        }

        public dep_api getbyid(int id)
        {
            return repo.getbyid(id);
        }
    }
}
