﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTest.Core.Entity
{
    public class ClassRoom: BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public Level TheLevel { get; set; }
    }
}
