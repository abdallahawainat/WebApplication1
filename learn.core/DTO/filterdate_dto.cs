using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.DTO
{
    public class filterdate_dto
    {
        public int employeeid { get; set; }
        public string fullname { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
    }
}
