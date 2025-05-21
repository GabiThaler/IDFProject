using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IDFProgect.models

{
    public class Hamas : MilitaryOrganization
    {
        private List<Terrorists>ListoOfTerrorists = new List<Terrorists>();


        public Hamas(string name, int date, string commander, List<Terrorists> listOfTerrorists) : base(name, date, commander)
        {
            ListoOfTerrorists = listOfTerrorists;
        }

    }
}
