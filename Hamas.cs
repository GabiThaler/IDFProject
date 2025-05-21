using System;

namespace IDFProgect
{
    public class Hamas : Military-organization
    {
        private List<string> ListoOfTerrorists = new List(string[] terrorists);


        public Hamas(string name, int date, string commander, LIst<string> listOfTerrorists) : base(name, date, commander)
        {
            ListoOfTerrorists = listOfTerrorists;
        }

    }
}
