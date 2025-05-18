using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_topSystem.Interfaces
{
    // В начале создадим интерфейс, для обязательной реализации двух методов в каждом классе
    public interface ICodeGenerator
    {
        public string GenerateCode();
        public string SomeCodeRelatedThing();
    }
}
