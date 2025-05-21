using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFProgect.models
{
    public class Terrorists:Uman
    {
        private string Rank;
        private string Status;
        public List <string> Weapons;

        public Terrorists(  string rank , string status , List<string> weapons, string name, int age) :base( name ,  age)
        {
            Rank = rank;
            Status = status;
            Weapons = weapons;
        }
    }
}


