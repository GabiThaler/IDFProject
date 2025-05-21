using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProgect.models

{
    public abstract class MilitaryOrganization
    {
        private string NameOrganization;
        private int DateOfEstablishment;
        private string CurrentCommander;
        


        public MilitaryOrganization(string name, int date , string commander)
        {
            NameOrganization = name;
            DateOfEstablishment = date;
            CurrentCommander = commander;
        }
        
    }
}


