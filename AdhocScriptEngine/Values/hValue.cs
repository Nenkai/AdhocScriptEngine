using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    /// <summary>
    ///  hFunctionValue
    ///  hMethodValue
    ///  hStaticValue
    ///  hMethodAttribute
    ///  hAttribute
    ///  hBuiltinAttribute
    ///  hBuiltinStatic
    /// </summary>
    public abstract class hValue
    {
        public uint SymbolID { get; set; }

        public abstract hObject GetValue();
        public abstract hObject SetValue();
        public abstract bool IsVirtual();

        public virtual HObject GetAttribute()
        {
            return null;
        }
    }
}
