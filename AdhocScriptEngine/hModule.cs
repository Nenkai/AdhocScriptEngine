using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    public class hModule
    {
        public hModule Previous { get; set; }
        public uint SymbolID { get; set; }
        public Dictionary<uint, hValue> ModuleValues { get; set; } // hSymID, HValue

        public hModule GetPrevious()
        {
            if (Previous is null /* || rc_count of prev module is 0 */)
                return null;
            else
                return Previous;
        }

        public void SetPrevious(hModule module)
        {
            if (Previous != null)
                ; // weak_ref module provided
            
            if (Previous is null)
            {
                Previous = module;
                return;
            }

            // Previous weak_unref
            Previous = module;
        }

        public void SetID(uint symbolID)
            => SymbolID = symbolID;

        public HObject GetModuleAttribute(uint symbAttributeID)
        {
            hValue value = GetModuleValue(symbAttributeID);
            if (value != null)
            {
                return value.GetAttribute();
            }
        }

        public hValue GetModuleValue(uint symID)
        {
            if (ModuleValues.TryGetValue(symID, out hValue value))
            {
                // if hValue::isValid return value
            }
        }

        public void DefineAttribute(string attrName)
        {
            int symbID = hSymbolMap.GetID(attrName);
        }
    }
}
