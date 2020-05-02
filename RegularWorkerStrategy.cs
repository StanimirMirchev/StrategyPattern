using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RegularWorkerStrategy : IStrategyPermissions
    {   
        private string highSchoolDiploma;
        public RegularWorkerStrategy(string highSchoolDiploma)
        {
            this.highSchoolDiploma = highSchoolDiploma;
        }

        public string GivePermissions(string name)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("High school diploma: {0}", this.highSchoolDiploma);
            result.AppendLine();
            result.AppendFormat("{0} your role is Regular Worker and your department is Regular Workers Department then you are granted with Regular worker permissions!", name);
            return result.ToString();
        }
    }
}
