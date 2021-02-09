using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    public class hClass : hModule
    {
        public hClass SuperClassID { get; private set; }

        public hClass(uint symbolID)
        {
            this.SymbolID = symbolID;
        }

        public void GetModuleValue(int val, int hSymID)
        {
            if (hSymID == HSymbol.S_SUPER)
            {

            }
            else
            {

            }
        }

        public hClass GetSuperClassID()
            => SuperClassID;

        public hClass SetSuperClassID(hClass superClass)
            => SuperClassID = superClass;
    }
}
