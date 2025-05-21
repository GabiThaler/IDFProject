using System;

namespace IDFProgect

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


