using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_topSystem.Interfaces;
using task_topSystem.Languages;

internal class CodeGeneratorFactory
{
    public static ICodeGenerator CreateGenerator(string language)
    {
        return language.ToLower() switch
        {
            "java" => new Java(),
            "cplusplus" => new CPlusPlus(),
            "c++" => new CPlusPlus(),
            "php" => new Php(),
            _ => throw new ArgumentException("Bad language")
        };
    }
}
