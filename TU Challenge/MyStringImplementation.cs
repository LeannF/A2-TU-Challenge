﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static bool IsNullEmptyOrWhiteSpace(string a)
        {
            if (a == null || a.Length <1)
            {
                return true;

            }
            else
            {
                foreach (char item in a)
                {
                    if (item != ' ') 
                        return false;
                }
                return true;
            }
        }
        public static string MixString(string a, string b)
        {
            if (a == null || a.Length <= 0)
            {
                throw new ArgumentException(nameof(a));
            }
            else if (b == null || b.Length <= 0)
            {
                throw new ArgumentException(nameof(b));
            }
            string? c = "";

            for (int i = 0; i < a.Length + b.Length; i++)
            {
                if (i < a.Length)
                {
                    c += a[i];
                }

                if (i < b.Length)
                {
                    c += b[i];
                }
            }
            return c;
        }

        public static string Reverse(string a)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            string? str = "";

            for (int i = 0; i < a.Length; i++)
            {
                char c = a[i];

                if (c != ' ' && c < 97 && c > 64)
                {
                    c += (char)32;
                }
                else if (c == 'É')
                {
                    c = 'é';
                }
                str += c;
            }
            return str;
        }

        public static string UnBazardString(string input)
        {
            throw new NotImplementedException();
        }

        public static string Voyelles(string a)
        {
            a = ToLowerCase(a);
            string? str = "";
            char[] voyelles = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (char c in a)
            {
                if (voyelles.Contains(c) && !str.Contains(c))
                {
                    str += c;
                }
            }
            return str;
        }
    }
}
