using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTest.Core.Entity
{
    public class ClassRoomSubject: BaseEntity
    {
        public ClassRoom TheClassRoom { get; set; }
        public Subject TheSubject { get; set; }
    }
}
