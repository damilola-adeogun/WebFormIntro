using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTest.Core.Entity
{
    public class Student: BaseEntity
    {
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public DateTime DOB { get; set; }
        public ClassRoom TheClassRoom { get; set; }
    }
}
