using System;

namespace IDFProgect
{
    public class Terrorists:Uman
    {
        private string Rank;
        private string Status;
        public List<string> Weapons;

        public Class1(string name , int age , string rank , string status , List<string> weapons):base(string name, int age)
        {
            Rank = rank;
            Status = status;
            Weapons = weapons;
        }
    }
}


