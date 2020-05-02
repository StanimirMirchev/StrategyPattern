using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AdministrativeWorkerStrategy : IStrategyPermissions
    {
        private string universityDiploma;
        private int personYears;
        public AdministrativeWorkerStrategy(string universityDiploma, int personYears)
        {
            this.universityDiploma = universityDiploma;
            this.personYears = personYears;
        }

        public string GivePermissions(string name)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("University diploma: {0}, Person years: {1}", this.universityDiploma, this.personYears);
            result.AppendLine();
            result.AppendFormat("{0} your role is Administrative worker and your department is Administrative department then you are granted with Administrative permissions!", name);
            return result.ToString();
        }
    }
}
