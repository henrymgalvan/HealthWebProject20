
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel
{
    public class SkillsAndHobbies
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public string SkillOrHobby { get; set; }
        public string Note { get; set; }
    }
}
