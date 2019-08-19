using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFTest.Core.Enum;

namespace WFTest.Core.Entity
{
    public class Lecturer: BaseEntity
    {
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public DateTime DOB { get; set; }
        public GenderEnum Gender { get; set; }
        public int MyProperty { get; set; }
    }
}
