using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyEnglishASP.Models
{
    public class EnglishWord
    {
        [Key]
        public Int64 Id { get; set; }
        [Required]
        public String Word { get; set; }
        public WordCategory Category { get; set; }
        public IEnumerable<RussianWord> RussianWords { get; set; }
    }

    public enum WordCategory
    {
        Topic,
        PhrasalVerb,
        PrepositionalPhrase,
        WordPattern
    }
}
