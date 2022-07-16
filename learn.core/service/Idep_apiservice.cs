using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.service
{
     public interface Idep_apiservice
    {
        public List<dep_api> getalldep();
        public bool createinsertdep(dep_api dep);

        public bool deletedep(int? id);
        public dep_api getbyid(int id);
    }
}
