using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishASP.Models
{
    public class User
    {
        [Key]
        public Int64 Id { get; set; } 
        public String Login { get; set; } 
        public String Password { get; set; } 
        public UserData UserData { get; set; }
    }
}
