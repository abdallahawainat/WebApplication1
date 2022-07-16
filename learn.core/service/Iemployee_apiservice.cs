using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.service
{
   public interface Iemployee_apiservice
    {
        public List<employee_api> getallemployee();
        public bool createinsertemployee(employee_api emp);

        public bool deleteemployee(int? id);
        public employee_api getbyid(int id);
    }
}
