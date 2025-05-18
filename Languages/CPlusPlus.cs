using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_topSystem.Interfaces;

namespace task_topSystem.Languages
{
    public class CPlusPlus : ICodeGenerator
    {
        public string GenerateCode()
        {
            return "generated C++ code";
        }

        public string SomeCodeRelatedThing()
        {
            return "generated C++ -related stuff";
        }
    }
}
