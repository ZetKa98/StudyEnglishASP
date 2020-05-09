using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishASP.Models
{
    public class RussianWord
    {
        [Key]
        public Int64 Id { get; set; }
        public String Word { get; set; }
        public Int64 EnglishWordId { get; set; }
        public EnglishWord EnglishWord { get; set; }
    }
}
