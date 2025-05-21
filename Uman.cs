using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDFProgect.models
{
    public abstract class Uman
    {
        string Name;
        int Age;

        public Uman(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

}