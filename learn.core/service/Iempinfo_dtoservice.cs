using learn.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.service
{
   public interface Iempinfo_dtoservice
    {
        public List<empinfo_dto> getempinfo();
        public List<emptask_dto> getemptask();

        public List<salinfo_dto> getsalinfo();
        public List<empemail_dto> getnameandemail();
        public List<empindep_dto> getcountempindep();

        public List<counttaskemp> getcountemptask();
        public List<filterdate_dto> filterdate(filterdate_dto filterdate_Dto);
    }
}
