using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_topSystem.Interfaces;

namespace task_topSystem.Languages
{
    public class Java : ICodeGenerator
    {
        public string GenerateCode()
        {
            return "generated java code";
        }

        public string SomeCodeRelatedThing()
        {
            return "generated java-related stuff";
        }
    }
}