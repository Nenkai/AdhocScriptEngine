using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Syroot.BinaryData;

namespace AdhocScriptEngine
{
    public class hCode
    {
        public List<HObject> Unk { get; set; }
        public List<hInst> Instructions { get; set; }
        public hModule Module { get; set; }

        public int UnkStackSize1 { get; set; }
        public int UnkStackSize2 { get; set; }

        public void Read(BinaryStream reader, uint version)
        {
            reader.ReadString(StringCoding.Int16CharCount); // hIOfile >> sourceFile
            int unkCount = reader.ReadInt32();
            Unk = new List<HObject>(unkCount);
            for (int i = 0; i < unkCount; i++)
            {
                reader.ReadString(StringCoding.Int16CharCount); // hIOfile >> auStack496
                // HSymID::GetID(auStack496)
            }

            UnkStackSize1 = reader.ReadInt32();
            UnkStackSize2 = reader.ReadInt32();
            int instructionCount = reader.ReadInt32();
            if (instructionCount < 0x40000000)
                Instructions = new List<hInst>(instructionCount);

            for (int i = 0; i < instructionCount; i++)
            {
                byte[] instMeta = reader.ReadBytes(5); // file.read(5);

            }
        }

        public hModule GetModule()
        {
            // Mainly reference checks
            return Module;
        }
    }
}
