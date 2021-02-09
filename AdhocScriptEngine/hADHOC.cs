using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdhocScriptEngine
{
    public class hADHOC
    {
        public string CurrentDir { get; set; }
        public string ProgramDir { get; set; }
        public Dictionary<string, hModule> Modules { get; set; }
        public Dictionary<string, Action<hModule>> ModuleHandles { get; set; }

        public void Initialize()
        {

        }

        /// <summary>
        /// Loads and executes a new script.
        /// </summary>
        /// <param name="scriptPath"></param>
        /// <param name="module"></param>
        public bool Load(string scriptPath, hModule module)
        {
            var prevParentModule = module.GetPrevious();
            if (prevParentModule is null)
                prevParentModule.SetPrevious(/* this.field_0x38 */ null);

            bool moduleLoaded = ModuleLoad(scriptPath, module);
            if (moduleLoaded)
                return moduleLoaded;

            // if path is absolute
            // do something..

            var scriptFilePath = scriptPath + ".adc";
            LoadCode(scriptFilePath);

            // check if loaded
            // if it is, return true, or false
            return false;
        }

        public void LoadCode(string file)
        {
            using var fs = new FileStream(file, FileMode.Open);
            using var br = new BinaryReader(fs);

            /* for (int i = 0; i < 7; i++)
                magic[i] = file.cget(); */
            var magic = br.ReadChars(7);
            br.ReadChar(); // file.cget(); 

            // strncmp
            bool isValidHeader = magic.AsSpan().SequenceEqual("ADCH007");
            if (isValidHeader)
            {
                int version = int.Parse(magic.AsSpan(4)); // strtol
                hCode code = new hCode();

            }
        }

        public bool Require(string moduleName)
        {
            if (Modules.ContainsKey(moduleName))
                return Modules[moduleName];

            hModule newModule = new hModule();
            Load(moduleName, hmodule);
        }

        public Action<hModule> GetModuleHandle(string moduleHandleName)
        {
            ModuleHandles.TryGetValue(moduleHandleName, out Action<hModule> handle);
            return handle;
        }

        private bool ModuleLoad(string name, hModule module)
        {
            var handle = GetModuleHandle(name);
            if (handle is null)
                return false;

            handle(module);
            return true;
        }
    }
}
