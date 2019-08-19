using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFTest.Core.Entity;

namespace WFTest.Core.Factory
{
    class ClassRoomFactory
    {
        public bool validate(ClassRoom entity, out string errormsg)
        {
            errormsg = string.Empty;
            if (string.IsNullOrEmpty(entity.Name) && entity.Name.Trim() != string.Empty)
            {
                errormsg = "Class Room name is required";
                return false;
            }

            if (string.IsNullOrEmpty(entity.Code) && entity.Code.Trim() != string.Empty)
            {
                errormsg = "Class Room code is required";
                return false;
            }

            return true;
        }


        public ClassRoom Create(string name, string code, string description, Level theLevel)
        {
            return new ClassRoom()
            {
                Code = code,
                Name = name,
                Description = description,
                TheLevel = theLevel,
                Status = Enum.StatusEnum.Active,
                CreatedAt = DateTime.Now
            };
        }
    }
}
