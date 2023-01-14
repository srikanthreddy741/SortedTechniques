﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortedTechniques
{
    public class Anagram
    {
        public static void DisplayAnagram()
        {
            string str1 = "heart";
            string str2 = "earth";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if(val1 == val2)
            {
                Console.WriteLine("Annagram");
            }else
            {
                Console.WriteLine("Not Anagram");
            }

        }
    }
}
