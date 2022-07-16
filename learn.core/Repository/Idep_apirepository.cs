using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.Repository
{
    public interface Idep_apirepository
    {
        public List<dep_api> getalldep();
        public bool createinsertdep(dep_api dep);

        public bool deletedep(int? id);
        public dep_api getbyid(int id);
    }
}
