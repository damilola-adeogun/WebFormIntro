using System;
using WFTest.Core.Enum;

namespace WFTest.Core.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public StatusEnum Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
