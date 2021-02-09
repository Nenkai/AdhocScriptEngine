using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    public class hThread
    {
        public List<hFrame> Frames { get; set; }
        public hStack Stack { get; set; }
        public hCode Code { get; set; }
        public hModule CurrentModuleScope { get; set; }
        public List<hInst> NextInstructions { get; set; }

        public ThreadState State { get; set; }

        public ThreadState Execute(uint unkCount)
        {
            foreach (var stackFrame in Frames)
            {
                ThreadState state = Execute0(unkCount);
                State = state;
                if (State == ThreadState.Running)
                    return ThreadState.Running;
            }

            return State;
        }

        private ThreadState Execute0(uint stackFrameCount)
        {
            if (Frames.Count >= stackFrameCount)
            {
                while (Frames.Count >= stackFrameCount)
                {
                    State = ThreadState.Completed;
                    while (true)
                    {
                        hInst currentInstruction = NextInstructions[0];
                        currentInstruction.Execute(this);
                    }
                }
            }
        }

        public hModule GetCurrentScope()
            => CurrentModuleScope;

        public void BeginCodeFrame(hCode code)
        {
            var codeFrame = new hCodeFrame();
            codeFrame.ModuleScope = CurrentModuleScope;
            codeFrame.Code = Code;
            codeFrame.Stack = Stack;

            CurrentModuleScope = code.GetModule();
            Code = code;

            Stack = new hStack(code.UnkStackSize1, code.UnkStackSize2);
            BeginFrame(codeFrame);
        }

        public void BeginFrame(hFrame frame)
        {
            Frames.Add(frame);
        }
    }

    public enum ThreadState
    {
        Unk,
        Running,
        Completed,
    }
}
