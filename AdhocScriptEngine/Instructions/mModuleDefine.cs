using System;
using System.Collections.Generic;
using System.Text;

using Syroot.BinaryData;

namespace AdhocScriptEngine.Instructions
{
    public class mModuleDefine : hInst
    {
        public hScopePath Paths { get; set; }
        public override void Execute(hThread thread)
        {
            if (Paths.PathSymbolIDs.Count < 2)
            {
                var moduleScope = thread.GetCurrentScope();
                var firstPath = Paths[0];
                HObject attribute = moduleScope.GetModuleAttribute(firstPath);
                // dynamic assign
                // if successful


            }
        }

        public override void Read(BinaryStream reader)
        {
            throw new NotImplementedException();
        }
    }
}
