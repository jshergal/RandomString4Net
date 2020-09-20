﻿using System;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class ExtensionAttribute : Attribute { }
}

namespace RandomString4Net
{

    public enum Types
    {
        ALPHABET_LOWERCASE,
        ALPHABET_LOWERCASE_WITH_SYMBOLS,
        ALPHABET_UPPERCASE,
        ALPHABET_UPPERCASE_WITH_SYMBOLS,
        ALPHABET_MIXEDCASE,
        ALPHABET_MIXEDCASE_WITH_SYMBOLS,
        ALPHANUMERIC_LOWERCASE,
        ALPHANUMERIC_LOWERCASE_WITH_SYMBOLS,
        ALPHANUMERIC_UPPERCASE,
        ALPHANUMERIC_UPPERCASE_WITH_SYMBOLS,
        ALPHANUMERIC_MIXEDCASE,
        ALPHANUMERIC_MIXEDCASE_WITH_SYMBOLS
    }
    public static class TypesMethods
    {


        public static string GetString(this Types types)
        {
            switch (types)
            {
                case Types.ALPHABET_LOWERCASE: return Source.Alphabets;
                case Types.ALPHABET_LOWERCASE_WITH_SYMBOLS: return string.Format("{0}{1}", Source.Alphabets, Source.Symbols);

                case Types.ALPHABET_UPPERCASE: return Types.ALPHABET_LOWERCASE.GetString().ToUpper();
                case Types.ALPHABET_UPPERCASE_WITH_SYMBOLS: return Types.ALPHABET_LOWERCASE_WITH_SYMBOLS.GetString().ToUpper();

                case Types.ALPHABET_MIXEDCASE: return string.Format("{0}{1}", Source.Alphabets.ToLower(), Source.Alphabets.ToUpper());
                case Types.ALPHABET_MIXEDCASE_WITH_SYMBOLS: return string.Format("{0}{1}", Types.ALPHABET_MIXEDCASE.GetString(), Source.Symbols);

                case Types.ALPHANUMERIC_LOWERCASE: return string.Format("{0}{1}", Source.Alphabets, Source.Numbers);
                case Types.ALPHANUMERIC_LOWERCASE_WITH_SYMBOLS: return string.Format("{0}{1}", Types.ALPHANUMERIC_LOWERCASE.GetString(), Source.Symbols);

                case Types.ALPHANUMERIC_UPPERCASE: return Types.ALPHANUMERIC_LOWERCASE.GetString().ToUpper();
                case Types.ALPHANUMERIC_UPPERCASE_WITH_SYMBOLS: return Types.ALPHANUMERIC_LOWERCASE_WITH_SYMBOLS.GetString().ToUpper();

                case Types.ALPHANUMERIC_MIXEDCASE: return string.Format("{0}{1}", Types.ALPHABET_MIXEDCASE.GetString(), Source.Numbers);
                case Types.ALPHANUMERIC_MIXEDCASE_WITH_SYMBOLS: return string.Format("{0}{1}", Types.ALPHANUMERIC_MIXEDCASE.GetString(), Source.Symbols);
            }
            return string.Empty;
        }
    }
}