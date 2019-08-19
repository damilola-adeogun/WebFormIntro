using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTest.Core.Entity
{
    public class LecturerSubject: BaseEntity
    {
        public Lecturer TheLecturer { get; set; }
        public Subject TheSubject { get; set; }
    }
}
