using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    public class hStack
    {
        public List<HObject> Stack { get; set; }
        public int Size1 { get; set; }

        public hStack(int size1, int size2)
        {
            Stack = new List<HObject>(size1 + size2);
            Size1 = size1;
        }
    }
}
