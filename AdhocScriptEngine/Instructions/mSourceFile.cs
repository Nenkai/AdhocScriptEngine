using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Syroot.BinaryData;

namespace AdhocScriptEngine.Instructions
{
    public class mSourceFile : hInst
    {
        public string SourceFile { get; set; }

        public override void Read(BinaryStream reader)
        {
            SourceFile = reader.ReadString(StringCoding.Int16CharCount);
        }

        public override void Execute(hThread thread)
        {
            // Empty.
        }
    }
}
