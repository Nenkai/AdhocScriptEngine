using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    public class hScopePath
    {
        public uint this[int index]
            => PathSymbolIDs[index];

        public List<uint> PathSymbolIDs { get; set; } = new List<uint>();

        public uint GetFullID()
            => PathSymbolIDs[^1];

        public override void ToString()
        {
            return null;
        }
    }
}
