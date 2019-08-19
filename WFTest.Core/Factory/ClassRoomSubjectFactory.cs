using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFTest.Core.Entity;

namespace WFTest.Core.Factory
{
    class ClassRoomSubjectFactory
    {
        public bool validate(ClassRoomSubject entity, out string errormsg)
        {
            errormsg = string.Empty;
            //if (string.IsNullOrEmpty(entity.Name) && entity.Name.Trim() != string.Empty)
            //{
            //    errormsg = "ClassRoomSubject name is required";
            //    return false;
            //}

            //if (string.IsNullOrEmpty(entity.Code) && entity.Code.Trim() != string.Empty)
            //{
            //    errormsg = "ClassRoomSubject code is required";
            //    return false;
            //}

            return true;
        }


        public ClassRoomSubject Create(string name, string code, string description)
        {
            ClassRoomSubject theClassRoomSubject = new ClassRoomSubject();
            theClassRoomSubject.CreatedAt = DateTime.Now;
            theClassRoomSubject.Status = Enum.StatusEnum.Active;
            return theClassRoomSubject;

            //return new ClassRoomSubject()
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
