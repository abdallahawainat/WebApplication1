using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learn.core.Data
{
    public class employee_task_api
    {
        [Key]
        public int id { get; set; }
        public int empid { get; set; }
        public int taskid { get; set; }
    }
}
