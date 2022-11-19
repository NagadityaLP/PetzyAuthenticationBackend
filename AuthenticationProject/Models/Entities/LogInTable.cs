using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationProject.Models.Entities
{
    public class LogInTable
    {
        [Key]
        public int LogInTableId { get; set; }
        public string Email { get; set; }    
        public string PassWord { get; set; }
        public string UserType { get; set; }
        public int UserId { get; set; }
    }
}