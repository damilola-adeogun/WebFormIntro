using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFTest.Core.Entity;

namespace WFTest.Core.Factory
{
    class LecturerFactory
    {
        public bool validate(Lecturer entity, out string errormsg)
        {
            errormsg = string.Empty;
            //if (string.IsNullOrEmpty(entity.Name) && entity.Name.Trim() != string.Empty)
            //{
            //    errormsg = "Lecturer name is required";
            //    return false;
            //}

            //if (string.IsNullOrEmpty(entity.Code) && entity.Code.Trim() != string.Empty)
            //{
            //    errormsg = "Lecturer code is required";
            //    return false;
            //}

            return true;
        }


        public Lecturer Create(string name, string code, string description)
        {
            Lecturer theLecturer = new Lecturer();
            //theLecturer.Name = name;
            //theLecturer.Code = code;
            //theLecturer.Description = description;
            theLecturer.CreatedAt = DateTime.Now;
            theLecturer.Status = Enum.StatusEnum.Active;
            return theLecturer;

            //return new Lecturer()
            //{
            //    Code = code,
            //    Name = name,
            //    Description = description,
            //    Status = Enum.StatusEnum.Active,
            //    CreatedAt = DateTime.Now
            //};
        }
    }
}
