﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Library1
{
    public class Letter : ILetter, ISymbol
    {
        private Regex vowels;

        public string Value
        {
            get;
            set;
        }

        public Letter()
        {
            vowels = new Regex("[aAeEuUiIoOyY]");
        }

        public bool IsVowel(string ch)
        {
            if (vowels.IsMatch(ch[0].ToString()))
                return true;
            return false;
        }

        public bool IsConsonant(string ch)
        {
            return !IsVowel(ch);
        }


    }
}
