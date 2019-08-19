﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFTest.Core.Entity;

namespace WFTest.Core.Factory
{
    public class LevelFactory
    {
        public bool validate(string name, string code, out string errormsg)
        {
            errormsg = string.Empty;
            if (string.IsNullOrEmpty(name) && name.Trim() != string.Empty)
            {
                errormsg = "Level name is required";
                return false;
            }

            if (string.IsNullOrEmpty(code) && code.Trim() != string.Empty)
            {
                errormsg = "Level code is required";
                return false;
            }

            return true;
        }


        public Level Create(string name, string code, string description)
        {
            Level theLevel = new Level();
            theLevel.Name = name;
            theLevel.Code = code;
            theLevel.Description = description;
            theLevel.CreatedAt = DateTime.Now;
            theLevel.Status = Enum.StatusEnum.Active;
            return theLevel;

            //return new Level()
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
