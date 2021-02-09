using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    public static class hSymbolMap
    {
        public static Dictionary<string, int> StaticSymbols { get; set; }
        public static int MaxID { get; set; } = -1;

        static hSymbolMap()
        {
            StaticSymbols = new Dictionary<string, int>();

            Add("ARGV"); // ARGV
            Add("Array"); // ARRAY
            Add("attribute"); // ATTRIBUTE
            Add("auto"); // AUTO
            Add("break"); // BREAK
            Add("case"); // CASE
            Add("catch"); // CATCH
            Add("class"); // CLASS
            Add("coerce"); // COERCE
            Add("continue"); // CONTINUE
            Add("do"); // DO
            Add("else"); // ELSE
            Add("for"); // FOR
            Add("function"); // FUNCTION
            Add("if"); // IF
            Add("import"); // IMPORT
            Add("isInstanceOf"); // IS_INSTANCE_OF
            Add("LOAD_PATH"); // LOAD_PATH
            Add("main"); // MAIN
            Add("method"); // METHOD
            Add("module"); // MODULE
            Add("new"); // NEW
            Add("nil"); // NIL
            Add("Object"); // OBJECT

            Add("+"); // OP_ADD
            Add("&"); // OP_AND
            Add("&&"); // OP_ANDAND
            Add("()"); // OP_CALL
            Add("/"); // OP_DIV
            Add("[]"); // OP_ELEM
            Add("=="); // OP_EQ
            Add(">="); // OP_GE
            Add(">"); // OP_GT
            Add("~"); // OP_INVERT
            Add("<="); // OP_LE
            Add("<<"); // OP_LSHIFT
            Add("<"); // OP_LT
            Add("%"); // OP_MOD
            Add("*"); // OP_MUL
            Add("!="); // OP_NE
            Add("!"); // OP_NOT
            Add("|"); // OP_OR
            Add("||"); // OP_OROR
            Add("@--"); // OP_POST_DECR
            Add("@++"); // OP_POST_INCR
            Add("**"); // OP_POW
            Add("--@"); // OP_PRE_DECR
            Add("++@"); // OP_PRE_INCR
            Add(">>"); // OP_RSHIFT
            Add("-"); // OP_SUB
            Add("-@"); // OP_UMINUS
            Add("+@"); // OP_UPLUS
            Add("^"); // OP_XOR
            Add("pr"); // PR

            Add("require"); // REQUIRE
            Add("return"); // RETURN
            Add("run"); // RUN
            Add("self"); // SELF
            Add("static"); // STATIC
            Add("stop"); // STOP
            Add("switch"); // SWITCH
            Add("System"); // SYSTEM_MODULE

            Add("__FILE__"); // S_FILE
            Add("__init__"); // S_INIT
            Add("__copy_init__"); // S_COPY_INIT
            Add("__LINE__"); // S_LINE
            Add("__new__"); // S_NEW
            Add("__prototype__"); // S_PROTOTYPE
            Add("__super__"); // S_SUPER

            Add("throw"); // THROW
            Add("try"); // TRY
            Add("undef"); // UNDEF
            Add("while"); // WHILE

            MaxID = StaticSymbols.Count - 1;
        }

        private static void Add(string name)
            => StaticSymbols.Add(name, ++MaxID);

        public static int GetID(string symbol)
        {
            if (!StaticSymbols.TryGetValue(symbol, out int symID))
            {
                symID = ++MaxID;
                StaticSymbols.Add(symbol, symID);
            }

            return symID;
        }

        /// <summary>
        /// Rewind to a set ID. (Used by the game to rewind aka cleanup, when loading up a new project)
        /// </summary>
        public static void RewindID(int id)
        {

        }
    }
}
