using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Syroot.BinaryData;

namespace AdhocScriptEngine
{
    public abstract class hInst
    {
        public virtual void GetPC()
        {

        }

        public virtual void ShiftPC()
        {

        }

        public virtual void SetPC()
        {

        }

        public abstract void Read(BinaryStream reader);
        public abstract void Execute(hThread thread);

        public static hInst NewInst()
        {
            return null;
        }
    }
}
