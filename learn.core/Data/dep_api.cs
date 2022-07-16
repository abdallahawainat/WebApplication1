using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace learn.core.Data
{
    public class dep_api
    {
        [Key]
        public int depid { get; set; }
        public string depname { get; set; }


    }
}
