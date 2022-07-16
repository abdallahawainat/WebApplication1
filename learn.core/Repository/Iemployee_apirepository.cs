using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.Repository
{
    public interface Iemployee_apirepository
    {
        public List<employee_api> getallemployee();
        public bool createinsertemployee(employee_api emp);

        public bool deleteemployee(int? id);
        public employee_api getbyid(int id);
    }
}
