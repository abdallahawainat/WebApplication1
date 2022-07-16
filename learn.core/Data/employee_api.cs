using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.Data
{
    public class employee_api
    {
        public int empid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int salary { get; set; }
        public string email { get; set; }

        public int depid { get; set; }
        public DateTime checkin { get; set; }

        public DateTime checkout { get; set; }

    }   
    }
