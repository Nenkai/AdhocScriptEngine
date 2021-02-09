using System;
using System.Collections.Generic;
using System.Text;

namespace AdhocScriptEngine
{
    /// <summary>
    /// A HSymbol is just a HSymID, which is just a uint.
    /// </summary>
    public struct HSymbol
    {
        public uint HSymID { get; set; }

        public static HSymbol ARGV { get; }
        public static HSymbol ARRAY { get; }
        public static HSymbol ATTRIBUTE { get; }
        public static HSymbol AUTO { get; }
        public static HSymbol BREAK { get; }
        public static HSymbol CASE { get; }
        public static HSymbol CATCH { get; }
        public static HSymbol CLASS { get; }
        public static HSymbol COERCE { get; }
        public static HSymbol CONTINUE { get; }
        public static HSymbol DEFAULT { get; }
        public static HSymbol DO { get; }
        public static HSymbol ELSE { get; }
        public static HSymbol FOR { get; }
        public static HSymbol FUNCTION { get; }
        public static HSymbol IF { get; }
        public static HSymbol IMPORT { get; }
        public static HSymbol IS_INSTANCE_OF { get; }
        public static HSymbol LOAD_PATH { get; }
        public static HSymbol MAIN { get; }
        public static HSymbol METHOD { get; }
        public static HSymbol MODULE { get; }
        public static HSymbol NEW { get; }
        public static HSymbol NIL { get; }
        public static HSymbol OBJECT { get; }
        public static HSymbol OP_ADD { get; }
        public static HSymbol OP_AND { get; }
        public static HSymbol OP_ANDAND { get; }
        public static HSymbol OP_CALL { get; }
        public static HSymbol OP_DIV { get; }
        public static HSymbol OP_ELEM { get; }
        public static HSymbol OP_EQ { get; }
        public static HSymbol OP_GE { get; }
        public static HSymbol OP_GT { get; }
        public static HSymbol OP_INVERT { get; }
        public static HSymbol OP_LE { get; }
        public static HSymbol OP_LSHIFT { get; }
        public static HSymbol OP_LT { get; }
        public static HSymbol OP_MOD { get; }
        public static HSymbol OP_MUL { get; }
        public static HSymbol OP_NE { get; }
        public static HSymbol OP_NOT { get; }
        public static HSymbol OP_OR { get; }
        public static HSymbol OP_OROR { get; }
        public static HSymbol OP_POST_DECR { get; }
        public static HSymbol OP_POST_INCR { get; }
        public static HSymbol OP_POW { get; }
        public static HSymbol OP_PRE_DECR { get; }
        public static HSymbol OP_PRE_INCR { get; }
        public static HSymbol OP_RSHIFT { get; }
        public static HSymbol OP_SUB { get; }
        public static HSymbol OP_UMINUS { get; }
        public static HSymbol OP_UPLUS { get; }
        public static HSymbol OP_XOR { get; }
        public static HSymbol PR { get; }
        public static HSymbol REQUIRE { get; }
        public static HSymbol RETURN { get; }
        public static HSymbol RUN { get; }
        public static HSymbol SELF { get; }
        public static HSymbol STATIC { get; }
        public static HSymbol STOP { get; }
        public static HSymbol SWITCH { get; }
        public static HSymbol SYSTEM_MODULE { get; }
        public static HSymbol SS_FILE { get; }
        public static HSymbol SS_INIT { get; }
        public static HSymbol S_COPY_INIT { get; }
        public static HSymbol S_LINE { get; }
        public static HSymbol S_NEW { get; }
        public static HSymbol S_PROTOTYPE { get; }
        public static HSymbol S_SUPER { get; }
        public static HSymbol THROW { get; }
        public static HSymbol TRY { get; }
        public static HSymbol WHILE { get; }

        public static bool operator ==(int id, HSymbol id2)
            => id2.HSymID == id;

        public static bool operator !=(int id, HSymbol id2)
            => id2.HSymID != id;
    }
}
