using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFTest.Core.Entity;

namespace WFTest.Repository.Repository
{
    public class LevelRepository
    {
        public List<Level> GetLevel
        {
            get
            {
                return Utility.levels;
            }
            
        }

        public List<Level> CreatLevel(Level theLevel)
        {
            if(Utility.levels == null)
            {
                Utility.levels = new List<Level>();
            }
            Utility.levels.Add(theLevel);
            return Utility.levels;
        }
    }
}
