using learn.core.DTO;
using learn.core.Repository;
using learn.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.infra.service
{
    public class empinfo_dtoservice : Iempinfo_dtoservice
    {
        private readonly Iempinfo_dtorepository empinfodto;

        public empinfo_dtoservice(Iempinfo_dtorepository empinfodto)
        {
            this.empinfodto = empinfodto;
        }

        public List<filterdate_dto> filterdate(filterdate_dto filterdate_Dto)
        {
            return empinfodto.filterdate(filterdate_Dto);
        }

        public List<empindep_dto> getcountempindep()
        {
            return empinfodto.getcountempindep();
        }

        public List<counttaskemp> getcountemptask()
        {
            return empinfodto.getcountemptask();
        }

        public List<empinfo_dto> getempinfo()
        {
            return empinfodto.getempinfo();
        }

        public List<emptask_dto> getemptask()
        {
            return empinfodto.getemptask();
        }

        public List<empemail_dto> getnameandemail()
        {
            return empinfodto.getnameandemail();
        }

        public List<salinfo_dto> getsalinfo()
        {
            return empinfodto.getsalinfo();
        }
    }
}
