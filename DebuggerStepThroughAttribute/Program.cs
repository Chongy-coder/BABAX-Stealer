using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggerStepThroughAttribute
{
    internal class NewBaseType
    {
        static void Main(string[] args) => MethPropWithInstMemo.FieldPtr();
    }

    class Program : NewBaseType
    {
    }
}
