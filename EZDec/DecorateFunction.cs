using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateFunction
{
    class DecorateFunction
    {
        string name;
        string[] arguments;
  
        public DecorateFunction(string n, string[] args)
        {
            name = n;
            arguments = args;
        }

        public string GetName() { return name; }

        public override string ToString()
        {
            if(arguments == null)
            {
                return name;
            }
            else
            {
                string ret = name + "(";
                for (int i = 0; i < arguments.Length; i++)
                {
                    ret += arguments[i] + ", ";
                }
                ret = ret.Substring(0, ret.Length - 2);
                ret += ")";
                return ret;
            }

        }

    }
}
