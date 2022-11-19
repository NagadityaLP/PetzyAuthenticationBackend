using AuthenticationProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationProject.Models.Data
{
    public class InformationRepo : IInformationRepo
    {
        InformationDbContext db = new InformationDbContext();
        public LogInTable GetInformationByEmail(string email1)
        {
            LogInTable information = db.Informations.Where(x => x.Email == email1).FirstOrDefault();
            return information;
        }

        public List<LogInTable> GetAll()
        {
            return db.Informations.ToList();
        }

        public void postSignUpInformation(LogInTable information)
        {
            db.Informations.Add(information);
            db.SaveChanges();
            
        }
    }
}