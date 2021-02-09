using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    public class hCodeFrame : hFrame
    {
        public hStack Stack { get; set; }
        public hCode Code { get; set; }
        public hModule ModuleScope { get; set; }
    }
}
