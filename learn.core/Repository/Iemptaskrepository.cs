using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.Repository
{
    public interface Iemptaskrepository
    {
        public List<employee_task_api> getallemployeetask();
        public bool createinsertemployeetask(employee_task_api emptask);

        public bool deleteemployeetask(int? id);
        public employee_task_api getbyid(int id);
    }
}
