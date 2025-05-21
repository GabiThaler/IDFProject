using System;

namespace IDFProgect
{
    public class idf:Military-organization
    {
        private List<string> AttackCapabilities = new List(string[] capabilities);


        public idf(string name , int date , string commander, LIst<string> attackCapabilities ) :base(name, date, commander)
        {
            AttackCapabilities = attackCapabilities;
        }

    }
}


