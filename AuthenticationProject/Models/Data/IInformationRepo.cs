using AuthenticationProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationProject.Models.Data
{
    public interface IInformationRepo
    {
        void postSignUpInformation(LogInTable information);
        LogInTable GetInformationByEmail(string email);
        List<LogInTable> GetAll();
    }
}
