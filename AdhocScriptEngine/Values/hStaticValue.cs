using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine.Values
{
    public class hStaticValue : hValue
    {
        public HObject Value { get; set; }
        public override HObject GetValue()
            => Value;

        public override bool IsVirtual()
            => false;

        public override void SetValue()
            => Value = Value;
    }
}
