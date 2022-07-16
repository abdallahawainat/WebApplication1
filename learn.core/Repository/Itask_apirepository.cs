using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.Repository
{
   public interface Itask_apirepository
    {
        public bool createinserttask(task_api task);
        

        public bool deletetask(int id);

        public List<task_api> getalltask();

        public task_api getbyid(int id);
    }
}
