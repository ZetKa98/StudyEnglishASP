using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishASP.Models
{
    public class UserData
    {
        [Key]
        public Int64 UserId { get; set; }
        public User User { get; set; }
        public String Name { get; set; }
        public Int32? Age { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        public EnglishLevel Level { get; set; }
    }

    public enum EnglishLevel
    {
        Beginner,
        Elementary,
        PreInter,
        Inter,
        UpperInter,
        Advanced,
        Mastery
    }
}
