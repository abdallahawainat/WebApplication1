using learn.core.Data;
using learn.core.Repository;
using learn.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.infra.service
{
    public class employee_apiservice : Iemployee_apiservice
    {
        private readonly Iemployee_apirepository emprepository;
        public employee_apiservice(Iemployee_apirepository emprepository)
        {
            this.emprepository = emprepository;
        }
        public bool createinsertemployee(employee_api emp)
        {
            return emprepository.createinsertemployee(emp);
        }

        public bool deleteemployee(int? id)
        {
            return emprepository.deleteemployee(id);
        }

        public List<employee_api> getallemployee()
        {
            return emprepository.getallemployee();
        }

        public employee_api getbyid(int id)
        {
            return emprepository.getbyid(id);
        }
    }
}
