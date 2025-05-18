using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using task_topSystem.Interfaces;

internal class CodeGenerator
{
    private readonly ICodeGenerator _generator;

    public CodeGenerator(string language)
    {
        _generator = CodeGeneratorFactory.CreateGenerator(language);
    }

    public string GenerateCode()
    {
       return _generator.GenerateCode();
    }
    public string SomeCodeRelatedThing()
    {
       return _generator.SomeCodeRelatedThing();
    }
}
